#region Using

using Android.Content;
using Android.Opengl;
using Android.Util;
using Android.Graphics;

#endregion

namespace Adfectus.Android.Graphics
{
    internal sealed class AdfectusGLSurface : GLSurfaceView
    {
        public AdfectusGLSurface(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public AdfectusGLSurface(Context context) : base(context)
        {
            SetEGLContextClientVersion(3);
            Holder.SetFormat(Format.Rgba8888);
            SetEGLConfigChooser(8, 8, 8, 8, 24, 8);
        }
    }
}