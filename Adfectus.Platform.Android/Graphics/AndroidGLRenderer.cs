#region Using

using Android.Opengl;
using Java.Lang;
using Javax.Microedition.Khronos.Opengles;
using EGLConfig = Javax.Microedition.Khronos.Egl.EGLConfig;

#endregion

namespace Adfectus.Android.Graphics
{
    public sealed class AndroidGLRenderer : Object, GLSurfaceView.IRenderer
    {
        private AndroidGraphicsManager _graphicsDevice;

        public AndroidGLRenderer(AndroidGraphicsManager graphicsDevice)
        {
            _graphicsDevice = graphicsDevice;
        }

        public void OnSurfaceCreated(IGL10 gl, EGLConfig config)
        {
            _graphicsDevice.OnSurfaceCreated();
        }

        public void OnDrawFrame(IGL10 gl)
        {
            _graphicsDevice.OnDrawFrame();
        }

        public void OnSurfaceChanged(IGL10 gl, int width, int height)
        {
            _graphicsDevice.OnSurfaceChanged();
        }
    }
}