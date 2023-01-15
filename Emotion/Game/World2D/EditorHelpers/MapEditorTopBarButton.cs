﻿#region Using

using System.Numerics;
using Emotion.Graphics;
using Emotion.Platform.Input;
using Emotion.Primitives;
using Emotion.UI;

#endregion

namespace Emotion.Game.World2D.EditorHelpers
{
    public class MapEditorTopBarButton : UICallbackButton
    {
        public string Text
        {
            get => _label.Text;
            set => _label.Text = value;
        }

        public bool Enabled = true;

        private UIDropDown _dropDownMode;
        private bool _activeMode;
        private UIText _label;

        public MapEditorTopBarButton()
        {
            WindowColor = MapEditorColorPalette.ButtonColor;
            ScaleMode = UIScaleMode.FloatScale;

            var txt = new UIText();
            txt.ParentAnchor = UIAnchor.CenterLeft;
            txt.Anchor = UIAnchor.CenterLeft;
            txt.ScaleMode = UIScaleMode.FloatScale;
            txt.WindowColor = MapEditorColorPalette.TextColor;
            txt.Id = "buttonText";
            txt.FontFile = "Editor/UbuntuMono-Regular.ttf";
            txt.FontSize = MapEditorColorPalette.EditorButtonTextSize;
            txt.IgnoreParentColor = true;
            _label = txt;
            AddChild(txt);

            StretchX = true;
            Paddings = new Rectangle(2, 1, 2, 1);
        }

        protected override bool RenderInternal(RenderComposer c)
        {
            c.RenderSprite(Bounds, _calculatedColor);
            return base.RenderInternal(c);
        }

        protected override bool UpdateInternal()
        {
	        if (!Enabled)
	        {
		        WindowColor = MapEditorColorPalette.ButtonColorDisabled.SetAlpha(150);
		        _label.IgnoreParentColor = false;
	        }
	        else
	        {
		        WindowColor = MouseInside ? MapEditorColorPalette.ActiveButtonColor : MapEditorColorPalette.ButtonColor;
		        _label.IgnoreParentColor = true;
	        }
	        
	        if (_dropDownMode != null && _dropDownMode.Controller == null)
            {
                _dropDownMode = null;
                _activeMode = false;
            }

	        return base.UpdateInternal();
        }

        public override bool OnKey(Key key, KeyStatus status, Vector2 mousePos)
        {
            if (!Enabled) return false;
            return base.OnKey(key, status, mousePos);
        }

        public override void OnMouseEnter(Vector2 _)
        {
            if (!Enabled) return;
            if (!_activeMode) WindowColor = MapEditorColorPalette.ActiveButtonColor;
            base.OnMouseEnter(_);
        }

        public override void OnMouseLeft(Vector2 _)
        {
	        if (!Enabled) return;
            if (!_activeMode) WindowColor = MapEditorColorPalette.ButtonColor;
            base.OnMouseLeft(_);
        }

        /// <summary>
        /// In drop down mode click is called on mouse over.
        /// </summary>
        public void SetDropDownMode(bool dropDownOnMe, UIDropDown dropDown)
        {
            _activeMode = dropDownOnMe;
            WindowColor = dropDownOnMe ? MapEditorColorPalette.ActiveButtonColor : MapEditorColorPalette.ButtonColor;
            _dropDownMode = dropDown;
        }
    }
}