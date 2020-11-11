#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective

#region Using

using System;
using System.Diagnostics;
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
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the symbolic constant identifying the RGB destination blend function. The
        /// initial value is Gl.ZERO. See Gl.BlendFunc and Gl.BlendFuncSeparate.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_EXT_blend_func_separate")]
        [RequiredByFeature("GL_OES_blend_func_separate", Api = "gles1")]
        public const int BLEND_DST_RGB = 0x80C8;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the symbolic constant identifying the RGB source blend function. The
        /// initial value is Gl.ONE. See Gl.BlendFunc and Gl.BlendFuncSeparate.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_EXT_blend_func_separate")]
        [RequiredByFeature("GL_OES_blend_func_separate", Api = "gles1")]
        public const int BLEND_SRC_RGB = 0x80C9;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the symbolic constant identifying the alpha destination blend function.
        /// The initial value is Gl.ZERO. See Gl.BlendFunc and Gl.BlendFuncSeparate.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_EXT_blend_func_separate")]
        [RequiredByFeature("GL_OES_blend_func_separate", Api = "gles1")]
        public const int BLEND_DST_ALPHA = 0x80CA;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the symbolic constant identifying the alpha source blend function. The
        /// initial value is Gl.ONE. See Gl.BlendFunc and Gl.BlendFuncSeparate.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_EXT_blend_func_separate")]
        [RequiredByFeature("GL_OES_blend_func_separate", Api = "gles1")]
        public const int BLEND_SRC_ALPHA = 0x80CB;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the point size threshold for determining the point size. See
        ///     Gl.PointParameter.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.PointParameter: params is a single floating-point value that specifies the threshold value to which point
        ///     sizes
        ///     are clamped if they exceed the specified value. The default value is 1.0.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, the point fade threshold. The initial value is Gl.. See
        ///     Gl.PointParameter.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.PointParameter: param specifies, or params points to the point fade threshold.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_point_parameters")]
        [RequiredByFeature("GL_EXT_point_parameters")]
        [RequiredByFeature("GL_SGIS_point_parameters")]
        public const int POINT_FADE_THRESHOLD_SIZE = 0x8128;

        /// <summary>
        /// [GL] Value of GL_DEPTH_COMPONENT16 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
        [RequiredByFeature("GL_ARB_depth_texture")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        [RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
        [RequiredByFeature("GL_SGIX_depth_texture")]
        public const int DEPTH_COMPONENT16 = 0x81A5;

        /// <summary>
        /// [GL] Value of GL_DEPTH_COMPONENT24 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_depth_texture")]
        [RequiredByFeature("GL_OES_depth24", Api = "gles1|gles2|glsc2")]
        [RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
        [RequiredByFeature("GL_SGIX_depth_texture")]
        public const int DEPTH_COMPONENT24 = 0x81A6;

        /// <summary>
        /// [GL] Value of GL_DEPTH_COMPONENT32 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ARB_depth_texture")]
        [RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
        [RequiredByFeature("GL_OES_depth32", Api = "gles1|gles2|glsc2")]
        [RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
        [RequiredByFeature("GL_SGIX_depth_texture")]
        public const int DEPTH_COMPONENT32 = 0x81A7;

        /// <summary>
        /// [GL] Value of GL_MIRRORED_REPEAT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_texture_mirrored_repeat", Api = "gl|glcore")]
        [RequiredByFeature("GL_IBM_texture_mirrored_repeat")]
        [RequiredByFeature("GL_OES_texture_mirrored_repeat", Api = "gles1")]
        public const int MIRRORED_REPEAT = 0x8370;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum, absolute value of the texture level-of-detail bias. The
        /// value
        /// must be at least 2.0.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture_lod_bias", Api = "gl|gles1")]
        public const int MAX_TEXTURE_LOD_BIAS = 0x84FD;

        /// <summary>
        /// [GL2.1] Gl.GetTexEnv: params returns a single floating-point value that is the texture level-of-detail bias. The
        /// initial
        /// value is 0.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_EXT_texture_lod_bias", Api = "gl|gles1")]
        public const int TEXTURE_LOD_BIAS = 0x8501;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.StencilOp: Increments the current stencil buffer value. Wraps stencil buffer value to zero when
        ///     incrementing the maximum representable unsigned value.
        ///     </para>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.StencilOpSeparate: Increments the current stencil buffer value. Wraps stencil buffer value to zero
        ///     when
        ///     incrementing the maximum representable unsigned value.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_stencil_wrap")]
        [RequiredByFeature("GL_OES_stencil_wrap", Api = "gles1")]
        public const int INCR_WRAP = 0x8507;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.StencilOp: Decrements the current stencil buffer value. Wraps stencil buffer value to the maximum
        ///     representable unsigned value when decrementing a stencil buffer value of zero.
        ///     </para>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.StencilOpSeparate: Decrements the current stencil buffer value. Wraps stencil buffer value to the
        ///     maximum representable unsigned value when decrementing a stencil buffer value of zero.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_stencil_wrap")]
        [RequiredByFeature("GL_OES_stencil_wrap", Api = "gles1")]
        public const int DECR_WRAP = 0x8508;

        /// <summary>
        /// [GL2.1] Gl.GetTexLevelParameter: The internal storage resolution of an individual component. The resolution chosen by
        /// the GL will be a close match for the resolution requested by the user with the component argument of Gl.TexImage1D,
        /// Gl.TexImage2D, Gl.TexImage3D, Gl.CopyTexImage1D, and Gl.CopyTexImage2D. The initial value is 0.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_depth_texture")]
        public const int TEXTURE_DEPTH_SIZE = 0x884A;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetSamplerParameter: Returns a single-valued texture comparison mode, a symbolic constant. The
        ///     initial
        ///     value is Gl.NONE. See Gl.SamplerParameter.
        ///     </para>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetTexParameter: Returns a single-valued texture comparison mode, a symbolic constant. The initial
        ///     value is Gl.NONE. See Gl.TexParameter.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_shadow")] [RequiredByFeature("GL_EXT_shadow_samplers", Api = "gles2")]
        public const int TEXTURE_COMPARE_MODE = 0x884C;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetSamplerParameter: Returns a single-valued texture comparison function, a symbolic constant. The
        ///     initial value is Gl.LEQUAL. See Gl.SamplerParameter.
        ///     </para>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetTexParameter: Returns a single-valued texture comparison function, a symbolic constant. The
        ///     initial
        ///     value is Gl.LEQUAL. See Gl.TexParameter.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_shadow")] [RequiredByFeature("GL_EXT_shadow_samplers", Api = "gles2")]
        public const int TEXTURE_COMPARE_FUNC = 0x884D;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, the lower bound for the attenuated point sizes. The initial value is 1.0.
        ///     See
        ///     Gl.PointParameter.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.PointParameter: params is a single floating-point value that specifies the minimum point size. The
        ///     default
        ///     value is 0.0.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, the lower bound to which the derived point size is clamped. The initial
        ///     value is Gl.. See Gl.PointParameter.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.PointParameter: param specifies, or params points to the lower bound to which the derived point size
        ///     is
        ///     clamped.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_point_parameters")]
        [RequiredByFeature("GL_EXT_point_parameters")]
        [RequiredByFeature("GL_SGIS_point_parameters")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int POINT_SIZE_MIN = 0x8126;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, the upper bound for the attenuated point sizes. The initial value is 0.0.
        ///     See
        ///     Gl.PointParameter.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.PointParameter: params is a single floating-point value that specifies the maximum point size. The
        ///     default
        ///     value is 1.0.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, the upper bound to which the derived point size is clamped. The initial
        ///     value is the maximum of the implementation dependent max aliased and smooth point sizes. See Gl.PointParameter.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.PointParameter: param specifies, or params points to the upper bound to which the derived point size
        ///     is
        ///     clamped.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_point_parameters")]
        [RequiredByFeature("GL_EXT_point_parameters")]
        [RequiredByFeature("GL_SGIS_point_parameters")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int POINT_SIZE_MAX = 0x8127;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns three values, the coefficients for computing the attenuation value for points. See
        ///     Gl.PointParameter.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.PointParameter: params is an array of three floating-point values that specify the coefficients used for
        ///     scaling the computed point size. The default values are 100.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns three values, the distance attenuation function coefficients a, b, and c. The
        ///     initial
        ///     value is (1, 0, 0). See Gl.PointParameter.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.PointParameter: params points to the distance attenuation function coefficients Gl., Gl., and Gl..
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_ARB_point_parameters")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int POINT_DISTANCE_ATTENUATION = 0x8129;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.GetTexParameter: Returns a single boolean value indicating if automatic mipmap level updates are
        ///     enabled. See
        ///     Gl.TexParameter.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexParameter: Specifies a boolean value that indicates if all levels of a mipmap array should be
        ///     automatically updated when any modification to the base level mipmap is done. The initial value is Gl.FALSE.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.GetTexParameter: Returns a single boolean value indicating if automatic mipmap level updates are
        ///     enabled.
        ///     The initial value is Gl.FALSE. See Gl.TexParameter.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.TexParameter: Sets the automatic mipmap generation parameter. If set to Gl.TRUE, making any change to
        ///     the
        ///     interior texels of the levelbase array of a mipmap will also compute a complete set of mipmap arrays derived from
        ///     the
        ///     modified levelbase array. Array levels levelbase+1 through p are replaced with the derived arrays, regardless of
        ///     their
        ///     previous contents. All other mipmap arrays, including the levelbase array, are left unchanged by this
        ///     computation.The
        ///     initial value of Gl.GENERATE_MIPMAP is Gl.FALSE.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_SGIS_generate_mipmap")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int GENERATE_MIPMAP = 0x8191;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, a symbolic constant indicating the mode of the mipmap generation
        ///     filtering
        ///     hint. The initial value is Gl.DONT_CARE. See Gl.Hint.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Hint: Indicates the quality of filtering when generating mipmap images.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, a symbolic constant indicating the mode of the generate mipmap quality
        ///     hint.
        ///     The initial value is Gl.DONT_CARE. See Gl.Hint.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Hint: Indicates the quality of filtering when generating mipmap images with Gl.GenerateMipmap.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_SGIS_generate_mipmap")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int GENERATE_MIPMAP_HINT = 0x8192;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled and no fragment shader is active, add the secondary color value to the computed
        ///     fragment
        ///     color. See Gl.SecondaryColor.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether primary and secondary color sum is
        ///     enabled. See
        ///     Gl.SecondaryColor.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_ARB_vertex_program")] [RequiredByFeature("GL_EXT_secondary_color")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int COLOR_SUM = 0x8458;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns four values: the red, green, blue, and alpha values of the current secondary color.
        /// Integer values, if requested, are linearly mapped from the internal floating-point representation such that 1.0 returns
        /// the most positive representable integer value, and -1.0 returns the most negative representable integer value. The
        /// initial value is (0, 0, 0, 0). See Gl.SecondaryColor.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_EXT_secondary_color")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int CURRENT_SECONDARY_COLOR = 0x8459;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the number of components per color in the secondary color array. The initial
        /// value is 3. See Gl.SecondaryColorPointer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_EXT_secondary_color")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SECONDARY_COLOR_ARRAY_SIZE = 0x845A;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the data type of each component in the secondary color array. The initial
        /// value is Gl.FLOAT. See Gl.SecondaryColorPointer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_EXT_secondary_color")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SECONDARY_COLOR_ARRAY_TYPE = 0x845B;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the byte offset between consecutive colors in the secondary color array. The
        /// initial value is 0. See Gl.SecondaryColorPointer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_EXT_secondary_color")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SECONDARY_COLOR_ARRAY_STRIDE = 0x845C;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.EnableClientState: If enabled, the secondary color array is enabled for writing and used during
        ///     rendering
        ///     when Gl.ArrayElement, Gl.DrawArrays, Gl.DrawElements, Gl.DrawRangeElementsGl.MultiDrawArrays, or
        ///     Gl.MultiDrawElements is
        ///     called. See Gl.ColorPointer.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether the secondary color array is enabled. The
        ///     initial value is Gl.FALSE. See Gl.SecondaryColorPointer.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_EXT_secondary_color")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SECONDARY_COLOR_ARRAY = 0x845E;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.GetTexParameter: Returns a single-valued texture format indicating how the depth values should be
        ///     converted
        ///     into color components. The initial value is Gl.LUMINANCE. See Gl.TexParameter.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexParameter: Specifies a single symbolic constant indicating how depth values should be treated during
        ///     filtering and texture application. Accepted values are Gl.LUMINANCE, Gl.INTENSITY, and Gl.ALPHA. The initial value
        ///     is
        ///     Gl.LUMINANCE.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_ARB_depth_texture")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int DEPTH_TEXTURE_MODE = 0x884B;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns four values, the red, green, blue, and alpha values which are the components of the
        /// blend color. See Gl.BlendColor.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_blend_color")]
        public const int BLEND_COLOR = 0x8005;

        /// <summary>
        /// [GL] Value of GL_BLEND_EQUATION symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_blend_minmax", Api = "gl|gles1|gles2")]
        [RequiredByFeature("GL_OES_blend_subtract", Api = "gles1")]
        public const int BLEND_EQUATION = 0x8009;

        /// <summary>
        /// [GL] Value of GL_CONSTANT_COLOR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_EXT_blend_color")]
        public const int CONSTANT_COLOR = 0x8001;

        /// <summary>
        /// [GL] Value of GL_ONE_MINUS_CONSTANT_COLOR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_EXT_blend_color")]
        public const int ONE_MINUS_CONSTANT_COLOR = 0x8002;

        /// <summary>
        /// [GL] Value of GL_CONSTANT_ALPHA symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_EXT_blend_color")]
        public const int CONSTANT_ALPHA = 0x8003;

        /// <summary>
        /// [GL] Value of GL_ONE_MINUS_CONSTANT_ALPHA symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_EXT_blend_color")]
        public const int ONE_MINUS_CONSTANT_ALPHA = 0x8004;

        /// <summary>
        /// [GL] Value of GL_FUNC_ADD symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_EXT_blend_minmax", Api = "gl|gles1|gles2")]
        [RequiredByFeature("GL_OES_blend_subtract", Api = "gles1")]
        public const int FUNC_ADD = 0x8006;

        /// <summary>
        /// [GL] Value of GL_FUNC_REVERSE_SUBTRACT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_EXT_blend_subtract")]
        [RequiredByFeature("GL_OES_blend_subtract", Api = "gles1")]
        public const int FUNC_REVERSE_SUBTRACT = 0x800B;

        /// <summary>
        /// [GL] Value of GL_FUNC_SUBTRACT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_EXT_blend_subtract")]
        [RequiredByFeature("GL_OES_blend_subtract", Api = "gles1")]
        public const int FUNC_SUBTRACT = 0x800A;

        /// <summary>
        /// [GL] Value of GL_MIN symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_EXT_blend_minmax", Api = "gl|gles1|gles2")]
        public const int MIN = 0x8007;

        /// <summary>
        /// [GL] Value of GL_MAX symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_EXT_blend_minmax", Api = "gl|gles1|gles2")]
        public const int MAX = 0x8008;

        /// <summary>
        /// [GL2.1] glBlendFuncSeparate: specify pixel arithmetic for RGB and alpha components separately
        /// </summary>
        /// <param name="sfactorRGB">
        /// A <see cref="T:BlendingFactor" />.
        /// </param>
        /// <param name="dfactorRGB">
        /// A <see cref="T:BlendingFactor" />.
        /// </param>
        /// <param name="sfactorAlpha">
        /// A <see cref="T:BlendingFactor" />.
        /// </param>
        /// <param name="dfactorAlpha">
        /// A <see cref="T:BlendingFactor" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_blend_func_separate")]
        [RequiredByFeature("GL_INGR_blend_func_separate")]
        public static void BlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha)
        {
            Debug.Assert(Delegates.pglBlendFuncSeparate != null, "pglBlendFuncSeparate not implemented");
            Delegates.pglBlendFuncSeparate((int) sfactorRGB, (int) dfactorRGB, (int) sfactorAlpha, (int) dfactorAlpha);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glMultiDrawArrays: render multiple sets of primitives from array data
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES,
        /// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES,
        /// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY and Gl.PATCHES are accepted.
        /// </param>
        /// <param name="first">
        /// Points to an array of starting indices in the enabled arrays.
        /// </param>
        /// <param name="count">
        /// Points to an array of the number of indices to be rendered.
        /// </param>
        /// <param name="drawcount">
        /// Specifies the size of the first and count
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_multi_draw_arrays", Api = "gl|gles1|gles2")]
        public static void MultiDrawArrays(PrimitiveType mode, int[] first, int[] count, int drawcount)
        {
            unsafe
            {
                fixed (int* p_first = first)
                fixed (int* p_count = count)
                {
                    Debug.Assert(Delegates.pglMultiDrawArrays != null, "pglMultiDrawArrays not implemented");
                    Delegates.pglMultiDrawArrays((int) mode, p_first, p_count, drawcount);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glMultiDrawElements: render multiple sets of primitives by specifying indices of array data elements
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES,
        /// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES,
        /// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY and Gl.PATCHES are accepted.
        /// </param>
        /// <param name="count">
        /// Points to an array of the elements counts.
        /// </param>
        /// <param name="type">
        /// Specifies the type of the values in <paramref name="indices" />. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or
        /// Gl.UNSIGNED_INT.
        /// </param>
        /// <param name="indices">
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        /// <param name="drawcount">
        /// Specifies the size of the <paramref name="count" /> and <paramref name="indices" /> arrays.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_multi_draw_arrays", Api = "gl|gles1|gles2")]
        public static void MultiDrawElements(PrimitiveType mode, int[] count, DrawElementsType type, IntPtr[] indices, int drawcount)
        {
            unsafe
            {
                fixed (int* p_count = count)
                fixed (IntPtr* p_indices = indices)
                {
                    Debug.Assert(Delegates.pglMultiDrawElements != null, "pglMultiDrawElements not implemented");
                    Delegates.pglMultiDrawElements((int) mode, p_count, (int) type, p_indices, drawcount);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glPointParameterf: specify point parameters
        ///     </para>
        ///     <para>
        ///     [GLES1.1] glPointParameterf: specify parameters for point rasterization
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies a single-valued point parameter. Gl.POINT_FADE_THRESHOLD_SIZE, and Gl.POINT_SPRITE_COORD_ORIGIN are accepted.
        /// </param>
        /// <param name="param">
        /// For Gl.PointParameterf and Gl.PointParameteri, specifies the value that <paramref name="pname" /> will be set to.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ARB_point_parameters")]
        [RequiredByFeature("GL_EXT_point_parameters")]
        [RequiredByFeature("GL_SGIS_point_parameters")]
        public static void PointParameter(int pname, float param)
        {
            Debug.Assert(Delegates.pglPointParameterf != null, "pglPointParameterf not implemented");
            Delegates.pglPointParameterf(pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glPointParameterfv: specify point parameters
        ///     </para>
        ///     <para>
        ///     [GLES1.1] glPointParameterfv: specify parameters for point rasterization
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies a single-valued point parameter. Gl.POINT_FADE_THRESHOLD_SIZE, and Gl.POINT_SPRITE_COORD_ORIGIN are accepted.
        /// </param>
        /// <param name="params">
        /// For Gl.PointParameterfv and Gl.PointParameteriv, specifies a pointer to an array where the value or values to be
        /// assigned to <paramref name="pname" /> are stored.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ARB_point_parameters")]
        [RequiredByFeature("GL_EXT_point_parameters")]
        [RequiredByFeature("GL_SGIS_point_parameters")]
        public static void PointParameter(int pname, float[] @params)
        {
            unsafe
            {
                fixed (float* p_params = @params)
                {
                    Debug.Assert(Delegates.pglPointParameterfv != null, "pglPointParameterfv not implemented");
                    Delegates.pglPointParameterfv(pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glPointParameteri: specify point parameters
        /// </summary>
        /// <param name="pname">
        /// Specifies a single-valued point parameter. Gl.POINT_FADE_THRESHOLD_SIZE, and Gl.POINT_SPRITE_COORD_ORIGIN are accepted.
        /// </param>
        /// <param name="param">
        /// For Gl.PointParameterf and Gl.PointParameteri, specifies the value that <paramref name="pname" /> will be set to.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_NV_point_sprite")]
        public static void PointParameter(int pname, int param)
        {
            Debug.Assert(Delegates.pglPointParameteri != null, "pglPointParameteri not implemented");
            Delegates.pglPointParameteri(pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glPointParameteriv: specify point parameters
        /// </summary>
        /// <param name="pname">
        /// Specifies a single-valued point parameter. Gl.POINT_FADE_THRESHOLD_SIZE, and Gl.POINT_SPRITE_COORD_ORIGIN are accepted.
        /// </param>
        /// <param name="params">
        /// For Gl.PointParameterfv and Gl.PointParameteriv, specifies a pointer to an array where the value or values to be
        /// assigned to <paramref name="pname" /> are stored.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_NV_point_sprite")]
        public static void PointParameter(int pname, int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Debug.Assert(Delegates.pglPointParameteriv != null, "pglPointParameteriv not implemented");
                    Delegates.pglPointParameteriv(pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glFogCoordf: set the current fog coordinates
        /// </summary>
        /// <param name="coord">
        /// Specify the fog distance.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_fog_coord")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void FogCoord(float coord)
        {
            Debug.Assert(Delegates.pglFogCoordf != null, "pglFogCoordf not implemented");
            Delegates.pglFogCoordf(coord);
        }

        /// <summary>
        /// [GL2.1] glFogCoordfv: set the current fog coordinates
        /// </summary>
        /// <param name="coord">
        /// Specify the fog distance.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_fog_coord")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void FogCoord(float[] coord)
        {
            Debug.Assert(coord.Length >= 1);
            unsafe
            {
                fixed (float* p_coord = coord)
                {
                    Debug.Assert(Delegates.pglFogCoordfv != null, "pglFogCoordfv not implemented");
                    Delegates.pglFogCoordfv(p_coord);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glFogCoordd: set the current fog coordinates
        /// </summary>
        /// <param name="coord">
        /// Specify the fog distance.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_fog_coord")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void FogCoord(double coord)
        {
            Debug.Assert(Delegates.pglFogCoordd != null, "pglFogCoordd not implemented");
            Delegates.pglFogCoordd(coord);
        }

        /// <summary>
        /// [GL2.1] glFogCoorddv: set the current fog coordinates
        /// </summary>
        /// <param name="coord">
        /// Specify the fog distance.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_fog_coord")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void FogCoord(double[] coord)
        {
            Debug.Assert(coord.Length >= 1);
            unsafe
            {
                fixed (double* p_coord = coord)
                {
                    Debug.Assert(Delegates.pglFogCoorddv != null, "pglFogCoorddv not implemented");
                    Delegates.pglFogCoorddv(p_coord);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glFogCoordPointer: define an array of fog coordinates
        /// </summary>
        /// <param name="type">
        /// Specifies the data type of each fog coordinate. Symbolic constants Gl.FLOAT, or Gl.DOUBLE are accepted. The initial
        /// value is Gl.FLOAT.
        /// </param>
        /// <param name="stride">
        /// Specifies the byte offset between consecutive fog coordinates. If <paramref name="stride" /> is 0, the array elements
        /// are
        /// understood to be tightly packed. The initial value is 0.
        /// </param>
        /// <param name="pointer">
        /// Specifies a pointer to the first coordinate of the first fog coordinate in the array. The initial value is 0.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_fog_coord")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void FogCoordPointer(FogCoordinatePointerType type, int stride, IntPtr pointer)
        {
            Debug.Assert(Delegates.pglFogCoordPointer != null, "pglFogCoordPointer not implemented");
            Delegates.pglFogCoordPointer((int) type, stride, pointer);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glFogCoordPointer: define an array of fog coordinates
        /// </summary>
        /// <param name="type">
        /// Specifies the data type of each fog coordinate. Symbolic constants Gl.FLOAT, or Gl.DOUBLE are accepted. The initial
        /// value is Gl.FLOAT.
        /// </param>
        /// <param name="stride">
        /// Specifies the byte offset between consecutive fog coordinates. If <paramref name="stride" /> is 0, the array elements
        /// are
        /// understood to be tightly packed. The initial value is 0.
        /// </param>
        /// <param name="pointer">
        /// Specifies a pointer to the first coordinate of the first fog coordinate in the array. The initial value is 0.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_fog_coord")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void FogCoordPointer(FogCoordinatePointerType type, int stride, object pointer)
        {
            GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                FogCoordPointer(type, stride, pin_pointer.AddrOfPinnedObject());
            }
            finally
            {
                pin_pointer.Free();
            }
        }

        /// <summary>
        /// [GL2.1] glSecondaryColor3b: set the current secondary color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_secondary_color")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void SecondaryColor3(sbyte red, sbyte green, sbyte blue)
        {
            Debug.Assert(Delegates.pglSecondaryColor3b != null, "pglSecondaryColor3b not implemented");
            Delegates.pglSecondaryColor3b(red, green, blue);
        }

        /// <summary>
        /// [GL2.1] glSecondaryColor3bv: set the current secondary color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:sbyte[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_secondary_color")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void SecondaryColor3(sbyte[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (sbyte* p_v = v)
                {
                    Debug.Assert(Delegates.pglSecondaryColor3bv != null, "pglSecondaryColor3bv not implemented");
                    Delegates.pglSecondaryColor3bv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glSecondaryColor3d: set the current secondary color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_secondary_color")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void SecondaryColor3(double red, double green, double blue)
        {
            Debug.Assert(Delegates.pglSecondaryColor3d != null, "pglSecondaryColor3d not implemented");
            Delegates.pglSecondaryColor3d(red, green, blue);
        }

        /// <summary>
        /// [GL2.1] glSecondaryColor3dv: set the current secondary color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_secondary_color")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void SecondaryColor3(double[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglSecondaryColor3dv != null, "pglSecondaryColor3dv not implemented");
                    Delegates.pglSecondaryColor3dv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glSecondaryColor3f: set the current secondary color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_secondary_color")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void SecondaryColor3(float red, float green, float blue)
        {
            Debug.Assert(Delegates.pglSecondaryColor3f != null, "pglSecondaryColor3f not implemented");
            Delegates.pglSecondaryColor3f(red, green, blue);
        }

        /// <summary>
        /// [GL2.1] glSecondaryColor3fv: set the current secondary color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_secondary_color")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void SecondaryColor3(float[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglSecondaryColor3fv != null, "pglSecondaryColor3fv not implemented");
                    Delegates.pglSecondaryColor3fv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glSecondaryColor3i: set the current secondary color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_secondary_color")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void SecondaryColor3(int red, int green, int blue)
        {
            Debug.Assert(Delegates.pglSecondaryColor3i != null, "pglSecondaryColor3i not implemented");
            Delegates.pglSecondaryColor3i(red, green, blue);
        }

        /// <summary>
        /// [GL2.1] glSecondaryColor3iv: set the current secondary color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_secondary_color")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void SecondaryColor3(int[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglSecondaryColor3iv != null, "pglSecondaryColor3iv not implemented");
                    Delegates.pglSecondaryColor3iv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glSecondaryColor3s: set the current secondary color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_secondary_color")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void SecondaryColor3(short red, short green, short blue)
        {
            Debug.Assert(Delegates.pglSecondaryColor3s != null, "pglSecondaryColor3s not implemented");
            Delegates.pglSecondaryColor3s(red, green, blue);
        }

        /// <summary>
        /// [GL2.1] glSecondaryColor3sv: set the current secondary color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_secondary_color")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void SecondaryColor3(short[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglSecondaryColor3sv != null, "pglSecondaryColor3sv not implemented");
                    Delegates.pglSecondaryColor3sv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glSecondaryColor3ub: set the current secondary color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_secondary_color")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void SecondaryColor3(byte red, byte green, byte blue)
        {
            Debug.Assert(Delegates.pglSecondaryColor3ub != null, "pglSecondaryColor3ub not implemented");
            Delegates.pglSecondaryColor3ub(red, green, blue);
        }

        /// <summary>
        /// [GL2.1] glSecondaryColor3ubv: set the current secondary color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:byte[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_secondary_color")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void SecondaryColor3(byte[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (byte* p_v = v)
                {
                    Debug.Assert(Delegates.pglSecondaryColor3ubv != null, "pglSecondaryColor3ubv not implemented");
                    Delegates.pglSecondaryColor3ubv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glSecondaryColor3ui: set the current secondary color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_secondary_color")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void SecondaryColor3(uint red, uint green, uint blue)
        {
            Debug.Assert(Delegates.pglSecondaryColor3ui != null, "pglSecondaryColor3ui not implemented");
            Delegates.pglSecondaryColor3ui(red, green, blue);
        }

        /// <summary>
        /// [GL2.1] glSecondaryColor3uiv: set the current secondary color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_secondary_color")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void SecondaryColor3(uint[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (uint* p_v = v)
                {
                    Debug.Assert(Delegates.pglSecondaryColor3uiv != null, "pglSecondaryColor3uiv not implemented");
                    Delegates.pglSecondaryColor3uiv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glSecondaryColor3us: set the current secondary color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current secondary color.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_secondary_color")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void SecondaryColor3(ushort red, ushort green, ushort blue)
        {
            Debug.Assert(Delegates.pglSecondaryColor3us != null, "pglSecondaryColor3us not implemented");
            Delegates.pglSecondaryColor3us(red, green, blue);
        }

        /// <summary>
        /// [GL2.1] glSecondaryColor3usv: set the current secondary color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:ushort[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_secondary_color")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void SecondaryColor3(ushort[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (ushort* p_v = v)
                {
                    Debug.Assert(Delegates.pglSecondaryColor3usv != null, "pglSecondaryColor3usv not implemented");
                    Delegates.pglSecondaryColor3usv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glSecondaryColorPointer: define an array of secondary colors
        /// </summary>
        /// <param name="size">
        /// Specifies the number of components per color. Must be 3.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of each color component in the array. Symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT,
        /// Gl.UNSIGNED_SHORT, Gl.INT, Gl.UNSIGNED_INT, Gl.FLOAT, or Gl.DOUBLE are accepted. The initial value is Gl.FLOAT.
        /// </param>
        /// <param name="stride">
        /// Specifies the byte offset between consecutive colors. If <paramref name="stride" /> is 0, the colors are understood to
        /// be
        /// tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_secondary_color")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void SecondaryColorPointer(int size, ColorPointerType type, int stride, IntPtr pointer)
        {
            Debug.Assert(Delegates.pglSecondaryColorPointer != null, "pglSecondaryColorPointer not implemented");
            Delegates.pglSecondaryColorPointer(size, (int) type, stride, pointer);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glSecondaryColorPointer: define an array of secondary colors
        /// </summary>
        /// <param name="size">
        /// Specifies the number of components per color. Must be 3.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of each color component in the array. Symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT,
        /// Gl.UNSIGNED_SHORT, Gl.INT, Gl.UNSIGNED_INT, Gl.FLOAT, or Gl.DOUBLE are accepted. The initial value is Gl.FLOAT.
        /// </param>
        /// <param name="stride">
        /// Specifies the byte offset between consecutive colors. If <paramref name="stride" /> is 0, the colors are understood to
        /// be
        /// tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_EXT_secondary_color")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void SecondaryColorPointer(int size, ColorPointerType type, int stride, object pointer)
        {
            GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                SecondaryColorPointer(size, type, stride, pin_pointer.AddrOfPinnedObject());
            }
            finally
            {
                pin_pointer.Free();
            }
        }

        /// <summary>
        /// [GL2.1] glWindowPos2d: specify the raster position in window coordinates for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ARB_window_pos")]
        [RequiredByFeature("GL_MESA_window_pos")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void WindowPos2(double x, double y)
        {
            Debug.Assert(Delegates.pglWindowPos2d != null, "pglWindowPos2d not implemented");
            Delegates.pglWindowPos2d(x, y);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glWindowPos2dv: specify the raster position in window coordinates for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ARB_window_pos")]
        [RequiredByFeature("GL_MESA_window_pos")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void WindowPos2(double[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglWindowPos2dv != null, "pglWindowPos2dv not implemented");
                    Delegates.pglWindowPos2dv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glWindowPos2f: specify the raster position in window coordinates for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ARB_window_pos")]
        [RequiredByFeature("GL_MESA_window_pos")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void WindowPos2(float x, float y)
        {
            Debug.Assert(Delegates.pglWindowPos2f != null, "pglWindowPos2f not implemented");
            Delegates.pglWindowPos2f(x, y);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glWindowPos2fv: specify the raster position in window coordinates for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ARB_window_pos")]
        [RequiredByFeature("GL_MESA_window_pos")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void WindowPos2(float[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglWindowPos2fv != null, "pglWindowPos2fv not implemented");
                    Delegates.pglWindowPos2fv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glWindowPos2i: specify the raster position in window coordinates for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ARB_window_pos")]
        [RequiredByFeature("GL_MESA_window_pos")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void WindowPos2(int x, int y)
        {
            Debug.Assert(Delegates.pglWindowPos2i != null, "pglWindowPos2i not implemented");
            Delegates.pglWindowPos2i(x, y);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glWindowPos2iv: specify the raster position in window coordinates for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ARB_window_pos")]
        [RequiredByFeature("GL_MESA_window_pos")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void WindowPos2(int[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglWindowPos2iv != null, "pglWindowPos2iv not implemented");
                    Delegates.pglWindowPos2iv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glWindowPos2s: specify the raster position in window coordinates for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ARB_window_pos")]
        [RequiredByFeature("GL_MESA_window_pos")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void WindowPos2(short x, short y)
        {
            Debug.Assert(Delegates.pglWindowPos2s != null, "pglWindowPos2s not implemented");
            Delegates.pglWindowPos2s(x, y);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glWindowPos2sv: specify the raster position in window coordinates for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ARB_window_pos")]
        [RequiredByFeature("GL_MESA_window_pos")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void WindowPos2(short[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglWindowPos2sv != null, "pglWindowPos2sv not implemented");
                    Delegates.pglWindowPos2sv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glWindowPos3d: specify the raster position in window coordinates for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        /// <param name="z">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ARB_window_pos")]
        [RequiredByFeature("GL_MESA_window_pos")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void WindowPos3(double x, double y, double z)
        {
            Debug.Assert(Delegates.pglWindowPos3d != null, "pglWindowPos3d not implemented");
            Delegates.pglWindowPos3d(x, y, z);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glWindowPos3dv: specify the raster position in window coordinates for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ARB_window_pos")]
        [RequiredByFeature("GL_MESA_window_pos")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void WindowPos3(double[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglWindowPos3dv != null, "pglWindowPos3dv not implemented");
                    Delegates.pglWindowPos3dv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glWindowPos3f: specify the raster position in window coordinates for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        /// <param name="z">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ARB_window_pos")]
        [RequiredByFeature("GL_MESA_window_pos")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void WindowPos3(float x, float y, float z)
        {
            Debug.Assert(Delegates.pglWindowPos3f != null, "pglWindowPos3f not implemented");
            Delegates.pglWindowPos3f(x, y, z);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glWindowPos3fv: specify the raster position in window coordinates for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ARB_window_pos")]
        [RequiredByFeature("GL_MESA_window_pos")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void WindowPos3(float[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglWindowPos3fv != null, "pglWindowPos3fv not implemented");
                    Delegates.pglWindowPos3fv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glWindowPos3i: specify the raster position in window coordinates for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        /// <param name="z">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ARB_window_pos")]
        [RequiredByFeature("GL_MESA_window_pos")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void WindowPos3(int x, int y, int z)
        {
            Debug.Assert(Delegates.pglWindowPos3i != null, "pglWindowPos3i not implemented");
            Delegates.pglWindowPos3i(x, y, z);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glWindowPos3iv: specify the raster position in window coordinates for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ARB_window_pos")]
        [RequiredByFeature("GL_MESA_window_pos")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void WindowPos3(int[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglWindowPos3iv != null, "pglWindowPos3iv not implemented");
                    Delegates.pglWindowPos3iv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glWindowPos3s: specify the raster position in window coordinates for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        /// <param name="z">
        /// Specify the x, y, z coordinates for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ARB_window_pos")]
        [RequiredByFeature("GL_MESA_window_pos")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void WindowPos3(short x, short y, short z)
        {
            Debug.Assert(Delegates.pglWindowPos3s != null, "pglWindowPos3s not implemented");
            Delegates.pglWindowPos3s(x, y, z);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glWindowPos3sv: specify the raster position in window coordinates for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ARB_window_pos")]
        [RequiredByFeature("GL_MESA_window_pos")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void WindowPos3(short[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglWindowPos3sv != null, "pglWindowPos3sv not implemented");
                    Delegates.pglWindowPos3sv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glBlendColor: set the blend color
        ///     </para>
        /// </summary>
        /// <param name="red">
        /// specify the components of Gl.BLEND_COLOR
        /// </param>
        /// <param name="green">
        /// specify the components of Gl.BLEND_COLOR
        /// </param>
        /// <param name="blue">
        /// specify the components of Gl.BLEND_COLOR
        /// </param>
        /// <param name="alpha">
        /// specify the components of Gl.BLEND_COLOR
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_blend_color")]
        public static void BlendColor(float red, float green, float blue, float alpha)
        {
            Debug.Assert(Delegates.pglBlendColor != null, "pglBlendColor not implemented");
            Delegates.pglBlendColor(red, green, blue, alpha);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glBlendEquation: specify the equation used for both the RGB blend equation and the Alpha blend equation
        /// </summary>
        /// <param name="mode">
        /// specifies how source and destination colors are combined. It must be Gl.FUNC_ADD, Gl.FUNC_SUBTRACT,
        /// Gl.FUNC_REVERSE_SUBTRACT, Gl.MIN, Gl.MAX.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_blend_minmax")]
        public static void BlendEquation(BlendEquationMode mode)
        {
            Debug.Assert(Delegates.pglBlendEquation != null, "pglBlendEquation not implemented");
            Delegates.pglBlendEquation((int) mode);
            DebugCheckErrors(null);
        }

        public static unsafe partial class Delegates
        {
            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_EXT_blend_func_separate")]
            [RequiredByFeature("GL_INGR_blend_func_separate")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBlendFuncSeparate(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_EXT_blend_func_separate", EntryPoint = "glBlendFuncSeparateEXT")]
            [RequiredByFeature("GL_INGR_blend_func_separate", EntryPoint = "glBlendFuncSeparateINGR")]
            [ThreadStatic]
            public static glBlendFuncSeparate pglBlendFuncSeparate;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_multi_draw_arrays", Api = "gl|gles1|gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glMultiDrawArrays(int mode, int* first, int* count, int drawcount);

            [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_EXT_multi_draw_arrays", Api = "gl|gles1|gles2", EntryPoint = "glMultiDrawArraysEXT")] [ThreadStatic]
            public static glMultiDrawArrays pglMultiDrawArrays;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_multi_draw_arrays", Api = "gl|gles1|gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glMultiDrawElements(int mode, int* count, int type, IntPtr* indices, int drawcount);

            [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_EXT_multi_draw_arrays", Api = "gl|gles1|gles2", EntryPoint = "glMultiDrawElementsEXT")] [ThreadStatic]
            public static glMultiDrawElements pglMultiDrawElements;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ARB_point_parameters")]
            [RequiredByFeature("GL_EXT_point_parameters")]
            [RequiredByFeature("GL_SGIS_point_parameters")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glPointParameterf(int pname, float param);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ARB_point_parameters", EntryPoint = "glPointParameterfARB")]
            [RequiredByFeature("GL_EXT_point_parameters", EntryPoint = "glPointParameterfEXT")]
            [RequiredByFeature("GL_SGIS_point_parameters", EntryPoint = "glPointParameterfSGIS")]
            [ThreadStatic]
            public static glPointParameterf pglPointParameterf;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ARB_point_parameters")]
            [RequiredByFeature("GL_EXT_point_parameters")]
            [RequiredByFeature("GL_SGIS_point_parameters")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glPointParameterfv(int pname, float* @params);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ARB_point_parameters", EntryPoint = "glPointParameterfvARB")]
            [RequiredByFeature("GL_EXT_point_parameters", EntryPoint = "glPointParameterfvEXT")]
            [RequiredByFeature("GL_SGIS_point_parameters", EntryPoint = "glPointParameterfvSGIS")]
            [ThreadStatic]
            public static glPointParameterfv pglPointParameterfv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_NV_point_sprite")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glPointParameteri(int pname, int param);

            [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_NV_point_sprite", EntryPoint = "glPointParameteriNV")] [ThreadStatic]
            public static glPointParameteri pglPointParameteri;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_NV_point_sprite")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glPointParameteriv(int pname, int* @params);

            [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_NV_point_sprite", EntryPoint = "glPointParameterivNV")] [ThreadStatic]
            public static glPointParameteriv pglPointParameteriv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_fog_coord")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glFogCoordf(float coord);

            [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_EXT_fog_coord", EntryPoint = "glFogCoordfEXT")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            public static glFogCoordf pglFogCoordf;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_fog_coord")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glFogCoordfv(float* coord);

            [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_EXT_fog_coord", EntryPoint = "glFogCoordfvEXT")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            public static glFogCoordfv pglFogCoordfv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_fog_coord")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glFogCoordd(double coord);

            [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_EXT_fog_coord", EntryPoint = "glFogCoorddEXT")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            public static glFogCoordd pglFogCoordd;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_fog_coord")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glFogCoorddv(double* coord);

            [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_EXT_fog_coord", EntryPoint = "glFogCoorddvEXT")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            public static glFogCoorddv pglFogCoorddv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_fog_coord")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glFogCoordPointer(int type, int stride, IntPtr pointer);

            [RequiredByFeature("GL_VERSION_1_4")] [RequiredByFeature("GL_EXT_fog_coord", EntryPoint = "glFogCoordPointerEXT")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            public static glFogCoordPointer pglFogCoordPointer;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSecondaryColor3b(sbyte red, sbyte green, sbyte blue);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color", EntryPoint = "glSecondaryColor3bEXT")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glSecondaryColor3b pglSecondaryColor3b;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSecondaryColor3bv(sbyte* v);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color", EntryPoint = "glSecondaryColor3bvEXT")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glSecondaryColor3bv pglSecondaryColor3bv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSecondaryColor3d(double red, double green, double blue);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color", EntryPoint = "glSecondaryColor3dEXT")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glSecondaryColor3d pglSecondaryColor3d;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSecondaryColor3dv(double* v);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color", EntryPoint = "glSecondaryColor3dvEXT")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glSecondaryColor3dv pglSecondaryColor3dv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSecondaryColor3f(float red, float green, float blue);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color", EntryPoint = "glSecondaryColor3fEXT")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glSecondaryColor3f pglSecondaryColor3f;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSecondaryColor3fv(float* v);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color", EntryPoint = "glSecondaryColor3fvEXT")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glSecondaryColor3fv pglSecondaryColor3fv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSecondaryColor3i(int red, int green, int blue);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color", EntryPoint = "glSecondaryColor3iEXT")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glSecondaryColor3i pglSecondaryColor3i;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSecondaryColor3iv(int* v);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color", EntryPoint = "glSecondaryColor3ivEXT")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glSecondaryColor3iv pglSecondaryColor3iv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSecondaryColor3s(short red, short green, short blue);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color", EntryPoint = "glSecondaryColor3sEXT")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glSecondaryColor3s pglSecondaryColor3s;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSecondaryColor3sv(short* v);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color", EntryPoint = "glSecondaryColor3svEXT")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glSecondaryColor3sv pglSecondaryColor3sv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSecondaryColor3ub(byte red, byte green, byte blue);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color", EntryPoint = "glSecondaryColor3ubEXT")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glSecondaryColor3ub pglSecondaryColor3ub;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSecondaryColor3ubv(byte* v);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color", EntryPoint = "glSecondaryColor3ubvEXT")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glSecondaryColor3ubv pglSecondaryColor3ubv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSecondaryColor3ui(uint red, uint green, uint blue);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color", EntryPoint = "glSecondaryColor3uiEXT")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glSecondaryColor3ui pglSecondaryColor3ui;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSecondaryColor3uiv(uint* v);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color", EntryPoint = "glSecondaryColor3uivEXT")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glSecondaryColor3uiv pglSecondaryColor3uiv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSecondaryColor3us(ushort red, ushort green, ushort blue);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color", EntryPoint = "glSecondaryColor3usEXT")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glSecondaryColor3us pglSecondaryColor3us;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSecondaryColor3usv(ushort* v);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color", EntryPoint = "glSecondaryColor3usvEXT")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glSecondaryColor3usv pglSecondaryColor3usv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSecondaryColorPointer(int size, int type, int stride, IntPtr pointer);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_EXT_secondary_color", EntryPoint = "glSecondaryColorPointerEXT")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glSecondaryColorPointer pglSecondaryColorPointer;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos")]
            [RequiredByFeature("GL_MESA_window_pos")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glWindowPos2d(double x, double y);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos", EntryPoint = "glWindowPos2dARB")]
            [RequiredByFeature("GL_MESA_window_pos", EntryPoint = "glWindowPos2dMESA")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glWindowPos2d pglWindowPos2d;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos")]
            [RequiredByFeature("GL_MESA_window_pos")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glWindowPos2dv(double* v);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos", EntryPoint = "glWindowPos2dvARB")]
            [RequiredByFeature("GL_MESA_window_pos", EntryPoint = "glWindowPos2dvMESA")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glWindowPos2dv pglWindowPos2dv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos")]
            [RequiredByFeature("GL_MESA_window_pos")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glWindowPos2f(float x, float y);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos", EntryPoint = "glWindowPos2fARB")]
            [RequiredByFeature("GL_MESA_window_pos", EntryPoint = "glWindowPos2fMESA")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glWindowPos2f pglWindowPos2f;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos")]
            [RequiredByFeature("GL_MESA_window_pos")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glWindowPos2fv(float* v);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos", EntryPoint = "glWindowPos2fvARB")]
            [RequiredByFeature("GL_MESA_window_pos", EntryPoint = "glWindowPos2fvMESA")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glWindowPos2fv pglWindowPos2fv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos")]
            [RequiredByFeature("GL_MESA_window_pos")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glWindowPos2i(int x, int y);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos", EntryPoint = "glWindowPos2iARB")]
            [RequiredByFeature("GL_MESA_window_pos", EntryPoint = "glWindowPos2iMESA")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glWindowPos2i pglWindowPos2i;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos")]
            [RequiredByFeature("GL_MESA_window_pos")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glWindowPos2iv(int* v);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos", EntryPoint = "glWindowPos2ivARB")]
            [RequiredByFeature("GL_MESA_window_pos", EntryPoint = "glWindowPos2ivMESA")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glWindowPos2iv pglWindowPos2iv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos")]
            [RequiredByFeature("GL_MESA_window_pos")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glWindowPos2s(short x, short y);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos", EntryPoint = "glWindowPos2sARB")]
            [RequiredByFeature("GL_MESA_window_pos", EntryPoint = "glWindowPos2sMESA")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glWindowPos2s pglWindowPos2s;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos")]
            [RequiredByFeature("GL_MESA_window_pos")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glWindowPos2sv(short* v);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos", EntryPoint = "glWindowPos2svARB")]
            [RequiredByFeature("GL_MESA_window_pos", EntryPoint = "glWindowPos2svMESA")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glWindowPos2sv pglWindowPos2sv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos")]
            [RequiredByFeature("GL_MESA_window_pos")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glWindowPos3d(double x, double y, double z);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos", EntryPoint = "glWindowPos3dARB")]
            [RequiredByFeature("GL_MESA_window_pos", EntryPoint = "glWindowPos3dMESA")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glWindowPos3d pglWindowPos3d;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos")]
            [RequiredByFeature("GL_MESA_window_pos")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glWindowPos3dv(double* v);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos", EntryPoint = "glWindowPos3dvARB")]
            [RequiredByFeature("GL_MESA_window_pos", EntryPoint = "glWindowPos3dvMESA")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glWindowPos3dv pglWindowPos3dv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos")]
            [RequiredByFeature("GL_MESA_window_pos")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glWindowPos3f(float x, float y, float z);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos", EntryPoint = "glWindowPos3fARB")]
            [RequiredByFeature("GL_MESA_window_pos", EntryPoint = "glWindowPos3fMESA")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glWindowPos3f pglWindowPos3f;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos")]
            [RequiredByFeature("GL_MESA_window_pos")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glWindowPos3fv(float* v);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos", EntryPoint = "glWindowPos3fvARB")]
            [RequiredByFeature("GL_MESA_window_pos", EntryPoint = "glWindowPos3fvMESA")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glWindowPos3fv pglWindowPos3fv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos")]
            [RequiredByFeature("GL_MESA_window_pos")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glWindowPos3i(int x, int y, int z);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos", EntryPoint = "glWindowPos3iARB")]
            [RequiredByFeature("GL_MESA_window_pos", EntryPoint = "glWindowPos3iMESA")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glWindowPos3i pglWindowPos3i;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos")]
            [RequiredByFeature("GL_MESA_window_pos")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glWindowPos3iv(int* v);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos", EntryPoint = "glWindowPos3ivARB")]
            [RequiredByFeature("GL_MESA_window_pos", EntryPoint = "glWindowPos3ivMESA")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glWindowPos3iv pglWindowPos3iv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos")]
            [RequiredByFeature("GL_MESA_window_pos")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glWindowPos3s(short x, short y, short z);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos", EntryPoint = "glWindowPos3sARB")]
            [RequiredByFeature("GL_MESA_window_pos", EntryPoint = "glWindowPos3sMESA")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glWindowPos3s pglWindowPos3s;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos")]
            [RequiredByFeature("GL_MESA_window_pos")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glWindowPos3sv(short* v);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ARB_window_pos", EntryPoint = "glWindowPos3svARB")]
            [RequiredByFeature("GL_MESA_window_pos", EntryPoint = "glWindowPos3svMESA")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            public static glWindowPos3sv pglWindowPos3sv;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_blend_color")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBlendColor(float red, float green, float blue, float alpha);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_blend_color", EntryPoint = "glBlendColorEXT")]
            [ThreadStatic]
            public static glBlendColor pglBlendColor;

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_blend_minmax")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBlendEquation(int mode);

            [RequiredByFeature("GL_VERSION_1_4")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_blend_minmax", EntryPoint = "glBlendEquationEXT")]
            [ThreadStatic]
            public static glBlendEquation pglBlendEquation;
        }
    }
}