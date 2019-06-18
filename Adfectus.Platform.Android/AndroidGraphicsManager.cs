#region Using

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Adfectus.Android.Graphics;
using Adfectus.Graphics;
using Adfectus.Primitives;
using Android.Opengl;
using Java.Nio;
using Color = System.Drawing.Color;

#endregion

namespace Adfectus.Android
{
    [SuppressMessage("ReSharper", "AccessToStaticMemberViaDerivedType")]
    public sealed class AndroidGraphicsManager : GraphicsManager
    {
        private AdfectusGLSurface _surface;
        private AndroidGLRenderer _renderer;
        private Action<float> _frameCallback;

        // Timing
        private Stopwatch _deltaTimer;
        private float _lastTick;

        public AndroidGraphicsManager()
        {
            // Create surface and set as view.
            _surface = new AdfectusGLSurface(AndroidPlatform.AndroidHost);
            AndroidPlatform.AndroidHost.SetContentView(_surface);

            // The rest of the constructor is in OnSurfaceCreated.
        }

        #region Android Specific

        public void StartLoop(Action<float> frameCallback)
        {
            _renderer = new AndroidGLRenderer(this);
            _surface.SetRenderer(_renderer);

            // Will flush only when there is something to flush.
            _surface.RenderMode = Rendermode.WhenDirty;
            _surface.PreserveEGLContextOnPause = true;

            _deltaTimer = Stopwatch.StartNew();
            _frameCallback = frameCallback;
        }

        public void OnSurfaceCreated()
        {
            // Set initial GL state.
            ResetState(true);
        }

        public void OnDrawFrame()
        {
            float curTick = _deltaTimer.ElapsedMilliseconds;
            float delta = curTick - _lastTick;
            _lastTick = curTick;

            _frameCallback(delta);
        }

        public void OnSurfaceChanged()
        {
        }

        #endregion

        [Conditional("DEBUG")]
        private void CheckError()
        {
            int err = GLES30.GlGetError();
            if (err != 0)
            {
                Debugger.Break();
            }
        }

        public void ResetState(bool full)
        {
            if (full)
            {
                GLES30.GlClearColor(0, 0, 0, 1f);
            }

            CheckError();
        }

        public void SetClearColor(Color c)
        {
            GLES30.GlClearColor((c.R) / 255f, (c.G) / 255f, (c.B) / 255f, (c.A) / 255f);
            CheckError();
        }

        public void Clear()
        {
            GLES30.GlClear(GLES30.GlColorBufferBit | GLES30.GlDepthBufferBit | GLES30.GlStencilBufferBit);
            CheckError();
        }

        public byte[] GetScreenshot()
        {
            ByteBuffer buffer = ByteBuffer.Allocate(_surface.Width * _surface.Height * 4);
            GLES20.GlReadPixels(0, 0, _surface.Width, _surface.Height, GLES30.GlRgba, GLES30.GlUnsignedByte, buffer);
            byte[] asByteArray = new byte[buffer.Capacity()];
            buffer.Get(asByteArray);
            buffer.Dispose();

            CheckError();

            return asByteArray;
        }

        public void SetViewport(Rectangle viewport)
        {
            GLES30.GlViewport((int) viewport.X, (int) viewport.Y, (int) viewport.Width, (int) viewport.Height);
            CheckError();
        }

        public void SwapBuffer()
        {
            _surface.RequestRender();
        }

        public override void Setup(System.Numerics.Vector2 renderSize)
        {
            
        }

        public override void CheckError(string location = "")
        {
            
        }

        public override void DefaultGLState()
        {
            
        }

        public override void StateDepthTest(bool enable)
        {
            
        }

        public override void StateClip(bool enable)
        {
            
        }

        public override void SetClipRect(int x, int y, int width, int height)
        {
            
        }

        public override void SetViewport(int x, int y, int width, int height)
        {
            
        }

        public override void ClearScreen()
        {
            
        }

        public override uint CreateTexture()
        {
            return 0;
        }

        public override void DeleteTexture(uint pointer)
        {
            
        }

        public override bool BindTexture(Texture texture, uint slot = 0)
        {
            return true;
        }

        public override bool BindTexture(uint pointer, uint slot = 0)
        {
            return true;
        }

        public override void SetTextureMask(uint r = 4278190080, uint g = 16711680, uint b = 65280, uint a = 255)
        {
            
        }

        public override void UploadToTexture(IntPtr data, System.Numerics.Vector2 size, TextureInternalFormat internalFormat, TexturePixelFormat pixelFormat)
        {
            
        }

        public override void SetTextureSmooth(bool smooth)
        {
            
        }

        public override uint CreateDataBuffer()
        {
            return 0;
        }

        public override bool BindDataBuffer(uint bufferId)
        {
            return true;
        }

        public override void UploadToDataBuffer<T>(T[] data)
        {
            
        }

        public override void UploadToDataBuffer(IntPtr data, uint size)
        {
            
        }

        public override void MapDataBuffer(IntPtr data, uint size, uint offset = 0)
        {
            
        }

        public override void DestroyDataBuffer(uint bufferId)
        {
            
        }

        public override uint CreateVertexArrayBuffer()
        {
            return 0;
        }

        public override bool BindVertexArrayBuffer(uint bufferId)
        {
            return true;
        }

        public override void AttachDataBufferToVertexArray(uint dataBufferId, uint vertexArrayBufferId, uint shaderIndex, uint componentCount, DataType dataType, bool normalized, uint stride, IntPtr offset)
        {
            
        }

        public override void DestroyVertexArrayBuffer(uint bufferId)
        {
            
        }

        public override bool BindIndexBuffer(uint bufferId)
        {
            return true;
        }

        public override void UploadToIndexBuffer<T>(T[] data)
        {
            
        }

        public override void UploadToIndexBuffer(IntPtr data, uint size)
        {
            
        }

        public override void MapIndexBuffer(IntPtr data, uint size, uint offset = 0)
        {
            
        }

        public override ShaderProgram CreateShaderProgram(string vert, string frag)
        {
            return null;
        }

        public override bool BindShaderProgram(ShaderProgram shaderProgram)
        {
            return true;
        }

        public override RenderTarget CreateRenderTarget(System.Numerics.Vector2 size, bool smooth = false, TextureInternalFormat internalFormat = TextureInternalFormat.Rgba, TexturePixelFormat pixelFormat = TexturePixelFormat.Rgba, bool attachStencil = false)
        {
            return null;
        }

        public override RenderTarget CreateMSAARenderTarget(int samples, System.Numerics.Vector2 size, TextureInternalFormat internalFormat = TextureInternalFormat.Rgba, bool attachStencil = false)
        {
            return null;
        }

        public override void BindRenderTarget(RenderTarget t)
        {
            
        }

        public override void CopyRenderTarget(RenderTarget source, RenderTarget dest, Rectangle? sourceRect = null, Rectangle? destRect = null, bool smooth = false)
        {
            
        }

        public override void StateStencilTest(bool enable)
        {
            
        }

        public override void StencilModeDefault()
        {
            
        }

        public override void StencilStartDraw(int value = 255)
        {
            
        }

        public override void StencilModeCutOutFrom(int threshold = 255)
        {
            
        }

        public override void StencilModeMask(int filter = 255)
        {
            
        }

        public override void StencilModeCustom(uint mask, string mode = "Always", int funcRef = 1, uint modeMask = 255)
        {
            
        }

        public override StreamBuffer CreateStreamBuffer(uint vbo, uint vao, uint ibo, uint objectSize, uint size, uint indicesPerObject, bool polygonMode = false)
        {
            return null;
        }

        public override uint GetBoundIndexBuffer()
        {
            return 0;
        }

        public override uint GetBoundDataBuffer()
        {
            return 0;
        }

        public override uint GetBoundVertexArrayBuffer()
        {
            return 0;
        }

        public override uint GetBoundRenderTarget()
        {
            return 0;
        }
    }
}