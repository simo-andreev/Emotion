﻿using Emotion.Common;
using Emotion.IO;
using Emotion.Testing;
using System.Collections;

namespace Tests.EngineTests;

[Test]
public class TextAssetTest
{
    [Test]
    public IEnumerator ReadTextFile_UTF8()
    {
        AssetHandle<TextAsset> assetHandle = Engine.AssetLoader.ONE_Get<TextAsset>("TextTest/Normal.txt");
        yield return assetHandle;

        Assert.True(assetHandle.AssetLoaded);

        TextAsset asset = assetHandle.Asset;
        Assert.NotNull(asset);

        string content = asset.Content;

        Assert.Equal(content.Length, 42);
        Assert.Equal(asset.ByteSize, 43); // One byte more because the original file has windows line endings
        Assert.True(content.StartsWith("Hello world!\nI am"));
    }

    [Test]
    public IEnumerator ReadTextFile_ANSI()
    {
        AssetHandle<TextAsset> assetHandle = Engine.AssetLoader.ONE_Get<TextAsset>("TextTest/ANSI.txt");
        yield return assetHandle;

        Assert.True(assetHandle.AssetLoaded);

        TextAsset asset = assetHandle.Asset;
        Assert.NotNull(asset);

        string content = asset.Content;

        Assert.Equal(content.Length, 25);
        Assert.Equal(asset.ByteSize, 26); // One byte more because the original file has windows line endings
        Assert.True(content.StartsWith("Hey, I am ANSI text\nyu"));
    }

    [Test]
    public IEnumerator ReadTextFile_UnixLneEnding()
    {
        AssetHandle<TextAsset> assetHandle = Engine.AssetLoader.ONE_Get<TextAsset>("TextTest/UTF8_UnixLineEnding.txt");
        yield return assetHandle;

        Assert.True(assetHandle.AssetLoaded);

        TextAsset asset = assetHandle.Asset;
        Assert.NotNull(asset);

        string content = asset.Content;

        Assert.Equal(content.Length, 57);
        Assert.Equal(asset.ByteSize, 57);
        Assert.True(content.StartsWith("I am UTF8 text without\na BOM"));
    }

    [Test]
    public IEnumerator ReadTextFile_UTF8BOM()
    {
        AssetHandle<TextAsset> assetHandle = Engine.AssetLoader.ONE_Get<TextAsset>("TextTest/UTF8BOM.txt");
        yield return assetHandle;

        Assert.True(assetHandle.AssetLoaded);

        TextAsset asset = assetHandle.Asset;
        Assert.NotNull(asset);

        string content = asset.Content;

        Assert.Equal(content.Length, 65);
        Assert.Equal(asset.ByteSize, 68); // 3 byte bom
        Assert.True(content.StartsWith("I am UTF8 text with BOM"));
    }

    [Test]
    public IEnumerator ReadTextFile_UTF16BE()
    {
        AssetHandle<TextAsset> assetHandle = Engine.AssetLoader.ONE_Get<TextAsset>("TextTest/UTF16BE.txt");
        yield return assetHandle;

        Assert.True(assetHandle.AssetLoaded);

        TextAsset asset = assetHandle.Asset;
        Assert.NotNull(asset);

        string content = asset.Content;

        Assert.Equal(content.Length, 59);
        Assert.Equal(asset.ByteSize, 124); // 59 * 2 + 2 (windows new line) + 4 (BOM)
        Assert.True(content.StartsWith("I am a god forsaken UTF16\nbig endian piece"));
    }

    [Test]
    public IEnumerator ReadTextFile_UTF16LE()
    {
        AssetHandle<TextAsset> assetHandle = Engine.AssetLoader.ONE_Get<TextAsset>("TextTest/UTF16LE.txt");
        yield return assetHandle;

        Assert.True(assetHandle.AssetLoaded);

        TextAsset asset = assetHandle.Asset;
        Assert.NotNull(asset);

        string content = asset.Content;

        Assert.Equal(content.Length, 62);
        Assert.Equal(asset.ByteSize, 130); // 62 * 2 + 2 (windows new line) + 4 (BOM)
        Assert.True(content.StartsWith("I am a god forsaken UTF16\nlittle endian piece"));
    }
}
