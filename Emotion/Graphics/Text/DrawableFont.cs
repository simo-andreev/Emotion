﻿#region Using

using System;
using System.Collections.Generic;
using System.Numerics;
using Emotion.Common;
using Emotion.Common.Threading;
using Emotion.Primitives;
using Emotion.Standard.OpenType;
using Emotion.Utility;

#endregion

namespace Emotion.Graphics.Text
{
    public class DrawableFont
    {
        public Font Font { get; init; }

        public float FontSize { get; init; }

        public bool PixelFont { get; init; }

        /// <summary>
        /// The scale multiplier for glyph metrics for this font's size.
        /// </summary>
        public float RenderScale;

        /// <summary>
        /// The space between new lines, from baseline to baseline.
        /// </summary>
        public float LineGap { get; init; }

        /// <summary>
        /// The distance from the baseline to the highest glyph ascent. Is positive because Y is up in glyph metrics.
        /// Used to offset glyphs to a top-left origin.
        /// </summary>
        public float Ascent;

        public Dictionary<char, DrawableGlyph> Glyphs { get; init; } = new Dictionary<char, DrawableGlyph>();

        public DrawableFont(Font font, int fontSize, bool pixelFont = false)
        {
            Font = font;
            FontSize = fontSize;
            if (pixelFont)
            {
                // Scale to closest power of two.
                float fontHeight = Font.Height;
                float scaleFactor = fontHeight / fontSize;
                int scaleFactorP2 = Maths.ClosestPowerOfTwoGreaterThan((int) MathF.Floor(scaleFactor));
                FontSize = fontHeight / scaleFactorP2;
            }

            // Convert from Emotion font size (legacy) to real font size.
            if (Engine.Configuration.UseEmotionFontSize)
            {
                float diff = (float)Font.UnitsPerEm / Font.Height;
                FontSize = MathF.Round(FontSize * diff);
            }

            // The scale to render at.
            float scale = FontSize / Font.UnitsPerEm;
            Ascent = font.Ascender * scale;
            LineGap = font.Height * scale;
            RenderScale = scale;
        }

        #region Internal API

        protected virtual void AddGlyphsToAtlas(List<DrawableGlyph> glyphsToAdd)
        {
        }

        #endregion

        public virtual void CacheGlyphs(string text)
        {
            List<DrawableGlyph> renderGlyphs = null;
            for (var i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (Glyphs.ContainsKey(ch) || !Font.CharToGlyph.TryGetValue(ch, out FontGlyph fontG)) continue;

                DrawableGlyph atlasGlyph = new DrawableGlyph(ch, fontG, RenderScale);
                Glyphs.Add(ch, atlasGlyph);

                if (atlasGlyph.Width == 0 || atlasGlyph.Height == 0 || fontG.Commands == null || fontG.Commands.Length == 0) continue;

                renderGlyphs ??= new List<DrawableGlyph>();
                renderGlyphs.Add(atlasGlyph);
            }

            if (renderGlyphs != null) GLThread.ExecuteOnGLThreadAsync(AddGlyphsToAtlas, renderGlyphs);
        }

        public virtual void SetupDrawing(RenderComposer c, string text)
        {
            CacheGlyphs(text);
        }

        public virtual void DrawGlyph(RenderComposer c, DrawableGlyph g, Vector3 pos, Color color)
        {
        }

        public virtual void FinishDrawing(RenderComposer c)
        {
        }
    }
}