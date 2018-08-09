﻿// Emotion - https://github.com/Cryru/Emotion

#region Using

using System.Threading;
using Emotion;
using Emotion.Engine;
using Emotion.Game.Layering;
using Emotion.Graphics;
using Emotion.Graphics.GLES;
using Emotion.Graphics.Text;
using Emotion.Primitives;
using EmotionSandbox.Examples.Generic;
using Soul;

#endregion

namespace EmotionSandbox.Examples.Rendering
{
    public class RenderingText : Layer
    {
        public static void Main()
        {
            // Get the context and load the loading screen plus this scene in.
            Context context = Starter.GetEmotionContext();
            context.LayerManager.Add(new LoadingScreen(), "__loading__", 0); // The loading screen is below this layer so it is hidden when this layer is loaded.
            context.LayerManager.Add(new RenderingText(), "Emotion Rendering - Text", 1);
            // Start the context.
            context.Start();
        }

        public override void Load()
        {
            Context.AssetLoader.Get<Font>("ExampleFont.ttf").GetFontAtlas(20);
        }

        public override void Update(float fr)
        {
        }

        public override void Draw(Renderer renderer)
        {
            // Render a cornflower background to hide the loading screen beneath this layer.
            renderer.Render(new Vector3(0, 0, 0), new Vector2(Context.Host.RenderSize.X, Context.Host.RenderSize.Y), Color.CornflowerBlue);
            renderer.RenderString(Context.AssetLoader.Get<Font>("ExampleFont.ttf"), 20, "Hello, I am simple text rendered by the renderer.", new Vector3(10, 10, 0), Color.White);
        }

        public override void Unload()
        {

        }
    }
}