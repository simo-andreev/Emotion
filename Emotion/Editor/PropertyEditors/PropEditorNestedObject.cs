﻿using Emotion.Editor.EditorHelpers;
using Emotion.Standard.XML;
using Emotion.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emotion.Editor.PropertyEditors
{
    public class PropEditorNestedObject : EditorButton, IPropEditorGeneric
    {
        public XMLFieldHandler Field { get; set; }

        private object _value;
        private Action<object> _changeCallback;

        public PropEditorNestedObject()
        {
            OnClickedProxy = (_) =>
            {
                if (_value == null) return;
                var panel = new GenericPropertiesEditorPanel(_value);
                Controller?.AddChild(panel);
            };
            StretchY = true;
        }

        public object GetValue()
        {
            return _value;
        }

        public void SetCallbackValueChanged(Action<object> callback)
        {
            _changeCallback = callback;
        }

        public void SetValue(object value)
        {
            Text = value == null ? "<null>" : value.ToString();
            _value = value;
        }
    }
}
