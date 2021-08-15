﻿#region Using

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using Emotion.Common;
using Emotion.Common.Serialization;
using Emotion.Graphics;
using Emotion.Platform.Input;
using Emotion.Primitives;

#endregion

#nullable enable

namespace Emotion.UI
{
    /// <summary>
    /// Provides list navigation to UICallbackButton children.
    /// </summary>
    public class UICallbackListNavigator : UIBaseWindow
    {
        // These three are the same thing.
        [DontSerialize]
        public UIBaseWindow? SelectedWnd { get; protected set; }

        [DontSerialize]
        public int SelectedChildIdx { get; protected set; } = -1;

        [DontSerialize]
        public Vector2 SelectedChildPos
        {
            get => _selectedPos;
        }

        /// <summary>
        /// Callback on new item selected. First param is the new item, second is the old one.
        /// </summary>
        [DontSerialize] public Action<UIBaseWindow?, UIBaseWindow?>? OnItemSelected;

        /// <summary>
        /// Callback on ConfirmChoice pressed. Passes in the selected window and its index.
        /// </summary>
        [DontSerialize] public Action<UIBaseWindow, int>? OnChoiceConfirmed;

        [DontSerialize] protected Vector2 _selectedPos;

        public Key NavigationKey;
        public Key ConfirmChoice;

        private Dictionary<Vector2, UIBaseWindow> _gridPosToChild = new Dictionary<Vector2, UIBaseWindow>();
        private Vector2 _gridSize;
        private int _lastRowColumn;

        private Vector2 _scrollPos = Vector2.Zero;

        public UICallbackListNavigator()
        {
            InputTransparent = false;
        }

        protected override Vector2 GetChildrenLayoutSize(Vector2 space, Vector2 measuredSize, Vector2 paddingSize)
        {
            Vector2 scrollArea = base.GetChildrenLayoutSize(space, measuredSize, paddingSize);
            switch (LayoutMode)
            {
                case LayoutMode.VerticalListWrap:
                case LayoutMode.HorizontalList:
                    scrollArea.X = MaxSize.X;
                    break;
                case LayoutMode.HorizontalListWrap:
                case LayoutMode.VerticalList:
                    scrollArea.Y = MaxSize.Y;
                    break;
            }


            return scrollArea;
        }

        protected override void RenderChildren(RenderComposer c)
        {
            Rectangle renderRect = _renderBounds;
            for (var i = 0; i < Children!.Count; i++)
            {
                UIBaseWindow child = Children[i];
                if (!child.Visible || !child.IsInsideRect(renderRect)) continue;
                child.Render(c);
            }
        }

        protected override void AfterLayout()
        {
            if (Children == null) return;

            _gridPosToChild.Clear();
            _gridSize = Vector2.Zero;

            var pen = new Vector2();
            for (var i = 0; i < Children.Count; i++)
            {
                UIBaseWindow child = Children[i];
                _gridPosToChild.Add(pen, child);
                _gridSize.X = MathF.Max(pen.X, _gridSize.X);
                _gridSize.Y = MathF.Max(pen.Y, _gridSize.Y);

                switch (LayoutMode)
                {
                    case LayoutMode.Free:
                        pen.X++;
                        pen.Y++;
                        break;
                    case LayoutMode.HorizontalListWrap:
                        pen.X++;
                        if (i != Children.Count - 1 && Children[i + 1].Y > child.Y)
                        {
                            pen.X = 0;
                            pen.Y++;
                        }

                        break;
                    case LayoutMode.HorizontalList:
                        pen.X++;
                        break;
                    case LayoutMode.VerticalListWrap:
                        pen.Y++;
                        if (i != Children.Count - 1 && Children[i + 1].X > child.X)
                        {
                            pen.Y = 0;
                            pen.X++;
                        }

                        break;
                    case LayoutMode.VerticalList:
                        pen.Y++;
                        break;
                }
            }

            _lastRowColumn = (int) pen.X - 1;
            base.AfterLayout();
        }

        public UIBaseWindow? GetChildByGridLikePos(Vector2 gridLikePos, out int index, bool includeInvisible)
        {
            index = -1;
            if (Children == null) return null;
            if (!_gridPosToChild.TryGetValue(gridLikePos, out UIBaseWindow? child)) return null;
            if (!child.Visible && !includeInvisible) return null;
            index = Children.IndexOf(child);
            return child;
        }

        public Vector2 GetGridLikePosFromChild(UIBaseWindow win)
        {
            foreach (KeyValuePair<Vector2, UIBaseWindow> child in _gridPosToChild)
            {
                if (child.Value == win) return child.Key;
            }

            return Vector2.Zero;
        }

        public override bool OnKey(Key key, KeyStatus status)
        {
            Vector2 axis = Engine.Host.IsKeyPartOfAxis(key, NavigationKey);
            if (axis != Vector2.Zero)
            {
                _selectedPos += axis;
                _selectedPos = Vector2.Clamp(_selectedPos, Vector2.Zero, _gridSize);
                if (_selectedPos.Y == _gridSize.Y && _selectedPos.X > _lastRowColumn && _lastRowColumn != -1) _selectedPos.X = _lastRowColumn;
                UIBaseWindow? newItem = GetChildByGridLikePos(_selectedPos, out int childIdx, false);
                Debug.Assert(childIdx != -1);
                UIBaseWindow? oldSel = SelectedWnd;
                SelectedWnd = newItem;
                SelectedChildIdx = childIdx;
                if (newItem != oldSel) OnItemSelected?.Invoke(newItem, oldSel);
            }

            if (key == ConfirmChoice && status == KeyStatus.Down && SelectedWnd != null) OnChoiceConfirmed?.Invoke(SelectedWnd, SelectedChildIdx);

            return base.OnKey(key, status);
        }

        public void ResetSelection(bool nullSelection = false)
        {
            if (nullSelection)
            {
                SelectedWnd = null;
                SelectedChildIdx = -1;
                _selectedPos = Vector2.Zero;
                return;
            }

            if (Children == null) return;
            for (var i = 0; i < Children.Count; i++)
            {
                if (Children[i].Visible)
                {
                    SetSelection(Children[i], true);
                    return;
                }
            }
        }

        public void SetSelection(UIBaseWindow wnd, bool force = false)
        {
            if (Children == null) return;

            UIBaseWindow? oldSel = SelectedWnd;
            if (wnd == oldSel)
            {
                // Prevent event from having old == new
                if (force)
                    oldSel = null;
                else
                    return;
            }

            Debug.Assert(Children.IndexOf(wnd) != -1);
            SelectedChildIdx = Children.IndexOf(wnd);
            SelectedWnd = wnd;
            _selectedPos = GetGridLikePosFromChild(wnd);

            OnItemSelected?.Invoke(wnd, oldSel);
        }

        public void SetupMouseSelection()
        {
            if (Children == null) return;
            for (var i = 0; i < Children.Count; i++)
            {
                if (Children[i] is not UICallbackButton b) continue;
                Debug.Assert(!Children[i].InputTransparent);
                b.OnClickedProxy = ProxyButtonClicked;
                b.OnMouseEnterProxy = ProxyButtonSelected;
            }
        }

        private void ProxyButtonClicked(UIBaseWindow b)
        {
            if (!b.Visible) return;
            SetSelection(b);
            Debug.Assert(SelectedWnd != null);
            OnChoiceConfirmed?.Invoke(SelectedWnd, SelectedChildIdx);
        }

        private void ProxyButtonSelected(UIBaseWindow b)
        {
            if (!b.Visible) return;
            SetSelection(b);
        }
    }
}