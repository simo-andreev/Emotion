﻿#region Using

using System.Text;
using Emotion.Standard.XML.TypeHandlers;

#endregion

#nullable enable

namespace Emotion.Standard.XML
{
	public static class XMLFormat
	{
		public static string IndentChar = "  ";

		public static string? To<T>(T obj)
		{
			Type type = typeof(T);
			var output = new StringBuilder();
			output.Append("<?xml version=\"1.0\"?>\n");

			XMLTypeHandler? handler = XMLHelpers.GetTypeHandler(type);
			if (handler == null) return null;

			var recursionChecker = new XMLRecursionChecker();
			recursionChecker.PushReference(obj, "main");
			handler.Serialize(obj, output, 1, recursionChecker);
			recursionChecker.PopReference(obj);

			return output.ToString();
		}

		public static T? From<T>(string xml)
		{
			if (string.IsNullOrEmpty(xml)) return default;
			Type requestedType = typeof(T);

			var reader = new XMLReader(xml);
			reader.GoToNextTag();

			// This is called first in order to index the type.
			XMLTypeHandler? requestedTypeHandler = XMLHelpers.GetTypeHandler(requestedType);

			// Check if the handler is supposed to be of an inherited type. Otherwise use the handler of the requested type.
			XMLTypeHandler? handler = XMLHelpers.GetInheritedTypeHandlerFromXMLTag(reader, out string tag) ?? requestedTypeHandler;
			if (handler == null)
			{
				Engine.Log.Warning($"Couldn't find type handler for type {requestedType}.", MessageSource.XML);
				return default;
			}

			// Try to find the type of the tag in the XML document.
			Type? headerTagType = XMLHelpers.GetTypeByNameWithTypeHint(requestedType, tag);
			if (headerTagType == null)
			{
				Engine.Log.Warning($"Tried to deserialize a document with header {tag} but found no such type that is assignable to {requestedType}.", MessageSource.XML);
				return default;
			}
			
			// If the document was serialized as another type...
			if (headerTagType != requestedType)
			{
				// but if it can be assigned to the requested type (inheriting type)
				if (headerTagType.IsAssignableTo(requestedType))
				{
					// then the handler is of the tag type.
					XMLTypeHandler? headerTypeHandler = XMLHelpers.GetTypeHandler(headerTagType);
					if (headerTypeHandler == null)
					{
						Engine.Log.Warning($"Couldn't find type handler for type {headerTagType} gotten from document tag {tag}.", MessageSource.XML);
						return default;
					}

					handler = headerTypeHandler;
				}
				// or if the document type can be cast from the requested type (inherited type)
				else if (headerTagType.IsAssignableFrom(requestedType))
				{
					// no changes
				}
				else
				{
					Engine.Log.Warning($"Tried to deserialize a document with header type {headerTagType}({tag}) while expecting inherited from {requestedType}.", MessageSource.XML);
					return default;
				}
			}

			// Verify whether document is of an assignable type.
			if (!requestedType.IsAssignableFrom(handler.Type))
			{
				Engine.Log.Warning($"Tried to deserialize a document of type {handler.TypeName} while expecting inherited from {requestedType}.", MessageSource.XML);
				return default;
			}

			return (T?) handler.Deserialize(reader);
		}

		public static T? From<T>(ReadOnlyMemory<byte> data)
		{
			ReadOnlySpan<byte> span = data.Span;
			Encoding encoding = GuessStringEncoding(span);
			return From<T>(encoding.GetString(span));
		}

		private static readonly byte[] Utf16Le = {0xFF, 0xFE};
		private static readonly byte[] Utf8Le = {0xEF, 0xBB, 0xBF};
		private static readonly byte[] Utf32Le = {0xFF, 0xFE, 0, 0};
		private static readonly byte[] Utf16Be = {0xFE, 0xFF};

		// <?xml search
		private static readonly byte[] Utf16LeAlt = {0x3C, 0, 0x3F, 0};
		private static readonly byte[] Utf8LeAlt = {0x3C, 0x3F, 0x78, 0x6D};
		private static readonly byte[] Utf32LeAlt = {0x3C, 0, 0, 0};
		private static readonly byte[] Utf16BeAlt = {0, 0x3C, 00, 0x3F};

		/// <summary>
		/// Guess the string encoding of the data array.
		/// https://stackoverflow.com/questions/581318/c-sharp-detect-xml-encoding-from-byte-array
		/// </summary>
		public static Encoding GuessStringEncoding(ReadOnlySpan<byte> data)
		{
			// "utf-16" - Unicode UTF-16, little endian byte order
			if (data.SequenceEqual(Utf16LeAlt)) return Encoding.Unicode;
			if ((data[2] == 0) ^ (data[3] == 0) && data.SequenceEqual(Utf16Le)) return Encoding.Unicode;

			// "utf-8" - Unicode (UTF-8)
			if (data.SequenceEqual(Utf8Le) || data.SequenceEqual(Utf8LeAlt)) return Encoding.UTF8;

			// "utf-32" - Unicode UTF-32, little endian byte order
			if (data.SequenceEqual(Utf32Le) || data.SequenceEqual(Utf32LeAlt)) return Encoding.UTF32;

			// "unicodeFFFE" - Unicode UTF-16, big endian byte order
			if (data.SequenceEqual(Utf16BeAlt)) return Encoding.BigEndianUnicode;
			if (data[2] != 0 && data[3] != 0 && data.SequenceEqual(Utf16Be)) return Encoding.BigEndianUnicode;

			return Encoding.UTF8;
		}
	}
}