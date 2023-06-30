#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective

#region Using

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Khronos;

#endregion

// ReSharper disable StringLiteralTypo
// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer
// ReSharper disable InvalidXmlDocComment
// ReSharper disable CommentTypo
namespace OpenGL
{
    public partial class Gl
    {
        /// <summary>
        /// [GL4|GLES3.2] Gl.GetVertexAttrib: params returns a single value that is the frequency divisor used for instanced
        /// rendering. See Gl.VertexAttribDivisor. The initial value is 0.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ANGLE_instanced_arrays", Api = "gles2")]
        [RequiredByFeature("GL_ARB_instanced_arrays", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_instanced_arrays", Api = "gles2")]
        [RequiredByFeature("GL_NV_instanced_arrays", Api = "gles2")]
        public const int VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;

        /// <summary>
        /// [GL] Value of GL_SRC1_COLOR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ARB_blend_func_extended", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
        public const int SRC1_COLOR = 0x88F9;

        /// <summary>
        /// [GL] Value of GL_ONE_MINUS_SRC1_COLOR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ARB_blend_func_extended", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
        public const int ONE_MINUS_SRC1_COLOR = 0x88FA;

        /// <summary>
        /// [GL] Value of GL_ONE_MINUS_SRC1_ALPHA symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ARB_blend_func_extended", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
        public const int ONE_MINUS_SRC1_ALPHA = 0x88FB;

        /// <summary>
        /// [GL4] Gl.Get: data returns one value, the maximum number of active draw buffers when using dual-source blending. The
        /// value must be at least 1. See Gl.BlendFunc and Gl.BlendFuncSeparate.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ARB_blend_func_extended", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
        public const int MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;

        /// <summary>
        /// [GL] Value of GL_ANY_SAMPLES_PASSED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_occlusion_query2", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
        public const int ANY_SAMPLES_PASSED = 0x8C2F;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single value, the name of the sampler object currently bound to the active texture
        /// unit. The initial value is 0. See Gl.BindSampler.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public const int SAMPLER_BINDING = 0x8919;

        /// <summary>
        /// [GL] Value of GL_RGB10_A2UI symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_rgb10_a2ui", Api = "gl|glcore")]
        public const int RGB10_A2UI = 0x906F;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetTexParameter: Returns the red component swizzle. The initial value is Gl.RED.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_swizzle", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_swizzle")]
        public const int TEXTURE_SWIZZLE_R = 0x8E42;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetTexParameter: Returns the green component swizzle. The initial value is Gl.GREEN.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_swizzle", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_swizzle")]
        public const int TEXTURE_SWIZZLE_G = 0x8E43;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetTexParameter: Returns the blue component swizzle. The initial value is Gl.BLUE.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_swizzle", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_swizzle")]
        public const int TEXTURE_SWIZZLE_B = 0x8E44;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetTexParameter: Returns the alpha component swizzle. The initial value is Gl.ALPHA.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_swizzle", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_swizzle")]
        public const int TEXTURE_SWIZZLE_A = 0x8E45;

        /// <summary>
        /// [GL4] Gl.GetTexParameter: Returns the component swizzle for all channels in a single query.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ARB_texture_swizzle", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_texture_swizzle")]
        public const int TEXTURE_SWIZZLE_RGBA = 0x8E46;

        /// <summary>
        /// [GL] Value of GL_TIME_ELAPSED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
        [RequiredByFeature("GL_EXT_timer_query")]
        public const int TIME_ELAPSED = 0x88BF;

        /// <summary>
        /// [GL4] Gl.Get: data returns a single value, the 64-bit value of the current GL time. See Gl.QueryCounter.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
        public const int TIMESTAMP = 0x8E28;

        /// <summary>
        /// [GL] Value of GL_INT_2_10_10_10_REV symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
        public const int INT_2_10_10_10_REV = 0x8D9F;

        /// <summary>
        /// [GL4] glBindFragDataLocationIndexed: bind a user-defined varying out variable to a fragment shader color number and
        /// index
        /// </summary>
        /// <param name="program">
        /// The name of the program containing varying out variable whose binding to modify
        /// </param>
        /// <param name="colorNumber">
        /// The color number to bind the user-defined varying out variable to
        /// </param>
        /// <param name="index">
        /// The index of the color input to bind the user-defined varying out variable to
        /// </param>
        /// <param name="name">
        /// The name of the user-defined varying out variable whose binding to modify
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ARB_blend_func_extended", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
        public static void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, string name)
        {
            Debug.Assert(Delegates.pglBindFragDataLocationIndexed != null, "pglBindFragDataLocationIndexed not implemented");
            Delegates.pglBindFragDataLocationIndexed(program, colorNumber, index, name);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetFragDataIndex: query the bindings of color indices to user-defined varying out variables
        /// </summary>
        /// <param name="program">
        /// The name of the program containing varying out variable whose binding to query
        /// </param>
        /// <param name="name">
        /// The name of the user-defined varying out variable whose index to query
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ARB_blend_func_extended", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
        public static int GetFragDataIndex(uint program, string name)
        {
            int retValue;

            Debug.Assert(Delegates.pglGetFragDataIndex != null, "pglGetFragDataIndex not implemented");
            retValue = Delegates.pglGetFragDataIndex(program, name);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGenSamplers: generate sampler object names
        ///     </para>
        /// </summary>
        /// <param name="samplers">
        /// Specifies an array in which the generated sampler object names are stored.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static void GenSamplers(uint[] samplers)
        {
            unsafe
            {
                fixed (uint* p_samplers = samplers)
                {
                    Debug.Assert(Delegates.pglGenSamplers != null, "pglGenSamplers not implemented");
                    Delegates.pglGenSamplers(samplers.Length, p_samplers);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGenSamplers: generate sampler object names
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static uint GenSampler()
        {
            uint retValue;
            unsafe
            {
                Delegates.pglGenSamplers(1, &retValue);
            }

            DebugCheckErrors(null);
            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDeleteSamplers: delete named sampler objects
        ///     </para>
        /// </summary>
        /// <param name="samplers">
        /// Specifies an array of sampler objects to be deleted.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static void DeleteSamplers(params uint[] samplers)
        {
            unsafe
            {
                fixed (uint* p_samplers = samplers)
                {
                    Debug.Assert(Delegates.pglDeleteSamplers != null, "pglDeleteSamplers not implemented");
                    Delegates.pglDeleteSamplers(samplers.Length, p_samplers);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glIsSampler: determine if a name corresponds to a sampler object
        ///     </para>
        /// </summary>
        /// <param name="sampler">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static bool IsSampler(uint sampler)
        {
            bool retValue;

            Debug.Assert(Delegates.pglIsSampler != null, "pglIsSampler not implemented");
            retValue = Delegates.pglIsSampler(sampler);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glBindSampler: bind a named sampler to a texturing target
        ///     </para>
        /// </summary>
        /// <param name="unit">
        /// Specifies the index of the texture unit to which the sampler is bound.
        /// </param>
        /// <param name="sampler">
        /// Specifies the name of a sampler.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static void BindSampler(uint unit, uint sampler)
        {
            Debug.Assert(Delegates.pglBindSampler != null, "pglBindSampler not implemented");
            Delegates.pglBindSampler(unit, sampler);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glSamplerParameteri: Binding for glSamplerParameteri.
        /// </summary>
        /// <param name="sampler">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:SamplerParameterName" />.
        /// </param>
        /// <param name="param">
        /// A <see cref="T:int" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static void SamplerParameter(uint sampler, SamplerParameterName pname, int param)
        {
            Debug.Assert(Delegates.pglSamplerParameteri != null, "pglSamplerParameteri not implemented");
            Delegates.pglSamplerParameteri(sampler, (int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glSamplerParameteriv: Binding for glSamplerParameteriv.
        /// </summary>
        /// <param name="sampler">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:SamplerParameterName" />.
        /// </param>
        /// <param name="param">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static void SamplerParameter(uint sampler, SamplerParameterName pname, int[] param)
        {
            unsafe
            {
                fixed (int* p_param = param)
                {
                    Debug.Assert(Delegates.pglSamplerParameteriv != null, "pglSamplerParameteriv not implemented");
                    Delegates.pglSamplerParameteriv(sampler, (int) pname, p_param);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glSamplerParameteriv: Binding for glSamplerParameteriv.
        /// </summary>
        /// <param name="sampler">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:SamplerParameterName" />.
        /// </param>
        /// <param name="param">
        /// A <see cref="T:int*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static unsafe void SamplerParameter(uint sampler, SamplerParameterName pname, int* param)
        {
            Debug.Assert(Delegates.pglSamplerParameteriv != null, "pglSamplerParameteriv not implemented");
            Delegates.pglSamplerParameteriv(sampler, (int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glSamplerParameteriv: Binding for glSamplerParameteriv.
        /// </summary>
        /// <param name="sampler">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:SamplerParameterName" />.
        /// </param>
        /// <param name="param">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static void SamplerParameteri<T>(uint sampler, SamplerParameterName pname, T param) where T : struct
        {
            Debug.Assert(Delegates.pglSamplerParameteriv != null, "pglSamplerParameteriv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(param);
			try {
				unsafe {
					Delegates.pglSamplerParameteriv(sampler, (int)pname, (int*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refParam = __makeref(param);
                IntPtr refParamPtr = *(IntPtr*) (&refParam);

                Delegates.pglSamplerParameteriv(sampler, (int) pname, (int*) refParamPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glSamplerParameterf: Binding for glSamplerParameterf.
        /// </summary>
        /// <param name="sampler">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:SamplerParameterName" />.
        /// </param>
        /// <param name="param">
        /// A <see cref="T:float" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static void SamplerParameter(uint sampler, SamplerParameterName pname, float param)
        {
            Debug.Assert(Delegates.pglSamplerParameterf != null, "pglSamplerParameterf not implemented");
            Delegates.pglSamplerParameterf(sampler, (int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glSamplerParameterfv: Binding for glSamplerParameterfv.
        /// </summary>
        /// <param name="sampler">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:SamplerParameterName" />.
        /// </param>
        /// <param name="param">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static void SamplerParameter(uint sampler, SamplerParameterName pname, float[] param)
        {
            unsafe
            {
                fixed (float* p_param = param)
                {
                    Debug.Assert(Delegates.pglSamplerParameterfv != null, "pglSamplerParameterfv not implemented");
                    Delegates.pglSamplerParameterfv(sampler, (int) pname, p_param);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glSamplerParameterfv: Binding for glSamplerParameterfv.
        /// </summary>
        /// <param name="sampler">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:SamplerParameterName" />.
        /// </param>
        /// <param name="param">
        /// A <see cref="T:float*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static unsafe void SamplerParameter(uint sampler, SamplerParameterName pname, float* param)
        {
            Debug.Assert(Delegates.pglSamplerParameterfv != null, "pglSamplerParameterfv not implemented");
            Delegates.pglSamplerParameterfv(sampler, (int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glSamplerParameterfv: Binding for glSamplerParameterfv.
        /// </summary>
        /// <param name="sampler">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:SamplerParameterName" />.
        /// </param>
        /// <param name="param">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static void SamplerParameterf<T>(uint sampler, SamplerParameterName pname, T param) where T : struct
        {
            Debug.Assert(Delegates.pglSamplerParameterfv != null, "pglSamplerParameterfv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(param);
			try {
				unsafe {
					Delegates.pglSamplerParameterfv(sampler, (int)pname, (float*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refParam = __makeref(param);
                IntPtr refParamPtr = *(IntPtr*) (&refParam);

                Delegates.pglSamplerParameterfv(sampler, (int) pname, (float*) refParamPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glSamplerParameterIiv: Binding for glSamplerParameterIiv.
        /// </summary>
        /// <param name="sampler">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:SamplerParameterName" />.
        /// </param>
        /// <param name="param">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void SamplerParameterI(uint sampler, SamplerParameterName pname, int[] param)
        {
            unsafe
            {
                fixed (int* p_param = param)
                {
                    Debug.Assert(Delegates.pglSamplerParameterIiv != null, "pglSamplerParameterIiv not implemented");
                    Delegates.pglSamplerParameterIiv(sampler, (int) pname, p_param);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glSamplerParameterIiv: Binding for glSamplerParameterIiv.
        /// </summary>
        /// <param name="sampler">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:SamplerParameterName" />.
        /// </param>
        /// <param name="param">
        /// A <see cref="T:int*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static unsafe void SamplerParameterI(uint sampler, SamplerParameterName pname, int* param)
        {
            Debug.Assert(Delegates.pglSamplerParameterIiv != null, "pglSamplerParameterIiv not implemented");
            Delegates.pglSamplerParameterIiv(sampler, (int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glSamplerParameterIiv: Binding for glSamplerParameterIiv.
        /// </summary>
        /// <param name="sampler">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:SamplerParameterName" />.
        /// </param>
        /// <param name="param">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void SamplerParameterIi<T>(uint sampler, SamplerParameterName pname, T param) where T : struct
        {
            Debug.Assert(Delegates.pglSamplerParameterIiv != null, "pglSamplerParameterIiv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(param);
			try {
				unsafe {
					Delegates.pglSamplerParameterIiv(sampler, (int)pname, (int*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refParam = __makeref(param);
                IntPtr refParamPtr = *(IntPtr*) (&refParam);

                Delegates.pglSamplerParameterIiv(sampler, (int) pname, (int*) refParamPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glSamplerParameterIuiv: Binding for glSamplerParameterIuiv.
        /// </summary>
        /// <param name="sampler">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:SamplerParameterName" />.
        /// </param>
        /// <param name="param">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void SamplerParameterI(uint sampler, SamplerParameterName pname, uint[] param)
        {
            unsafe
            {
                fixed (uint* p_param = param)
                {
                    Debug.Assert(Delegates.pglSamplerParameterIuiv != null, "pglSamplerParameterIuiv not implemented");
                    Delegates.pglSamplerParameterIuiv(sampler, (int) pname, p_param);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glSamplerParameterIuiv: Binding for glSamplerParameterIuiv.
        /// </summary>
        /// <param name="sampler">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:SamplerParameterName" />.
        /// </param>
        /// <param name="param">
        /// A <see cref="T:uint*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static unsafe void SamplerParameterI(uint sampler, SamplerParameterName pname, uint* param)
        {
            Debug.Assert(Delegates.pglSamplerParameterIuiv != null, "pglSamplerParameterIuiv not implemented");
            Delegates.pglSamplerParameterIuiv(sampler, (int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glSamplerParameterIuiv: Binding for glSamplerParameterIuiv.
        /// </summary>
        /// <param name="sampler">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:SamplerParameterName" />.
        /// </param>
        /// <param name="param">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void SamplerParameterIui<T>(uint sampler, SamplerParameterName pname, T param) where T : struct
        {
            Debug.Assert(Delegates.pglSamplerParameterIuiv != null, "pglSamplerParameterIuiv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(param);
			try {
				unsafe {
					Delegates.pglSamplerParameterIuiv(sampler, (int)pname, (uint*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refParam = __makeref(param);
                IntPtr refParamPtr = *(IntPtr*) (&refParam);

                Delegates.pglSamplerParameterIuiv(sampler, (int) pname, (uint*) refParamPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetSamplerParameteriv: return sampler parameter values
        ///     </para>
        /// </summary>
        /// <param name="sampler">
        /// Specifies name of the sampler object from which to retrieve parameters.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD,
        /// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R,
        /// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the sampler parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static void GetSamplerParameter(uint sampler, SamplerParameterName pname, [Out] int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetSamplerParameteriv != null, "pglGetSamplerParameteriv not implemented");
                    Delegates.pglGetSamplerParameteriv(sampler, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetSamplerParameteriv: return sampler parameter values
        ///     </para>
        /// </summary>
        /// <param name="sampler">
        /// Specifies name of the sampler object from which to retrieve parameters.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD,
        /// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R,
        /// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the sampler parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static void GetSamplerParameter(uint sampler, SamplerParameterName pname, out int @params)
        {
            unsafe
            {
                fixed (int* p_params = &@params)
                {
                    Debug.Assert(Delegates.pglGetSamplerParameteriv != null, "pglGetSamplerParameteriv not implemented");
                    Delegates.pglGetSamplerParameteriv(sampler, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetSamplerParameteriv: return sampler parameter values
        ///     </para>
        /// </summary>
        /// <param name="sampler">
        /// Specifies name of the sampler object from which to retrieve parameters.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD,
        /// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R,
        /// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the sampler parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static unsafe void GetSamplerParameter(uint sampler, SamplerParameterName pname, [Out] int* @params)
        {
            Debug.Assert(Delegates.pglGetSamplerParameteriv != null, "pglGetSamplerParameteriv not implemented");
            Delegates.pglGetSamplerParameteriv(sampler, (int) pname, @params);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetSamplerParameteriv: return sampler parameter values
        ///     </para>
        /// </summary>
        /// <param name="sampler">
        /// Specifies name of the sampler object from which to retrieve parameters.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD,
        /// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R,
        /// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the sampler parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static void GetSamplerParameteri<T>(uint sampler, SamplerParameterName pname, out T @params) where T : struct
        {
            Debug.Assert(Delegates.pglGetSamplerParameteriv != null, "pglGetSamplerParameteriv not implemented");
            @params = default;
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(@params);
			try {
				unsafe {
					Delegates.pglGetSamplerParameteriv(sampler, (int)pname, (int*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refParams = __makeref(@params);
                IntPtr refParamsPtr = *(IntPtr*) (&refParams);

                Delegates.pglGetSamplerParameteriv(sampler, (int) pname, (int*) refParamsPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetSamplerParameterIiv: return sampler parameter values
        ///     </para>
        /// </summary>
        /// <param name="sampler">
        /// Specifies name of the sampler object from which to retrieve parameters.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD,
        /// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R,
        /// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the sampler parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void GetSamplerParameterI(uint sampler, SamplerParameterName pname, [Out] int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetSamplerParameterIiv != null, "pglGetSamplerParameterIiv not implemented");
                    Delegates.pglGetSamplerParameterIiv(sampler, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetSamplerParameterIiv: return sampler parameter values
        ///     </para>
        /// </summary>
        /// <param name="sampler">
        /// Specifies name of the sampler object from which to retrieve parameters.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD,
        /// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R,
        /// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the sampler parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void GetSamplerParameterI(uint sampler, SamplerParameterName pname, out int @params)
        {
            unsafe
            {
                fixed (int* p_params = &@params)
                {
                    Debug.Assert(Delegates.pglGetSamplerParameterIiv != null, "pglGetSamplerParameterIiv not implemented");
                    Delegates.pglGetSamplerParameterIiv(sampler, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetSamplerParameterIiv: return sampler parameter values
        ///     </para>
        /// </summary>
        /// <param name="sampler">
        /// Specifies name of the sampler object from which to retrieve parameters.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD,
        /// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R,
        /// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the sampler parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static unsafe void GetSamplerParameterI(uint sampler, SamplerParameterName pname, [Out] int* @params)
        {
            Debug.Assert(Delegates.pglGetSamplerParameterIiv != null, "pglGetSamplerParameterIiv not implemented");
            Delegates.pglGetSamplerParameterIiv(sampler, (int) pname, @params);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetSamplerParameterIiv: return sampler parameter values
        ///     </para>
        /// </summary>
        /// <param name="sampler">
        /// Specifies name of the sampler object from which to retrieve parameters.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD,
        /// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R,
        /// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the sampler parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void GetSamplerParameterIi<T>(uint sampler, SamplerParameterName pname, out T @params) where T : struct
        {
            Debug.Assert(Delegates.pglGetSamplerParameterIiv != null, "pglGetSamplerParameterIiv not implemented");
            @params = default;
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(@params);
			try {
				unsafe {
					Delegates.pglGetSamplerParameterIiv(sampler, (int)pname, (int*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refParams = __makeref(@params);
                IntPtr refParamsPtr = *(IntPtr*) (&refParams);

                Delegates.pglGetSamplerParameterIiv(sampler, (int) pname, (int*) refParamsPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetSamplerParameterfv: return sampler parameter values
        ///     </para>
        /// </summary>
        /// <param name="sampler">
        /// Specifies name of the sampler object from which to retrieve parameters.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD,
        /// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R,
        /// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the sampler parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static void GetSamplerParameter(uint sampler, SamplerParameterName pname, [Out] float[] @params)
        {
            unsafe
            {
                fixed (float* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetSamplerParameterfv != null, "pglGetSamplerParameterfv not implemented");
                    Delegates.pglGetSamplerParameterfv(sampler, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetSamplerParameterfv: return sampler parameter values
        ///     </para>
        /// </summary>
        /// <param name="sampler">
        /// Specifies name of the sampler object from which to retrieve parameters.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD,
        /// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R,
        /// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the sampler parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static void GetSamplerParameter(uint sampler, SamplerParameterName pname, out float @params)
        {
            unsafe
            {
                fixed (float* p_params = &@params)
                {
                    Debug.Assert(Delegates.pglGetSamplerParameterfv != null, "pglGetSamplerParameterfv not implemented");
                    Delegates.pglGetSamplerParameterfv(sampler, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetSamplerParameterfv: return sampler parameter values
        ///     </para>
        /// </summary>
        /// <param name="sampler">
        /// Specifies name of the sampler object from which to retrieve parameters.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD,
        /// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R,
        /// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the sampler parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static unsafe void GetSamplerParameter(uint sampler, SamplerParameterName pname, [Out] float* @params)
        {
            Debug.Assert(Delegates.pglGetSamplerParameterfv != null, "pglGetSamplerParameterfv not implemented");
            Delegates.pglGetSamplerParameterfv(sampler, (int) pname, @params);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetSamplerParameterfv: return sampler parameter values
        ///     </para>
        /// </summary>
        /// <param name="sampler">
        /// Specifies name of the sampler object from which to retrieve parameters.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD,
        /// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R,
        /// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the sampler parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        public static void GetSamplerParameterf<T>(uint sampler, SamplerParameterName pname, out T @params) where T : struct
        {
            Debug.Assert(Delegates.pglGetSamplerParameterfv != null, "pglGetSamplerParameterfv not implemented");
            @params = default;
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(@params);
			try {
				unsafe {
					Delegates.pglGetSamplerParameterfv(sampler, (int)pname, (float*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refParams = __makeref(@params);
                IntPtr refParamsPtr = *(IntPtr*) (&refParams);

                Delegates.pglGetSamplerParameterfv(sampler, (int) pname, (float*) refParamsPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetSamplerParameterIuiv: return sampler parameter values
        ///     </para>
        /// </summary>
        /// <param name="sampler">
        /// Specifies name of the sampler object from which to retrieve parameters.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD,
        /// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R,
        /// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the sampler parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void GetSamplerParameterI(uint sampler, SamplerParameterName pname, [Out] uint[] @params)
        {
            unsafe
            {
                fixed (uint* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetSamplerParameterIuiv != null, "pglGetSamplerParameterIuiv not implemented");
                    Delegates.pglGetSamplerParameterIuiv(sampler, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetSamplerParameterIuiv: return sampler parameter values
        ///     </para>
        /// </summary>
        /// <param name="sampler">
        /// Specifies name of the sampler object from which to retrieve parameters.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD,
        /// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R,
        /// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the sampler parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void GetSamplerParameterI(uint sampler, SamplerParameterName pname, out uint @params)
        {
            unsafe
            {
                fixed (uint* p_params = &@params)
                {
                    Debug.Assert(Delegates.pglGetSamplerParameterIuiv != null, "pglGetSamplerParameterIuiv not implemented");
                    Delegates.pglGetSamplerParameterIuiv(sampler, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetSamplerParameterIuiv: return sampler parameter values
        ///     </para>
        /// </summary>
        /// <param name="sampler">
        /// Specifies name of the sampler object from which to retrieve parameters.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD,
        /// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R,
        /// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the sampler parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static unsafe void GetSamplerParameterI(uint sampler, SamplerParameterName pname, [Out] uint* @params)
        {
            Debug.Assert(Delegates.pglGetSamplerParameterIuiv != null, "pglGetSamplerParameterIuiv not implemented");
            Delegates.pglGetSamplerParameterIuiv(sampler, (int) pname, @params);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetSamplerParameterIuiv: return sampler parameter values
        ///     </para>
        /// </summary>
        /// <param name="sampler">
        /// Specifies name of the sampler object from which to retrieve parameters.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD,
        /// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R,
        /// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the sampler parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void GetSamplerParameterIui<T>(uint sampler, SamplerParameterName pname, out T @params) where T : struct
        {
            Debug.Assert(Delegates.pglGetSamplerParameterIuiv != null, "pglGetSamplerParameterIuiv not implemented");
            @params = default;
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(@params);
			try {
				unsafe {
					Delegates.pglGetSamplerParameterIuiv(sampler, (int)pname, (uint*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refParams = __makeref(@params);
                IntPtr refParamsPtr = *(IntPtr*) (&refParams);

                Delegates.pglGetSamplerParameterIuiv(sampler, (int) pname, (uint*) refParamsPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glQueryCounter: record the GL time into a query object after all previous commands have reached the GL server but
        /// have not yet necessarily executed.
        /// </summary>
        /// <param name="id">
        /// Specify the name of a query object into which to record the GL time.
        /// </param>
        /// <param name="target">
        /// Specify the counter to query. <paramref name="target" /> must be Gl.TIMESTAMP.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
        public static void QueryCounter(uint id, QueryTarget target)
        {
            Debug.Assert(Delegates.pglQueryCounter != null, "pglQueryCounter not implemented");
            Delegates.pglQueryCounter(id, (int) target);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetQueryObjecti64v: return parameters of a query object
        /// </summary>
        /// <param name="id">
        /// Specifies the name of a query object.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a query object parameter. Accepted values are Gl.QUERY_RESULT or
        /// Gl.QUERY_RESULT_AVAILABLE.
        /// </param>
        /// <param name="params">
        /// If a buffer is bound to the Gl.QUERY_RESULT_BUFFER target, then <paramref name="params" /> is treated as an offset to a
        /// location within that buffer's data store to receive the result of the query. If no buffer is bound to
        /// Gl.QUERY_RESULT_BUFFER, then <paramref name="params" /> is treated as an address in client memory of a variable to
        /// receive the resulting data.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
        [RequiredByFeature("GL_EXT_timer_query")]
        public static void GetQueryObject(uint id, QueryObjectParameterName pname, [Out] long[] @params)
        {
            unsafe
            {
                fixed (long* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetQueryObjecti64v != null, "pglGetQueryObjecti64v not implemented");
                    Delegates.pglGetQueryObjecti64v(id, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetQueryObjecti64v: return parameters of a query object
        /// </summary>
        /// <param name="id">
        /// Specifies the name of a query object.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a query object parameter. Accepted values are Gl.QUERY_RESULT or
        /// Gl.QUERY_RESULT_AVAILABLE.
        /// </param>
        /// <param name="params">
        /// If a buffer is bound to the Gl.QUERY_RESULT_BUFFER target, then <paramref name="params" /> is treated as an offset to a
        /// location within that buffer's data store to receive the result of the query. If no buffer is bound to
        /// Gl.QUERY_RESULT_BUFFER, then <paramref name="params" /> is treated as an address in client memory of a variable to
        /// receive the resulting data.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
        [RequiredByFeature("GL_EXT_timer_query")]
        public static void GetQueryObject(uint id, QueryObjectParameterName pname, out long @params)
        {
            unsafe
            {
                fixed (long* p_params = &@params)
                {
                    Debug.Assert(Delegates.pglGetQueryObjecti64v != null, "pglGetQueryObjecti64v not implemented");
                    Delegates.pglGetQueryObjecti64v(id, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetQueryObjectui64v: return parameters of a query object
        /// </summary>
        /// <param name="id">
        /// Specifies the name of a query object.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a query object parameter. Accepted values are Gl.QUERY_RESULT or
        /// Gl.QUERY_RESULT_AVAILABLE.
        /// </param>
        /// <param name="params">
        /// If a buffer is bound to the Gl.QUERY_RESULT_BUFFER target, then <paramref name="params" /> is treated as an offset to a
        /// location within that buffer's data store to receive the result of the query. If no buffer is bound to
        /// Gl.QUERY_RESULT_BUFFER, then <paramref name="params" /> is treated as an address in client memory of a variable to
        /// receive the resulting data.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
        [RequiredByFeature("GL_EXT_timer_query")]
        public static void GetQueryObject(uint id, QueryObjectParameterName pname, [Out] ulong[] @params)
        {
            unsafe
            {
                fixed (ulong* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetQueryObjectui64v != null, "pglGetQueryObjectui64v not implemented");
                    Delegates.pglGetQueryObjectui64v(id, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetQueryObjectui64v: return parameters of a query object
        /// </summary>
        /// <param name="id">
        /// Specifies the name of a query object.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a query object parameter. Accepted values are Gl.QUERY_RESULT or
        /// Gl.QUERY_RESULT_AVAILABLE.
        /// </param>
        /// <param name="params">
        /// If a buffer is bound to the Gl.QUERY_RESULT_BUFFER target, then <paramref name="params" /> is treated as an offset to a
        /// location within that buffer's data store to receive the result of the query. If no buffer is bound to
        /// Gl.QUERY_RESULT_BUFFER, then <paramref name="params" /> is treated as an address in client memory of a variable to
        /// receive the resulting data.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
        [RequiredByFeature("GL_EXT_timer_query")]
        public static void GetQueryObject(uint id, QueryObjectParameterName pname, out ulong @params)
        {
            unsafe
            {
                fixed (ulong* p_params = &@params)
                {
                    Debug.Assert(Delegates.pglGetQueryObjectui64v != null, "pglGetQueryObjectui64v not implemented");
                    Delegates.pglGetQueryObjectui64v(id, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glVertexAttribDivisor: modify the rate at which generic vertex attributes advance during instanced
        ///     rendering
        ///     </para>
        /// </summary>
        /// <param name="index">
        /// Specify the index of the generic vertex attribute.
        /// </param>
        /// <param name="divisor">
        /// Specify the number of instances that will pass between updates of the generic attribute at slot
        /// <paramref
        ///     name="index" />
        /// .
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ANGLE_instanced_arrays", Api = "gles2")]
        [RequiredByFeature("GL_ARB_instanced_arrays", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_instanced_arrays", Api = "gles2")]
        [RequiredByFeature("GL_NV_instanced_arrays", Api = "gles2")]
        public static void VertexAttribDivisor(uint index, uint divisor)
        {
            Debug.Assert(Delegates.pglVertexAttribDivisor != null, "pglVertexAttribDivisor not implemented");
            Delegates.pglVertexAttribDivisor(index, divisor);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribP1ui: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="type">
        /// For the packed commands (Gl.VertexAttribP*), specified the type of packing used on the data. This parameter must be
        /// Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV, to specify signed or unsigned data, respectively, or
        /// Gl.UNSIGNED_INT_10F_11F_11F_REV to specify floating point data.
        /// </param>
        /// <param name="normalized">
        /// For the packed commands, if Gl.TRUE, then the values are to be converted to floating point values by normalizing.
        /// Otherwise, they are converted directly to floating-point values. If <paramref name="type" /> indicates a floating-pont
        /// format, then <paramref name="normalized" /> value must be Gl.FALSE.
        /// </param>
        /// <param name="value">
        /// For the packed commands, specifies the new packed value to be used for the specified vertex attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
        public static void VertexAttribP1(uint index, VertexAttribType type, bool normalized, uint value)
        {
            Debug.Assert(Delegates.pglVertexAttribP1ui != null, "pglVertexAttribP1ui not implemented");
            Delegates.pglVertexAttribP1ui(index, (int) type, normalized, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glVertexAttribP1uiv: Binding for glVertexAttribP1uiv.
        /// </summary>
        /// <param name="index">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="type">
        /// A <see cref="T:VertexAttribType" />.
        /// </param>
        /// <param name="normalized">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
        public static void VertexAttribP1(uint index, VertexAttribType type, bool normalized, uint[] value)
        {
            Debug.Assert(value.Length >= 1);
            unsafe
            {
                fixed (uint* p_value = value)
                {
                    Debug.Assert(Delegates.pglVertexAttribP1uiv != null, "pglVertexAttribP1uiv not implemented");
                    Delegates.pglVertexAttribP1uiv(index, (int) type, normalized, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribP2ui: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="type">
        /// For the packed commands (Gl.VertexAttribP*), specified the type of packing used on the data. This parameter must be
        /// Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV, to specify signed or unsigned data, respectively, or
        /// Gl.UNSIGNED_INT_10F_11F_11F_REV to specify floating point data.
        /// </param>
        /// <param name="normalized">
        /// For the packed commands, if Gl.TRUE, then the values are to be converted to floating point values by normalizing.
        /// Otherwise, they are converted directly to floating-point values. If <paramref name="type" /> indicates a floating-pont
        /// format, then <paramref name="normalized" /> value must be Gl.FALSE.
        /// </param>
        /// <param name="value">
        /// For the packed commands, specifies the new packed value to be used for the specified vertex attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
        public static void VertexAttribP2(uint index, VertexAttribType type, bool normalized, uint value)
        {
            Debug.Assert(Delegates.pglVertexAttribP2ui != null, "pglVertexAttribP2ui not implemented");
            Delegates.pglVertexAttribP2ui(index, (int) type, normalized, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glVertexAttribP2uiv: Binding for glVertexAttribP2uiv.
        /// </summary>
        /// <param name="index">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="type">
        /// A <see cref="T:VertexAttribType" />.
        /// </param>
        /// <param name="normalized">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
        public static void VertexAttribP2(uint index, VertexAttribType type, bool normalized, uint[] value)
        {
            Debug.Assert(value.Length >= 1);
            unsafe
            {
                fixed (uint* p_value = value)
                {
                    Debug.Assert(Delegates.pglVertexAttribP2uiv != null, "pglVertexAttribP2uiv not implemented");
                    Delegates.pglVertexAttribP2uiv(index, (int) type, normalized, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribP3ui: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="type">
        /// For the packed commands (Gl.VertexAttribP*), specified the type of packing used on the data. This parameter must be
        /// Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV, to specify signed or unsigned data, respectively, or
        /// Gl.UNSIGNED_INT_10F_11F_11F_REV to specify floating point data.
        /// </param>
        /// <param name="normalized">
        /// For the packed commands, if Gl.TRUE, then the values are to be converted to floating point values by normalizing.
        /// Otherwise, they are converted directly to floating-point values. If <paramref name="type" /> indicates a floating-pont
        /// format, then <paramref name="normalized" /> value must be Gl.FALSE.
        /// </param>
        /// <param name="value">
        /// For the packed commands, specifies the new packed value to be used for the specified vertex attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
        public static void VertexAttribP3(uint index, VertexAttribType type, bool normalized, uint value)
        {
            Debug.Assert(Delegates.pglVertexAttribP3ui != null, "pglVertexAttribP3ui not implemented");
            Delegates.pglVertexAttribP3ui(index, (int) type, normalized, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glVertexAttribP3uiv: Binding for glVertexAttribP3uiv.
        /// </summary>
        /// <param name="index">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="type">
        /// A <see cref="T:VertexAttribType" />.
        /// </param>
        /// <param name="normalized">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
        public static void VertexAttribP3(uint index, VertexAttribType type, bool normalized, uint[] value)
        {
            Debug.Assert(value.Length >= 1);
            unsafe
            {
                fixed (uint* p_value = value)
                {
                    Debug.Assert(Delegates.pglVertexAttribP3uiv != null, "pglVertexAttribP3uiv not implemented");
                    Delegates.pglVertexAttribP3uiv(index, (int) type, normalized, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribP4ui: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="type">
        /// For the packed commands (Gl.VertexAttribP*), specified the type of packing used on the data. This parameter must be
        /// Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV, to specify signed or unsigned data, respectively, or
        /// Gl.UNSIGNED_INT_10F_11F_11F_REV to specify floating point data.
        /// </param>
        /// <param name="normalized">
        /// For the packed commands, if Gl.TRUE, then the values are to be converted to floating point values by normalizing.
        /// Otherwise, they are converted directly to floating-point values. If <paramref name="type" /> indicates a floating-pont
        /// format, then <paramref name="normalized" /> value must be Gl.FALSE.
        /// </param>
        /// <param name="value">
        /// For the packed commands, specifies the new packed value to be used for the specified vertex attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
        public static void VertexAttribP4(uint index, VertexAttribType type, bool normalized, uint value)
        {
            Debug.Assert(Delegates.pglVertexAttribP4ui != null, "pglVertexAttribP4ui not implemented");
            Delegates.pglVertexAttribP4ui(index, (int) type, normalized, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glVertexAttribP4uiv: Binding for glVertexAttribP4uiv.
        /// </summary>
        /// <param name="index">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="type">
        /// A <see cref="T:VertexAttribType" />.
        /// </param>
        /// <param name="normalized">
        /// A <see cref="T:bool" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
        public static void VertexAttribP4(uint index, VertexAttribType type, bool normalized, uint[] value)
        {
            Debug.Assert(value.Length >= 1);
            unsafe
            {
                fixed (uint* p_value = value)
                {
                    Debug.Assert(Delegates.pglVertexAttribP4uiv != null, "pglVertexAttribP4uiv not implemented");
                    Delegates.pglVertexAttribP4uiv(index, (int) type, normalized, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glVertexP2ui: Binding for glVertexP2ui.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:VertexPointerType" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void VertexP2(VertexPointerType type, uint value)
        {
            Debug.Assert(Delegates.pglVertexP2ui != null, "pglVertexP2ui not implemented");
            Delegates.pglVertexP2ui((int) type, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glVertexP2uiv: Binding for glVertexP2uiv.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:VertexPointerType" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void VertexP2(VertexPointerType type, uint[] value)
        {
            Debug.Assert(value.Length >= 1);
            unsafe
            {
                fixed (uint* p_value = value)
                {
                    Debug.Assert(Delegates.pglVertexP2uiv != null, "pglVertexP2uiv not implemented");
                    Delegates.pglVertexP2uiv((int) type, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glVertexP3ui: Binding for glVertexP3ui.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:VertexPointerType" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void VertexP3(VertexPointerType type, uint value)
        {
            Debug.Assert(Delegates.pglVertexP3ui != null, "pglVertexP3ui not implemented");
            Delegates.pglVertexP3ui((int) type, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glVertexP3uiv: Binding for glVertexP3uiv.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:VertexPointerType" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void VertexP3(VertexPointerType type, uint[] value)
        {
            Debug.Assert(value.Length >= 1);
            unsafe
            {
                fixed (uint* p_value = value)
                {
                    Debug.Assert(Delegates.pglVertexP3uiv != null, "pglVertexP3uiv not implemented");
                    Delegates.pglVertexP3uiv((int) type, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glVertexP4ui: Binding for glVertexP4ui.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:VertexPointerType" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void VertexP4(VertexPointerType type, uint value)
        {
            Debug.Assert(Delegates.pglVertexP4ui != null, "pglVertexP4ui not implemented");
            Delegates.pglVertexP4ui((int) type, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glVertexP4uiv: Binding for glVertexP4uiv.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:VertexPointerType" />.
        /// </param>
        /// <param name="value">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void VertexP4(VertexPointerType type, uint[] value)
        {
            Debug.Assert(value.Length >= 1);
            unsafe
            {
                fixed (uint* p_value = value)
                {
                    Debug.Assert(Delegates.pglVertexP4uiv != null, "pglVertexP4uiv not implemented");
                    Delegates.pglVertexP4uiv((int) type, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glTexCoordP1ui: Binding for glTexCoordP1ui.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:TexCoordPointerType" />.
        /// </param>
        /// <param name="coords">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void TexCoordP1(TexCoordPointerType type, uint coords)
        {
            Debug.Assert(Delegates.pglTexCoordP1ui != null, "pglTexCoordP1ui not implemented");
            Delegates.pglTexCoordP1ui((int) type, coords);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glTexCoordP1uiv: Binding for glTexCoordP1uiv.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:TexCoordPointerType" />.
        /// </param>
        /// <param name="coords">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void TexCoordP1(TexCoordPointerType type, uint[] coords)
        {
            Debug.Assert(coords.Length >= 1);
            unsafe
            {
                fixed (uint* p_coords = coords)
                {
                    Debug.Assert(Delegates.pglTexCoordP1uiv != null, "pglTexCoordP1uiv not implemented");
                    Delegates.pglTexCoordP1uiv((int) type, p_coords);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glTexCoordP2ui: Binding for glTexCoordP2ui.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:TexCoordPointerType" />.
        /// </param>
        /// <param name="coords">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void TexCoordP2(TexCoordPointerType type, uint coords)
        {
            Debug.Assert(Delegates.pglTexCoordP2ui != null, "pglTexCoordP2ui not implemented");
            Delegates.pglTexCoordP2ui((int) type, coords);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glTexCoordP2uiv: Binding for glTexCoordP2uiv.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:TexCoordPointerType" />.
        /// </param>
        /// <param name="coords">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void TexCoordP2(TexCoordPointerType type, uint[] coords)
        {
            Debug.Assert(coords.Length >= 1);
            unsafe
            {
                fixed (uint* p_coords = coords)
                {
                    Debug.Assert(Delegates.pglTexCoordP2uiv != null, "pglTexCoordP2uiv not implemented");
                    Delegates.pglTexCoordP2uiv((int) type, p_coords);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glTexCoordP3ui: Binding for glTexCoordP3ui.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:TexCoordPointerType" />.
        /// </param>
        /// <param name="coords">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void TexCoordP3(TexCoordPointerType type, uint coords)
        {
            Debug.Assert(Delegates.pglTexCoordP3ui != null, "pglTexCoordP3ui not implemented");
            Delegates.pglTexCoordP3ui((int) type, coords);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glTexCoordP3uiv: Binding for glTexCoordP3uiv.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:TexCoordPointerType" />.
        /// </param>
        /// <param name="coords">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void TexCoordP3(TexCoordPointerType type, uint[] coords)
        {
            Debug.Assert(coords.Length >= 1);
            unsafe
            {
                fixed (uint* p_coords = coords)
                {
                    Debug.Assert(Delegates.pglTexCoordP3uiv != null, "pglTexCoordP3uiv not implemented");
                    Delegates.pglTexCoordP3uiv((int) type, p_coords);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glTexCoordP4ui: Binding for glTexCoordP4ui.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:TexCoordPointerType" />.
        /// </param>
        /// <param name="coords">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void TexCoordP4(TexCoordPointerType type, uint coords)
        {
            Debug.Assert(Delegates.pglTexCoordP4ui != null, "pglTexCoordP4ui not implemented");
            Delegates.pglTexCoordP4ui((int) type, coords);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glTexCoordP4uiv: Binding for glTexCoordP4uiv.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:TexCoordPointerType" />.
        /// </param>
        /// <param name="coords">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void TexCoordP4(TexCoordPointerType type, uint[] coords)
        {
            Debug.Assert(coords.Length >= 1);
            unsafe
            {
                fixed (uint* p_coords = coords)
                {
                    Debug.Assert(Delegates.pglTexCoordP4uiv != null, "pglTexCoordP4uiv not implemented");
                    Delegates.pglTexCoordP4uiv((int) type, p_coords);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glMultiTexCoordP1ui: Binding for glMultiTexCoordP1ui.
        /// </summary>
        /// <param name="texture">
        /// A <see cref="T:TextureUnit" />.
        /// </param>
        /// <param name="type">
        /// A <see cref="T:TexCoordPointerType" />.
        /// </param>
        /// <param name="coords">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void MultiTexCoordP1(TextureUnit texture, TexCoordPointerType type, uint coords)
        {
            Debug.Assert(Delegates.pglMultiTexCoordP1ui != null, "pglMultiTexCoordP1ui not implemented");
            Delegates.pglMultiTexCoordP1ui((int) texture, (int) type, coords);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glMultiTexCoordP1uiv: Binding for glMultiTexCoordP1uiv.
        /// </summary>
        /// <param name="texture">
        /// A <see cref="T:TextureUnit" />.
        /// </param>
        /// <param name="type">
        /// A <see cref="T:TexCoordPointerType" />.
        /// </param>
        /// <param name="coords">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void MultiTexCoordP1(TextureUnit texture, TexCoordPointerType type, uint[] coords)
        {
            Debug.Assert(coords.Length >= 1);
            unsafe
            {
                fixed (uint* p_coords = coords)
                {
                    Debug.Assert(Delegates.pglMultiTexCoordP1uiv != null, "pglMultiTexCoordP1uiv not implemented");
                    Delegates.pglMultiTexCoordP1uiv((int) texture, (int) type, p_coords);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glMultiTexCoordP2ui: Binding for glMultiTexCoordP2ui.
        /// </summary>
        /// <param name="texture">
        /// A <see cref="T:TextureUnit" />.
        /// </param>
        /// <param name="type">
        /// A <see cref="T:TexCoordPointerType" />.
        /// </param>
        /// <param name="coords">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void MultiTexCoordP2(TextureUnit texture, TexCoordPointerType type, uint coords)
        {
            Debug.Assert(Delegates.pglMultiTexCoordP2ui != null, "pglMultiTexCoordP2ui not implemented");
            Delegates.pglMultiTexCoordP2ui((int) texture, (int) type, coords);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glMultiTexCoordP2uiv: Binding for glMultiTexCoordP2uiv.
        /// </summary>
        /// <param name="texture">
        /// A <see cref="T:TextureUnit" />.
        /// </param>
        /// <param name="type">
        /// A <see cref="T:TexCoordPointerType" />.
        /// </param>
        /// <param name="coords">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void MultiTexCoordP2(TextureUnit texture, TexCoordPointerType type, uint[] coords)
        {
            Debug.Assert(coords.Length >= 1);
            unsafe
            {
                fixed (uint* p_coords = coords)
                {
                    Debug.Assert(Delegates.pglMultiTexCoordP2uiv != null, "pglMultiTexCoordP2uiv not implemented");
                    Delegates.pglMultiTexCoordP2uiv((int) texture, (int) type, p_coords);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glMultiTexCoordP3ui: Binding for glMultiTexCoordP3ui.
        /// </summary>
        /// <param name="texture">
        /// A <see cref="T:TextureUnit" />.
        /// </param>
        /// <param name="type">
        /// A <see cref="T:TexCoordPointerType" />.
        /// </param>
        /// <param name="coords">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void MultiTexCoordP3(TextureUnit texture, TexCoordPointerType type, uint coords)
        {
            Debug.Assert(Delegates.pglMultiTexCoordP3ui != null, "pglMultiTexCoordP3ui not implemented");
            Delegates.pglMultiTexCoordP3ui((int) texture, (int) type, coords);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glMultiTexCoordP3uiv: Binding for glMultiTexCoordP3uiv.
        /// </summary>
        /// <param name="texture">
        /// A <see cref="T:TextureUnit" />.
        /// </param>
        /// <param name="type">
        /// A <see cref="T:TexCoordPointerType" />.
        /// </param>
        /// <param name="coords">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void MultiTexCoordP3(TextureUnit texture, TexCoordPointerType type, uint[] coords)
        {
            Debug.Assert(coords.Length >= 1);
            unsafe
            {
                fixed (uint* p_coords = coords)
                {
                    Debug.Assert(Delegates.pglMultiTexCoordP3uiv != null, "pglMultiTexCoordP3uiv not implemented");
                    Delegates.pglMultiTexCoordP3uiv((int) texture, (int) type, p_coords);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glMultiTexCoordP4ui: Binding for glMultiTexCoordP4ui.
        /// </summary>
        /// <param name="texture">
        /// A <see cref="T:TextureUnit" />.
        /// </param>
        /// <param name="type">
        /// A <see cref="T:TexCoordPointerType" />.
        /// </param>
        /// <param name="coords">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void MultiTexCoordP4(TextureUnit texture, TexCoordPointerType type, uint coords)
        {
            Debug.Assert(Delegates.pglMultiTexCoordP4ui != null, "pglMultiTexCoordP4ui not implemented");
            Delegates.pglMultiTexCoordP4ui((int) texture, (int) type, coords);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glMultiTexCoordP4uiv: Binding for glMultiTexCoordP4uiv.
        /// </summary>
        /// <param name="texture">
        /// A <see cref="T:TextureUnit" />.
        /// </param>
        /// <param name="type">
        /// A <see cref="T:TexCoordPointerType" />.
        /// </param>
        /// <param name="coords">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void MultiTexCoordP4(TextureUnit texture, TexCoordPointerType type, uint[] coords)
        {
            Debug.Assert(coords.Length >= 1);
            unsafe
            {
                fixed (uint* p_coords = coords)
                {
                    Debug.Assert(Delegates.pglMultiTexCoordP4uiv != null, "pglMultiTexCoordP4uiv not implemented");
                    Delegates.pglMultiTexCoordP4uiv((int) texture, (int) type, p_coords);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glNormalP3ui: Binding for glNormalP3ui.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:NormalPointerType" />.
        /// </param>
        /// <param name="coords">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void NormalP3(NormalPointerType type, uint coords)
        {
            Debug.Assert(Delegates.pglNormalP3ui != null, "pglNormalP3ui not implemented");
            Delegates.pglNormalP3ui((int) type, coords);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glNormalP3uiv: Binding for glNormalP3uiv.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:NormalPointerType" />.
        /// </param>
        /// <param name="coords">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void NormalP3(NormalPointerType type, uint[] coords)
        {
            Debug.Assert(coords.Length >= 1);
            unsafe
            {
                fixed (uint* p_coords = coords)
                {
                    Debug.Assert(Delegates.pglNormalP3uiv != null, "pglNormalP3uiv not implemented");
                    Delegates.pglNormalP3uiv((int) type, p_coords);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glColorP3ui: Binding for glColorP3ui.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:ColorPointerType" />.
        /// </param>
        /// <param name="color">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void ColorP3(ColorPointerType type, uint color)
        {
            Debug.Assert(Delegates.pglColorP3ui != null, "pglColorP3ui not implemented");
            Delegates.pglColorP3ui((int) type, color);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glColorP3uiv: Binding for glColorP3uiv.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:ColorPointerType" />.
        /// </param>
        /// <param name="color">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void ColorP3(ColorPointerType type, uint[] color)
        {
            Debug.Assert(color.Length >= 1);
            unsafe
            {
                fixed (uint* p_color = color)
                {
                    Debug.Assert(Delegates.pglColorP3uiv != null, "pglColorP3uiv not implemented");
                    Delegates.pglColorP3uiv((int) type, p_color);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glColorP4ui: Binding for glColorP4ui.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:ColorPointerType" />.
        /// </param>
        /// <param name="color">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void ColorP4(ColorPointerType type, uint color)
        {
            Debug.Assert(Delegates.pglColorP4ui != null, "pglColorP4ui not implemented");
            Delegates.pglColorP4ui((int) type, color);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glColorP4uiv: Binding for glColorP4uiv.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:ColorPointerType" />.
        /// </param>
        /// <param name="color">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void ColorP4(ColorPointerType type, uint[] color)
        {
            Debug.Assert(color.Length >= 1);
            unsafe
            {
                fixed (uint* p_color = color)
                {
                    Debug.Assert(Delegates.pglColorP4uiv != null, "pglColorP4uiv not implemented");
                    Delegates.pglColorP4uiv((int) type, p_color);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glSecondaryColorP3ui: Binding for glSecondaryColorP3ui.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:ColorPointerType" />.
        /// </param>
        /// <param name="color">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void SecondaryColorP3(ColorPointerType type, uint color)
        {
            Debug.Assert(Delegates.pglSecondaryColorP3ui != null, "pglSecondaryColorP3ui not implemented");
            Delegates.pglSecondaryColorP3ui((int) type, color);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glSecondaryColorP3uiv: Binding for glSecondaryColorP3uiv.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:ColorPointerType" />.
        /// </param>
        /// <param name="color">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
        [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
        public static void SecondaryColorP3(ColorPointerType type, uint[] color)
        {
            Debug.Assert(color.Length >= 1);
            unsafe
            {
                fixed (uint* p_color = color)
                {
                    Debug.Assert(Delegates.pglSecondaryColorP3uiv != null, "pglSecondaryColorP3uiv not implemented");
                    Delegates.pglSecondaryColorP3uiv((int) type, p_color);
                }
            }

            DebugCheckErrors(null);
        }

        public static unsafe partial class Delegates
        {
            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ARB_blend_func_extended", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, string name);

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ARB_blend_func_extended", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2", EntryPoint = "glBindFragDataLocationIndexedEXT")]
            [ThreadStatic]
            public static glBindFragDataLocationIndexed pglBindFragDataLocationIndexed;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ARB_blend_func_extended", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate int glGetFragDataIndex(uint program, string name);

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ARB_blend_func_extended", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2", EntryPoint = "glGetFragDataIndexEXT")]
            [ThreadStatic]
            public static glGetFragDataIndex pglGetFragDataIndex;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGenSamplers(int count, uint* samplers);

            [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glGenSamplers pglGenSamplers;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDeleteSamplers(int count, uint* samplers);

            [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glDeleteSamplers pglDeleteSamplers;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.I1)]
            public delegate bool glIsSampler(uint sampler);

            [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glIsSampler pglIsSampler;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBindSampler(uint unit, uint sampler);

            [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glBindSampler pglBindSampler;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSamplerParameteri(uint sampler, int pname, int param);

            [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glSamplerParameteri pglSamplerParameteri;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSamplerParameteriv(uint sampler, int pname, int* param);

            [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glSamplerParameteriv pglSamplerParameteriv;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSamplerParameterf(uint sampler, int pname, float param);

            [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glSamplerParameterf pglSamplerParameterf;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSamplerParameterfv(uint sampler, int pname, float* param);

            [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glSamplerParameterfv pglSamplerParameterfv;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
            [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSamplerParameterIiv(uint sampler, int pname, int* param);

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2", EntryPoint = "glSamplerParameterIivEXT")]
            [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2", EntryPoint = "glSamplerParameterIivOES")]
            [ThreadStatic]
            public static glSamplerParameterIiv pglSamplerParameterIiv;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
            [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSamplerParameterIuiv(uint sampler, int pname, uint* param);

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2", EntryPoint = "glSamplerParameterIuivEXT")]
            [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2", EntryPoint = "glSamplerParameterIuivOES")]
            [ThreadStatic]
            public static glSamplerParameterIuiv pglSamplerParameterIuiv;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetSamplerParameteriv(uint sampler, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glGetSamplerParameteriv pglGetSamplerParameteriv;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
            [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetSamplerParameterIiv(uint sampler, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2", EntryPoint = "glGetSamplerParameterIivEXT")]
            [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2", EntryPoint = "glGetSamplerParameterIivOES")]
            [ThreadStatic]
            public static glGetSamplerParameterIiv pglGetSamplerParameterIiv;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetSamplerParameterfv(uint sampler, int pname, float* @params);

            [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")] [ThreadStatic]
            public static glGetSamplerParameterfv pglGetSamplerParameterfv;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
            [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetSamplerParameterIuiv(uint sampler, int pname, uint* @params);

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2", EntryPoint = "glGetSamplerParameterIuivEXT")]
            [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2", EntryPoint = "glGetSamplerParameterIuivOES")]
            [ThreadStatic]
            public static glGetSamplerParameterIuiv pglGetSamplerParameterIuiv;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glQueryCounter(uint id, int target);

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2", EntryPoint = "glQueryCounterEXT")]
            [ThreadStatic]
            public static glQueryCounter pglQueryCounter;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
            [RequiredByFeature("GL_EXT_timer_query")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetQueryObjecti64v(uint id, int pname, long* @params);

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2", EntryPoint = "glGetQueryObjecti64vEXT")]
            [RequiredByFeature("GL_EXT_timer_query", EntryPoint = "glGetQueryObjecti64vEXT")]
            [ThreadStatic]
            public static glGetQueryObjecti64v pglGetQueryObjecti64v;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
            [RequiredByFeature("GL_EXT_timer_query")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetQueryObjectui64v(uint id, int pname, ulong* @params);

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2", EntryPoint = "glGetQueryObjectui64vEXT")]
            [RequiredByFeature("GL_EXT_timer_query", EntryPoint = "glGetQueryObjectui64vEXT")]
            [ThreadStatic]
            public static glGetQueryObjectui64v pglGetQueryObjectui64v;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ANGLE_instanced_arrays", Api = "gles2")]
            [RequiredByFeature("GL_ARB_instanced_arrays", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_instanced_arrays", Api = "gles2")]
            [RequiredByFeature("GL_NV_instanced_arrays", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribDivisor(uint index, uint divisor);

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ANGLE_instanced_arrays", Api = "gles2", EntryPoint = "glVertexAttribDivisorANGLE")]
            [RequiredByFeature("GL_ARB_instanced_arrays", Api = "gl|glcore", EntryPoint = "glVertexAttribDivisorARB")]
            [RequiredByFeature("GL_EXT_instanced_arrays", Api = "gles2", EntryPoint = "glVertexAttribDivisorEXT")]
            [RequiredByFeature("GL_NV_instanced_arrays", Api = "gles2", EntryPoint = "glVertexAttribDivisorNV")]
            [ThreadStatic]
            public static glVertexAttribDivisor pglVertexAttribDivisor;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribP1ui(uint index, int type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint value);

            [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")] [ThreadStatic]
            public static glVertexAttribP1ui pglVertexAttribP1ui;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribP1uiv(uint index, int type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint* value);

            [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")] [ThreadStatic]
            public static glVertexAttribP1uiv pglVertexAttribP1uiv;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribP2ui(uint index, int type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint value);

            [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")] [ThreadStatic]
            public static glVertexAttribP2ui pglVertexAttribP2ui;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribP2uiv(uint index, int type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint* value);

            [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")] [ThreadStatic]
            public static glVertexAttribP2uiv pglVertexAttribP2uiv;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribP3ui(uint index, int type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint value);

            [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")] [ThreadStatic]
            public static glVertexAttribP3ui pglVertexAttribP3ui;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribP3uiv(uint index, int type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint* value);

            [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")] [ThreadStatic]
            public static glVertexAttribP3uiv pglVertexAttribP3uiv;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribP4ui(uint index, int type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint value);

            [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")] [ThreadStatic]
            public static glVertexAttribP4ui pglVertexAttribP4ui;

            [RequiredByFeature("GL_VERSION_3_3")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribP4uiv(uint index, int type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint* value);

            [RequiredByFeature("GL_VERSION_3_3")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")] [ThreadStatic]
            public static glVertexAttribP4uiv pglVertexAttribP4uiv;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexP2ui(int type, uint value);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glVertexP2ui pglVertexP2ui;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexP2uiv(int type, uint* value);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glVertexP2uiv pglVertexP2uiv;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexP3ui(int type, uint value);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glVertexP3ui pglVertexP3ui;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexP3uiv(int type, uint* value);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glVertexP3uiv pglVertexP3uiv;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexP4ui(int type, uint value);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glVertexP4ui pglVertexP4ui;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexP4uiv(int type, uint* value);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glVertexP4uiv pglVertexP4uiv;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glTexCoordP1ui(int type, uint coords);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glTexCoordP1ui pglTexCoordP1ui;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glTexCoordP1uiv(int type, uint* coords);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glTexCoordP1uiv pglTexCoordP1uiv;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glTexCoordP2ui(int type, uint coords);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glTexCoordP2ui pglTexCoordP2ui;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glTexCoordP2uiv(int type, uint* coords);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glTexCoordP2uiv pglTexCoordP2uiv;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glTexCoordP3ui(int type, uint coords);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glTexCoordP3ui pglTexCoordP3ui;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glTexCoordP3uiv(int type, uint* coords);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glTexCoordP3uiv pglTexCoordP3uiv;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glTexCoordP4ui(int type, uint coords);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glTexCoordP4ui pglTexCoordP4ui;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glTexCoordP4uiv(int type, uint* coords);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glTexCoordP4uiv pglTexCoordP4uiv;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glMultiTexCoordP1ui(int texture, int type, uint coords);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glMultiTexCoordP1ui pglMultiTexCoordP1ui;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glMultiTexCoordP1uiv(int texture, int type, uint* coords);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glMultiTexCoordP1uiv pglMultiTexCoordP1uiv;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glMultiTexCoordP2ui(int texture, int type, uint coords);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glMultiTexCoordP2ui pglMultiTexCoordP2ui;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glMultiTexCoordP2uiv(int texture, int type, uint* coords);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glMultiTexCoordP2uiv pglMultiTexCoordP2uiv;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glMultiTexCoordP3ui(int texture, int type, uint coords);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glMultiTexCoordP3ui pglMultiTexCoordP3ui;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glMultiTexCoordP3uiv(int texture, int type, uint* coords);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glMultiTexCoordP3uiv pglMultiTexCoordP3uiv;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glMultiTexCoordP4ui(int texture, int type, uint coords);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glMultiTexCoordP4ui pglMultiTexCoordP4ui;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glMultiTexCoordP4uiv(int texture, int type, uint* coords);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glMultiTexCoordP4uiv pglMultiTexCoordP4uiv;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glNormalP3ui(int type, uint coords);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glNormalP3ui pglNormalP3ui;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glNormalP3uiv(int type, uint* coords);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glNormalP3uiv pglNormalP3uiv;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glColorP3ui(int type, uint color);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glColorP3ui pglColorP3ui;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glColorP3uiv(int type, uint* color);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glColorP3uiv pglColorP3uiv;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glColorP4ui(int type, uint color);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glColorP4ui pglColorP4ui;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glColorP4uiv(int type, uint* color);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glColorP4uiv pglColorP4uiv;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSecondaryColorP3ui(int type, uint color);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glSecondaryColorP3ui pglSecondaryColorP3ui;

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")]
            [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSecondaryColorP3uiv(int type, uint* color);

            [RequiredByFeature("GL_VERSION_3_3", Profile = "compatibility")] [RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Profile = "compatibility")] [ThreadStatic]
            public static glSecondaryColorP3uiv pglSecondaryColorP3uiv;
        }
    }
}