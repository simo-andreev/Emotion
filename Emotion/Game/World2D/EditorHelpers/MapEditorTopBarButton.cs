﻿#region Using

using Emotion.Graphics;
using Emotion.Platform.Input;
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

		public bool Enabled
		{
			get => _enabled;
			set
			{
				_enabled = value;
				RecalculateButtonColor();
			}
		}

		private bool _enabled = true;

		public bool RenderInactiveBG = true;

		public object? UserData;

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
			if (RenderInactiveBG || MouseInside) c.RenderSprite(Bounds, _calculatedColor);
			return base.RenderInternal(c);
		}

		public override bool OnKey(Key key, KeyStatus status, Vector2 mousePos)
		{
			if (!Enabled) return false;
			return base.OnKey(key, status, mousePos);
		}

		public override void OnMouseEnter(Vector2 _)
		{
			if (!Enabled) return;
			base.OnMouseEnter(_);
			RecalculateButtonColor();
		}

		public override void OnMouseLeft(Vector2 _)
		{
			if (!Enabled) return;
			base.OnMouseLeft(_);
			RecalculateButtonColor();
		}

		public void SetActiveMode(bool activeLock)
		{
			_activeMode = activeLock;
			RecalculateButtonColor();
		}

		private void RecalculateButtonColor()
		{
			if (!Enabled)
			{
				WindowColor = MapEditorColorPalette.ButtonColorDisabled.SetAlpha(150);
				_label.IgnoreParentColor = false;
				return;
			}

			if (_activeMode)
			{
				WindowColor = MapEditorColorPalette.ActiveButtonColor;
				_label.IgnoreParentColor = true;
				return;
			}

			WindowColor = MouseInside ? MapEditorColorPalette.ActiveButtonColor : MapEditorColorPalette.ButtonColor;
			_label.IgnoreParentColor = true;
		}
	}
}