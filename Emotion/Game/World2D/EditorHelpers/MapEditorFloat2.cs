﻿#region Using

using Emotion.UI;

#endregion

namespace Emotion.Game.World2D.EditorHelpers
{
	public class MapEditorFloat2 : UIBaseWindow, IMapEditorGeneric
	{
		private Vector2 _value;
		private Action<object> _callback;

		private string _xEdit;
		private string _yEdit;

		private MapEditorFloat _editorX;
		private MapEditorFloat _editorY;

		public MapEditorFloat2()
		{
			LayoutMode = LayoutMode.HorizontalList;
			ListSpacing = new Vector2(2, 0);
			InputTransparent = false;
			StretchX = true;
			StretchY = true;
		}

		public override void AttachedToController(UIController controller)
		{
			base.AttachedToController(controller);

			var labelX = new MapEditorLabel("X:");
			AddChild(labelX);
			var editorX = new MapEditorFloat();
			AddChild(editorX);
			_editorX = editorX;
			editorX.SetValue(_value.X);
			editorX.SetCallbackValueChanged(newXVal =>
			{
				_value.X = (float) newXVal;
				_callback?.Invoke(_value);
			});

			var labelY = new MapEditorLabel("Y:");
			labelY.Margins = new Rectangle(2, 0, 0, 0);
			AddChild(labelY);
			var editorY = new MapEditorFloat();
			AddChild(editorY);
			_editorY = editorY;
			editorY.SetValue(_value.Y);
			editorY.SetCallbackValueChanged(newYVal =>
			{
				_value.Y = (float) newYVal;
				_callback?.Invoke(_value);
			});
		}

		public void SetValue(object value)
		{
			_value = (Vector2) value;
			_editorX?.SetValue(_value.X);
			_editorY?.SetValue(_value.Y);
		}

		public object GetValue()
		{
			return _value;
		}

		public void SetCallbackValueChanged(Action<object> callback)
		{
			_callback = callback;
		}
	}
}