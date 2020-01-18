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
        /// [GL] Value of GL_TEXTURE0 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RequiredByFeature("GL_NV_register_combiners")]
        public const int TEXTURE0 = 0x84C0;

        /// <summary>
        /// [GL] Value of GL_TEXTURE1 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RequiredByFeature("GL_NV_register_combiners")]
        public const int TEXTURE1 = 0x84C1;

        /// <summary>
        /// [GL] Value of GL_TEXTURE2 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE2 = 0x84C2;

        /// <summary>
        /// [GL] Value of GL_TEXTURE3 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE3 = 0x84C3;

        /// <summary>
        /// [GL] Value of GL_TEXTURE4 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE4 = 0x84C4;

        /// <summary>
        /// [GL] Value of GL_TEXTURE5 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE5 = 0x84C5;

        /// <summary>
        /// [GL] Value of GL_TEXTURE6 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE6 = 0x84C6;

        /// <summary>
        /// [GL] Value of GL_TEXTURE7 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE7 = 0x84C7;

        /// <summary>
        /// [GL] Value of GL_TEXTURE8 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE8 = 0x84C8;

        /// <summary>
        /// [GL] Value of GL_TEXTURE9 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE9 = 0x84C9;

        /// <summary>
        /// [GL] Value of GL_TEXTURE10 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE10 = 0x84CA;

        /// <summary>
        /// [GL] Value of GL_TEXTURE11 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE11 = 0x84CB;

        /// <summary>
        /// [GL] Value of GL_TEXTURE12 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE12 = 0x84CC;

        /// <summary>
        /// [GL] Value of GL_TEXTURE13 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE13 = 0x84CD;

        /// <summary>
        /// [GL] Value of GL_TEXTURE14 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE14 = 0x84CE;

        /// <summary>
        /// [GL] Value of GL_TEXTURE15 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE15 = 0x84CF;

        /// <summary>
        /// [GL] Value of GL_TEXTURE16 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE16 = 0x84D0;

        /// <summary>
        /// [GL] Value of GL_TEXTURE17 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE17 = 0x84D1;

        /// <summary>
        /// [GL] Value of GL_TEXTURE18 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE18 = 0x84D2;

        /// <summary>
        /// [GL] Value of GL_TEXTURE19 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE19 = 0x84D3;

        /// <summary>
        /// [GL] Value of GL_TEXTURE20 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE20 = 0x84D4;

        /// <summary>
        /// [GL] Value of GL_TEXTURE21 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE21 = 0x84D5;

        /// <summary>
        /// [GL] Value of GL_TEXTURE22 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE22 = 0x84D6;

        /// <summary>
        /// [GL] Value of GL_TEXTURE23 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE23 = 0x84D7;

        /// <summary>
        /// [GL] Value of GL_TEXTURE24 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE24 = 0x84D8;

        /// <summary>
        /// [GL] Value of GL_TEXTURE25 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE25 = 0x84D9;

        /// <summary>
        /// [GL] Value of GL_TEXTURE26 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE26 = 0x84DA;

        /// <summary>
        /// [GL] Value of GL_TEXTURE27 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE27 = 0x84DB;

        /// <summary>
        /// [GL] Value of GL_TEXTURE28 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE28 = 0x84DC;

        /// <summary>
        /// [GL] Value of GL_TEXTURE29 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE29 = 0x84DD;

        /// <summary>
        /// [GL] Value of GL_TEXTURE30 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE30 = 0x84DE;

        /// <summary>
        /// [GL] Value of GL_TEXTURE31 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int TEXTURE31 = 0x84DF;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single value indicating the active multitexture unit. The initial value is
        /// Gl.TEXTURE0. See Gl.ActiveTexture.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public const int ACTIVE_TEXTURE = 0x84E0;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, use multiple fragment samples in computing the final color of a pixel. See
        ///     Gl.SampleCoverage.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Enable: If enabled, use multiple fragment samples in computing the final color of a pixel. See
        ///     Gl.SampleCoverage.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns a single boolean value indicating whether multisampling is enabled. The initial
        ///     value
        ///     is Gl.TRUE.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_multisample")]
        [RequiredByFeature("GL_EXT_multisample")]
        [RequiredByFeature("GL_EXT_multisampled_compatibility", Api = "gles2")]
        [RequiredByFeature("GL_SGIS_multisample")]
        public const int MULTISAMPLE = 0x809D;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, compute a temporary coverage value where each bit is determined by the alpha value
        ///     at the
        ///     corresponding sample location. The temporary coverage value is then ANDed with the fragment coverage value.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns a single boolean value indicating whether modification of sample coverage based on
        ///     alpha
        ///     is enabled. The initial value is Gl.FALSE. See Gl.SampleCoverage.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multisample")]
        public const int SAMPLE_ALPHA_TO_COVERAGE = 0x809E;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, each sample alpha value is replaced by the maximum representable alpha value.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Enable: If enabled, each sample alpha value is replaced by the maximum representable alpha value.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns a single boolean value indicating if the fragment's alpha value should be replaced
        ///     by
        ///     the maximum representable alpha value after coverage determination. The initial value is Gl.FALSE. See
        ///     Gl.SampleCoverage.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_multisample")]
        [RequiredByFeature("GL_EXT_multisample")]
        [RequiredByFeature("GL_EXT_multisampled_compatibility", Api = "gles2")]
        [RequiredByFeature("GL_SGIS_multisample")]
        public const int SAMPLE_ALPHA_TO_ONE = 0x809F;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, the fragment's coverage is ANDed with the temporary coverage value. If
        ///     Gl.SAMPLE_COVERAGE_INVERT is set to Gl.TRUE, invert the coverage value. See Gl.SampleCoverage.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns a single boolean value indicating whether modification of sample coverage based on
        ///     the
        ///     value specified by Gl.SampleCoverage is enabled. The initial value is Gl.FALSE.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multisample")]
        public const int SAMPLE_COVERAGE = 0x80A0;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns a single integer value indicating the number of sample buffers associated with the
        ///     framebuffer. See Gl.SampleCoverage.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetFramebufferParameter: param returns an integer value indicating the number of sample buffers associated
        ///     with
        ///     the framebuffer object. See Gl.SampleCoverage.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns a single integer value indicating the number of sample buffers associated with the
        ///     framebuffer. See Gl.SampleCoverage.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multisample")]
        [RequiredByFeature("GL_EXT_multisample")]
        [RequiredByFeature("GL_SGIS_multisample")]
        public const int SAMPLE_BUFFERS = 0x80A8;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns a single integer value indicating the coverage mask size. See Gl.SampleCoverage.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetFramebufferParameter: param returns an integer value indicating the coverage mask size for the
        ///     framebuffer
        ///     object. See Gl.SampleCoverage.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns a single integer value indicating the coverage mask size. See Gl.SampleCoverage.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_multisample")]
        [RequiredByFeature("GL_NV_multisample_coverage")]
        [RequiredByFeature("GL_EXT_multisample")]
        [RequiredByFeature("GL_SGIS_multisample")]
        public const int SAMPLES = 0x80A9;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single positive floating-point value indicating the current sample coverage value.
        /// See Gl.SampleCoverage.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multisample")]
        public const int SAMPLE_COVERAGE_VALUE = 0x80AA;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single boolean value indicating if the temporary coverage value should be
        /// inverted.
        /// See Gl.SampleCoverage.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multisample")]
        public const int SAMPLE_COVERAGE_INVERT = 0x80AB;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled and no fragment shader is active, cube-mapped texturing is performed. See
        ///     Gl.TexImage2D.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether cube-mapped texture mapping is enabled.
        ///     The
        ///     initial value is Gl.FALSE. See Gl.TexImage2D.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_cube_map")]
        [RequiredByFeature("GL_EXT_texture_cube_map")]
        [RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
        public const int TEXTURE_CUBE_MAP = 0x8513;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single value, the name of the texture currently bound to the target
        /// Gl.TEXTURE_CUBE_MAP. The initial value is 0. See Gl.BindTexture.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_4_5")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_texture_cube_map")]
        [RequiredByFeature("GL_EXT_texture_cube_map")]
        [RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
        public const int TEXTURE_BINDING_CUBE_MAP = 0x8514;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_CUBE_MAP_POSITIVE_X symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_cube_map")]
        [RequiredByFeature("GL_EXT_texture_cube_map")]
        [RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
        public const int TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_CUBE_MAP_NEGATIVE_X symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_cube_map")]
        [RequiredByFeature("GL_EXT_texture_cube_map")]
        [RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
        public const int TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_CUBE_MAP_POSITIVE_Y symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_cube_map")]
        [RequiredByFeature("GL_EXT_texture_cube_map")]
        [RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
        public const int TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_CUBE_MAP_NEGATIVE_Y symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_cube_map")]
        [RequiredByFeature("GL_EXT_texture_cube_map")]
        [RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
        public const int TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_CUBE_MAP_POSITIVE_Z symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_cube_map")]
        [RequiredByFeature("GL_EXT_texture_cube_map")]
        [RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
        public const int TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_CUBE_MAP_NEGATIVE_Z symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_cube_map")]
        [RequiredByFeature("GL_EXT_texture_cube_map")]
        [RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
        public const int TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;

        /// <summary>
        /// [GL] Value of GL_PROXY_TEXTURE_CUBE_MAP symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_texture_cube_map")] [RequiredByFeature("GL_EXT_texture_cube_map")]
        public const int PROXY_TEXTURE_CUBE_MAP = 0x851B;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value. The value gives a rough estimate of the largest cube-map texture that the GL
        ///     can
        ///     handle. The value must be at least 1024. Use Gl.PROXY_TEXTURE_CUBE_MAP to determine if a texture is too large. See
        ///     Gl.TexImage2D.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value. The value gives a rough estimate of the largest cube-map texture that the
        ///     GL
        ///     can handle. The value must be at least 2048. See Gl.TexImage2D.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_cube_map")]
        [RequiredByFeature("GL_EXT_texture_cube_map")]
        [RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
        public const int MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_RGB symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_texture_compression")]
        public const int COMPRESSED_RGB = 0x84ED;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_RGBA symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_texture_compression")]
        public const int COMPRESSED_RGBA = 0x84EE;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns a single value indicating the mode of the texture compression hint. The initial value is
        ///     Gl.DONT_CARE.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.Hint: Indicates the quality and performance of the compressing texture images. Hinting Gl.FASTEST
        ///     indicates
        ///     that texture images should be compressed as quickly as possible, while Gl.NICEST indicates that texture images
        ///     should be
        ///     compressed with as little image quality loss as possible. Gl.NICEST should be selected if the texture is to be
        ///     retrieved
        ///     by Gl.GetCompressedTexImage for reuse.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_texture_compression")]
        public const int TEXTURE_COMPRESSION_HINT = 0x84EF;

        /// <summary>
        /// [GL4] Gl.GetTexLevelParameter: params returns a single integer value, the number of unsigned bytes of the compressed
        /// texture image that would be returned from Gl.GetCompressedTexImage.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_texture_compression")]
        public const int TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetTexLevelParameter: params returns a single boolean value indicating if the texture image is stored in a
        ///     compressed internal format. The initiali value is Gl.FALSE.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetTexLevelParameter: params returns a single boolean value indicating if the texture image is stored
        ///     in a
        ///     compressed internal format.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_texture_compression")]
        public const int TEXTURE_COMPRESSED = 0x86A1;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns a single integer value indicating the number of available compressed texture formats.
        ///     The
        ///     minimum value is 4. See Gl.CompressedTexImage2D.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns a single integer value indicating the number of available compressed texture
        ///     formats. The
        ///     minimum value is 38. See Gl.CompressedTexImage2D.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_texture_compression")]
        public const int NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a list of symbolic constants of length Gl.NUM_COMPRESSED_TEXTURE_FORMATS indicating
        /// which compressed texture formats are available. See Gl.CompressedTexImage2D.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_texture_compression")]
        public const int COMPRESSED_TEXTURE_FORMATS = 0x86A3;

        /// <summary>
        /// [GL] Value of GL_CLAMP_TO_BORDER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_border_clamp", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_NV_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_SGIS_texture_border_clamp")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public const int CLAMP_TO_BORDER = 0x812D;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single integer value indicating the current client active multitexture unit. The
        ///     initial value is Gl.TEXTURE0. See Gl.ClientActiveTexture.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns a single value indicating the current client active multitexture unit. The initial
        ///     value is Gl.TEXTURE0. See Gl.ClientActiveTexture.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_ARB_multitexture")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int CLIENT_ACTIVE_TEXTURE = 0x84E1;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single value indicating the number of conventional texture units supported. Each
        ///     conventional texture unit includes both a texture coordinate set and a texture image unit. Conventional texture
        ///     units
        ///     may be used for fixed-function (non-shader) rendering. The value must be at least 2. Additional texture coordinate
        ///     sets
        ///     and texture image units may be accessed from vertex and fragment shaders. See Gl.ActiveTexture and
        ///     Gl.ClientActiveTexture.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns a single value indicating the number of texture units supported. The value must be
        ///     at
        ///     least 1. See Gl.ActiveTexture, Gl.ClientActiveTexture and Gl.MultiTexCoord.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_ARB_multitexture")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAX_TEXTURE_UNITS = 0x84E2;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns 16 values, the elements of the modelview matrix in row-major order. See
        /// Gl.LoadTransposeMatrix.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_transpose_matrix")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int TRANSPOSE_MODELVIEW_MATRIX = 0x84E3;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns 16 values, the elements of the projection matrix in row-major order. See
        /// Gl.LoadTransposeMatrix.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_transpose_matrix")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int TRANSPOSE_PROJECTION_MATRIX = 0x84E4;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns 16 values, the elements of the texture matrix in row-major order. See
        /// Gl.LoadTransposeMatrix.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_transpose_matrix")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int TRANSPOSE_TEXTURE_MATRIX = 0x84E5;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns 16 values, the elements of the color matrix in row-major order. See
        /// Gl.LoadTransposeMatrix.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_transpose_matrix")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int TRANSPOSE_COLOR_MATRIX = 0x84E6;

        /// <summary>
        /// [GL] Value of GL_MULTISAMPLE_BIT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multisample")]
        [RequiredByFeature("GL_EXT_multisample")]
        [RequiredByFeature("GL_3DFX_multisample")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const uint MULTISAMPLE_BIT = 0x20000000;

        /// <summary>
        /// [GL] Value of GL_NORMAL_MAP symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_texture_cube_map")]
        [RequiredByFeature("GL_EXT_texture_cube_map")]
        [RequiredByFeature("GL_NV_texgen_reflection")]
        [RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int NORMAL_MAP = 0x8511;

        /// <summary>
        /// [GL] Value of GL_REFLECTION_MAP symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_texture_cube_map")]
        [RequiredByFeature("GL_EXT_texture_cube_map")]
        [RequiredByFeature("GL_NV_texgen_reflection")]
        [RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int REFLECTION_MAP = 0x8512;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_ALPHA symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_texture_compression")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int COMPRESSED_ALPHA = 0x84E9;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_LUMINANCE symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_texture_compression")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int COMPRESSED_LUMINANCE = 0x84EA;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_LUMINANCE_ALPHA symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_texture_compression")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int COMPRESSED_LUMINANCE_ALPHA = 0x84EB;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_INTENSITY symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_texture_compression")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int COMPRESSED_INTENSITY = 0x84EC;

        /// <summary>
        /// [GL] Value of GL_COMBINE symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_texture_env_combine")]
        [RequiredByFeature("GL_EXT_texture_env_combine")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int COMBINE = 0x8570;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.GetTexEnv: params returns a single symbolic constant value representing the current RGB combine
        /// mode.
        /// The initial value is Gl.MODULATE.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_texture_env_combine")]
        [RequiredByFeature("GL_EXT_texture_env_combine")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int COMBINE_RGB = 0x8571;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.GetTexEnv: params returns a single symbolic constant value representing the current alpha combine
        /// mode. The initial value is Gl.MODULATE.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_texture_env_combine")]
        [RequiredByFeature("GL_EXT_texture_env_combine")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int COMBINE_ALPHA = 0x8572;

        /// <summary>
        /// [GL] Value of GL_SOURCE0_RGB symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_texture_env_combine")] [RequiredByFeature("GL_EXT_texture_env_combine")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SOURCE0_RGB = 0x8580;

        /// <summary>
        /// [GL] Value of GL_SOURCE1_RGB symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_texture_env_combine")] [RequiredByFeature("GL_EXT_texture_env_combine")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SOURCE1_RGB = 0x8581;

        /// <summary>
        /// [GL] Value of GL_SOURCE2_RGB symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_texture_env_combine")] [RequiredByFeature("GL_EXT_texture_env_combine")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SOURCE2_RGB = 0x8582;

        /// <summary>
        /// [GL] Value of GL_SOURCE0_ALPHA symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_texture_env_combine")] [RequiredByFeature("GL_EXT_texture_env_combine")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SOURCE0_ALPHA = 0x8588;

        /// <summary>
        /// [GL] Value of GL_SOURCE1_ALPHA symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_texture_env_combine")] [RequiredByFeature("GL_EXT_texture_env_combine")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SOURCE1_ALPHA = 0x8589;

        /// <summary>
        /// [GL] Value of GL_SOURCE2_ALPHA symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_texture_env_combine")] [RequiredByFeature("GL_EXT_texture_env_combine")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SOURCE2_ALPHA = 0x858A;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.GetTexEnv: params returns a single symbolic constant value representing the texture combiner zero's
        /// RGB operand. The initial value is Gl.SRC_COLOR.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_texture_env_combine")]
        [RequiredByFeature("GL_EXT_texture_env_combine")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int OPERAND0_RGB = 0x8590;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.GetTexEnv: params returns a single symbolic constant value representing the texture combiner one's
        /// RGB operand. The initial value is Gl.SRC_COLOR.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_texture_env_combine")]
        [RequiredByFeature("GL_EXT_texture_env_combine")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int OPERAND1_RGB = 0x8591;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.GetTexEnv: params returns a single symbolic constant value representing the texture combiner two's
        /// RGB operand. The initial value is Gl.SRC_ALPHA.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_texture_env_combine")]
        [RequiredByFeature("GL_EXT_texture_env_combine")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int OPERAND2_RGB = 0x8592;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.GetTexEnv: params returns a single symbolic constant value representing the texture combiner zero's
        /// alpha operand. The initial value is Gl.SRC_ALPHA.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_texture_env_combine")]
        [RequiredByFeature("GL_EXT_texture_env_combine")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int OPERAND0_ALPHA = 0x8598;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.GetTexEnv: params returns a single symbolic constant value representing the texture combiner one's
        /// alpha operand. The initial value is Gl.SRC_ALPHA.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_texture_env_combine")]
        [RequiredByFeature("GL_EXT_texture_env_combine")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int OPERAND1_ALPHA = 0x8599;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.GetTexEnv: params returns a single symbolic constant value representing the texture combiner two's
        /// alpha operand. The initial value is Gl.SRC_ALPHA.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_texture_env_combine")]
        [RequiredByFeature("GL_EXT_texture_env_combine")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int OPERAND2_ALPHA = 0x859A;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.GetTexEnv: params returns a single floating-point value representing the current RGB texture
        /// combiner
        /// scaling factor. The initial value is 1.0.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_texture_env_combine")]
        [RequiredByFeature("GL_EXT_texture_env_combine")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int RGB_SCALE = 0x8573;

        /// <summary>
        /// [GL] Value of GL_ADD_SIGNED symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_texture_env_combine")]
        [RequiredByFeature("GL_EXT_texture_env_combine")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int ADD_SIGNED = 0x8574;

        /// <summary>
        /// [GL] Value of GL_INTERPOLATE symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_texture_env_combine")]
        [RequiredByFeature("GL_EXT_texture_env_combine")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int INTERPOLATE = 0x8575;

        /// <summary>
        /// [GL] Value of GL_SUBTRACT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_ARB_texture_env_combine")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SUBTRACT = 0x84E7;

        /// <summary>
        /// [GL] Value of GL_CONSTANT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_texture_env_combine")]
        [RequiredByFeature("GL_EXT_texture_env_combine")]
        [RequiredByFeature("GL_NV_path_rendering", Api = "gl|glcore|gles2")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int CONSTANT = 0x8576;

        /// <summary>
        /// [GL] Value of GL_PRIMARY_COLOR symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_NV_path_rendering", Api = "gl|glcore|gles2")]
        [RequiredByFeature("GL_ARB_texture_env_combine")]
        [RequiredByFeature("GL_EXT_texture_env_combine")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int PRIMARY_COLOR = 0x8577;

        /// <summary>
        /// [GL] Value of GL_PREVIOUS symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_texture_env_combine")]
        [RequiredByFeature("GL_EXT_texture_env_combine")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int PREVIOUS = 0x8578;

        /// <summary>
        /// [GL] Value of GL_DOT3_RGB symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_ARB_texture_env_dot3")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int DOT3_RGB = 0x86AE;

        /// <summary>
        /// [GL] Value of GL_DOT3_RGBA symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_texture_env_dot3")]
        [RequiredByFeature("GL_IMG_texture_env_enhanced_fixed_function", Api = "gles1")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int DOT3_RGBA = 0x86AF;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glActiveTexture: select active texture unit
        ///     </para>
        /// </summary>
        /// <param name="texture">
        /// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at
        /// least 80. <paramref name="texture" /> must be one of Gl.TEXTUREi, where i ranges from zero to the value of
        /// Gl.MAX_COMBINED_TEXTURE_IMAGE_UNITS minus one. The initial value is Gl.TEXTURE0.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multitexture")]
        public static void ActiveTexture(TextureUnit texture)
        {
            Debug.Assert(Delegates.pglActiveTexture != null, "pglActiveTexture not implemented");
            Delegates.pglActiveTexture((int) texture);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glSampleCoverage: specify multisample coverage parameters
        ///     </para>
        /// </summary>
        /// <param name="value">
        /// Specify a single floating-point sample coverage value. The value is clamped to the range 01. The initial value is 1.0.
        /// </param>
        /// <param name="invert">
        /// Specify a single boolean value representing if the coverage masks should be inverted. Gl.TRUE and Gl.FALSE are
        /// accepted.
        /// The initial value is Gl.FALSE.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_multisample")]
        public static void SampleCoverage(float value, bool invert)
        {
            Debug.Assert(Delegates.pglSampleCoverage != null, "pglSampleCoverage not implemented");
            Delegates.pglSampleCoverage(value, invert);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES3.2] glCompressedTexImage3D: specify a three-dimensional texture image in a compressed format
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture. Must be Gl.TEXTURE_3D or Gl.PROXY_TEXTURE_3D.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat">
        /// Specifies the format of the compressed image data stored at address <paramref name="data" />.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture
        /// images
        /// that are at least 16 texels wide.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture
        /// images
        /// that are at least 16 texels high.
        /// </param>
        /// <param name="depth">
        /// Specifies the depth of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture
        /// images
        /// that are at least 16 texels deep.
        /// </param>
        /// <param name="border">
        /// Specifies the width of the border. Must be either 0 or 1.
        /// </param>
        /// <param name="imageSize">
        /// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_compression")]
        public static void CompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
        {
            Debug.Assert(Delegates.pglCompressedTexImage3D != null, "pglCompressedTexImage3D not implemented");
            Delegates.pglCompressedTexImage3D((int) target, level, (int) internalformat, width, height, depth, border, imageSize, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES3.2] glCompressedTexImage3D: specify a three-dimensional texture image in a compressed format
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture. Must be Gl.TEXTURE_3D or Gl.PROXY_TEXTURE_3D.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat">
        /// Specifies the format of the compressed image data stored at address <paramref name="data" />.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture
        /// images
        /// that are at least 16 texels wide.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture
        /// images
        /// that are at least 16 texels high.
        /// </param>
        /// <param name="depth">
        /// Specifies the depth of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture
        /// images
        /// that are at least 16 texels deep.
        /// </param>
        /// <param name="border">
        /// Specifies the width of the border. Must be either 0 or 1.
        /// </param>
        /// <param name="imageSize">
        /// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_compression")]
        public static void CompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, object data)
        {
            GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, pin_data.AddrOfPinnedObject());
            }
            finally
            {
                pin_data.Free();
            }
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES3.2] glCompressedTexImage2D: specify a two-dimensional texture image in a compressed format
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture. Must be Gl.TEXTURE_2D, Gl.PROXY_TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X,
        /// Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y,
        /// Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.PROXY_TEXTURE_CUBE_MAP.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat">
        /// Specifies the format of the compressed image data stored at address <paramref name="data" />.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 2D texture
        /// images
        /// that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be Must be 2n+2⁡border for some integer n. All implementations support 2D
        /// texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border">
        /// Specifies the width of the border. Must be either 0 or 1.
        /// </param>
        /// <param name="imageSize">
        /// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_compression")]
        public static void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, IntPtr data)
        {
            Debug.Assert(Delegates.pglCompressedTexImage2D != null, "pglCompressedTexImage2D not implemented");
            Delegates.pglCompressedTexImage2D((int) target, level, (int) internalformat, width, height, border, imageSize, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES3.2] glCompressedTexImage2D: specify a two-dimensional texture image in a compressed format
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture. Must be Gl.TEXTURE_2D, Gl.PROXY_TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X,
        /// Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y,
        /// Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.PROXY_TEXTURE_CUBE_MAP.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat">
        /// Specifies the format of the compressed image data stored at address <paramref name="data" />.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support 2D texture
        /// images
        /// that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be Must be 2n+2⁡border for some integer n. All implementations support 2D
        /// texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border">
        /// Specifies the width of the border. Must be either 0 or 1.
        /// </param>
        /// <param name="imageSize">
        /// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_compression")]
        public static void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, object data)
        {
            GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, pin_data.AddrOfPinnedObject());
            }
            finally
            {
                pin_data.Free();
            }
        }

        /// <summary>
        /// [GL2.1] glCompressedTexImage1D: specify a one-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture. Must be Gl.TEXTURE_1D or Gl.PROXY_TEXTURE_1D.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat">
        /// Specifies the format of the compressed image data stored at address <paramref name="data" />.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images
        /// that are at least 64 texels wide. The height of the 1D texture image is 1.
        /// </param>
        /// <param name="border">
        /// Specifies the width of the border. Must be either 0 or 1.
        /// </param>
        /// <param name="imageSize">
        /// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_texture_compression")]
        public static void CompressedTexImage1D(TextureTarget target, int level, InternalFormat internalformat, int width, int border, int imageSize, IntPtr data)
        {
            Debug.Assert(Delegates.pglCompressedTexImage1D != null, "pglCompressedTexImage1D not implemented");
            Delegates.pglCompressedTexImage1D((int) target, level, (int) internalformat, width, border, imageSize, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glCompressedTexImage1D: specify a one-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture. Must be Gl.TEXTURE_1D or Gl.PROXY_TEXTURE_1D.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat">
        /// Specifies the format of the compressed image data stored at address <paramref name="data" />.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images
        /// that are at least 64 texels wide. The height of the 1D texture image is 1.
        /// </param>
        /// <param name="border">
        /// Specifies the width of the border. Must be either 0 or 1.
        /// </param>
        /// <param name="imageSize">
        /// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_texture_compression")]
        public static void CompressedTexImage1D(TextureTarget target, int level, InternalFormat internalformat, int width, int border, int imageSize, object data)
        {
            GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                CompressedTexImage1D(target, level, internalformat, width, border, imageSize, pin_data.AddrOfPinnedObject());
            }
            finally
            {
                pin_data.Free();
            }
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glCompressedTexSubImage3D: specify a three-dimensional texture subimage in a compressed format
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.CompressedTexSubImage3D function. Must be
        /// Gl.TEXTURE_2D_ARRAY,
        /// Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP_ARRAY.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset">
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset">
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="zoffset">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="depth">
        /// Specifies the depth of the texture subimage.
        /// </param>
        /// <param name="format">
        /// Specifies the format of the compressed image data stored at address <paramref name="data" />.
        /// </param>
        /// <param name="imageSize">
        /// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_compression")]
        public static void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize,
            IntPtr data)
        {
            Debug.Assert(Delegates.pglCompressedTexSubImage3D != null, "pglCompressedTexSubImage3D not implemented");
            Delegates.pglCompressedTexSubImage3D((int) target, level, xoffset, yoffset, zoffset, width, height, depth, (int) format, imageSize, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glCompressedTexSubImage3D: specify a three-dimensional texture subimage in a compressed format
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.CompressedTexSubImage3D function. Must be
        /// Gl.TEXTURE_2D_ARRAY,
        /// Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP_ARRAY.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset">
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset">
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="zoffset">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="depth">
        /// Specifies the depth of the texture subimage.
        /// </param>
        /// <param name="format">
        /// Specifies the format of the compressed image data stored at address <paramref name="data" />.
        /// </param>
        /// <param name="imageSize">
        /// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_compression")]
        public static void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize,
            object data)
        {
            GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, pin_data.AddrOfPinnedObject());
            }
            finally
            {
                pin_data.Free();
            }
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glCompressedTexSubImage2D: specify a two-dimensional texture subimage in a compressed format
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.CompressedTexSubImage2D function. Must be
        /// Gl.TEXTURE_1D_ARRAY,
        /// Gl.TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y,
        /// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, or Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset">
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset">
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format">
        /// Specifies the format of the compressed image data stored at address <paramref name="data" />.
        /// </param>
        /// <param name="imageSize">
        /// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_texture_compression")]
        public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, IntPtr data)
        {
            Debug.Assert(Delegates.pglCompressedTexSubImage2D != null, "pglCompressedTexSubImage2D not implemented");
            Delegates.pglCompressedTexSubImage2D((int) target, level, xoffset, yoffset, width, height, (int) format, imageSize, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glCompressedTexSubImage2D: specify a two-dimensional texture subimage in a compressed format
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.CompressedTexSubImage2D function. Must be
        /// Gl.TEXTURE_1D_ARRAY,
        /// Gl.TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y,
        /// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, or Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset">
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset">
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format">
        /// Specifies the format of the compressed image data stored at address <paramref name="data" />.
        /// </param>
        /// <param name="imageSize">
        /// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_texture_compression")]
        public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, object data)
        {
            GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, pin_data.AddrOfPinnedObject());
            }
            finally
            {
                pin_data.Free();
            }
        }

        /// <summary>
        /// [GL4] glCompressedTexSubImage1D: specify a one-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target">
        /// Specifies the target, to which the texture is bound, for Gl.CompressedTexSubImage1D function. Must be Gl.TEXTURE_1D.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset">
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="format">
        /// Specifies the format of the compressed image data stored at address <paramref name="data" />.
        /// </param>
        /// <param name="imageSize">
        /// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_texture_compression")]
        public static void CompressedTexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, IntPtr data)
        {
            Debug.Assert(Delegates.pglCompressedTexSubImage1D != null, "pglCompressedTexSubImage1D not implemented");
            Delegates.pglCompressedTexSubImage1D((int) target, level, xoffset, width, (int) format, imageSize, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glCompressedTexSubImage1D: specify a one-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target">
        /// Specifies the target, to which the texture is bound, for Gl.CompressedTexSubImage1D function. Must be Gl.TEXTURE_1D.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset">
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="format">
        /// Specifies the format of the compressed image data stored at address <paramref name="data" />.
        /// </param>
        /// <param name="imageSize">
        /// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_texture_compression")]
        public static void CompressedTexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, object data)
        {
            GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, pin_data.AddrOfPinnedObject());
            }
            finally
            {
                pin_data.Free();
            }
        }

        /// <summary>
        /// [GL4] glGetCompressedTexImage: return a compressed texture image
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetCompressedTexImage and Gl.GetnCompressedTexImage
        /// functions.
        /// Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D, Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP_ARRAY,
        /// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y,
        /// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, and Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z,
        /// Gl.TEXTURE_RECTANGLE
        /// are accepted.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level $n$ is the $n$-th
        /// mipmap reduction image.
        /// </param>
        /// <param name="img">
        /// A <see cref="T:IntPtr" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_texture_compression")]
        public static void GetCompressedTexImage(TextureTarget target, int level, IntPtr img)
        {
            Debug.Assert(Delegates.pglGetCompressedTexImage != null, "pglGetCompressedTexImage not implemented");
            Delegates.pglGetCompressedTexImage((int) target, level, img);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetCompressedTexImage: return a compressed texture image
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetCompressedTexImage and Gl.GetnCompressedTexImage
        /// functions.
        /// Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D, Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP_ARRAY,
        /// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y,
        /// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, and Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z,
        /// Gl.TEXTURE_RECTANGLE
        /// are accepted.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level $n$ is the $n$-th
        /// mipmap reduction image.
        /// </param>
        /// <param name="img">
        /// A <see cref="T:object" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_texture_compression")]
        public static void GetCompressedTexImage(TextureTarget target, int level, object img)
        {
            GCHandle pin_img = GCHandle.Alloc(img, GCHandleType.Pinned);
            try
            {
                GetCompressedTexImage(target, level, pin_img.AddrOfPinnedObject());
            }
            finally
            {
                pin_img.Free();
            }
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1] glClientActiveTexture: select active texture unit
        ///     </para>
        ///     <para>
        ///     [GLES1.1] glClientActiveTexture: select client-side active texture unit
        ///     </para>
        /// </summary>
        /// <param name="texture">
        /// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at
        /// least two. <paramref name="texture" /> must be one of Gl.TEXTUREi, where i ranges from 0 to the value of
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value. The initial value is Gl.TEXTURE0.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void ClientActiveTexture(TextureUnit texture)
        {
            Debug.Assert(Delegates.pglClientActiveTexture != null, "pglClientActiveTexture not implemented");
            Delegates.pglClientActiveTexture((int) texture);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord1d: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="s">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord1(TextureUnit target, double s)
        {
            Debug.Assert(Delegates.pglMultiTexCoord1d != null, "pglMultiTexCoord1d not implemented");
            Delegates.pglMultiTexCoord1d((int) target, s);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord1dv: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord1(TextureUnit target, double[] v)
        {
            Debug.Assert(v.Length >= 1);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglMultiTexCoord1dv != null, "pglMultiTexCoord1dv not implemented");
                    Delegates.pglMultiTexCoord1dv((int) target, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord1f: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="s">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord1(TextureUnit target, float s)
        {
            Debug.Assert(Delegates.pglMultiTexCoord1f != null, "pglMultiTexCoord1f not implemented");
            Delegates.pglMultiTexCoord1f((int) target, s);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord1fv: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord1(TextureUnit target, float[] v)
        {
            Debug.Assert(v.Length >= 1);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglMultiTexCoord1fv != null, "pglMultiTexCoord1fv not implemented");
                    Delegates.pglMultiTexCoord1fv((int) target, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord1i: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="s">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord1(TextureUnit target, int s)
        {
            Debug.Assert(Delegates.pglMultiTexCoord1i != null, "pglMultiTexCoord1i not implemented");
            Delegates.pglMultiTexCoord1i((int) target, s);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord1iv: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord1(TextureUnit target, int[] v)
        {
            Debug.Assert(v.Length >= 1);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglMultiTexCoord1iv != null, "pglMultiTexCoord1iv not implemented");
                    Delegates.pglMultiTexCoord1iv((int) target, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord1s: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="s">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord1(TextureUnit target, short s)
        {
            Debug.Assert(Delegates.pglMultiTexCoord1s != null, "pglMultiTexCoord1s not implemented");
            Delegates.pglMultiTexCoord1s((int) target, s);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord1sv: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord1(TextureUnit target, short[] v)
        {
            Debug.Assert(v.Length >= 1);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglMultiTexCoord1sv != null, "pglMultiTexCoord1sv not implemented");
                    Delegates.pglMultiTexCoord1sv((int) target, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord2d: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="s">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord2(TextureUnit target, double s, double t)
        {
            Debug.Assert(Delegates.pglMultiTexCoord2d != null, "pglMultiTexCoord2d not implemented");
            Delegates.pglMultiTexCoord2d((int) target, s, t);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord2dv: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord2(TextureUnit target, double[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglMultiTexCoord2dv != null, "pglMultiTexCoord2dv not implemented");
                    Delegates.pglMultiTexCoord2dv((int) target, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord2f: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="s">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord2(TextureUnit target, float s, float t)
        {
            Debug.Assert(Delegates.pglMultiTexCoord2f != null, "pglMultiTexCoord2f not implemented");
            Delegates.pglMultiTexCoord2f((int) target, s, t);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord2fv: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord2(TextureUnit target, float[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglMultiTexCoord2fv != null, "pglMultiTexCoord2fv not implemented");
                    Delegates.pglMultiTexCoord2fv((int) target, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord2i: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="s">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord2(TextureUnit target, int s, int t)
        {
            Debug.Assert(Delegates.pglMultiTexCoord2i != null, "pglMultiTexCoord2i not implemented");
            Delegates.pglMultiTexCoord2i((int) target, s, t);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord2iv: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord2(TextureUnit target, int[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglMultiTexCoord2iv != null, "pglMultiTexCoord2iv not implemented");
                    Delegates.pglMultiTexCoord2iv((int) target, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord2s: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="s">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord2(TextureUnit target, short s, short t)
        {
            Debug.Assert(Delegates.pglMultiTexCoord2s != null, "pglMultiTexCoord2s not implemented");
            Delegates.pglMultiTexCoord2s((int) target, s, t);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord2sv: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord2(TextureUnit target, short[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglMultiTexCoord2sv != null, "pglMultiTexCoord2sv not implemented");
                    Delegates.pglMultiTexCoord2sv((int) target, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord3d: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="s">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="r">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord3(TextureUnit target, double s, double t, double r)
        {
            Debug.Assert(Delegates.pglMultiTexCoord3d != null, "pglMultiTexCoord3d not implemented");
            Delegates.pglMultiTexCoord3d((int) target, s, t, r);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord3dv: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord3(TextureUnit target, double[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglMultiTexCoord3dv != null, "pglMultiTexCoord3dv not implemented");
                    Delegates.pglMultiTexCoord3dv((int) target, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord3f: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="s">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="r">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord3(TextureUnit target, float s, float t, float r)
        {
            Debug.Assert(Delegates.pglMultiTexCoord3f != null, "pglMultiTexCoord3f not implemented");
            Delegates.pglMultiTexCoord3f((int) target, s, t, r);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord3fv: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord3(TextureUnit target, float[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglMultiTexCoord3fv != null, "pglMultiTexCoord3fv not implemented");
                    Delegates.pglMultiTexCoord3fv((int) target, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord3i: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="s">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="r">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord3(TextureUnit target, int s, int t, int r)
        {
            Debug.Assert(Delegates.pglMultiTexCoord3i != null, "pglMultiTexCoord3i not implemented");
            Delegates.pglMultiTexCoord3i((int) target, s, t, r);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord3iv: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord3(TextureUnit target, int[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglMultiTexCoord3iv != null, "pglMultiTexCoord3iv not implemented");
                    Delegates.pglMultiTexCoord3iv((int) target, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord3s: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="s">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="r">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord3(TextureUnit target, short s, short t, short r)
        {
            Debug.Assert(Delegates.pglMultiTexCoord3s != null, "pglMultiTexCoord3s not implemented");
            Delegates.pglMultiTexCoord3s((int) target, s, t, r);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord3sv: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord3(TextureUnit target, short[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglMultiTexCoord3sv != null, "pglMultiTexCoord3sv not implemented");
                    Delegates.pglMultiTexCoord3sv((int) target, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord4d: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="s">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="r">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="q">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord4(TextureUnit target, double s, double t, double r, double q)
        {
            Debug.Assert(Delegates.pglMultiTexCoord4d != null, "pglMultiTexCoord4d not implemented");
            Delegates.pglMultiTexCoord4d((int) target, s, t, r, q);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord4dv: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord4(TextureUnit target, double[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglMultiTexCoord4dv != null, "pglMultiTexCoord4dv not implemented");
                    Delegates.pglMultiTexCoord4dv((int) target, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glMultiTexCoord4f: set the current texture coordinates
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="s">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="r">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="q">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord4(TextureUnit target, float s, float t, float r, float q)
        {
            Debug.Assert(Delegates.pglMultiTexCoord4f != null, "pglMultiTexCoord4f not implemented");
            Delegates.pglMultiTexCoord4f((int) target, s, t, r, q);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord4fv: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord4(TextureUnit target, float[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglMultiTexCoord4fv != null, "pglMultiTexCoord4fv not implemented");
                    Delegates.pglMultiTexCoord4fv((int) target, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord4i: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="s">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="r">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="q">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord4(TextureUnit target, int s, int t, int r, int q)
        {
            Debug.Assert(Delegates.pglMultiTexCoord4i != null, "pglMultiTexCoord4i not implemented");
            Delegates.pglMultiTexCoord4i((int) target, s, t, r, q);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord4iv: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord4(TextureUnit target, int[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglMultiTexCoord4iv != null, "pglMultiTexCoord4iv not implemented");
                    Delegates.pglMultiTexCoord4iv((int) target, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord4s: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="s">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="r">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="q">
        /// Specify <paramref name="s" />, <paramref name="t" />, <paramref name="r" />, and <paramref name="q" /> texture
        /// coordinates
        /// for <paramref name="target" /> texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord4(TextureUnit target, short s, short t, short r, short q)
        {
            Debug.Assert(Delegates.pglMultiTexCoord4s != null, "pglMultiTexCoord4s not implemented");
            Delegates.pglMultiTexCoord4s((int) target, s, t, r, q);
        }

        /// <summary>
        /// [GL2.1] glMultiTexCoord4sv: set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation
        /// dependent, but must be at least two. Symbolic constant must be one of Gl.TEXTUREi, where i ranges from 0 to
        /// Gl.MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_multitexture")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultiTexCoord4(TextureUnit target, short[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglMultiTexCoord4sv != null, "pglMultiTexCoord4sv not implemented");
                    Delegates.pglMultiTexCoord4sv((int) target, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glLoadTransposeMatrixf: replace the current matrix with the specified row-major ordered matrix
        /// </summary>
        /// <param name="m">
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 row-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_transpose_matrix")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void LoadTransposeMatrix(float[] m)
        {
            Debug.Assert(m.Length >= 16);
            unsafe
            {
                fixed (float* p_m = m)
                {
                    Debug.Assert(Delegates.pglLoadTransposeMatrixf != null, "pglLoadTransposeMatrixf not implemented");
                    Delegates.pglLoadTransposeMatrixf(p_m);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glLoadTransposeMatrixf: replace the current matrix with the specified row-major ordered matrix
        /// </summary>
        /// <param name="m">
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 row-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_transpose_matrix")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static unsafe void LoadTransposeMatrix(float* m)
        {
            Debug.Assert(Delegates.pglLoadTransposeMatrixf != null, "pglLoadTransposeMatrixf not implemented");
            Delegates.pglLoadTransposeMatrixf(m);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glLoadTransposeMatrixf: replace the current matrix with the specified row-major ordered matrix
        /// </summary>
        /// <param name="m">
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 row-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_transpose_matrix")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void LoadTransposeMatrixf<T>(T m) where T : struct
        {
            Debug.Assert(Delegates.pglLoadTransposeMatrixf != null, "pglLoadTransposeMatrixf not implemented");
            unsafe
            {
                TypedReference refM = __makeref(m);
                IntPtr refMPtr = *(IntPtr*) (&refM);

                Delegates.pglLoadTransposeMatrixf((float*) refMPtr.ToPointer());
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glLoadTransposeMatrixd: replace the current matrix with the specified row-major ordered matrix
        /// </summary>
        /// <param name="m">
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 row-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_transpose_matrix")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void LoadTransposeMatrix(double[] m)
        {
            Debug.Assert(m.Length >= 16);
            unsafe
            {
                fixed (double* p_m = m)
                {
                    Debug.Assert(Delegates.pglLoadTransposeMatrixd != null, "pglLoadTransposeMatrixd not implemented");
                    Delegates.pglLoadTransposeMatrixd(p_m);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glLoadTransposeMatrixd: replace the current matrix with the specified row-major ordered matrix
        /// </summary>
        /// <param name="m">
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 row-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_transpose_matrix")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static unsafe void LoadTransposeMatrix(double* m)
        {
            Debug.Assert(Delegates.pglLoadTransposeMatrixd != null, "pglLoadTransposeMatrixd not implemented");
            Delegates.pglLoadTransposeMatrixd(m);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glLoadTransposeMatrixd: replace the current matrix with the specified row-major ordered matrix
        /// </summary>
        /// <param name="m">
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 row-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_transpose_matrix")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void LoadTransposeMatrixd<T>(T m) where T : struct
        {
            Debug.Assert(Delegates.pglLoadTransposeMatrixd != null, "pglLoadTransposeMatrixd not implemented");
            unsafe
            {
                TypedReference refM = __makeref(m);
                IntPtr refMPtr = *(IntPtr*) (&refM);

                Delegates.pglLoadTransposeMatrixd((double*) refMPtr.ToPointer());
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultTransposeMatrixf: multiply the current matrix with the specified row-major ordered matrix
        /// </summary>
        /// <param name="m">
        /// Points to 16 consecutive values that are used as the elements of a 4×4 row-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_transpose_matrix")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultTransposeMatrix(float[] m)
        {
            Debug.Assert(m.Length >= 16);
            unsafe
            {
                fixed (float* p_m = m)
                {
                    Debug.Assert(Delegates.pglMultTransposeMatrixf != null, "pglMultTransposeMatrixf not implemented");
                    Delegates.pglMultTransposeMatrixf(p_m);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultTransposeMatrixf: multiply the current matrix with the specified row-major ordered matrix
        /// </summary>
        /// <param name="m">
        /// Points to 16 consecutive values that are used as the elements of a 4×4 row-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_transpose_matrix")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static unsafe void MultTransposeMatrix(float* m)
        {
            Debug.Assert(Delegates.pglMultTransposeMatrixf != null, "pglMultTransposeMatrixf not implemented");
            Delegates.pglMultTransposeMatrixf(m);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultTransposeMatrixf: multiply the current matrix with the specified row-major ordered matrix
        /// </summary>
        /// <param name="m">
        /// Points to 16 consecutive values that are used as the elements of a 4×4 row-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_transpose_matrix")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultTransposeMatrixf<T>(T m) where T : struct
        {
            Debug.Assert(Delegates.pglMultTransposeMatrixf != null, "pglMultTransposeMatrixf not implemented");
            unsafe
            {
                TypedReference refM = __makeref(m);
                IntPtr refMPtr = *(IntPtr*) (&refM);

                Delegates.pglMultTransposeMatrixf((float*) refMPtr.ToPointer());
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultTransposeMatrixd: multiply the current matrix with the specified row-major ordered matrix
        /// </summary>
        /// <param name="m">
        /// Points to 16 consecutive values that are used as the elements of a 4×4 row-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_transpose_matrix")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultTransposeMatrix(double[] m)
        {
            Debug.Assert(m.Length >= 16);
            unsafe
            {
                fixed (double* p_m = m)
                {
                    Debug.Assert(Delegates.pglMultTransposeMatrixd != null, "pglMultTransposeMatrixd not implemented");
                    Delegates.pglMultTransposeMatrixd(p_m);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultTransposeMatrixd: multiply the current matrix with the specified row-major ordered matrix
        /// </summary>
        /// <param name="m">
        /// Points to 16 consecutive values that are used as the elements of a 4×4 row-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_transpose_matrix")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static unsafe void MultTransposeMatrix(double* m)
        {
            Debug.Assert(Delegates.pglMultTransposeMatrixd != null, "pglMultTransposeMatrixd not implemented");
            Delegates.pglMultTransposeMatrixd(m);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultTransposeMatrixd: multiply the current matrix with the specified row-major ordered matrix
        /// </summary>
        /// <param name="m">
        /// Points to 16 consecutive values that are used as the elements of a 4×4 row-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_3")]
        [RequiredByFeature("GL_ARB_transpose_matrix")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultTransposeMatrixd<T>(T m) where T : struct
        {
            Debug.Assert(Delegates.pglMultTransposeMatrixd != null, "pglMultTransposeMatrixd not implemented");
            unsafe
            {
                TypedReference refM = __makeref(m);
                IntPtr refMPtr = *(IntPtr*) (&refM);

                Delegates.pglMultTransposeMatrixd((double*) refMPtr.ToPointer());
            }

            DebugCheckErrors(null);
        }

        internal static unsafe partial class Delegates
        {
            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glActiveTexture(int texture);

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glActiveTextureARB")]
            [ThreadStatic]
            internal static glActiveTexture pglActiveTexture;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_multisample")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glSampleCoverage(float value, [MarshalAs(UnmanagedType.I1)] bool invert);

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_multisample", EntryPoint = "glSampleCoverageARB")]
            [ThreadStatic]
            internal static glSampleCoverage pglSampleCoverage;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_texture_compression")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glCompressedTexImage3D(int target, int level, int internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_texture_compression", EntryPoint = "glCompressedTexImage3DARB")]
            [ThreadStatic]
            internal static glCompressedTexImage3D pglCompressedTexImage3D;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_texture_compression")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glCompressedTexImage2D(int target, int level, int internalformat, int width, int height, int border, int imageSize, IntPtr data);

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_texture_compression", EntryPoint = "glCompressedTexImage2DARB")]
            [ThreadStatic]
            internal static glCompressedTexImage2D pglCompressedTexImage2D;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_texture_compression")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glCompressedTexImage1D(int target, int level, int internalformat, int width, int border, int imageSize, IntPtr data);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_texture_compression", EntryPoint = "glCompressedTexImage1DARB")] [ThreadStatic]
            internal static glCompressedTexImage1D pglCompressedTexImage1D;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_texture_compression")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glCompressedTexSubImage3D(int target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int format, int imageSize, IntPtr data);

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_texture_compression", EntryPoint = "glCompressedTexSubImage3DARB")]
            [ThreadStatic]
            internal static glCompressedTexSubImage3D pglCompressedTexSubImage3D;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_texture_compression")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glCompressedTexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, int imageSize, IntPtr data);

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_texture_compression", EntryPoint = "glCompressedTexSubImage2DARB")]
            [ThreadStatic]
            internal static glCompressedTexSubImage2D pglCompressedTexSubImage2D;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_texture_compression")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glCompressedTexSubImage1D(int target, int level, int xoffset, int width, int format, int imageSize, IntPtr data);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_texture_compression", EntryPoint = "glCompressedTexSubImage1DARB")] [ThreadStatic]
            internal static glCompressedTexSubImage1D pglCompressedTexSubImage1D;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_texture_compression")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetCompressedTexImage(int target, int level, IntPtr img);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_texture_compression", EntryPoint = "glGetCompressedTexImageARB")] [ThreadStatic]
            internal static glGetCompressedTexImage pglGetCompressedTexImage;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glClientActiveTexture(int texture);

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glClientActiveTextureARB")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            internal static glClientActiveTexture pglClientActiveTexture;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord1d(int target, double s);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord1dARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord1d pglMultiTexCoord1d;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord1dv(int target, double* v);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord1dvARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord1dv pglMultiTexCoord1dv;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord1f(int target, float s);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord1fARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord1f pglMultiTexCoord1f;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord1fv(int target, float* v);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord1fvARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord1fv pglMultiTexCoord1fv;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord1i(int target, int s);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord1iARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord1i pglMultiTexCoord1i;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord1iv(int target, int* v);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord1ivARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord1iv pglMultiTexCoord1iv;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord1s(int target, short s);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord1sARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord1s pglMultiTexCoord1s;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord1sv(int target, short* v);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord1svARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord1sv pglMultiTexCoord1sv;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord2d(int target, double s, double t);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord2dARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord2d pglMultiTexCoord2d;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord2dv(int target, double* v);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord2dvARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord2dv pglMultiTexCoord2dv;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord2f(int target, float s, float t);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord2fARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord2f pglMultiTexCoord2f;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord2fv(int target, float* v);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord2fvARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord2fv pglMultiTexCoord2fv;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord2i(int target, int s, int t);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord2iARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord2i pglMultiTexCoord2i;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord2iv(int target, int* v);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord2ivARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord2iv pglMultiTexCoord2iv;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord2s(int target, short s, short t);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord2sARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord2s pglMultiTexCoord2s;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord2sv(int target, short* v);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord2svARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord2sv pglMultiTexCoord2sv;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord3d(int target, double s, double t, double r);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord3dARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord3d pglMultiTexCoord3d;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord3dv(int target, double* v);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord3dvARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord3dv pglMultiTexCoord3dv;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord3f(int target, float s, float t, float r);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord3fARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord3f pglMultiTexCoord3f;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord3fv(int target, float* v);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord3fvARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord3fv pglMultiTexCoord3fv;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord3i(int target, int s, int t, int r);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord3iARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord3i pglMultiTexCoord3i;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord3iv(int target, int* v);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord3ivARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord3iv pglMultiTexCoord3iv;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord3s(int target, short s, short t, short r);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord3sARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord3s pglMultiTexCoord3s;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord3sv(int target, short* v);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord3svARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord3sv pglMultiTexCoord3sv;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord4d(int target, double s, double t, double r, double q);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord4dARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord4d pglMultiTexCoord4d;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord4dv(int target, double* v);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord4dvARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord4dv pglMultiTexCoord4dv;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord4f(int target, float s, float t, float r, float q);

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord4fARB")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            internal static glMultiTexCoord4f pglMultiTexCoord4f;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord4fv(int target, float* v);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord4fvARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord4fv pglMultiTexCoord4fv;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord4i(int target, int s, int t, int r, int q);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord4iARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord4i pglMultiTexCoord4i;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord4iv(int target, int* v);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord4ivARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord4iv pglMultiTexCoord4iv;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord4s(int target, short s, short t, short r, short q);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord4sARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord4s pglMultiTexCoord4s;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_multitexture")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultiTexCoord4sv(int target, short* v);

            [RequiredByFeature("GL_VERSION_1_3")] [RequiredByFeature("GL_ARB_multitexture", EntryPoint = "glMultiTexCoord4svARB")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultiTexCoord4sv pglMultiTexCoord4sv;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_transpose_matrix")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glLoadTransposeMatrixf(float* m);

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_transpose_matrix", EntryPoint = "glLoadTransposeMatrixfARB")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            internal static glLoadTransposeMatrixf pglLoadTransposeMatrixf;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_transpose_matrix")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glLoadTransposeMatrixd(double* m);

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_transpose_matrix", EntryPoint = "glLoadTransposeMatrixdARB")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            internal static glLoadTransposeMatrixd pglLoadTransposeMatrixd;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_transpose_matrix")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultTransposeMatrixf(float* m);

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_transpose_matrix", EntryPoint = "glMultTransposeMatrixfARB")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            internal static glMultTransposeMatrixf pglMultTransposeMatrixf;

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_transpose_matrix")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultTransposeMatrixd(double* m);

            [RequiredByFeature("GL_VERSION_1_3")]
            [RequiredByFeature("GL_ARB_transpose_matrix", EntryPoint = "glMultTransposeMatrixdARB")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [ThreadStatic]
            internal static glMultTransposeMatrixd pglMultTransposeMatrixd;
        }
    }
}