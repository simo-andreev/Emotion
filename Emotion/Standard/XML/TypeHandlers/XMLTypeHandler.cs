﻿#region Using

using System;
using System.Globalization;
using System.Text;

#endregion

#nullable enable

namespace Emotion.Standard.XML.TypeHandlers
{
    /// <summary>
    /// Object which knows how to handle the serialization and deserialization of objects.
    /// </summary>
    public abstract class XMLTypeHandler
    {
        /// <summary>
        /// The type this handler relates to.
        /// </summary>
        public Type Type { get; protected set; }

        /// <summary>
        /// The serialization name of the type.
        /// </summary>
        public string TypeName { get; }

        /// <summary>
        /// Create a handler for a type.
        /// </summary>
        /// <param name="type">The type to handle.</param>
        protected XMLTypeHandler(Type type)
        {
            Type = type;
            TypeName = XMLHelpers.GetTypeName(Type) ?? "UnknownType";
        }

        /// <summary>
        /// Serialize the object.
        /// Includes indentation and field tags.
        /// </summary>
        public virtual bool Serialize(object? obj, StringBuilder output, int indentation = 1, XMLRecursionChecker? recursionChecker = null, string? fieldName = null)
        {
            if (obj == null) return false;

            fieldName ??= TypeName;
            output.AppendJoin(XMLFormat.IndentChar, new string[indentation]);
            output.Append($"<{fieldName}>");
            SerializeValue(obj, output, indentation, recursionChecker);
            output.Append($"</{fieldName}>\n");
            return true;
        }

        /// <summary>
        /// Serialize just the value of the object without extra tags.
        /// Used by complex handlers.
        /// </summary>
        public virtual void SerializeValue(object obj, StringBuilder output, int indentation = 1, XMLRecursionChecker? recursionChecker = null)
        {
            output.Append(Convert.ToString(obj, CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Deserialize the object.
        /// </summary>
        public abstract object? Deserialize(XMLReader input);
    }
}