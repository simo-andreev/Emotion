﻿#region Using

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Threading.Tasks;
using Emotion.Common;
using Emotion.Common.Serialization;
using Emotion.Game.Time;
using Emotion.Graphics;
using Emotion.Platform.Input;
using Emotion.Primitives;
using Emotion.Standard.XML;
using Emotion.Utility;

#endregion

#nullable enable

namespace Emotion.UI
{
    [DontSerializeMembers("Position", "Size")]
    public class UIBaseWindow : Transform, IRenderable, IComparable<UIBaseWindow>, IEnumerable<UIBaseWindow>
    {
        /// <summary>
        /// By default windows greedily take up all the size they can.
        /// </summary>
        public static Vector2 DefaultMaxSize = new(9999, 9999);

        /// <summary>
        /// Unique identifier for this window to be used with GetWindowById. If two windows share an id the one closer
        /// to the parent GetWindowById is called from will be returned.
        /// </summary>
        public string? Id { get; set; }

        #region Runtime State

        [DontSerialize]
        public UIBaseWindow? Parent { get; protected set; }

        [DontSerialize]
        public UIDebugger? Debugger { get; protected set; }

        [DontSerialize]
        public UIController? Controller { get; protected set; }

        #endregion

        #region Preload, Update, Render

        public virtual async Task Preload()
        {
            if (Children == null) return;

            try
            {
                Task[] preloadTasks = new Task[Children.Count];
                for (var i = 0; i < Children.Count; i++)
                {
                    UIBaseWindow child = Children[i];
                    Task preloadTask = child.Preload();
                    preloadTasks[i] = preloadTask;
                }

                await Task.WhenAll(preloadTasks);
            }
            catch (Exception ex)
            {
                Engine.Log.Error($"Window loading {this} failed. {ex}", "UI");
            }
        }

        public void Update()
        {
            if (!Visible) return;
            Debug.Assert(Controller != null || this is UIController);

            if (_alphaTween != null)
            {
                _alphaTween.Update(Engine.DeltaTime);
                var current = (byte) Maths.Lerp(_startingAlpha, _targetAlpha, _alphaTween.Progress);
                WindowColor = WindowColor.SetAlpha(current);
                if (_alphaTween.Finished)
                {
                    Debug.Assert(WindowColor.A == _targetAlpha);
                    _alphaTween = null;
                }

                InvalidateColor();
            }

            if (_updateColor)
            {
                CalculateColor();
                _updateColor = false;
            }

            bool updateChildren = UpdateInternal();
            if (!updateChildren || Children == null) return;

            for (var i = 0; i < Children.Count; i++)
            {
                UIBaseWindow child = Children[i];
                child.Update();
            }
        }

        protected virtual bool UpdateInternal()
        {
            // nop
            return true;
        }

        public void Render(RenderComposer c)
        {
            if (!Visible) return;

            // Push displacements if any.
            var matrixPushed = false;
            if (_transformationStackBacking != null)
            {
                if (_transformationStackBacking.MatrixDirty) _transformationStackBacking.RecalculateMatrix(GetScale());
                c.PushModelMatrix(_transformationStackBacking.CurrentMatrix, !IgnoreParentDisplacement);
                matrixPushed = true;
            }
            else if (IgnoreParentDisplacement && !c.ModelMatrix.IsIdentity)
            {
                c.PushModelMatrix(Matrix4x4.Identity, false);
                matrixPushed = true;
            }

            if (RenderInternal(c) && Children != null)
            {
                for (var i = 0; i < Children.Count; i++)
                {
                    UIBaseWindow child = Children[i];
                    if (!child.Visible) continue;
                    child.Render(c);
                }
            }

            // Pop displacements, if any were pushed.
            if (matrixPushed) c.PopModelMatrix();
            AfterRenderChildren(c);
        }

        protected virtual bool RenderInternal(RenderComposer c)
        {
            return true;
        }

        protected virtual void AfterRenderChildren(RenderComposer c)
        {

        }

        protected void AttachDebugger(UIDebugger debugger)
        {
            Debugger = debugger;
            if (Children == null) return;
            for (var i = 0; i < Children.Count; i++)
            {
                UIBaseWindow child = Children[i];
                child.AttachDebugger(debugger);
            }
        }

        #endregion

        #region Hierarchy

        /// <summary>
        /// Children of this window.
        /// </summary>
        public List<UIBaseWindow>? Children { get; set; }

        public virtual void AddChild(UIBaseWindow child, int index = -1)
        {
            Children ??= new List<UIBaseWindow>();
            if (index != -1)
                Children.Insert(index, child);
            else
                Children.Add(child);

            child.Parent = this;
            child.InvalidateLayout();
            child.InvalidateColor();
            child.EnsureParentLinks();
            if (Debugger != null) child.AttachDebugger(Debugger);
            if (Controller != null)
            {
                child.AttachedToController(Controller);
            }
        }

        /// <summary>
        /// Parents aren't serialized so the links need to be reestablished once the UI is loaded.
        /// </summary>
        protected void EnsureParentLinks()
        {
            if (Children == null) return;
            for (var i = 0; i < Children.Count; i++)
            {
                UIBaseWindow child = Children[i];
                child.Parent = this;
                child.EnsureParentLinks();
            }
        }

        public virtual void RemoveChild(UIBaseWindow win, bool evict = true)
        {
            if (Children == null) return;
            Debug.Assert(win.Parent == this);

            if (evict) Children.Remove(win);
        }

        public virtual void ClearChildren()
        {
            if (Children == null) return;
            for (var i = 0; i < Children.Count; i++)
            {
                UIBaseWindow child = Children[i];
                RemoveChild(child, false);
            }

            Children = null;
        }

        public virtual void AttachedToController(UIController controller)
        {
            Controller = controller;
            Controller?.InvalidatePreload();
            if (Children == null) return;
            for (var i = 0; i < Children.Count; i++)
            {
                UIBaseWindow child = Children[i];
                child.AttachedToController(controller);
            }
        }

        public virtual void DetachedFromController(UIController controller)
        {
            Controller = null;
            if (Children == null) return;
            for (var i = 0; i < Children.Count; i++)
            {
                UIBaseWindow child = Children[i];
                child.DetachedFromController(controller);
            }
        }

        /// <summary>
        /// Marks this window as generated by code. Such windows will not be serialized by the UI editor.
        /// </summary>
        [DontSerialize]
        public bool CodeGenerated { get; set; }

        public virtual void RemoveCodeGeneratedChildren()
        {
            if (Children == null) return;
            for (int i = Children.Count - 1; i >= 0; i--)
            {
                UIBaseWindow child = Children[i];
                if (child.CodeGenerated)
                    RemoveChild(child);
                else
                    child.RemoveCodeGeneratedChildren();
            }
        }

        #endregion

        #region Layout

        /// <summary>
        /// The point in the parent to anchor the window to.
        /// </summary>
        public UIAnchor ParentAnchor { get; set; } = UIAnchor.TopLeft;

        /// <summary>
        /// Where the window should anchor to relative to the alignment in its parent.
        /// </summary>
        public UIAnchor Anchor { get; set; } = UIAnchor.TopLeft;

        /// <summary>
        /// How to layout the children of this window.
        /// </summary>
        public LayoutMode LayoutMode { get; set; } = LayoutMode.Free;

        /// <summary>
        /// Spacing if the LayoutMode is a list.
        /// </summary>
        public Vector2 ListSpacing { get; set; }

        /// <summary>
        /// Whether the window is visible.
        /// If not, the RenderInternal function will not be called and
        /// children will not be drawn either.
        /// </summary>
        public bool Visible { get; set; } = true;

        /// <summary>
        /// Whether to consider this window as part of the layout when invisible.
        /// Matters only within lists.
        /// </summary>
        public bool DontTakeSpaceWhenHidden { get; set; }

        /// <summary>
        /// The Z axis is combined with that of the parent, whose is combined with that of their parent, and so forth.
        /// This is the Z offset for this window, added to this window and its children.
        /// </summary>
        public float ZOffset { get; set; }

        /// <summary>
        /// Margins push the window in one of the four directions, only if it is against another window.
        /// This is applied after alignment, but before the anchor.
        /// </summary>
        public Rectangle Margins { get; set; }

        /// <summary>
        /// The minimum size the window can be.
        /// </summary>
        public Vector2 MinSize { get; set; }

        public Vector2 MaxSize { get; set; } = DefaultMaxSize;

        /// <summary>
        /// Always added to the position after all other checks.
        /// Mostly used to offset from an anchor position.
        /// </summary>
        public Vector2 Offset { get; set; }

        /// <summary>
        /// Position and size is multiplied by Renderer.Scale, Renderer.IntScale or neither.
        /// </summary>
        public UIScaleMode ScaleMode { get; set; } = UIScaleMode.FloatScale;

        /// <summary>
        /// Stretch the window to be as big as its children.
        /// </summary>
        public bool StretchX { get; set; }

        public bool StretchY { get; set; }

        /// <summary>
        /// Position relative to another window in the same controller.
        /// </summary>
        public string? RelativeTo { get; set; }

        private Vector2 _measuredSize;

        public virtual void InvalidateLayout()
        {
            Parent?.InvalidateLayout();
        }

        protected virtual Vector2 InternalMeasure(Vector2 space)
        {
            return space;
        }

        protected Vector2 Measure(Vector2 space)
        {
            float scale = GetScale();
            if (AnchorsInsideParent(ParentAnchor, Anchor))
            {
                Rectangle scaledMargins = Margins * scale;
                space.X -= scaledMargins.X + scaledMargins.Width;
                space.Y -= scaledMargins.Y + scaledMargins.Height;
            }
            else 
            {
                space = Controller!.Size;
            }

            Vector2 contentSize = InternalMeasure(space);
            Debugger?.RecordMetric(this, "Measure_Internal", contentSize);
            contentSize = Vector2.Clamp(contentSize, MinSize * scale, MaxSize * scale).RoundClosest();
            Debugger?.RecordMetric(this, "Measure_Internal_PostClamp", contentSize);
            Vector2 usedSpace = Vector2.Zero;

            if (Children != null)
            {
                Vector2 freeSpace = StretchX || StretchY ? space : contentSize;
                Vector2 scaledSpacing = ListSpacing * scale;
                bool wrap = LayoutMode is LayoutMode.HorizontalListWrap or LayoutMode.VerticalListWrap;
                switch (LayoutMode)
                {
                    case LayoutMode.Free:
                        for (var i = 0; i < Children.Count; i++)
                        {
                            UIBaseWindow child = Children[i];
                            Vector2 childSize = child.Measure(freeSpace);
                            if (AnchorsInsideParent(child.ParentAnchor, child.Anchor))
                                usedSpace = Vector2.Max(usedSpace, childSize);
                        }

                        break;
                    case LayoutMode.HorizontalListWrap:
                    case LayoutMode.HorizontalList:
                        for (var i = 0; i < Children.Count; i++)
                        {
                            UIBaseWindow child = Children[i];
                            bool insideParent = AnchorsInsideParent(child.ParentAnchor, child.Anchor);
                            if (insideParent && i != 0)
                            {
                                freeSpace.X -= scaledSpacing.X;
                                usedSpace.X += scaledSpacing.X;
                            }

                            Vector2 childSize = child.Measure(freeSpace);
                            if (!child.Visible && child.DontTakeSpaceWhenHidden) continue;
                            if (!insideParent) continue;

                            float childScale = child.GetScale();
                            Vector2 childScaledOffset = child.Offset * childScale;
                            Rectangle childScaledMargins = child.Margins * childScale;
                            float spaceTaken = childSize.X + childScaledOffset.X + childScaledMargins.X + childScaledMargins.Width;
                            freeSpace.X -= spaceTaken;
                            usedSpace.X += spaceTaken;
                            usedSpace.Y = MathF.Max(usedSpace.Y, childSize.Y);
                        }

                        break;
                    case LayoutMode.VerticalListWrap:
                    case LayoutMode.VerticalList:
                        for (var i = 0; i < Children.Count; i++)
                        {
                            UIBaseWindow child = Children[i];
                            bool insideParent = AnchorsInsideParent(child.ParentAnchor, child.Anchor);
                            if (insideParent && i != 0)
                            {
                                freeSpace.Y -= scaledSpacing.Y;
                                usedSpace.Y += scaledSpacing.Y;
                            }

                            Vector2 childSize = child.Measure(freeSpace);
                            if (!child.Visible && child.DontTakeSpaceWhenHidden) continue;
                            if (!insideParent) continue;

                            float childScale = child.GetScale();
                            Vector2 childScaledOffset = child.Offset * childScale;
                            Rectangle childScaledMargins = child.Margins * childScale;
                            float spaceTaken = childSize.Y + childScaledOffset.Y + childScaledMargins.Y + childScaledMargins.Height;
                            freeSpace.Y -= spaceTaken;
                            usedSpace.Y += spaceTaken;
                            usedSpace.X = MathF.Max(usedSpace.X, childSize.X);
                        }

                        break;
                }
            }

            _measuredSize = new Vector2(StretchX ? usedSpace.X : contentSize.X, StretchY ? usedSpace.Y : contentSize.Y);
            Debugger?.RecordMetric(this, "Measure_PostChildren", _measuredSize);
            Size = _measuredSize;
            return _measuredSize;
        }

        public Vector2 CalculateContentPos(Vector2 parentPos, Vector2 parentSize)
        {
            float scale = GetScale();
            var parentSpaceForChild = new Rectangle(0, 0, parentSize);
            Rectangle childScaledMargins = Margins * scale;
            if (AnchorsInsideParent(ParentAnchor, Anchor))
            {
                parentSpaceForChild.X += childScaledMargins.X;
                parentSpaceForChild.Y += childScaledMargins.Y;
                parentSpaceForChild.Width -= childScaledMargins.Width;
                parentSpaceForChild.Height -= childScaledMargins.Height;
            }
            else
            {
                bool applyYMargin = ParentAnchor is UIAnchor.TopCenter;
                if (ParentAnchor is UIAnchor.TopLeft or UIAnchor.TopRight && Anchor is UIAnchor.BottomLeft or UIAnchor.BottomCenter or UIAnchor.BottomRight)
                {
                    applyYMargin = true;
                }

                bool applyXMargin = ParentAnchor is UIAnchor.CenterLeft;
                if (ParentAnchor is UIAnchor.TopLeft or UIAnchor.BottomLeft && Anchor is UIAnchor.TopRight or UIAnchor.CenterRight or UIAnchor.BottomRight)
                {
                    applyXMargin = true;
                }


                if (applyYMargin)
                {
                    parentSpaceForChild.Y -= childScaledMargins.Height;
                }
                else if(applyXMargin)
                {
                    parentSpaceForChild.X -= childScaledMargins.Width;
                }
                
                
                parentSpaceForChild.Width += childScaledMargins.X;
                parentSpaceForChild.Height += childScaledMargins.Y;
            }

            Debugger?.RecordMetric(this, "Layout_ParentContentRect", parentSpaceForChild);
            return parentPos + GetUIAnchorPosition(ParentAnchor, parentSize, parentSpaceForChild, Anchor, _measuredSize);
        }

        protected void Layout(Vector2 contentPos)
        {
            Debugger?.RecordMetric(this, "Layout_ContentPos", contentPos);

            float scale = GetScale();

            Size = _measuredSize;
            contentPos += Offset * scale;
            contentPos = BeforeLayout(contentPos);
            Position = contentPos.RoundClosest().ToVec3(Z);

            // Invalidate transformations.
            if (_transformationStackBacking != null) _transformationStackBacking.MatrixDirty = true;

            if (Children != null)
            {
                bool wrap = LayoutMode is LayoutMode.HorizontalListWrap or LayoutMode.VerticalListWrap;
                Vector2 scaledSpacing = ListSpacing * scale;
                switch (LayoutMode)
                {
                    case LayoutMode.Free:
                    {
                        for (var i = 0; i < Children.Count; i++)
                        {
                            UIBaseWindow child = Children[i];
                            Vector2 parentSize = Vector2.Zero;
                            Vector2 parentPos = Vector2.Zero;
                            if (child.RelativeTo == null)
                            {
                                parentSize = _measuredSize;
                                parentPos = contentPos;
                            }
                            else
                            {
                                UIBaseWindow? win = Controller?.GetWindowById(child.RelativeTo);
                                if (win != null)
                                {
                                    if (Debugger != null && Debugger.GetMetricsForWindow(win) == null)
                                    {
                                        Engine.Log.Warning($"{this} will layout relative to {child.RelativeTo}, before it had a chance to layout itself.", "UI");
                                    }

                                    parentSize = win.Size;
                                    parentPos = win.Position2;
                                }
                                else
                                {
                                    Engine.Log.Warning($"{this} tried to layout relative to {child.RelativeTo} but it couldn't find it.", "UI");
                                }
                            }

                            Vector2 childPos = child.CalculateContentPos(parentPos, parentSize);

                            child.Layout(childPos);
                        }

                        break;
                    }
                    case LayoutMode.HorizontalListWrap:
                    case LayoutMode.HorizontalList:
                    {
                        Vector2 pen = contentPos;
                        Vector2 sizeLeft = _measuredSize;
                        for (var i = 0; i < Children.Count; i++)
                        {
                            UIBaseWindow child = Children[i];
                            bool insideParent = AnchorsInsideParent(child.ParentAnchor, child.Anchor);
                            if (insideParent && i != 0)
                            {
                                pen.X += scaledSpacing.X;
                                sizeLeft.X -= scaledSpacing.X;
                            }

                            Vector2 pos = child.CalculateContentPos(pen, sizeLeft);
                            child.Layout(pos);
                            if (!child.Visible && child.DontTakeSpaceWhenHidden) continue;
                            if (!insideParent) continue; // Dont count spcae taken by windows outside parent.

                            float childScale = child.GetScale();
                            Vector2 childOffsetScaled = child.Offset * childScale;
                            Rectangle childMarginsScaled = child.Margins * childScale;
                            float spaceTaken = child.Size.X + childOffsetScaled.X + childMarginsScaled.X + childMarginsScaled.Width;
                            pen.X += spaceTaken;
                            sizeLeft.X -= spaceTaken;
                        }

                        break;
                    }
                    case LayoutMode.VerticalListWrap:
                    case LayoutMode.VerticalList:
                    {
                        Vector2 pen = contentPos;
                        Vector2 sizeLeft = _measuredSize;
                        for (var i = 0; i < Children.Count; i++)
                        {
                            UIBaseWindow child = Children[i];
                            bool insideParent = AnchorsInsideParent(child.ParentAnchor, child.Anchor);
                            if (insideParent && i != 0)
                            {
                                pen.Y += scaledSpacing.Y;
                                sizeLeft.Y -= scaledSpacing.Y;
                            }

                            Vector2 pos = child.CalculateContentPos(pen, sizeLeft);
                            child.Layout(pos);
                            if (!child.Visible && child.DontTakeSpaceWhenHidden) continue;
                            if (!insideParent) continue;

                            float childScale = child.GetScale();
                            Vector2 childOffsetScaled = child.Offset * childScale;
                            Rectangle childMarginsScaled = child.Margins * childScale;
                            float spaceTaken = child.Size.Y + childOffsetScaled.Y + childMarginsScaled.Y + childMarginsScaled.Height;
                            pen.Y += spaceTaken;
                            sizeLeft.Y -= spaceTaken;
                        }

                        break;
                    }
                }
            }

            AfterLayout();
        }

        protected virtual Vector2 BeforeLayout(Vector2 position)
        {
            return position;
        }

        protected virtual void AfterLayout()
        {
            // nop - to be overriden
        }

        #endregion

        #region Color

        /// <summary>
        /// This color should be mixed in with the rendering of the window somehow.
        /// Used to control opacity as well.
        /// </summary>
        public Color WindowColor
        {
            get => _windowColor;
            set
            {
                _windowColor = value;
                InvalidateColor();
            }
        }

        private Color _windowColor = Color.White;

        /// <summary>
        /// If set to true then this window will not mix its color with its parent's.
        /// </summary>
        public bool IgnoreParentColor = false;

        protected Color _calculatedColor;
        protected bool _updateColor = true;
        protected byte _startingAlpha = 255;
        protected byte _targetAlpha = 255;
        protected ITimer? _alphaTween;

        public void InvalidateColor()
        {
            _updateColor = true;
            if (Children == null) return;
            for (var i = 0; i < Children.Count; i++)
            {
                UIBaseWindow child = Children[i];
                child.InvalidateColor();
            }
        }

        public void SetAlpha(byte value, ITimer tween)
        {
            _startingAlpha = WindowColor.A;
            _targetAlpha = value;
            _alphaTween = tween;
        }

        protected void CalculateColor()
        {
            if (Parent == null || IgnoreParentColor)
                _calculatedColor = WindowColor;
            else
                _calculatedColor = WindowColor * Parent._calculatedColor.A;

            if (Children == null) return;
            for (var i = 0; i < Children.Count; i++)
            {
                UIBaseWindow child = Children[i];
                child.CalculateColor();
            }
        }

        #endregion

        #region Input

        /// <summary>
        /// If true then this window will not catch input unless propagated by a child. Used for large containers which
        /// take up the whole screen and such.
        /// </summary>
        public bool InputTransparent
        {
            get => _inputTransparent;
            set
            {
                if (value == _inputTransparent) return;
                _inputTransparent = value;
                Controller?.InvalidateInputFocus();
            }
        }

        private bool _inputTransparent = true;

        public virtual bool OnKey(Key key, KeyStatus status)
        {
            return Parent == null || Parent.OnKey(key, status);
        }

        #endregion

        #region Animations

        /// <summary>
        /// Ignore the displacements on the parent, otherwise the displacements of this window are multiplied by the parent's.
        /// </summary>
        public bool IgnoreParentDisplacement { get; set; }

        /// <summary>
        /// List of affine transformations to apply to this window and its children.
        /// </summary>
        [DontSerialize]
        public NamedTransformationStack TransformationStack
        {
            get => _transformationStackBacking ??= new NamedTransformationStack();
        }

        private NamedTransformationStack? _transformationStackBacking;

        #endregion

        #region Layout Helpers

        public void SetExactRequestedSize(Vector2 size)
        {
            size = size.Ceiling();
            MinSize = size;
            MaxSize = size;
        }

        /// <summary>
        /// A very simple check for whether the anchors will land the window inside or outside the parent.
        /// This decides whether the window will layout within the parent or outside it.
        /// </summary>
        /// <returns></returns>
        protected static bool AnchorsInsideParent(UIAnchor parentAnchor, UIAnchor anchor)
        {
            bool parentIsTop = parentAnchor is UIAnchor.TopLeft or UIAnchor.TopCenter or UIAnchor.TopRight;
            bool parentIsVCenter = parentAnchor is UIAnchor.CenterLeft or UIAnchor.CenterCenter or UIAnchor.CenterRight;
            bool parentIsBottom = parentAnchor is UIAnchor.BottomLeft or UIAnchor.BottomCenter or UIAnchor.BottomRight;

            bool parentIsLeft = parentAnchor is UIAnchor.TopLeft or UIAnchor.CenterLeft or UIAnchor.BottomLeft;
            bool parentIsHCenter = parentAnchor is UIAnchor.TopCenter or UIAnchor.CenterCenter or UIAnchor.BottomCenter;
            bool parentIsRight = parentAnchor is UIAnchor.TopRight or UIAnchor.CenterRight or UIAnchor.BottomRight;

            if (parentIsTop)
            {
                if (parentIsLeft && anchor == UIAnchor.TopLeft) return true;

                if (parentIsHCenter && anchor is UIAnchor.TopLeft or UIAnchor.TopCenter or UIAnchor.TopRight) return true;

                if (parentIsRight && anchor == UIAnchor.TopRight) return true;
            }
            else if (parentIsVCenter)
            {
                if (parentIsLeft && anchor is UIAnchor.TopLeft or UIAnchor.CenterLeft or UIAnchor.BottomLeft) return true;
                if (parentIsHCenter) return true;
                if (parentIsRight && anchor is UIAnchor.TopRight or UIAnchor.CenterRight or UIAnchor.BottomRight) return true;
            }
            else if (parentIsBottom)
            {
                if (parentIsLeft && anchor == UIAnchor.BottomLeft) return true;
                if (parentIsHCenter && anchor is UIAnchor.BottomLeft or UIAnchor.BottomCenter or UIAnchor.BottomRight) return true;
                if (parentIsRight && anchor == UIAnchor.BottomRight) return true;
            }

            return false;
        }

        protected static Vector2 GetUIAnchorPosition(UIAnchor parentAnchor, Vector2 parentSize, Rectangle parentContentRect, UIAnchor anchor, Vector2 contentSize)
        {
            Vector2 offset = Vector2.Zero;

            switch (parentAnchor)
            {
                case UIAnchor.TopLeft:
                case UIAnchor.CenterLeft:
                case UIAnchor.BottomLeft:
                    offset.X += parentContentRect.X;
                    break;
                case UIAnchor.TopCenter:
                case UIAnchor.CenterCenter:
                case UIAnchor.BottomCenter:
                    offset.X += parentSize.X / 2;
                    break;
                case UIAnchor.TopRight:
                case UIAnchor.CenterRight:
                case UIAnchor.BottomRight:
                    offset.X += parentContentRect.Width;
                    break;
            }

            switch (parentAnchor)
            {
                case UIAnchor.TopLeft:
                case UIAnchor.TopCenter:
                case UIAnchor.TopRight:
                    offset.Y += parentContentRect.Y;
                    break;
                case UIAnchor.CenterLeft:
                case UIAnchor.CenterCenter:
                case UIAnchor.CenterRight:
                    offset.Y += parentSize.Y / 2;
                    break;
                case UIAnchor.BottomLeft:
                case UIAnchor.BottomCenter:
                case UIAnchor.BottomRight:
                    offset.Y += parentContentRect.Height;
                    break;
            }

            switch (anchor)
            {
                case UIAnchor.TopCenter:
                case UIAnchor.CenterCenter:
                case UIAnchor.BottomCenter:
                    offset.X -= contentSize.X / 2;
                    break;
                case UIAnchor.TopRight:
                case UIAnchor.CenterRight:
                case UIAnchor.BottomRight:
                    offset.X -= contentSize.X;
                    break;
            }

            switch (anchor)
            {
                case UIAnchor.CenterLeft:
                case UIAnchor.CenterCenter:
                case UIAnchor.CenterRight:
                    offset.Y -= contentSize.Y / 2;
                    break;
                case UIAnchor.BottomLeft:
                case UIAnchor.BottomCenter:
                case UIAnchor.BottomRight:
                    offset.Y -= contentSize.Y;
                    break;
            }

            return offset;
        }

        /// <summary>
        /// The scale factor applied on the UI.
        /// </summary>
        /// <returns></returns>
        public float GetScale()
        {
            return ScaleMode switch
            {
                UIScaleMode.FloatScale => Engine.Renderer.Scale,
                UIScaleMode.IntScale => Engine.Renderer.IntScale,
                _ => 1.0f
            };
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Get a window with the specified id which is either a child of this window,
        /// or below it on the tree.
        /// </summary>
        /// <param name="id">The id of the window to look for.</param>
        /// <returns>The instance of the window.</returns>
        public virtual UIBaseWindow? GetWindowById(string id)
        {
            if (id == "Controller")
            {
                UIBaseWindow cur = this;
                while (cur.Parent != null)
                {
                    if (cur is UIController) return cur;
                    cur = cur.Parent;
                }
            }

            if (Children == null) return null;

            for (var i = 0; i < Children.Count; i++)
            {
                if (Children[i].Id == id) return Children[i];
            }

            for (var i = 0; i < Children.Count; i++)
            {
                UIBaseWindow? win = Children[i].GetWindowById(id);
                if (win != null) return win;
            }

            return null;
        }

        /// <summary>
        /// Clone the window. By default this performs a serialization clone.
        /// </summary>
        /// <returns></returns>
        public UIBaseWindow Clone()
        {
            string xml = XMLFormat.To(this);
            return XMLFormat.From<UIBaseWindow>(xml);
        }

        /// <summary>
        /// Compares the windows based on their Z order.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(UIBaseWindow? other)
        {
            if (other == null) return MathF.Sign(Z);
            return MathF.Sign(Z - other.Z);
        }

        public override string ToString()
        {
            return $"{GetType().ToString().Replace("Emotion.UI.", "")} {Id}";
        }

        #endregion

        #region Enum

        public IEnumerator<UIBaseWindow> GetEnumerator()
        {
            for (var i = 0; i < Children?.Count; i++)
            {
                UIBaseWindow cur = Children[i];

                // Get children.
                var childrenLists = new Queue<List<UIBaseWindow>>();
                if (cur.Children != null) childrenLists.Enqueue(cur.Children);
                yield return cur;

                while (childrenLists.Count > 0)
                {
                    List<UIBaseWindow> list = childrenLists.Dequeue();
                    for (var j = 0; j < list.Count; j++)
                    {
                        UIBaseWindow child = list[j];
                        // Get grandchildren if any.
                        if (child.Children?.Count > 0) childrenLists.Enqueue(child.Children);
                        yield return child;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}