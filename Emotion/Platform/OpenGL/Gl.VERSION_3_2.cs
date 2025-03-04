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
        /// [GL] Value of GL_CONTEXT_CORE_PROFILE_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] public const uint CONTEXT_CORE_PROFILE_BIT = 0x00000001;

        /// <summary>
        /// [GL] Value of GL_CONTEXT_COMPATIBILITY_PROFILE_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] public const uint CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002;

        /// <summary>
        /// [GL] Value of GL_LINES_ADJACENCY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_EXT_geometry_shader4")]
        [RequiredByFeature("GL_NV_geometry_program4")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int LINES_ADJACENCY = 0x000A;

        /// <summary>
        /// [GL] Value of GL_LINE_STRIP_ADJACENCY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_EXT_geometry_shader4")]
        [RequiredByFeature("GL_NV_geometry_program4")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int LINE_STRIP_ADJACENCY = 0x000B;

        /// <summary>
        /// [GL] Value of GL_TRIANGLES_ADJACENCY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_EXT_geometry_shader4")]
        [RequiredByFeature("GL_NV_geometry_program4")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int TRIANGLES_ADJACENCY = 0x000C;

        /// <summary>
        /// [GL] Value of GL_TRIANGLE_STRIP_ADJACENCY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_EXT_geometry_shader4")]
        [RequiredByFeature("GL_NV_geometry_program4")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int TRIANGLE_STRIP_ADJACENCY = 0x000D;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum supported texture image units that can be used to access
        /// texture maps from the geometry shader. The value must be at least 16. See Gl.ActiveTexture.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_EXT_geometry_shader4")]
        [RequiredByFeature("GL_NV_geometry_program4")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_LAYERED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_EXT_geometry_shader4")]
        [RequiredByFeature("GL_NV_geometry_program4")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_EXT_geometry_shader4")]
        [RequiredByFeature("GL_NV_geometry_program4")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;

        /// <summary>
        /// [GL] Value of GL_GEOMETRY_SHADER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_EXT_geometry_shader4")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int GEOMETRY_SHADER = 0x8DD9;

        /// <summary>
        /// [GL4] Gl.GetProgram: params returns the maximum number of vertices that the geometry shader in program will output.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        public const int GEOMETRY_VERTICES_OUT = 0x8916;

        /// <summary>
        /// [GL4] Gl.GetProgram: params returns a symbolic constant indicating the primitive type accepted as input to the geometry
        /// shader contained in program.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        public const int GEOMETRY_INPUT_TYPE = 0x8917;

        /// <summary>
        /// [GL4] Gl.GetProgram: params returns a symbolic constant indicating the primitive type that will be output by the
        /// geometry shader contained in program.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        public const int GEOMETRY_OUTPUT_TYPE = 0x8918;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of individual floating-point, integer, or boolean
        /// values that can be held in uniform variable storage for a geometry shader. The value must be at least 1024. See
        /// Gl.Uniform.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_EXT_geometry_shader4")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;

        /// <summary>
        /// [GLES3.2] Gl.Get: data returns one value, the maximum number of vertices emit by a geometry shader, which must be at
        /// least 256.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_EXT_geometry_shader4")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;

        /// <summary>
        /// [GLES3.2] Gl.Get: data returns one value, the maximum total number of components of active outputs for all vertices
        /// written by a geometry shader, which must be at least 1024.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_EXT_geometry_shader4")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of components of output written by a vertex shader,
        /// which must be at least 64.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of components of inputs read by a geometry shader,
        /// which must be at least 64.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of components of outputs written by a geometry shader,
        /// which must be at least 128.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the maximum number of components of the inputs read by the fragment shader,
        ///     which
        ///     must be at least 128.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the maximum number of components of the inputs read by the fragment
        ///     shader,
        ///     which must be at least 60.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;

        /// <summary>
        /// [GL] Value of GL_CONTEXT_PROFILE_MASK symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] public const int CONTEXT_PROFILE_MASK = 0x9126;

        /// <summary>
        /// [GL] Value of GL_DEPTH_CLAMP symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ARB_depth_clamp", Api = "gl|glcore")] [RequiredByFeature("GL_NV_depth_clamp")]
        public const int DEPTH_CLAMP = 0x864F;

        /// <summary>
        /// [GL] Value of GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ARB_provoking_vertex", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_provoking_vertex")]
        public const int QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;

        /// <summary>
        /// [GL] Value of GL_FIRST_VERTEX_CONVENTION symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_provoking_vertex", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_EXT_provoking_vertex")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int FIRST_VERTEX_CONVENTION = 0x8E4D;

        /// <summary>
        /// [GL] Value of GL_LAST_VERTEX_CONVENTION symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_provoking_vertex", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_EXT_provoking_vertex")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int LAST_VERTEX_CONVENTION = 0x8E4E;

        /// <summary>
        /// [GL4] Gl.Get: data returns one value, the currently selected provoking vertex convention. The initial value is
        /// Gl.LAST_VERTEX_CONVENTION. See Gl.ProvokingVertex.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ARB_provoking_vertex", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_provoking_vertex")]
        public const int PROVOKING_VERTEX = 0x8E4F;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_CUBE_MAP_SEAMLESS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_AMD_seamless_cubemap_per_texture")]
        [RequiredByFeature("GL_ARB_seamless_cube_map", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_seamless_cubemap_per_texture", Api = "gl|glcore")]
        public const int TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum Gl.WaitSync timeout interval.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        public const int MAX_SERVER_WAIT_TIMEOUT = 0x9111;

        /// <summary>
        /// [GL] Value of GL_OBJECT_TYPE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        public const int OBJECT_TYPE = 0x9112;

        /// <summary>
        /// [GL] Value of GL_SYNC_CONDITION symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        public const int SYNC_CONDITION = 0x9113;

        /// <summary>
        /// [GL] Value of GL_SYNC_STATUS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        public const int SYNC_STATUS = 0x9114;

        /// <summary>
        /// [GL] Value of GL_SYNC_FLAGS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        public const int SYNC_FLAGS = 0x9115;

        /// <summary>
        /// [GL] Value of GL_SYNC_FENCE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        public const int SYNC_FENCE = 0x9116;

        /// <summary>
        /// [GL] Value of GL_SYNC_GPU_COMMANDS_COMPLETE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        public const int SYNC_GPU_COMMANDS_COMPLETE = 0x9117;

        /// <summary>
        /// [GL] Value of GL_UNSIGNALED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        public const int UNSIGNALED = 0x9118;

        /// <summary>
        /// [GL] Value of GL_SIGNALED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        public const int SIGNALED = 0x9119;

        /// <summary>
        /// [GL] Value of GL_ALREADY_SIGNALED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        public const int ALREADY_SIGNALED = 0x911A;

        /// <summary>
        /// [GL] Value of GL_TIMEOUT_EXPIRED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        public const int TIMEOUT_EXPIRED = 0x911B;

        /// <summary>
        /// [GL] Value of GL_CONDITION_SATISFIED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        public const int CONDITION_SATISFIED = 0x911C;

        /// <summary>
        /// [GL] Value of GL_WAIT_FAILED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        public const int WAIT_FAILED = 0x911D;

        /// <summary>
        /// [GL] Value of GL_TIMEOUT_IGNORED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        public const ulong TIMEOUT_IGNORED = 0xFFFFFFFFFFFFF;

        /// <summary>
        /// [GL] Value of GL_SYNC_FLUSH_COMMANDS_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        public const uint SYNC_FLUSH_COMMANDS_BIT = 0x00000001;

        /// <summary>
        /// [GL] Value of GL_SAMPLE_POSITION symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_explicit_multisample")]
        public const int SAMPLE_POSITION = 0x8E50;

        /// <summary>
        /// [GL] Value of GL_SAMPLE_MASK symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_explicit_multisample")]
        public const int SAMPLE_MASK = 0x8E51;

        /// <summary>
        /// [GL] Value of GL_SAMPLE_MASK_VALUE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_explicit_multisample")]
        public const int SAMPLE_MASK_VALUE = 0x8E52;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of sample mask words.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_explicit_multisample")]
        public const int MAX_SAMPLE_MASK_WORDS = 0x8E59;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_2D_MULTISAMPLE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
        public const int TEXTURE_2D_MULTISAMPLE = 0x9100;

        /// <summary>
        /// [GL] Value of GL_PROXY_TEXTURE_2D_MULTISAMPLE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        public const int PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_2D_MULTISAMPLE_ARRAY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
        [RequiredByFeature("GL_OES_texture_storage_multisample_2d_array", Api = "gles2")]
        public const int TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;

        /// <summary>
        /// [GL] Value of GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        public const int PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single value, the name of the texture currently bound to the target
        /// Gl.TEXTURE_2D_MULTISAMPLE. The initial value is 0. See Gl.BindTexture.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_VERSION_4_5")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        public const int TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single value, the name of the texture currently bound to the target
        /// Gl.TEXTURE_2D_MULTISAMPLE_ARRAY. The initial value is 0. See Gl.BindTexture.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_VERSION_4_5")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_texture_storage_multisample_2d_array", Api = "gles2")]
        public const int TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;

        /// <summary>
        /// [GLES3.2] Gl.GetTexLevelParameter: params returns a single value, the number of samples of the texture image.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        public const int TEXTURE_SAMPLES = 0x9106;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_FIXED_SAMPLE_LOCATIONS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        public const int TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;

        /// <summary>
        /// [GL] Value of GL_SAMPLER_2D_MULTISAMPLE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        public const int SAMPLER_2D_MULTISAMPLE = 0x9108;

        /// <summary>
        /// [GL] Value of GL_INT_SAMPLER_2D_MULTISAMPLE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        public const int INT_SAMPLER_2D_MULTISAMPLE = 0x9109;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        public const int UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;

        /// <summary>
        /// [GL] Value of GL_SAMPLER_2D_MULTISAMPLE_ARRAY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_texture_storage_multisample_2d_array", Api = "gles2")]
        public const int SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;

        /// <summary>
        /// [GL] Value of GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_texture_storage_multisample_2d_array", Api = "gles2")]
        public const int INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_texture_storage_multisample_2d_array", Api = "gles2")]
        public const int UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of samples in a color multisample texture.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        public const int MAX_COLOR_TEXTURE_SAMPLES = 0x910E;

        /// <summary>
        /// [GL4] Gl.Get: data returns one value, the maximum number of samples in a multisample depth or depth-stencil texture.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        public const int MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of samples supported in integer format multisample
        /// buffers.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        public const int MAX_INTEGER_SAMPLES = 0x9110;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDrawElementsBaseVertex: render primitives from array data with a per-element offset
        ///     </para>
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES,
        /// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, Gl.LINES_ADJACENCY, Gl.LINE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY,
        /// Gl.TRIANGLE_STRIP_ADJACENCY and Gl.PATCHES are accepted.
        /// </param>
        /// <param name="count">
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type">
        /// Specifies the type of the values in indices. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or Gl.UNSIGNED_INT.
        /// </param>
        /// <param name="indices">
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        /// <param name="basevertex">
        /// Specifies a constant that should be added to each element of <paramref name="indices" /> when chosing elements from the
        /// enabled vertex arrays.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
        public static void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int basevertex)
        {
            Debug.Assert(Delegates.pglDrawElementsBaseVertex != null, "pglDrawElementsBaseVertex not implemented");
            Delegates.pglDrawElementsBaseVertex((int) mode, count, (int) type, indices, basevertex);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDrawElementsBaseVertex: render primitives from array data with a per-element offset
        ///     </para>
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES,
        /// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, Gl.LINES_ADJACENCY, Gl.LINE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY,
        /// Gl.TRIANGLE_STRIP_ADJACENCY and Gl.PATCHES are accepted.
        /// </param>
        /// <param name="count">
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type">
        /// Specifies the type of the values in indices. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or Gl.UNSIGNED_INT.
        /// </param>
        /// <param name="indices">
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        /// <param name="basevertex">
        /// Specifies a constant that should be added to each element of <paramref name="indices" /> when chosing elements from the
        /// enabled vertex arrays.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
        public static void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, object indices, int basevertex)
        {
            GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                DrawElementsBaseVertex(mode, count, type, pin_indices.AddrOfPinnedObject(), basevertex);
            }
            finally
            {
                pin_indices.Free();
            }
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDrawRangeElementsBaseVertex: render primitives from array data with a per-element offset
        ///     </para>
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES,
        /// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, Gl.LINES_ADJACENCY, Gl.LINE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY,
        /// Gl.TRIANGLE_STRIP_ADJACENCY and Gl.PATCHES are accepted.
        /// </param>
        /// <param name="start">
        /// Specifies the minimum array index contained in <paramref name="indices" />.
        /// </param>
        /// <param name="end">
        /// Specifies the maximum array index contained in <paramref name="indices" />.
        /// </param>
        /// <param name="count">
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type">
        /// Specifies the type of the values in indices. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or Gl.UNSIGNED_INT.
        /// </param>
        /// <param name="indices">
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        /// <param name="basevertex">
        /// Specifies a constant that should be added to each element of <paramref name="indices" /> when chosing elements from the
        /// enabled vertex arrays.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
        public static void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices, int basevertex)
        {
            Debug.Assert(Delegates.pglDrawRangeElementsBaseVertex != null, "pglDrawRangeElementsBaseVertex not implemented");
            Delegates.pglDrawRangeElementsBaseVertex((int) mode, start, end, count, (int) type, indices, basevertex);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDrawRangeElementsBaseVertex: render primitives from array data with a per-element offset
        ///     </para>
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES,
        /// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, Gl.LINES_ADJACENCY, Gl.LINE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY,
        /// Gl.TRIANGLE_STRIP_ADJACENCY and Gl.PATCHES are accepted.
        /// </param>
        /// <param name="start">
        /// Specifies the minimum array index contained in <paramref name="indices" />.
        /// </param>
        /// <param name="end">
        /// Specifies the maximum array index contained in <paramref name="indices" />.
        /// </param>
        /// <param name="count">
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type">
        /// Specifies the type of the values in indices. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or Gl.UNSIGNED_INT.
        /// </param>
        /// <param name="indices">
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        /// <param name="basevertex">
        /// Specifies a constant that should be added to each element of <paramref name="indices" /> when chosing elements from the
        /// enabled vertex arrays.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
        public static void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, object indices, int basevertex)
        {
            GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                DrawRangeElementsBaseVertex(mode, start, end, count, type, pin_indices.AddrOfPinnedObject(), basevertex);
            }
            finally
            {
                pin_indices.Free();
            }
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDrawElementsInstancedBaseVertex: render multiple instances of a set of primitives from array data
        ///     with a
        ///     per-element offset
        ///     </para>
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES,
        /// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, Gl.LINES_ADJACENCY, Gl.LINE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY,
        /// Gl.TRIANGLE_STRIP_ADJACENCY and Gl.PATCHES are accepted.
        /// </param>
        /// <param name="count">
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type">
        /// Specifies the type of the values in indices. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or Gl.UNSIGNED_INT.
        /// </param>
        /// <param name="indices">
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        /// <param name="primcount">
        /// Specifies the number of instances of the indexed geometry that should be drawn.
        /// </param>
        /// <param name="basevertex">
        /// Specifies a constant that should be added to each element of <paramref name="indices" /> when chosing elements from the
        /// enabled vertex arrays.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
        public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int primcount, int basevertex)
        {
            Debug.Assert(Delegates.pglDrawElementsInstancedBaseVertex != null, "pglDrawElementsInstancedBaseVertex not implemented");
            Delegates.pglDrawElementsInstancedBaseVertex((int) mode, count, (int) type, indices, primcount, basevertex);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDrawElementsInstancedBaseVertex: render multiple instances of a set of primitives from array data
        ///     with a
        ///     per-element offset
        ///     </para>
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES,
        /// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, Gl.LINES_ADJACENCY, Gl.LINE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY,
        /// Gl.TRIANGLE_STRIP_ADJACENCY and Gl.PATCHES are accepted.
        /// </param>
        /// <param name="count">
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type">
        /// Specifies the type of the values in indices. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or Gl.UNSIGNED_INT.
        /// </param>
        /// <param name="indices">
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        /// <param name="primcount">
        /// Specifies the number of instances of the indexed geometry that should be drawn.
        /// </param>
        /// <param name="basevertex">
        /// Specifies a constant that should be added to each element of <paramref name="indices" /> when chosing elements from the
        /// enabled vertex arrays.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
        public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, object indices, int primcount, int basevertex)
        {
            GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                DrawElementsInstancedBaseVertex(mode, count, type, pin_indices.AddrOfPinnedObject(), primcount, basevertex);
            }
            finally
            {
                pin_indices.Free();
            }
        }

        /// <summary>
        /// [GL4] glMultiDrawElementsBaseVertex: render multiple sets of primitives by specifying indices of array data elements
        /// and
        /// an index to apply to each index
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
        /// Specifies the size of the <paramref name="count" />, <paramref name="indices" /> and <paramref name="basevertex" />
        /// arrays.
        /// </param>
        /// <param name="basevertex">
        /// Specifies a pointer to the location where the base vertices are stored.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
        public static void MultiDrawElementsBaseVertex(PrimitiveType mode, int[] count, DrawElementsType type, IntPtr[] indices, int drawcount, int[] basevertex)
        {
            unsafe
            {
                fixed (int* p_count = count)
                fixed (IntPtr* p_indices = indices)
                fixed (int* p_basevertex = basevertex)
                {
                    Debug.Assert(Delegates.pglMultiDrawElementsBaseVertex != null, "pglMultiDrawElementsBaseVertex not implemented");
                    Delegates.pglMultiDrawElementsBaseVertex((int) mode, p_count, (int) type, p_indices, drawcount, p_basevertex);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glProvokingVertex: specifiy the vertex to be used as the source of data for flat shaded varyings
        /// </summary>
        /// <param name="provokeMode">
        /// Specifies the vertex to be used as the source of data for flat shaded varyings.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ARB_provoking_vertex", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_provoking_vertex")]
        public static void ProvokingVertex(VertexProvokingMode provokeMode)
        {
            Debug.Assert(Delegates.pglProvokingVertex != null, "pglProvokingVertex not implemented");
            Delegates.pglProvokingVertex((int) provokeMode);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glFenceSync: create a new sync object and insert it into the GL command stream
        ///     </para>
        /// </summary>
        /// <param name="condition">
        /// Specifies the condition that must be met to set the sync object's state to signaled. <paramref name="condition" /> must
        /// be Gl.SYNC_GPU_COMMANDS_COMPLETE.
        /// </param>
        /// <param name="flags">
        /// Specifies a bitwise combination of flags controlling the behavior of the sync object. No flags are presently defined
        /// for
        /// this operation and <paramref name="flags" /> must be zero.<paramref name="flags" /> is a placeholder for anticipated
        /// future extensions of fence sync object capabilities.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        public static IntPtr FenceSync(SyncCondition condition, uint flags)
        {
            IntPtr retValue;

            Debug.Assert(Delegates.pglFenceSync != null, "pglFenceSync not implemented");
            retValue = Delegates.pglFenceSync((int) condition, flags);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glIsSync: determine if a name corresponds to a sync object
        ///     </para>
        /// </summary>
        /// <param name="sync">
        /// Specifies a value that may be the name of a sync object.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        public static bool IsSync(IntPtr sync)
        {
            bool retValue;

            Debug.Assert(Delegates.pglIsSync != null, "pglIsSync not implemented");
            retValue = Delegates.pglIsSync(sync);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDeleteSync: delete a sync object
        ///     </para>
        /// </summary>
        /// <param name="sync">
        /// The sync object to be deleted.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        public static void DeleteSync(IntPtr sync)
        {
            Debug.Assert(Delegates.pglDeleteSync != null, "pglDeleteSync not implemented");
            Delegates.pglDeleteSync(sync);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glClientWaitSync: block and wait for a sync object to become signaled
        ///     </para>
        /// </summary>
        /// <param name="sync">
        /// The sync object whose status to wait on.
        /// </param>
        /// <param name="flags">
        /// A bitfield controlling the command flushing behavior. <paramref name="flags" /> may be Gl.SYNC_FLUSH_COMMANDS_BIT.
        /// </param>
        /// <param name="timeout">
        /// The timeout, specified in nanoseconds, for which the implementation should wait for <paramref name="sync" /> to become
        /// signaled.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        public static SyncStatus ClientWaitSync(IntPtr sync, SyncObjectMask flags, ulong timeout)
        {
            int retValue;

            Debug.Assert(Delegates.pglClientWaitSync != null, "pglClientWaitSync not implemented");
            retValue = Delegates.pglClientWaitSync(sync, (uint) flags, timeout);
            DebugCheckErrors(retValue);

            return (SyncStatus) retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glWaitSync: instruct the GL server to block until the specified sync object becomes signaled
        ///     </para>
        /// </summary>
        /// <param name="sync">
        /// Specifies the sync object whose status to wait on.
        /// </param>
        /// <param name="flags">
        /// A bitfield controlling the command flushing behavior. <paramref name="flags" /> may be zero.
        /// </param>
        /// <param name="timeout">
        /// Specifies the timeout that the server should wait before continuing. <paramref name="timeout" /> must be
        /// Gl.TIMEOUT_IGNORED.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        public static void WaitSync(IntPtr sync, uint flags, ulong timeout)
        {
            Debug.Assert(Delegates.pglWaitSync != null, "pglWaitSync not implemented");
            Delegates.pglWaitSync(sync, flags, timeout);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetInteger64v: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        public static void Get(int pname, [Out] long[] data)
        {
            unsafe
            {
                fixed (long* p_data = data)
                {
                    Debug.Assert(Delegates.pglGetInteger64v != null, "pglGetInteger64v not implemented");
                    Delegates.pglGetInteger64v(pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetInteger64v: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        public static void Get(GetPName pname, [Out] long[] data)
        {
            unsafe
            {
                fixed (long* p_data = data)
                {
                    Debug.Assert(Delegates.pglGetInteger64v != null, "pglGetInteger64v not implemented");
                    Delegates.pglGetInteger64v((int) pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetInteger64v: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        public static void Get(int pname, out long data)
        {
            unsafe
            {
                fixed (long* p_data = &data)
                {
                    Debug.Assert(Delegates.pglGetInteger64v != null, "pglGetInteger64v not implemented");
                    Delegates.pglGetInteger64v(pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetInteger64v: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        public static void Get(GetPName pname, out long data)
        {
            unsafe
            {
                fixed (long* p_data = &data)
                {
                    Debug.Assert(Delegates.pglGetInteger64v != null, "pglGetInteger64v not implemented");
                    Delegates.pglGetInteger64v((int) pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetInteger64v: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        public static unsafe void Get(GetPName pname, [Out] long* data)
        {
            Debug.Assert(Delegates.pglGetInteger64v != null, "pglGetInteger64v not implemented");
            Delegates.pglGetInteger64v((int) pname, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetInteger64v: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        public static void GetInteger64<T>(GetPName pname, out T data) where T : struct
        {
            Debug.Assert(Delegates.pglGetInteger64v != null, "pglGetInteger64v not implemented");
            data = default;
            unsafe
            {
                TypedReference refData = __makeref(data);
                IntPtr refDataPtr = *(IntPtr*) (&refData);

                Delegates.pglGetInteger64v((int) pname, (long*) refDataPtr.ToPointer());
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetSynciv: query the properties of a sync object
        ///     </para>
        /// </summary>
        /// <param name="sync">
        /// Specifies the sync object whose properties to query.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter whose value to retrieve from the sync object specified in <paramref name="sync" />.
        /// </param>
        /// <param name="bufSize">
        /// Specifies the size of the buffer whose address is given in <paramref name="values" />.
        /// </param>
        /// <param name="length">
        /// Specifies the address of an variable to receive the number of integers placed in <paramref name="values" />.
        /// </param>
        /// <param name="values">
        /// Specifies the address of an array to receive the values of the queried parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        public static void GetSync(IntPtr sync, SyncParameterName pname, int bufSize, out int length, [Out] int[] values)
        {
            unsafe
            {
                fixed (int* p_length = &length)
                fixed (int* p_values = values)
                {
                    Debug.Assert(Delegates.pglGetSynciv != null, "pglGetSynciv not implemented");
                    Delegates.pglGetSynciv(sync, (int) pname, bufSize, p_length, p_values);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetSynciv: query the properties of a sync object
        ///     </para>
        /// </summary>
        /// <param name="sync">
        /// Specifies the sync object whose properties to query.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter whose value to retrieve from the sync object specified in <paramref name="sync" />.
        /// </param>
        /// <param name="length">
        /// Specifies the address of an variable to receive the number of integers placed in <paramref name="values" />.
        /// </param>
        /// <param name="values">
        /// Specifies the address of an array to receive the values of the queried parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
        [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
        public static unsafe void GetSync(IntPtr sync, SyncParameterName pname, out int length, [Out] int[] values)
        {
            fixed (int* p_length = &length)
            fixed (int* p_values = values)
            {
                Debug.Assert(Delegates.pglGetSynciv != null, "pglGetSynciv not implemented");
                Delegates.pglGetSynciv(sync, (int) pname, values.Length, p_length, p_values);
            }

            DebugCheckErrors(null);
        }

        public static unsafe int GetSync(IntPtr sync, SyncParameterName pname)
        {
            int value = 0;
            Debug.Assert(Delegates.pglGetSynciv != null, "pglGetSynciv not implemented");
            Delegates.pglGetSynciv(sync, (int) pname, sizeof(int), (int*) IntPtr.Zero, &value);
            DebugCheckErrors(null);
            return value;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetInteger64i_v: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below
        /// are accepted.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the particular element being queried.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public static void Get(int target, uint index, [Out] long[] data)
        {
            unsafe
            {
                fixed (long* p_data = data)
                {
                    Debug.Assert(Delegates.pglGetInteger64i_v != null, "pglGetInteger64i_v not implemented");
                    Delegates.pglGetInteger64i_v(target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetInteger64i_v: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below
        /// are accepted.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the particular element being queried.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public static void Get(GetPName target, uint index, [Out] long[] data)
        {
            unsafe
            {
                fixed (long* p_data = data)
                {
                    Debug.Assert(Delegates.pglGetInteger64i_v != null, "pglGetInteger64i_v not implemented");
                    Delegates.pglGetInteger64i_v((int) target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetInteger64i_v: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below
        /// are accepted.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the particular element being queried.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public static void Get(int target, uint index, out long data)
        {
            unsafe
            {
                fixed (long* p_data = &data)
                {
                    Debug.Assert(Delegates.pglGetInteger64i_v != null, "pglGetInteger64i_v not implemented");
                    Delegates.pglGetInteger64i_v(target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetInteger64i_v: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below
        /// are accepted.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the particular element being queried.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public static void Get(GetPName target, uint index, out long data)
        {
            unsafe
            {
                fixed (long* p_data = &data)
                {
                    Debug.Assert(Delegates.pglGetInteger64i_v != null, "pglGetInteger64i_v not implemented");
                    Delegates.pglGetInteger64i_v((int) target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetInteger64i_v: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below
        /// are accepted.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the particular element being queried.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public static unsafe void Get(GetPName target, uint index, [Out] long* data)
        {
            Debug.Assert(Delegates.pglGetInteger64i_v != null, "pglGetInteger64i_v not implemented");
            Delegates.pglGetInteger64i_v((int) target, index, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetInteger64i_v: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below
        /// are accepted.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the particular element being queried.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public static void GetInteger64<T>(GetPName target, uint index, out T data) where T : struct
        {
            Debug.Assert(Delegates.pglGetInteger64i_v != null, "pglGetInteger64i_v not implemented");
            data = default;
            unsafe
            {
                TypedReference refData = __makeref(data);
                IntPtr refDataPtr = *(IntPtr*) (&refData);

                Delegates.pglGetInteger64i_v((int) target, index, (long*) refDataPtr.ToPointer());
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetBufferParameteri64v: return parameters of a buffer object
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound for Gl.GetBufferParameteriv and Gl.GetBufferParameteri64v.
        /// Must
        /// be one of the buffer binding targets in the following table:
        /// </param>
        /// <param name="value">
        /// Specifies the name of the buffer object parameter to query.
        /// </param>
        /// <param name="data">
        /// Returns the requested parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public static void GetBufferParameter(BufferTarget target, int value, [Out] long[] data)
        {
            unsafe
            {
                fixed (long* p_params = data)
                {
                    Debug.Assert(Delegates.pglGetBufferParameteri64v != null, "pglGetBufferParameteri64v not implemented");
                    Delegates.pglGetBufferParameteri64v((int) target, value, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glFramebufferTexture: attach a level of a texture object as a logical buffer of a framebuffer object
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the framebuffer is bound for all commands exceptGl.NamedFramebufferTexture.
        /// </param>
        /// <param name="attachment">
        /// Specifies the attachment point of the framebuffer.
        /// </param>
        /// <param name="texture">
        /// Specifies the name of an existing texture object to attach.
        /// </param>
        /// <param name="level">
        /// Specifies the mipmap level of the texture object to attach.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_NV_geometry_program4")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public static void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level)
        {
            Debug.Assert(Delegates.pglFramebufferTexture != null, "pglFramebufferTexture not implemented");
            Delegates.pglFramebufferTexture((int) target, (int) attachment, texture, level);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glTexImage2DMultisample: establish the data storage, format, dimensions, and number of samples of a multisample
        /// texture's image
        /// </summary>
        /// <param name="target">
        /// Specifies the target of the operation. <paramref name="target" /> must be Gl.TEXTURE_2D_MULTISAMPLE or
        /// Gl.PROXY_TEXTURE_2D_MULTISAMPLE.
        /// </param>
        /// <param name="samples">
        /// The number of samples in the multisample texture's image.
        /// </param>
        /// <param name="internalformat">
        /// The internal format to be used to store the multisample texture's image. <paramref name="internalformat" /> must
        /// specify
        /// a color-renderable, depth-renderable, or stencil-renderable format.
        /// </param>
        /// <param name="width">
        /// The width of the multisample texture's image, in texels.
        /// </param>
        /// <param name="height">
        /// The height of the multisample texture's image, in texels.
        /// </param>
        /// <param name="fixedsamplelocations">
        /// Specifies whether the image will use identical sample locations and the same number of samples for all texels in the
        /// image, and the sample locations will not depend on the internal format or size of the image.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        public static void TexImage2DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, bool fixedsamplelocations)
        {
            Debug.Assert(Delegates.pglTexImage2DMultisample != null, "pglTexImage2DMultisample not implemented");
            Delegates.pglTexImage2DMultisample((int) target, samples, (int) internalformat, width, height, fixedsamplelocations);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glTexImage3DMultisample: establish the data storage, format, dimensions, and number of samples of a multisample
        /// texture's image
        /// </summary>
        /// <param name="target">
        /// Specifies the target of the operation. <paramref name="target" /> must be Gl.TEXTURE_2D_MULTISAMPLE_ARRAY or
        /// Gl.PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY.
        /// </param>
        /// <param name="samples">
        /// The number of samples in the multisample texture's image.
        /// </param>
        /// <param name="internalformat">
        /// The internal format to be used to store the multisample texture's image. <paramref name="internalformat" /> must
        /// specify
        /// a color-renderable, depth-renderable, or stencil-renderable format.
        /// </param>
        /// <param name="width">
        /// The width of the multisample texture's image, in texels.
        /// </param>
        /// <param name="height">
        /// The height of the multisample texture's image, in texels.
        /// </param>
        /// <param name="depth">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="fixedsamplelocations">
        /// Specifies whether the image will use identical sample locations and the same number of samples for all texels in the
        /// image, and the sample locations will not depend on the internal format or size of the image.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        public static void TexImage3DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations)
        {
            Debug.Assert(Delegates.pglTexImage3DMultisample != null, "pglTexImage3DMultisample not implemented");
            Delegates.pglTexImage3DMultisample((int) target, samples, (int) internalformat, width, height, depth, fixedsamplelocations);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetMultisamplefv: retrieve the location of a sample
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the sample parameter name. <paramref name="pname" /> must be Gl.SAMPLE_POSITION.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the sample whose position to query.
        /// </param>
        /// <param name="val">
        /// Specifies the address of an array to receive the position of the sample.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_explicit_multisample")]
        public static void GetMultisample(int pname, uint index, [Out] float[] val)
        {
            unsafe
            {
                fixed (float* p_val = val)
                {
                    Debug.Assert(Delegates.pglGetMultisamplefv != null, "pglGetMultisamplefv not implemented");
                    Delegates.pglGetMultisamplefv(pname, index, p_val);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glSampleMaski: set the value of a sub-word of the sample mask
        ///     </para>
        /// </summary>
        /// <param name="maskNumber">
        /// Specifies which 32-bit sub-word of the sample mask to update.
        /// </param>
        /// <param name="mask">
        /// Specifies the new value of the mask sub-word.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_2")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
        public static void SampleMask(uint maskNumber, uint mask)
        {
            Debug.Assert(Delegates.pglSampleMaski != null, "pglSampleMaski not implemented");
            Delegates.pglSampleMaski(maskNumber, mask);
            DebugCheckErrors(null);
        }

        public static unsafe partial class Delegates
        {
            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
            [RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDrawElementsBaseVertex(int mode, int count, int type, IntPtr indices, int basevertex);

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2", EntryPoint = "glDrawElementsBaseVertexEXT")]
            [RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2", EntryPoint = "glDrawElementsBaseVertexOES")]
            [ThreadStatic]
            public static glDrawElementsBaseVertex pglDrawElementsBaseVertex;

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
            [RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDrawRangeElementsBaseVertex(int mode, uint start, uint end, int count, int type, IntPtr indices, int basevertex);

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2", EntryPoint = "glDrawRangeElementsBaseVertexEXT")]
            [RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2", EntryPoint = "glDrawRangeElementsBaseVertexOES")]
            [ThreadStatic]
            public static glDrawRangeElementsBaseVertex pglDrawRangeElementsBaseVertex;

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
            [RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDrawElementsInstancedBaseVertex(int mode, int count, int type, IntPtr indices, int instancecount, int basevertex);

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2", EntryPoint = "glDrawElementsInstancedBaseVertexEXT")]
            [RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2", EntryPoint = "glDrawElementsInstancedBaseVertexOES")]
            [ThreadStatic]
            public static glDrawElementsInstancedBaseVertex pglDrawElementsInstancedBaseVertex;

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2")]
            [RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glMultiDrawElementsBaseVertex(int mode, int* count, int type, IntPtr* indices, int drawcount, int* basevertex);

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ARB_draw_elements_base_vertex", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_draw_elements_base_vertex", Api = "gles2", EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
            [RequiredByFeature("GL_OES_draw_elements_base_vertex", Api = "gles2", EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
            [ThreadStatic]
            public static glMultiDrawElementsBaseVertex pglMultiDrawElementsBaseVertex;

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ARB_provoking_vertex", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_provoking_vertex")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glProvokingVertex(int mode);

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ARB_provoking_vertex", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_provoking_vertex", EntryPoint = "glProvokingVertexEXT")]
            [ThreadStatic]
            public static glProvokingVertex pglProvokingVertex;

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
            [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr glFenceSync(int condition, uint flags);

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2", EntryPoint = "glFenceSyncAPPLE")]
            [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
            [ThreadStatic]
            public static glFenceSync pglFenceSync;

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
            [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.I1)]
            public delegate bool glIsSync(IntPtr sync);

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2", EntryPoint = "glIsSyncAPPLE")]
            [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
            [ThreadStatic]
            public static glIsSync pglIsSync;

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
            [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDeleteSync(IntPtr sync);

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2", EntryPoint = "glDeleteSyncAPPLE")]
            [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
            [ThreadStatic]
            public static glDeleteSync pglDeleteSync;

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
            [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate int glClientWaitSync(IntPtr sync, uint flags, ulong timeout);

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2", EntryPoint = "glClientWaitSyncAPPLE")]
            [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
            [ThreadStatic]
            public static glClientWaitSync pglClientWaitSync;

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
            [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glWaitSync(IntPtr sync, uint flags, ulong timeout);

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2", EntryPoint = "glWaitSyncAPPLE")]
            [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
            [ThreadStatic]
            public static glWaitSync pglWaitSync;

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
            [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetInteger64v(int pname, long* data);

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2", EntryPoint = "glGetInteger64vAPPLE")]
            [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
            [ThreadStatic]
            public static glGetInteger64v pglGetInteger64v;

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
            [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetSynciv(IntPtr sync, int pname, int bufSize, int* length, int* values);

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2", EntryPoint = "glGetSyncivAPPLE")]
            [RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
            [ThreadStatic]
            public static glGetSynciv pglGetSynciv;

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetInteger64i_v(int target, uint index, long* data);

            [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [ThreadStatic]
            public static glGetInteger64i_v pglGetInteger64i_v;

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetBufferParameteri64v(int target, int pname, long* @params);

            [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [ThreadStatic]
            public static glGetBufferParameteri64v pglGetBufferParameteri64v;

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
            [RequiredByFeature("GL_NV_geometry_program4")]
            [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glFramebufferTexture(int target, int attachment, uint texture, int level);

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore", EntryPoint = "glFramebufferTextureARB")]
            [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2", EntryPoint = "glFramebufferTextureEXT")]
            [RequiredByFeature("GL_NV_geometry_program4", EntryPoint = "glFramebufferTextureEXT")]
            [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2", EntryPoint = "glFramebufferTextureOES")]
            [ThreadStatic]
            public static glFramebufferTexture pglFramebufferTexture;

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glTexImage2DMultisample(int target, int samples, int internalformat, int width, int height, [MarshalAs(UnmanagedType.I1)] bool fixedsamplelocations);

            [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")] [ThreadStatic]
            public static glTexImage2DMultisample pglTexImage2DMultisample;

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glTexImage3DMultisample(int target, int samples, int internalformat, int width, int height, int depth, [MarshalAs(UnmanagedType.I1)] bool fixedsamplelocations);

            [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")] [ThreadStatic]
            public static glTexImage3DMultisample pglTexImage3DMultisample;

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
            [RequiredByFeature("GL_NV_explicit_multisample")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetMultisamplefv(int pname, uint index, float* val);

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
            [RequiredByFeature("GL_NV_explicit_multisample", EntryPoint = "glGetMultisamplefvNV")]
            [ThreadStatic]
            public static glGetMultisamplefv pglGetMultisamplefv;

            [RequiredByFeature("GL_VERSION_3_2")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glSampleMaski(uint maskNumber, uint mask);

            [RequiredByFeature("GL_VERSION_3_2")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")] [ThreadStatic]
            public static glSampleMaski pglSampleMaski;
        }
    }
}