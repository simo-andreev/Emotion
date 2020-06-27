﻿#region Using

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using Emotion.Common;
using Emotion.Primitives;
using Emotion.Standard.Image.PNG;
using Emotion.Utility;

#endregion

namespace Emotion.Standard.OpenType
{
    /// <summary>
    /// Represents a single glyph within a FontAtlas.
    /// </summary>
    public class AtlasGlyph
    {
        /// <summary>
        /// The location of the glyph within the atlas texture.
        /// </summary>
        public Vector2 Location { get; set; }

        /// <summary>
        /// The size of the glyph.
        /// </summary>
        public Vector2 Size { get; set; }

        /// <summary>
        /// The size of the glyph texture within the atlas texture.
        /// </summary>
        public Vector2 UV { get; set; }

        /// <summary>
        /// The glyph's scaled advance.
        /// </summary>
        public float Advance { get; set; }

        /// <summary>
        /// The glyph's scaled XMin.
        /// </summary>
        public float XMin { get; set; }

        /// <summary>
        /// The size below the origin.
        /// </summary>
        public float YMin { get; set; }

        /// <summary>
        /// The glyph's scaled YBearing, which is the font's scaled ascend minus the glyph's scaled YMax.
        /// </summary>
        public float YBearing { get; set; }

        /// <summary>
        /// The font glyph this glyph represents.
        /// </summary>
        public Glyph FontGlyph { get; set; }

        /// <summary>
        /// Constructor used to synthesize glyphs for tests.
        /// </summary>
        public AtlasGlyph(float advance, float xMin, float yBearing)
        {
            Advance = advance;
            XMin = xMin;
            YBearing = yBearing;
        }

        /// <summary>
        /// Create a new AtlasGlyph which holds metadata about a rasterized glyph within an atlas texture.
        /// </summary>
        /// <param name="fontGlyph"></param>
        /// <param name="scale"></param>
        /// <param name="ascend"></param>
        public AtlasGlyph(Glyph fontGlyph, float scale, float ascend)
        {
            FontGlyph = fontGlyph;
            Advance = MathF.Round(fontGlyph.AdvanceWidth * scale);
            XMin = MathF.Floor(fontGlyph.XMin * scale);
            Rectangle bbox = fontGlyph.GetBBox(scale);
            YBearing = bbox.Y + MathF.Ceiling(ascend * scale);
            YMin = MathF.Floor(fontGlyph.YMin * scale);
            Size = fontGlyph.GetDrawBox(scale).Size;
        }
    }

    /// <summary>
    /// Represents a rasterized texture of glyphs.
    /// </summary>
    public class FontAtlas
    {
        /// <summary>
        /// The scale of the glyphs relative to their size in the font.
        /// </summary>
        public float Scale { get; set; }

        /// <summary>
        /// The size of the texture.
        /// </summary>
        public Vector2 Size { get; set; }

        /// <summary>
        /// The pixel data of the texture.
        /// </summary>
        public byte[] Pixels { get; set; }

        /// <summary>
        /// A list of all glyphs, indexed by the character they represent.
        /// </summary>
        public Dictionary<char, AtlasGlyph> Glyphs { get; } = new Dictionary<char, AtlasGlyph>();

        /// <summary>
        /// The name of the rasterizer who rasterized this atlas.
        /// Is expected to be one of the Font.GlyphRasterizer enum, but doesn't have to be.
        /// </summary>
        public string RasterizedBy { get; set; }

        /// <summary>
        /// The font's height scaled.
        /// Is used as the distance between lines and is regarded as the safe space.
        /// </summary>
        public float FontHeight { get; set; }

        /// <summary>
        /// A font atlas containing a rasterized font and meta data about the atlas.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="pixels"></param>
        /// <param name="rasterizedBy"></param>
        /// <param name="scale"></param>
        /// <param name="f"></param>
        public FontAtlas(Vector2 size, byte[] pixels, string rasterizedBy, float scale, Font f)
        {
            Size = size;
            Pixels = pixels;
            RasterizedBy = rasterizedBy;
            Scale = scale;
            FontHeight = MathF.Ceiling(f.Height * scale);
        }

        /// <summary>
        /// Dump the pixel data to a file in the "Player" AssetStore in the DebugDump folder.
        /// Used for debugging purposes.
        /// </summary>
        /// <param name="fileName">The file to save to.</param>
        [Conditional("DEBUG")]
        public void DebugDump(string fileName)
        {
            byte[] bytes = ImageUtil.AToRgba(Pixels);
            bytes = PngFormat.Encode(bytes, (int) Size.X, (int) Size.Y);
            Engine.AssetLoader.Save(bytes, $"Player/DebugDump/{fileName}");
        }
    }
}