﻿#region Using

using System;
using System.Collections.Generic;
using System.Text;
using Emotion.Common;
using Emotion.Standard.Logging;

#endregion

#nullable enable

namespace Emotion.Standard.XML.TypeHandlers
{
    public class XMLComplexValueTypeHandler : XMLComplexBaseTypeHandler
    {
        /// <summary>
        /// The default value of this complex type, if a value type.
        /// </summary>
        private object? _defaultValue;

        public XMLComplexValueTypeHandler(Type type, bool nullable) : base(type)
        {
            // Create default value reference.
            _defaultValue = nullable ? Activator.CreateInstance(type, true) : null;
        }

        public override bool Serialize(object obj, StringBuilder output, int indentation = 1, XMLRecursionChecker? recursionChecker = null, string? fieldName = null)
        {
            if (_defaultValue != null && obj.Equals(_defaultValue)) return false;
            return base.Serialize(obj, output, indentation, recursionChecker, fieldName);
        }

        public override void SerializeValue(object obj, StringBuilder output, int indentation = 1, XMLRecursionChecker? recursionChecker = null)
        {
            output.Append("\n");

            Dictionary<string, XMLFieldHandler> fieldHandlers = _fieldHandlers.Value;
            foreach ((string _, XMLFieldHandler field) in fieldHandlers)
            {
                if (field.Skip) continue;

                object? propertyVal = field.ReflectionInfo.GetValue(obj);
                field.TypeHandler.Serialize(propertyVal, output, indentation + 1, recursionChecker, field.Name);
            }

            output.AppendJoin(XMLFormat.IndentChar, new string[indentation - 1]);
        }

        public override object? Deserialize(XMLReader input)
        {
            int depth = input.Depth;
            object? newObj = Activator.CreateInstance(Type, true);
            if (newObj == null) return null;

            input.GoToNextTag();
            while (input.Depth >= depth && !input.Finished)
            {
                string currentTag = input.ReadTagWithoutAttribute();
                if (!_fieldHandlers.Value.TryGetValue(currentTag, out XMLFieldHandler? field))
                {
                    Engine.Log.Warning($"Couldn't find handler for field - {currentTag}", MessageSource.XML);
                    return newObj;
                }

                object val = field.TypeHandler.Deserialize(input);
                if (!field.Skip) field.ReflectionInfo.SetValue(newObj, val);
                input.GoToNextTag();
            }

            return newObj;
        }
    }
}