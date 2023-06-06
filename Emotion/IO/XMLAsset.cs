﻿#region Using

using System.Text;
using Emotion.Standard.XML;

#endregion

#nullable enable

namespace Emotion.IO;

// Non generic marker class to differentiate XMLAsset classes
public abstract class XMLAssetMarkerClass : Asset
{
	/// <summary>
	/// Whether the file was successfully parsed,
	/// and an instance of the type was created.
	/// </summary>
	public abstract bool HasContent();
}

/// <summary>
/// A file in XML structure.
/// </summary>
/// <typeparam name="T">The class to deserialize to.</typeparam>
public class XMLAsset<T> : XMLAssetMarkerClass
{
	/// <summary>
	/// The contents of the file.
	/// </summary>
	public T? Content { get; protected set; }

	protected override void CreateInternal(ReadOnlyMemory<byte> data)
	{
		try
		{
			Content = XMLFormat.From<T>(data);
		}
		catch (Exception ex)
		{
			Engine.Log.Error(new Exception($"Couldn't parse XML asset of type {GetType()}!", ex));
		}
	}

	protected override void DisposeInternal()
	{
	}

	/// <inheritdoc />
	public override bool HasContent()
	{
		return Content != null;
	}

	/// <summary>
	/// Create a new xml file from content and a name.
	/// </summary>
	public static XMLAsset<T> CreateFromContent(T content, string name = "Untitled")
	{
		return new()
		{
			Content = content,
			Name = name
		};
	}

	/// <summary>
	/// Save the file to the asset store.
	/// </summary>
	public bool Save()
	{
		return SaveAs(Name);
	}

	/// <summary>
	/// Save the file to the asset store with the provided name.
	/// </summary>
	public bool SaveAs(string name, bool backup = true)
	{
		string data = XMLFormat.To(Content);
		bool saved = Engine.AssetLoader.Save(Encoding.UTF8.GetBytes(data), name, backup);
		if (!saved) Engine.Log.Warning($"Couldn't save file {name}.", MessageSource.Other);
		return saved;
	}

	/// <summary>
	/// Load a xml file via the asset loader, or create a new one if missing.
	/// </summary>
	public static XMLAsset<T> LoadSaveOrCreate(string name)
	{
		if (Engine.AssetLoader.Exists(name)) return Engine.AssetLoader.Get<XMLAsset<T>>(name)!;

		// If the file doesn't exist - create it.
		XMLAsset<T> newFile = CreateFromContent(Activator.CreateInstance<T>(), name);
		newFile.Save();
		return newFile;
	}
}