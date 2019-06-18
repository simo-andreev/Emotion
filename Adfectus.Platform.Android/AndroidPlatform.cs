#region Using

using System;
using System.Threading.Tasks;
using Adfectus.Common;
using Adfectus.Graphics;
using Adfectus.Implementation;
using Adfectus.Input;
using Adfectus.IO;
using Adfectus.Sound;
using Android.App;

#endregion

namespace Adfectus.Android
{
    public sealed class AndroidPlatform : IPlatform
    {
        public static Activity AndroidHost;
        public AndroidGraphicsManager AndroidGraphics;

        public static void SetActivity(Activity androidHost)
        {
            AndroidHost = androidHost;
        }

        public void RunLoop(Action<float> loop)
        {
            // On this platform the loop is run by the graphics device through a callback.
            AndroidGraphics.StartLoop(loop);
        }

        public void Initialize()
        {

        }

        public AssetLoader CreateAssetLoader(EngineBuilder builder)
        {
            return null;
        }

        public IHost CreateHost(EngineBuilder builder)
        {
            return null;
        }

        public IInputManager CreateInputManager(EngineBuilder builder)
        {
            return null;
        }

        public GraphicsManager CreateGraphicsManager(EngineBuilder builder)
        {
            if (AndroidGraphics != null) return AndroidGraphics;
            AndroidGraphics = new AndroidGraphicsManager();
            return AndroidGraphics;
        }

        public SoundManager CreateSoundManager(EngineBuilder builder)
        {
            return null;
        }

        public void Dispose()
        {
            
        }
    }
}