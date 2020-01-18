#pragma warning disable 618, 649
//, 1734

#region Using

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security;
using Emotion.Platform;
using Emotion.Utility;
using Khronos;

#endregion

// ReSharper disable InheritdocConsiderUsage
// ReSharper disable SwitchStatementMissingSomeCases
// ReSharper disable RedundantIfElseBlock
// ReSharper disable once CheckNamespace
namespace OpenGL
{
    /// <summary>
    /// Modern OpenGL bindings.
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public partial class Gl : KhronosApi
    {
        #region Constructors

        /// <summary>
        /// Eventual exception raised during Gl initialization.
        /// </summary>
        internal static Exception InitializationException;

        #endregion

        #region Versions, Extensions and Limits

        /// <summary>
        /// OpenGL version currently implemented.
        /// </summary>
        /// <remarks>
        /// Higher OpenGL versions versions cannot be requested to be implemented.
        /// </remarks>
        public static KhronosVersion CurrentVersion { get; private set; }

        /// <summary>
        /// OpenGL Shading Language version currently implemented.
        /// </summary>
        /// <remarks>
        /// Higher OpenGL Shading Language versions cannot be requested to be implemented.
        /// </remarks>
        public static GlslVersion CurrentShadingVersion { get; private set; }

        /// <summary>
        /// Get the OpenGL vendor.
        /// </summary>
        public static string CurrentVendor { get; private set; }

        /// <summary>
        /// Get the OpenGL renderer.
        /// </summary>
        public static string CurrentRenderer { get; private set; }

        /// <summary>
        /// OpenGL extension support.
        /// </summary>
        public static Extensions CurrentExtensions { get; private set; }

        /// <summary>
        /// OpenGL limits.
        /// </summary>
        public static Limits CurrentLimits { get; private set; }

        #endregion

        #region API Binding

        /// <summary>
        /// Bind the OpenGL delegates for the API corresponding to the current OpenGL context.
        /// </summary>
        /// <param name="procLoadFunction">
        /// The function OpenGL functions will be loaded through. Should be provided by your context creator.
        /// </param>
        public static void BindAPI(Func<string, IntPtr> procLoadFunction)
        {
            // Set the function loading function.
            ProcLoadFunction = procLoadFunction;

            // Get version.
            BindAPI<Gl>(QueryContextVersionCore(), CurrentExtensions);

            // Query OpenGL informations
            string glVersion = GetString(StringName.Version);
            CurrentVersion = KhronosVersion.Parse(glVersion);

            // Query OpenGL extensions (current OpenGL implementation, CurrentCaps)
            CurrentExtensions = new Extensions();
            CurrentExtensions.Query();

            // Query OpenGL limits
            CurrentLimits = Limits.Query(CurrentVersion, CurrentExtensions);

            // Obtain current OpenGL Shading Language version
            string glslVersion = null;

            switch (CurrentVersion.Api)
            {
                case KhronosVersion.API_GL:
                    if (CurrentVersion >= Version200 || CurrentExtensions.ShadingLanguage100_ARB)
                        glslVersion = GetString(StringName.ShadingLanguageVersion);
                    break;
                case KhronosVersion.API_GLES2:
                    glslVersion = GetString(StringName.ShadingLanguageVersion);
                    break;
            }

            if (glslVersion != null)
                CurrentShadingVersion = GlslVersion.Parse(glslVersion, CurrentVersion.Api);

            // Vendor/Render information
            CurrentVendor = GetString(StringName.Vendor);
            CurrentRenderer = GetString(StringName.Renderer);
        }

        /// <summary>
        /// Query the version of the current OpenGL context.
        /// </summary>
        /// <returns>
        /// It returns the <see cref="KhronosVersion" /> specifying the actual version of the context current on this thread.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Exception thrown if no GL context is current on the calling thread.
        /// </exception>
        public static KhronosVersion QueryContextVersion()
        {
            // Parse version string (effective for detecting Desktop and ES contextes)
            string str = GetString(StringName.Version);
            KhronosVersion glVersion = KhronosVersion.Parse(str);

            // Context profile
            if (glVersion.Api == KhronosVersion.API_GL && glVersion >= Version320)
            {
                string glProfile;

                Get(CONTEXT_PROFILE_MASK, out int ctxProfile);

                if ((ctxProfile & CONTEXT_COMPATIBILITY_PROFILE_BIT) != 0)
                    glProfile = KhronosVersion.PROFILE_COMPATIBILITY;
                else if ((ctxProfile & CONTEXT_CORE_PROFILE_BIT) != 0)
                    glProfile = KhronosVersion.PROFILE_CORE;
                else
                    glProfile = KhronosVersion.PROFILE_COMPATIBILITY;

                return new KhronosVersion(glVersion, glProfile);
            }
            else
            {
                return new KhronosVersion(glVersion, KhronosVersion.PROFILE_COMPATIBILITY);
            }
        }

        /// <summary>
        /// Query the version of the current OpenGL context.
        /// </summary>
        /// <returns>
        /// It returns the <see cref="KhronosVersion" /> specifying the actual version of the context current on this thread.
        /// </returns>
        public static KhronosVersion QueryContextVersionCore()
        {
            BindAPIFunction<Gl>("glGetError", Version100, null);
            BindAPIFunction<Gl>("glGetString", Version100, null);
            BindAPIFunction<Gl>("glGetIntegerv", Version100, null);

            return QueryContextVersion();
        }

        /// <summary>
        /// Query the OpenGL version without binding the API.
        /// </summary>
        /// <param name="procLoadFunction">The function OpenGL functions will be loaded through (in this case glGetString only).</param>
        /// <returns>It returns the <see cref="KhronosVersion" /> specifying the actual version of the context current on this thread.</returns>
        public static KhronosVersion QueryVersionExternal(Func<string, IntPtr> procLoadFunction)
        {
            IntPtr func = procLoadFunction("glGetString");
            if(func == IntPtr.Zero) return null;

            var getString = Marshal.GetDelegateForFunctionPointer<Delegates.glGetString>(func);
            IntPtr ptr = getString((int) StringName.Version);
            string str = NativeHelpers.StringFromPtr(ptr);
            return KhronosVersion.Parse(str);
        }

        #endregion

        #region Error Handling

        /// <summary>
        /// OpenGL error checking.
        /// </summary>
        public static void CheckErrors()
        {
            ErrorCode error = GetError();

            if (error != ErrorCode.NoError)
                throw new GlException(error);
        }

        /// <summary>
        /// Flush GL errors queue.
        /// </summary>
        private static void ClearErrors()
        {
            while (GetError() != ErrorCode.NoError)
                // ReSharper disable once EmptyEmbeddedStatement
                ;
        }

        /// <summary>
        /// OpenGL error checking.
        /// </summary>
        /// <param name="returnValue">
        /// A <see cref="Object" /> that specifies the function returned value, if any.
        /// </param>
        [Conditional("DEBUG")]
        // ReSharper disable once UnusedParameter.Local
        private static void DebugCheckErrors(object returnValue)
        {
            CheckErrors();
        }

        #endregion

        #region Hand-crafted Bindings

        /// <summary>
        /// Specify a callback to receive debugging messages from the GL.
        /// </summary>
        /// <param name="source">
        /// A <see cref="DebugSource" /> that specify the source of the message.
        /// </param>
        /// <param name="type">
        /// A <see cref="DebugType" /> that specify the type of the message.
        /// </param>
        /// <param name="id">
        /// A <see cref="UInt32" /> that specify the identifier of the message.
        /// </param>
        /// <param name="severity">
        /// A <see cref="DebugSeverity" /> that specify the severity of the message.
        /// </param>
        /// <param name="length">
        /// The length of the message.
        /// </param>
        /// <param name="message">
        /// A <see cref="IntPtr" /> that specify a pointer to a null-terminated ASCII C string, representing the content of the
        /// message.
        /// </param>
        /// <param name="userParam">
        /// A <see cref="IntPtr" /> that specify the user-specified parameter.
        /// </param>
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void DebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, IntPtr message, IntPtr userParam);

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public delegate IntPtr VulkanProc();

        /// <summary>
        /// specify values to record in transform feedback buffers
        /// </summary>
        /// <param name="program">
        /// The name of the target program object.
        /// </param>
        /// <param name="varyings">
        /// An array of zero-terminated strings specifying the names of the varying variables to use for
        /// transform feedback.
        /// </param>
        /// <param name="bufferMode">
        /// Identifies the mode used to capture the varying variables when transform feedback is active.
        /// <paramref
        ///     name="bufferMode" />
        /// must be Gl.INTERLEAVED_ATTRIBS or Gl.SEPARATE_ATTRIBS.
        /// </param>
        /// <remarks>
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Gl.INVALID_VALUE is generated if <paramref name="program" /> is not the name of a program object.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Gl.INVALID_VALUE is generated if <paramref name="bufferMode" /> is Gl.SEPARATE_ATTRIBS and the length of
        /// <paramref name="varyings" /> is
        /// greater than the implementation-dependent limit Gl.MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS.
        /// </exception>
        /// <seealso cref="Gl.BeginTransformFeedback" />
        /// <seealso cref="Gl.EndTransformFeedback" />
        /// <seealso cref="Gl.GetTransformFeedbackVarying" />
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_transform_feedback")]
        public static void TransformFeedbackVaryings(uint program, IntPtr[] varyings, int bufferMode)
        {
            unsafe
            {
                fixed (IntPtr* p_varyings = varyings)
                {
                    Debug.Assert(Delegates.pglTransformFeedbackVaryings_Unmanaged != null, "pglTransformFeedbackVaryings not implemented");
                    Delegates.pglTransformFeedbackVaryings_Unmanaged(program, varyings.Length, p_varyings, bufferMode);
                }
            }

            DebugCheckErrors(null);
        }

        internal static unsafe partial class Delegates
        {
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTransformFeedbackVaryings_Unmanaged(uint program, int count, IntPtr* varyings, int bufferMode);

            [RequiredByFeature("GL_VERSION_3_0", EntryPoint = "glTransformFeedbackVaryings")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2", EntryPoint = "glTransformFeedbackVaryings")]
            [RequiredByFeature("GL_EXT_transform_feedback", EntryPoint = "glTransformFeedbackVaryingsEXT")]
            [ThreadStatic]
            internal static glTransformFeedbackVaryings_Unmanaged pglTransformFeedbackVaryings_Unmanaged;
        }

        #endregion
    }
}