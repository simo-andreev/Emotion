﻿#region Using

using System.Numerics;
using System.Threading.Tasks;
using Emotion.Common;
using Emotion.Game.Text;
using Emotion.Graphics;
using Emotion.Graphics.Text;
using Emotion.IO;
using Emotion.Primitives;
using Emotion.Scenography;

#endregion

namespace Emotion.ExecTest.Examples
{
    public class TextRenderers : Scene
    {
        private FontAsset _font;

        public override async Task LoadAsync()
        {
            _font = await Engine.AssetLoader.GetAsync<FontAsset>("debugFont.otf");
        }

        public override void Update()
        {
        }

        public override void Draw(RenderComposer composer)
        {
            Color textCol = new Color(32, 32, 32);

            int size = 20;
            string text = "The quick brown fox jumped over the lazy dog.";

            composer.SetUseViewMatrix(false);

            composer.RenderSprite(new Vector3(0, 0, 0), Engine.Renderer.CurrentTarget.Size, new Color(240, 240, 240));

            composer.PushModelMatrix(Matrix4x4.CreateScale(1, 1, 1) * Matrix4x4.CreateTranslation(100, 100, 0));

            FontAsset.GlyphRasterizer = GlyphRasterizer.Emotion;
            composer.RenderLine(new Vector3(0, 0, 0), new Vector3(500, 0, 0), Color.Red);
            composer.RenderString(new Vector3(0, 0, 0), textCol, "Emotion Renderer:\n" + text, _font.GetAtlas(size));

            FontAsset.GlyphRasterizer = GlyphRasterizer.EmotionSDFVer3;
            composer.RenderLine(new Vector3(0, 180, 0), new Vector3(500, 180, 0), Color.Red);
            composer.RenderString(new Vector3(0, 180, 0), textCol, "EmotionSDFVer3:\n" + text, _font.GetAtlas(size));

            FontAsset.GlyphRasterizer = GlyphRasterizer.EmotionSDFVer4;
            composer.RenderLine(new Vector3(0, 320, 0), new Vector3(500, 320, 0), Color.Red);
            composer.RenderString(new Vector3(0, 320, 0), textCol, "EmotionSDFVer4:\n" + text, _font.GetAtlas(size));

            FontAsset.GlyphRasterizer = GlyphRasterizer.StbTrueType;
            composer.RenderLine(new Vector3(0, 500, 0), new Vector3(500, 500, 0), Color.Red);
            composer.RenderString(new Vector3(0, 500, 0), textCol, "StbTrueType:\n" + text, _font.GetAtlas(size));

            composer.PopModelMatrix();

            composer.SetUseViewMatrix(true);
        }
    }
}