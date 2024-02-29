#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective

#region Using

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Emotion.Platform;
using Emotion.Utility;
using Khronos;

#endregion

// ReSharper disable StringLiteralTypo
// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer
// ReSharper disable InvalidXmlDocComment
// ReSharper disable CommentTypo

#pragma warning disable CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type

namespace OpenGL
{
    public partial class Gl
    {
        /// <summary>
        /// [GL] Value of GL_CLIP_DISTANCE0 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_APPLE_clip_distance", Api = "gles2")]
        public const int CLIP_DISTANCE0 = 0x3000;

        /// <summary>
        /// [GL] Value of GL_CLIP_DISTANCE1 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_APPLE_clip_distance", Api = "gles2")]
        public const int CLIP_DISTANCE1 = 0x3001;

        /// <summary>
        /// [GL] Value of GL_CLIP_DISTANCE2 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_APPLE_clip_distance", Api = "gles2")]
        public const int CLIP_DISTANCE2 = 0x3002;

        /// <summary>
        /// [GL] Value of GL_CLIP_DISTANCE3 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_APPLE_clip_distance", Api = "gles2")]
        public const int CLIP_DISTANCE3 = 0x3003;

        /// <summary>
        /// [GL] Value of GL_CLIP_DISTANCE4 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_APPLE_clip_distance", Api = "gles2")]
        public const int CLIP_DISTANCE4 = 0x3004;

        /// <summary>
        /// [GL] Value of GL_CLIP_DISTANCE5 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_APPLE_clip_distance", Api = "gles2")]
        public const int CLIP_DISTANCE5 = 0x3005;

        /// <summary>
        /// [GL] Value of GL_CLIP_DISTANCE6 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_APPLE_clip_distance", Api = "gles2")]
        public const int CLIP_DISTANCE6 = 0x3006;

        /// <summary>
        /// [GL] Value of GL_CLIP_DISTANCE7 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_APPLE_clip_distance", Api = "gles2")]
        public const int CLIP_DISTANCE7 = 0x3007;

        /// <summary>
        /// [GL4] Gl.Get: data returns one value, the maximum number of application-defined clipping distances. The value must be
        /// at
        /// least 8.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_APPLE_clip_distance", Api = "gles2")]
        public const int MAX_CLIP_DISTANCES = 0x0D32;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the major version number of the OpenGL API supported by the current context.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the major version number of the OpenGL ES API supported by the current
        ///     context. This must be 3.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int MAJOR_VERSION = 0x821B;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the minor version number of the OpenGL API supported by the current context.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the minor version number of the OpenGL ES API supported by the current
        ///     context.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int MINOR_VERSION = 0x821C;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the number of extensions supported by the GL implementation for the
        /// current context. See Gl.GetString.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int NUM_EXTENSIONS = 0x821D;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the flags with which the context was created (such as debugging
        /// functionality).
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        public const int CONTEXT_FLAGS = 0x821E;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_RED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] public const int COMPRESSED_RED = 0x8225;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_RG symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] public const int COMPRESSED_RG = 0x8226;

        /// <summary>
        /// [GL] Value of GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] public const uint CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001;

        /// <summary>
        /// [GL] Value of GL_RGBA32F symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_float")]
        [RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
        public const int RGBA32F = 0x8814;

        /// <summary>
        /// [GL] Value of GL_RGB32F symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_buffer_object_rgb32", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_texture_float")]
        [RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
        public const int RGB32F = 0x8815;

        /// <summary>
        /// [GL] Value of GL_RGBA16F symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_float")]
        [RequiredByFeature("GL_EXT_color_buffer_half_float", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
        public const int RGBA16F = 0x881A;

        /// <summary>
        /// [GL] Value of GL_RGB16F symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_float")]
        [RequiredByFeature("GL_EXT_color_buffer_half_float", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
        public const int RGB16F = 0x881B;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetVertexAttrib: params returns a single value that is non-zero (true) if fixed-point data types for
        /// the vertex attribute array indicated by index have integer data types, and 0 (false) otherwise. The initial value is 0
        /// (Gl.FALSE).
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4")] [RequiredByFeature("GL_NV_vertex_program4")]
        public const int VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value. The value indicates the maximum number of layers allowed in an array
        /// texture, and must be at least 256. See Gl.TexImage2D.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture_array")]
        public const int MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the minimum texel offset allowed in a texture lookup, which must be at
        /// most -8.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4")] [RequiredByFeature("GL_NV_gpu_program4")]
        public const int MIN_PROGRAM_TEXEL_OFFSET = 0x8904;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum texel offset allowed in a texture lookup, which must be at
        /// least 7.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4")] [RequiredByFeature("GL_NV_gpu_program4")]
        public const int MAX_PROGRAM_TEXEL_OFFSET = 0x8905;

        /// <summary>
        /// [GL] Value of GL_CLAMP_READ_COLOR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ARB_color_buffer_float")]
        public const int CLAMP_READ_COLOR = 0x891C;

        /// <summary>
        /// [GL] Value of GL_FIXED_ONLY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ARB_color_buffer_float")]
        public const int FIXED_ONLY = 0x891D;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_1D_ARRAY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_texture_array")]
        public const int TEXTURE_1D_ARRAY = 0x8C18;

        /// <summary>
        /// [GL] Value of GL_PROXY_TEXTURE_1D_ARRAY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_EXT_texture_array")]
        public const int PROXY_TEXTURE_1D_ARRAY = 0x8C19;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_2D_ARRAY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_array")]
        public const int TEXTURE_2D_ARRAY = 0x8C1A;

        /// <summary>
        /// [GL] Value of GL_PROXY_TEXTURE_2D_ARRAY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_EXT_texture_array")]
        public const int PROXY_TEXTURE_2D_ARRAY = 0x8C1B;

        /// <summary>
        /// [GL4] Gl.Get: data returns a single value, the name of the texture currently bound to the target Gl.TEXTURE_1D_ARRAY.
        /// The initial value is 0. See Gl.BindTexture.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_VERSION_4_5")] [RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_texture_array")]
        public const int TEXTURE_BINDING_1D_ARRAY = 0x8C1C;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single value, the name of the texture currently bound to the target
        /// Gl.TEXTURE_2D_ARRAY. The initial value is 0. See Gl.BindTexture.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_VERSION_4_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_array")]
        public const int TEXTURE_BINDING_2D_ARRAY = 0x8C1D;

        /// <summary>
        /// [GL] Value of GL_R11F_G11F_B10F symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_texture_packed_float", Api = "gles2")]
        [RequiredByFeature("GL_EXT_packed_float")]
        public const int R11F_G11F_B10F = 0x8C3A;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_INT_10F_11F_11F_REV symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_vertex_type_10f_11f_11f_rev", Api = "gl|glcore")]
        [RequiredByFeature("GL_APPLE_texture_packed_float", Api = "gles2")]
        [RequiredByFeature("GL_EXT_packed_float")]
        public const int UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;

        /// <summary>
        /// [GL] Value of GL_RGB9_E5 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_texture_packed_float", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_shared_exponent")]
        public const int RGB9_E5 = 0x8C3D;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_INT_5_9_9_9_REV symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_texture_packed_float", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_shared_exponent")]
        public const int UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_SHARED_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_EXT_texture_shared_exponent")]
        public const int TEXTURE_SHARED_SIZE = 0x8C3F;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetProgram: params returns the length of the longest variable name to be used for transform feedback,
        /// including the null-terminator.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_transform_feedback")]
        public const int TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetProgram: params returns a symbolic constant indicating the buffer mode used when transform feedback
        /// is active. This may be Gl.SEPARATE_ATTRIBS or Gl.INTERLEAVED_ATTRIBS.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_transform_feedback")] [RequiredByFeature("GL_NV_transform_feedback")]
        public const int TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;

        /// <summary>
        /// [GLES3.2] Gl.Get: data returns one value, the maximum number of components which can be written per attribute or output
        /// in separate transform feedback mode. The value must be at least 4. See Gl.TransformFeedbackVaryings.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_transform_feedback")] [RequiredByFeature("GL_NV_transform_feedback")]
        public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetProgram: params returns the number of varying variables to capture in transform feedback mode for
        /// the program.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_transform_feedback")] [RequiredByFeature("GL_NV_transform_feedback")]
        public const int TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: When used with indexed variants of glGet (such as glGetInteger64i_v), data returns a single
        /// value,
        /// the start offset of the binding range for each transform feedback attribute stream. The initial value is 0 for all
        /// streams. See Gl.BindBufferRange.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_transform_feedback")] [RequiredByFeature("GL_NV_transform_feedback")]
        public const int TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: When used with indexed variants of glGet (such as glGetInteger64i_v), data returns a single
        /// value,
        /// the size of the binding range for each transform feedback attribute stream. The initial value is 0 for all streams. See
        /// Gl.BindBufferRange.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_transform_feedback")] [RequiredByFeature("GL_NV_transform_feedback")]
        public const int TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;

        /// <summary>
        /// [GL] Value of GL_PRIMITIVES_GENERATED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_EXT_transform_feedback")]
        [RequiredByFeature("GL_NV_transform_feedback")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int PRIMITIVES_GENERATED = 0x8C87;

        /// <summary>
        /// [GL] Value of GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_transform_feedback")] [RequiredByFeature("GL_NV_transform_feedback")]
        public const int TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;

        /// <summary>
        /// [GLES3.2] Gl.Get: data returns one value, a single boolean value indicating whether primitives are discarded
        /// immediately
        /// before the rasterization stage, but after the optional transform feedback stage. See Gl.Enable.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_transform_feedback")] [RequiredByFeature("GL_NV_transform_feedback")]
        public const int RASTERIZER_DISCARD = 0x8C89;

        /// <summary>
        /// [GLES3.2] Gl.Get: data returns one value, the maximum number of components which can be written to a single transform
        /// feedback buffer in interleaved mode. The value must be at least 64. See Gl.TransformFeedbackVaryings.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_transform_feedback")] [RequiredByFeature("GL_NV_transform_feedback")]
        public const int MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;

        /// <summary>
        /// [GLES3.2] Gl.Get: data returns one value, the maximum separate attributes or outputs which can be captured in separate
        /// transform feedback mode. The value must be at least 4. See Gl.TransformFeedbackVaryings.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_transform_feedback")] [RequiredByFeature("GL_NV_transform_feedback")]
        public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;

        /// <summary>
        /// [GL] Value of GL_INTERLEAVED_ATTRIBS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_transform_feedback")] [RequiredByFeature("GL_NV_transform_feedback")]
        public const int INTERLEAVED_ATTRIBS = 0x8C8C;

        /// <summary>
        /// [GL] Value of GL_SEPARATE_ATTRIBS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_transform_feedback")] [RequiredByFeature("GL_NV_transform_feedback")]
        public const int SEPARATE_ATTRIBS = 0x8C8D;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetProgramInterface: The query is targeted at the set of active buffer binding points to which output
        ///     variables
        ///     in the Gl.TRANSFORM_FEEDBACK_VARYING interface are written.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetProgramResourceIndex: The query is targeted at the set of active buffer binding points to which output
        ///     variables in the Gl.TRANSFORM_FEEDBACK_VARYING interface are written.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramInterface: The query is targeted at the set of active buffer binding points to which output
        ///     variables in the Gl.TRANSFORM_FEEDBACK_VARYING interface are written.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_enhanced_layouts", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_transform_feedback")]
        [RequiredByFeature("GL_NV_transform_feedback")]
        public const int TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: When used with non-indexed variants of glGet (such as glGetIntegerv), data returns a single
        /// value,
        /// the name of the buffer object currently bound to the target Gl.TRANSFORM_FEEDBACK_BUFFER. If no buffer object is bound
        /// to this target, 0 is returned. When used with indexed variants of glGet (such as glGetIntegeri_v), data returns a
        /// single
        /// value, the name of the buffer object bound to the indexed transform feedback attribute stream. The initial value is 0
        /// for all targets. See Gl.BindBuffer, Gl.BindBufferBase, and Gl.BindBufferRange.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_transform_feedback")] [RequiredByFeature("GL_NV_transform_feedback")]
        public const int TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;

        /// <summary>
        /// [GL] Value of GL_RGBA32UI symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture_integer")]
        public const int RGBA32UI = 0x8D70;

        /// <summary>
        /// [GL] Value of GL_RGB32UI symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_buffer_object_rgb32", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_integer")]
        public const int RGB32UI = 0x8D71;

        /// <summary>
        /// [GL] Value of GL_RGBA16UI symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture_integer")]
        public const int RGBA16UI = 0x8D76;

        /// <summary>
        /// [GL] Value of GL_RGB16UI symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture_integer")]
        public const int RGB16UI = 0x8D77;

        /// <summary>
        /// [GL] Value of GL_RGBA8UI symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_AMD_interleaved_elements")] [RequiredByFeature("GL_EXT_texture_integer")]
        public const int RGBA8UI = 0x8D7C;

        /// <summary>
        /// [GL] Value of GL_RGB8UI symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture_integer")]
        public const int RGB8UI = 0x8D7D;

        /// <summary>
        /// [GL] Value of GL_RGBA32I symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture_integer")]
        public const int RGBA32I = 0x8D82;

        /// <summary>
        /// [GL] Value of GL_RGB32I symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_buffer_object_rgb32", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_integer")]
        public const int RGB32I = 0x8D83;

        /// <summary>
        /// [GL] Value of GL_RGBA16I symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture_integer")]
        public const int RGBA16I = 0x8D88;

        /// <summary>
        /// [GL] Value of GL_RGB16I symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture_integer")]
        public const int RGB16I = 0x8D89;

        /// <summary>
        /// [GL] Value of GL_RGBA8I symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture_integer")]
        public const int RGBA8I = 0x8D8E;

        /// <summary>
        /// [GL] Value of GL_RGB8I symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture_integer")]
        public const int RGB8I = 0x8D8F;

        /// <summary>
        /// [GL] Value of GL_RED_INTEGER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture_integer")]
        public const int RED_INTEGER = 0x8D94;

        /// <summary>
        /// [GL] Value of GL_GREEN_INTEGER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_EXT_texture_integer")]
        public const int GREEN_INTEGER = 0x8D95;

        /// <summary>
        /// [GL] Value of GL_BLUE_INTEGER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_EXT_texture_integer")]
        public const int BLUE_INTEGER = 0x8D96;

        /// <summary>
        /// [GL] Value of GL_RGB_INTEGER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture_integer")]
        public const int RGB_INTEGER = 0x8D98;

        /// <summary>
        /// [GL] Value of GL_RGBA_INTEGER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_texture_integer")]
        public const int RGBA_INTEGER = 0x8D99;

        /// <summary>
        /// [GL] Value of GL_BGR_INTEGER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_EXT_texture_integer")]
        public const int BGR_INTEGER = 0x8D9A;

        /// <summary>
        /// [GL] Value of GL_BGRA_INTEGER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_EXT_texture_integer")]
        public const int BGRA_INTEGER = 0x8D9B;

        /// <summary>
        /// [GL] Value of GL_SAMPLER_1D_ARRAY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_EXT_gpu_shader4")]
        public const int SAMPLER_1D_ARRAY = 0x8DC0;

        /// <summary>
        /// [GL] Value of GL_SAMPLER_2D_ARRAY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4")]
        public const int SAMPLER_2D_ARRAY = 0x8DC1;

        /// <summary>
        /// [GL] Value of GL_SAMPLER_1D_ARRAY_SHADOW symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_EXT_gpu_shader4")]
        public const int SAMPLER_1D_ARRAY_SHADOW = 0x8DC3;

        /// <summary>
        /// [GL] Value of GL_SAMPLER_2D_ARRAY_SHADOW symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        [RequiredByFeature("GL_NV_shadow_samplers_array", Api = "gles2")]
        public const int SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;

        /// <summary>
        /// [GL] Value of GL_SAMPLER_CUBE_SHADOW symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        [RequiredByFeature("GL_NV_shadow_samplers_cube", Api = "gles2")]
        public const int SAMPLER_CUBE_SHADOW = 0x8DC5;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_INT_VEC2 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4")]
        public const int UNSIGNED_INT_VEC2 = 0x8DC6;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_INT_VEC3 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4")]
        public const int UNSIGNED_INT_VEC3 = 0x8DC7;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_INT_VEC4 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4")]
        public const int UNSIGNED_INT_VEC4 = 0x8DC8;

        /// <summary>
        /// [GL] Value of GL_INT_SAMPLER_1D symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_EXT_gpu_shader4")]
        public const int INT_SAMPLER_1D = 0x8DC9;

        /// <summary>
        /// [GL] Value of GL_INT_SAMPLER_2D symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4")]
        public const int INT_SAMPLER_2D = 0x8DCA;

        /// <summary>
        /// [GL] Value of GL_INT_SAMPLER_3D symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4")]
        public const int INT_SAMPLER_3D = 0x8DCB;

        /// <summary>
        /// [GL] Value of GL_INT_SAMPLER_CUBE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4")]
        public const int INT_SAMPLER_CUBE = 0x8DCC;

        /// <summary>
        /// [GL] Value of GL_INT_SAMPLER_1D_ARRAY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_EXT_gpu_shader4")]
        public const int INT_SAMPLER_1D_ARRAY = 0x8DCE;

        /// <summary>
        /// [GL] Value of GL_INT_SAMPLER_2D_ARRAY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4")]
        public const int INT_SAMPLER_2D_ARRAY = 0x8DCF;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_INT_SAMPLER_1D symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_EXT_gpu_shader4")]
        public const int UNSIGNED_INT_SAMPLER_1D = 0x8DD1;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_INT_SAMPLER_2D symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4")]
        public const int UNSIGNED_INT_SAMPLER_2D = 0x8DD2;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_INT_SAMPLER_3D symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4")]
        public const int UNSIGNED_INT_SAMPLER_3D = 0x8DD3;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_INT_SAMPLER_CUBE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4")]
        public const int UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_INT_SAMPLER_1D_ARRAY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_EXT_gpu_shader4")]
        public const int UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_INT_SAMPLER_2D_ARRAY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4")]
        public const int UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;

        /// <summary>
        /// [GL] Value of GL_QUERY_WAIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_conditional_render", Api = "gl|glcore|gles2")]
        public const int QUERY_WAIT = 0x8E13;

        /// <summary>
        /// [GL] Value of GL_QUERY_NO_WAIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_conditional_render", Api = "gl|glcore|gles2")]
        public const int QUERY_NO_WAIT = 0x8E14;

        /// <summary>
        /// [GL] Value of GL_QUERY_BY_REGION_WAIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_conditional_render", Api = "gl|glcore|gles2")]
        public const int QUERY_BY_REGION_WAIT = 0x8E15;

        /// <summary>
        /// [GL] Value of GL_QUERY_BY_REGION_NO_WAIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_conditional_render", Api = "gl|glcore|gles2")]
        public const int QUERY_BY_REGION_NO_WAIT = 0x8E16;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetBufferParameter: params returns the access policy set while mapping the buffer object (the value of the
        ///     access parameter bitfield passed to glMapBufferRange). If the buffer was mapped with glMapBuffer, the access policy
        ///     is
        ///     determined by translating the enums in that access parameter to the corresponding bits for glMapBufferRange as
        ///     described
        ///     in the OpenGL Specification. The initial value is zero.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetBufferParameter: params returns the access policy set while mapping the buffer object.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int BUFFER_ACCESS_FLAGS = 0x911F;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetBufferParameter: params returns the length of the mapping into the buffer object established with
        ///     glMapBuffer*. The i64v versions of these queries should be used for this parameter. The initial value is zero.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetBufferParameter: params returns the length of the buffer object mapping, measured in bytes. The
        ///     initial
        ///     value is 0.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int BUFFER_MAP_LENGTH = 0x9120;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetBufferParameter: params returns the offset of the mapping into the buffer object established with
        ///     glMapBuffer*. The i64v versions of these queries should be used for this parameter. The initial value is zero.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetBufferParameter: params returns the offset (start) of the buffer object mapping, measured in bytes.
        ///     The
        ///     initial value is 0.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int BUFFER_MAP_OFFSET = 0x9121;

        /// <summary>
        /// [GL] Value of GL_DEPTH_COMPONENT32F symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_depth_buffer_float", Api = "gl|glcore")]
        public const int DEPTH_COMPONENT32F = 0x8CAC;

        /// <summary>
        /// [GL] Value of GL_DEPTH32F_STENCIL8 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_depth_buffer_float", Api = "gl|glcore")]
        public const int DEPTH32F_STENCIL8 = 0x8CAD;

        /// <summary>
        /// [GL] Value of GL_FLOAT_32_UNSIGNED_INT_24_8_REV symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_depth_buffer_float", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_depth_buffer_float")]
        public const int FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetError: The framebuffer object is not complete. The offending command is ignored and has no other
        /// side effect than to set the error flag.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int INVALID_FRAMEBUFFER_OPERATION = 0x0506;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_sRGB", Api = "gles1|gles2")]
        public const int FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_color_buffer_half_float", Api = "gles2")]
        public const int FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        public const int FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        public const int FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        public const int FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        public const int FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        public const int FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        public const int FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_DEFAULT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        public const int FRAMEBUFFER_DEFAULT = 0x8218;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_UNDEFINED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_surfaceless_context", Api = "gles1|gles2")]
        public const int FRAMEBUFFER_UNDEFINED = 0x8219;

        /// <summary>
        /// [GL] Value of GL_DEPTH_STENCIL_ATTACHMENT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        public const int DEPTH_STENCIL_ATTACHMENT = 0x821A;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value. The value indicates the maximum supported size for renderbuffers. See
        ///     Gl.FramebufferRenderbuffer.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value. The value indicates the maximum supported size for renderbuffers and must
        ///     be
        ///     at least 2048. See Gl.FramebufferRenderbuffer.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int MAX_RENDERBUFFER_SIZE = 0x84E8;

        /// <summary>
        /// [GL] Value of GL_DEPTH_STENCIL symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_packed_depth_stencil")]
        [RequiredByFeature("GL_NV_packed_depth_stencil")]
        [RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
        [RequiredByFeature("GL_OES_packed_depth_stencil", Api = "gles1|gles2")]
        public const int DEPTH_STENCIL = 0x84F9;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_INT_24_8 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_packed_depth_stencil")]
        [RequiredByFeature("GL_NV_packed_depth_stencil")]
        [RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
        [RequiredByFeature("GL_OES_packed_depth_stencil", Api = "gles1|gles2")]
        public const int UNSIGNED_INT_24_8 = 0x84FA;

        /// <summary>
        /// [GL] Value of GL_DEPTH24_STENCIL8 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_packed_depth_stencil")]
        [RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
        [RequiredByFeature("GL_OES_packed_depth_stencil", Api = "gles1|gles2")]
        [RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
        public const int DEPTH24_STENCIL8 = 0x88F0;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_STENCIL_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_packed_depth_stencil")]
        public const int TEXTURE_STENCIL_SIZE = 0x88F1;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetTexLevelParameter: The data type used to store the component. The types Gl.NONE, Gl.SIGNED_NORMALIZED,
        ///     Gl.UNSIGNED_NORMALIZED, Gl.FLOAT, Gl.INT, and Gl.UNSIGNED_INT may be returned to indicate signed normalized
        ///     fixed-point,
        ///     unsigned normalized fixed-point, floating-point, integer unnormalized, and unsigned integer unnormalized
        ///     components,
        ///     respectively.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetTexLevelParameter: The data type used to store the component. The types Gl.NONE,
        ///     Gl.SIGNED_NORMALIZED,
        ///     Gl.UNSIGNED_NORMALIZED, Gl.FLOAT, Gl.INT, and Gl.UNSIGNED_INT may be returned to indicate missing, signed
        ///     normalized
        ///     fixed-point, unsigned normalized fixed-point, floating-point, signed unnormalized integer, and unsigned
        ///     unnormalized
        ///     integer components, respectively.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_float")]
        public const int TEXTURE_RED_TYPE = 0x8C10;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_GREEN_TYPE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_float")]
        public const int TEXTURE_GREEN_TYPE = 0x8C11;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_BLUE_TYPE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_float")]
        public const int TEXTURE_BLUE_TYPE = 0x8C12;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_ALPHA_TYPE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_float")]
        public const int TEXTURE_ALPHA_TYPE = 0x8C13;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_DEPTH_TYPE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_float")]
        public const int TEXTURE_DEPTH_TYPE = 0x8C16;

        /// <summary>
        /// [GL] Value of GL_UNSIGNED_NORMALIZED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_texture_float")]
        [RequiredByFeature("GL_EXT_color_buffer_half_float", Api = "gles2")]
        public const int UNSIGNED_NORMALIZED = 0x8C17;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_BINDING symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int FRAMEBUFFER_BINDING = 0x8CA6;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the name of the framebuffer object currently bound to the
        /// Gl.DRAW_FRAMEBUFFER target. If the default framebuffer is bound, this value will be zero. The initial value is zero.
        /// See
        /// Gl.BindFramebuffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_ANGLE_framebuffer_blit", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_blit")]
        [RequiredByFeature("GL_NV_framebuffer_blit", Api = "gles2")]
        public const int DRAW_FRAMEBUFFER_BINDING = 0x8CA6;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single value, the name of the renderbuffer object currently bound to the target
        /// Gl.RENDERBUFFER. If no renderbuffer object is bound to this target, 0 is returned. The initial value is 0. See
        /// Gl.BindRenderbuffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int RENDERBUFFER_BINDING = 0x8CA7;

        /// <summary>
        /// [GL] Value of GL_READ_FRAMEBUFFER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_ANGLE_framebuffer_blit", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_blit")]
        [RequiredByFeature("GL_NV_framebuffer_blit", Api = "gles2")]
        public const int READ_FRAMEBUFFER = 0x8CA8;

        /// <summary>
        /// [GL] Value of GL_DRAW_FRAMEBUFFER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_ANGLE_framebuffer_blit", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_blit")]
        [RequiredByFeature("GL_NV_framebuffer_blit", Api = "gles2")]
        public const int DRAW_FRAMEBUFFER = 0x8CA9;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the name of the framebuffer object currently bound to the
        /// Gl.READ_FRAMEBUFFER target. If the default framebuffer is bound, this value will be zero. The initial value is zero.
        /// See
        /// Gl.BindFramebuffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_ANGLE_framebuffer_blit", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_blit")]
        [RequiredByFeature("GL_NV_framebuffer_blit", Api = "gles2")]
        public const int READ_FRAMEBUFFER_BINDING = 0x8CAA;

        /// <summary>
        /// [GL] Value of GL_RENDERBUFFER_SAMPLES symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_ANGLE_framebuffer_multisample", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_multisample")]
        [RequiredByFeature("GL_EXT_multisampled_render_to_texture", Api = "gles1|gles2")]
        [RequiredByFeature("GL_NV_framebuffer_multisample", Api = "gles2")]
        public const int RENDERBUFFER_SAMPLES = 0x8CAB;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader4")]
        [RequiredByFeature("GL_EXT_texture_array")]
        [RequiredByFeature("GL_NV_geometry_program4")]
        public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_COMPLETE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int FRAMEBUFFER_COMPLETE = 0x8CD5;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_framebuffer_object")]
        public const int FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_framebuffer_object")]
        public const int FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_UNSUPPORTED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int FRAMEBUFFER_UNSUPPORTED = 0x8CDD;

        /// <summary>
        /// [GLES3.2] Gl.Get: data returns one value, the maximum number of color attachment points in a framebuffer object. The
        /// value must be at least 4. See Gl.FramebufferRenderbuffer and Gl.FramebufferTexture2D.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
        public const int MAX_COLOR_ATTACHMENTS = 0x8CDF;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT0 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int COLOR_ATTACHMENT0 = 0x8CE0;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT1 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
        public const int COLOR_ATTACHMENT1 = 0x8CE1;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT2 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
        public const int COLOR_ATTACHMENT2 = 0x8CE2;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT3 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
        public const int COLOR_ATTACHMENT3 = 0x8CE3;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT4 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
        public const int COLOR_ATTACHMENT4 = 0x8CE4;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT5 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
        public const int COLOR_ATTACHMENT5 = 0x8CE5;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT6 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
        public const int COLOR_ATTACHMENT6 = 0x8CE6;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT7 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
        public const int COLOR_ATTACHMENT7 = 0x8CE7;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT8 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
        public const int COLOR_ATTACHMENT8 = 0x8CE8;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT9 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
        public const int COLOR_ATTACHMENT9 = 0x8CE9;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT10 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
        public const int COLOR_ATTACHMENT10 = 0x8CEA;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT11 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
        public const int COLOR_ATTACHMENT11 = 0x8CEB;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT12 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
        public const int COLOR_ATTACHMENT12 = 0x8CEC;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT13 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
        public const int COLOR_ATTACHMENT13 = 0x8CED;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT14 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
        public const int COLOR_ATTACHMENT14 = 0x8CEE;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT15 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
        public const int COLOR_ATTACHMENT15 = 0x8CEF;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT16 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int COLOR_ATTACHMENT16 = 0x8CF0;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT17 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int COLOR_ATTACHMENT17 = 0x8CF1;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT18 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int COLOR_ATTACHMENT18 = 0x8CF2;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT19 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int COLOR_ATTACHMENT19 = 0x8CF3;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT20 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int COLOR_ATTACHMENT20 = 0x8CF4;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT21 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int COLOR_ATTACHMENT21 = 0x8CF5;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT22 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int COLOR_ATTACHMENT22 = 0x8CF6;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT23 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int COLOR_ATTACHMENT23 = 0x8CF7;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT24 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int COLOR_ATTACHMENT24 = 0x8CF8;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT25 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int COLOR_ATTACHMENT25 = 0x8CF9;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT26 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int COLOR_ATTACHMENT26 = 0x8CFA;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT27 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int COLOR_ATTACHMENT27 = 0x8CFB;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT28 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int COLOR_ATTACHMENT28 = 0x8CFC;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT29 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int COLOR_ATTACHMENT29 = 0x8CFD;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT30 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int COLOR_ATTACHMENT30 = 0x8CFE;

        /// <summary>
        /// [GL] Value of GL_COLOR_ATTACHMENT31 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int COLOR_ATTACHMENT31 = 0x8CFF;

        /// <summary>
        /// [GL] Value of GL_DEPTH_ATTACHMENT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int DEPTH_ATTACHMENT = 0x8D00;

        /// <summary>
        /// [GL] Value of GL_STENCIL_ATTACHMENT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int STENCIL_ATTACHMENT = 0x8D20;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int FRAMEBUFFER = 0x8D40;

        /// <summary>
        /// [GL] Value of GL_RENDERBUFFER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int RENDERBUFFER = 0x8D41;

        /// <summary>
        /// [GL4] Gl.GetRenderbufferParameter: params returns the width in pixels, the height in pixels, internal format, or the
        /// number of samples, respectively, of the image of the specified renderbuffer object.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int RENDERBUFFER_WIDTH = 0x8D42;

        /// <summary>
        /// [GL] Value of GL_RENDERBUFFER_HEIGHT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int RENDERBUFFER_HEIGHT = 0x8D43;

        /// <summary>
        /// [GL] Value of GL_RENDERBUFFER_INTERNAL_FORMAT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;

        /// <summary>
        /// [GL] Value of GL_STENCIL_INDEX1 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_stencil1", Api = "gles1|gles2")]
        public const int STENCIL_INDEX1 = 0x8D46;

        /// <summary>
        /// [GL] Value of GL_STENCIL_INDEX4 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_stencil4", Api = "gles1|gles2")]
        public const int STENCIL_INDEX4 = 0x8D47;

        /// <summary>
        /// [GL] Value of GL_STENCIL_INDEX8 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_texture_stencil8", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_stencil8", Api = "gles1")]
        [RequiredByFeature("GL_OES_texture_stencil8", Api = "gles2")]
        public const int STENCIL_INDEX8 = 0x8D48;

        /// <summary>
        /// [GL] Value of GL_STENCIL_INDEX16 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_framebuffer_object")]
        public const int STENCIL_INDEX16 = 0x8D49;

        /// <summary>
        /// [GL4] Gl.GetRenderbufferParameter: params returns the actual resolution in bits (not the resolution specified when the
        /// image was defined) for the red, green, blue, alpha, depth or stencil components, respectively, of the image of the
        /// renderbuffer object.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int RENDERBUFFER_RED_SIZE = 0x8D50;

        /// <summary>
        /// [GL] Value of GL_RENDERBUFFER_GREEN_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int RENDERBUFFER_GREEN_SIZE = 0x8D51;

        /// <summary>
        /// [GL] Value of GL_RENDERBUFFER_BLUE_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int RENDERBUFFER_BLUE_SIZE = 0x8D52;

        /// <summary>
        /// [GL] Value of GL_RENDERBUFFER_ALPHA_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int RENDERBUFFER_ALPHA_SIZE = 0x8D53;

        /// <summary>
        /// [GL] Value of GL_RENDERBUFFER_DEPTH_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int RENDERBUFFER_DEPTH_SIZE = 0x8D54;

        /// <summary>
        /// [GL] Value of GL_RENDERBUFFER_STENCIL_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int RENDERBUFFER_STENCIL_SIZE = 0x8D55;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_ANGLE_framebuffer_multisample", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_multisample")]
        [RequiredByFeature("GL_EXT_multisampled_render_to_texture", Api = "gles1|gles2")]
        [RequiredByFeature("GL_NV_framebuffer_multisample", Api = "gles2")]
        public const int FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;

        /// <summary>
        /// [GLES3.2] Gl.Get: data returns one value. The value indicates the maximum supported number of samples for
        /// multisampling.
        /// The value must be at least 4. See Gl.GetInternalformativ.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_ANGLE_framebuffer_multisample", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
        [RequiredByFeature("GL_EXT_framebuffer_multisample")]
        [RequiredByFeature("GL_EXT_multisampled_render_to_texture", Api = "gles1|gles2")]
        [RequiredByFeature("GL_NV_framebuffer_multisample", Api = "gles2")]
        public const int MAX_SAMPLES = 0x8D57;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_SRGB symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ARB_framebuffer_sRGB", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_sRGB")]
        [RequiredByFeature("GL_EXT_sRGB_write_control", Api = "gles2")]
        public const int FRAMEBUFFER_SRGB = 0x8DB9;

        /// <summary>
        /// [GL] Value of GL_HALF_FLOAT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_half_float_vertex", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_half_float_pixel")]
        [RequiredByFeature("GL_NV_half_float")]
        public const int HALF_FLOAT = 0x140B;

        /// <summary>
        /// [GL] Value of GL_MAP_READ_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
        [RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
        public const int MAP_READ_BIT = 0x0001;

        /// <summary>
        /// [GL] Value of GL_MAP_WRITE_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
        [RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
        public const int MAP_WRITE_BIT = 0x0002;

        /// <summary>
        /// [GL] Value of GL_MAP_INVALIDATE_RANGE_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
        public const int MAP_INVALIDATE_RANGE_BIT = 0x0004;

        /// <summary>
        /// [GL] Value of GL_MAP_INVALIDATE_BUFFER_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
        public const int MAP_INVALIDATE_BUFFER_BIT = 0x0008;

        /// <summary>
        /// [GL] Value of GL_MAP_FLUSH_EXPLICIT_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
        public const int MAP_FLUSH_EXPLICIT_BIT = 0x0010;

        /// <summary>
        /// [GL] Value of GL_MAP_UNSYNCHRONIZED_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
        public const int MAP_UNSYNCHRONIZED_BIT = 0x0020;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_RED_RGTC1 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ARB_texture_compression_rgtc", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_texture_compression_rgtc", Api = "gl|gles2")]
        public const int COMPRESSED_RED_RGTC1 = 0x8DBB;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_SIGNED_RED_RGTC1 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ARB_texture_compression_rgtc", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_texture_compression_rgtc", Api = "gl|gles2")]
        public const int COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_RG_RGTC2 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ARB_texture_compression_rgtc", Api = "gl|glcore")]
        public const int COMPRESSED_RG_RGTC2 = 0x8DBD;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_SIGNED_RG_RGTC2 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ARB_texture_compression_rgtc", Api = "gl|glcore")]
        public const int COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;

        /// <summary>
        /// [GL] Value of GL_RG symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_rg", Api = "gles2")]
        public const int RG = 0x8227;

        /// <summary>
        /// [GL] Value of GL_RG_INTEGER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        public const int RG_INTEGER = 0x8228;

        /// <summary>
        /// [GL] Value of GL_R8 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_rg", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
        public const int R8 = 0x8229;

        /// <summary>
        /// [GL] Value of GL_R16 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_texture_norm16", Api = "gles2")]
        public const int R16 = 0x822A;

        /// <summary>
        /// [GL] Value of GL_RG8 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_rg", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
        public const int RG8 = 0x822B;

        /// <summary>
        /// [GL] Value of GL_RG16 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_texture_norm16", Api = "gles2")]
        public const int RG16 = 0x822C;

        /// <summary>
        /// [GL] Value of GL_R16F symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_color_buffer_half_float", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
        public const int R16F = 0x822D;

        /// <summary>
        /// [GL] Value of GL_R32F symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
        public const int R32F = 0x822E;

        /// <summary>
        /// [GL] Value of GL_RG16F symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_color_buffer_half_float", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
        public const int RG16F = 0x822F;

        /// <summary>
        /// [GL] Value of GL_RG32F symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
        public const int RG32F = 0x8230;

        /// <summary>
        /// [GL] Value of GL_R8I symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        public const int R8I = 0x8231;

        /// <summary>
        /// [GL] Value of GL_R8UI symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        public const int R8UI = 0x8232;

        /// <summary>
        /// [GL] Value of GL_R16I symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        public const int R16I = 0x8233;

        /// <summary>
        /// [GL] Value of GL_R16UI symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        public const int R16UI = 0x8234;

        /// <summary>
        /// [GL] Value of GL_R32I symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        public const int R32I = 0x8235;

        /// <summary>
        /// [GL] Value of GL_R32UI symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        public const int R32UI = 0x8236;

        /// <summary>
        /// [GL] Value of GL_RG8I symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        public const int RG8I = 0x8237;

        /// <summary>
        /// [GL] Value of GL_RG8UI symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_AMD_interleaved_elements")]
        [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        public const int RG8UI = 0x8238;

        /// <summary>
        /// [GL] Value of GL_RG16I symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        public const int RG16I = 0x8239;

        /// <summary>
        /// [GL] Value of GL_RG16UI symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_AMD_interleaved_elements")]
        [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        public const int RG16UI = 0x823A;

        /// <summary>
        /// [GL] Value of GL_RG32I symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        public const int RG32I = 0x823B;

        /// <summary>
        /// [GL] Value of GL_RG32UI symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
        public const int RG32UI = 0x823C;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns a single value, the name of the vertex array object currently bound to the context. If
        ///     no
        ///     vertex array object is bound to the context, 0 is returned. The initial value is 0. See Gl.BindVertexArray.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns a single value, the name of the vertex array object currently bound. If no vertex
        ///     array
        ///     object is bound, 0 is returned. The initial value is 0. See Gl.BindVertexArray.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_APPLE_vertex_array_object")]
        [RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2")]
        public const int VERTEX_ARRAY_BINDING = 0x85B5;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glColorMaski: enable and disable writing of frame buffer color components
        ///     </para>
        /// </summary>
        /// <param name="buf">
        /// For Gl.ColorMaski, specifies the index of the draw buffer whose color mask to set.
        /// </param>
        /// <param name="red">
        /// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all
        /// Gl.TRUE,
        /// indicating that the color components are written.
        /// </param>
        /// <param name="green">
        /// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all
        /// Gl.TRUE,
        /// indicating that the color components are written.
        /// </param>
        /// <param name="blue">
        /// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all
        /// Gl.TRUE,
        /// indicating that the color components are written.
        /// </param>
        /// <param name="alpha">
        /// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all
        /// Gl.TRUE,
        /// indicating that the color components are written.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_draw_buffers2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        public static void ColorMask(uint buf, bool red, bool green, bool blue, bool alpha)
        {
            Assert(Delegates.pglColorMaski != null, "pglColorMaski not implemented");
            Delegates.pglColorMaski(buf, red, green, blue, alpha);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetBooleani_v: return the value or values of a selected parameter
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
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers2")]
        public static void Get(int target, uint index, [Out] byte[] data)
        {
            unsafe
            {
                fixed (byte* p_data = data)
                {
                    Assert(Delegates.pglGetBooleani_v != null, "pglGetBooleani_v not implemented");
                    Delegates.pglGetBooleani_v(target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetBooleani_v: return the value or values of a selected parameter
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
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers2")]
        public static void Get(BufferTarget target, uint index, [Out] byte[] data)
        {
            unsafe
            {
                fixed (byte* p_data = data)
                {
                    Assert(Delegates.pglGetBooleani_v != null, "pglGetBooleani_v not implemented");
                    Delegates.pglGetBooleani_v((int) target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetBooleani_v: return the value or values of a selected parameter
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
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers2")]
        public static void Get(int target, uint index, out byte data)
        {
            unsafe
            {
                fixed (byte* p_data = &data)
                {
                    Assert(Delegates.pglGetBooleani_v != null, "pglGetBooleani_v not implemented");
                    Delegates.pglGetBooleani_v(target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetBooleani_v: return the value or values of a selected parameter
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
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers2")]
        public static void Get(BufferTarget target, uint index, out byte data)
        {
            unsafe
            {
                fixed (byte* p_data = &data)
                {
                    Assert(Delegates.pglGetBooleani_v != null, "pglGetBooleani_v not implemented");
                    Delegates.pglGetBooleani_v((int) target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetBooleani_v: return the value or values of a selected parameter
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
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers2")]
        public static unsafe void Get(BufferTarget target, uint index, [Out] byte* data)
        {
            Assert(Delegates.pglGetBooleani_v != null, "pglGetBooleani_v not implemented");
            Delegates.pglGetBooleani_v((int) target, index, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetBooleani_v: return the value or values of a selected parameter
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
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers2")]
        public static void GetBoolean<T>(BufferTarget target, uint index, out T data) where T : struct
        {
            Assert(Delegates.pglGetBooleani_v != null, "pglGetBooleani_v not implemented");
            data = default;
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(data);
			try {
				unsafe {
					Delegates.pglGetBooleani_v((int)target, index, (byte*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refData = __makeref(data);
                IntPtr refDataPtr = *(IntPtr*) (&refData);

                Delegates.pglGetBooleani_v((int) target, index, (byte*) refDataPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetIntegeri_v: return the value or values of a selected parameter
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
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_VERSION_3_1")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers2")]
        public static void Get(int target, uint index, [Out] int[] data)
        {
            unsafe
            {
                fixed (int* p_data = data)
                {
                    Assert(Delegates.pglGetIntegeri_v != null, "pglGetIntegeri_v not implemented");
                    Delegates.pglGetIntegeri_v(target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetIntegeri_v: return the value or values of a selected parameter
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
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_VERSION_3_1")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers2")]
        public static void Get(GetPName target, uint index, [Out] int[] data)
        {
            unsafe
            {
                fixed (int* p_data = data)
                {
                    Assert(Delegates.pglGetIntegeri_v != null, "pglGetIntegeri_v not implemented");
                    Delegates.pglGetIntegeri_v((int) target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetIntegeri_v: return the value or values of a selected parameter
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
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_VERSION_3_1")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers2")]
        public static void Get(int target, uint index, out int data)
        {
            unsafe
            {
                fixed (int* p_data = &data)
                {
                    Assert(Delegates.pglGetIntegeri_v != null, "pglGetIntegeri_v not implemented");
                    Delegates.pglGetIntegeri_v(target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetIntegeri_v: return the value or values of a selected parameter
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
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_VERSION_3_1")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers2")]
        public static void Get(GetPName target, uint index, out int data)
        {
            unsafe
            {
                fixed (int* p_data = &data)
                {
                    Assert(Delegates.pglGetIntegeri_v != null, "pglGetIntegeri_v not implemented");
                    Delegates.pglGetIntegeri_v((int) target, index, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetIntegeri_v: return the value or values of a selected parameter
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
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_VERSION_3_1")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers2")]
        public static unsafe void Get(GetPName target, uint index, [Out] int* data)
        {
            Assert(Delegates.pglGetIntegeri_v != null, "pglGetIntegeri_v not implemented");
            Delegates.pglGetIntegeri_v((int) target, index, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetIntegeri_v: return the value or values of a selected parameter
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
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_VERSION_3_1")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers2")]
        public static void GetInteger<T>(GetPName target, uint index, out T data) where T : struct
        {
            Assert(Delegates.pglGetIntegeri_v != null, "pglGetIntegeri_v not implemented");
            data = default;
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(data);
			try {
				unsafe {
					Delegates.pglGetIntegeri_v((int)target, index, (int*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refData = __makeref(data);
                IntPtr refDataPtr = *(IntPtr*) (&refData);

                Delegates.pglGetIntegeri_v((int) target, index, (int*) refDataPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glEnablei: Binding for glEnablei.
        /// </summary>
        /// <param name="cap">
        /// A <see cref="T:EnableCap" />.
        /// </param>
        /// <param name="index">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public static void Enable(EnableCap cap, uint index)
        {
            Assert(Delegates.pglEnablei != null, "pglEnablei not implemented");
            Delegates.pglEnablei((int) cap, index);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glDisablei: Binding for glDisablei.
        /// </summary>
        /// <param name="cap">
        /// A <see cref="T:EnableCap" />.
        /// </param>
        /// <param name="index">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public static void Disable(EnableCap cap, uint index)
        {
            Assert(Delegates.pglDisablei != null, "pglDisablei not implemented");
            Delegates.pglDisablei((int) cap, index);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glIsEnabledi: test whether a capability is enabled
        ///     </para>
        /// </summary>
        /// <param name="cap">
        /// Specifies a symbolic constant indicating a GL capability.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the capability.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_draw_buffers2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public static bool IsEnabled(EnableCap cap, uint index)
        {
            bool retValue;

            Assert(Delegates.pglIsEnabledi != null, "pglIsEnabledi not implemented");
            retValue = Delegates.pglIsEnabledi((int) cap, index);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glBeginTransformFeedback: start transform feedback operation
        ///     </para>
        /// </summary>
        /// <param name="primitiveMode">
        /// Specify the output type of the primitives that will be recorded into the buffer objects that are bound for transform
        /// feedback.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_transform_feedback")]
        [RequiredByFeature("GL_NV_transform_feedback")]
        public static void BeginTransformFeedback(PrimitiveType primitiveMode)
        {
            Assert(Delegates.pglBeginTransformFeedback != null, "pglBeginTransformFeedback not implemented");
            Delegates.pglBeginTransformFeedback((int) primitiveMode);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glEndTransformFeedback: start transform feedback operation
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_transform_feedback")]
        [RequiredByFeature("GL_NV_transform_feedback")]
        public static void EndTransformFeedback()
        {
            Assert(Delegates.pglEndTransformFeedback != null, "pglEndTransformFeedback not implemented");
            Delegates.pglEndTransformFeedback();
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glBindBufferRange: bind a range within a buffer object to an indexed buffer target
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specify the target of the bind operation. <paramref name="target" /> must be one of Gl.ATOMIC_COUNTER_BUFFER,
        /// Gl.TRANSFORM_FEEDBACK_BUFFER, Gl.UNIFORM_BUFFER, or Gl.SHADER_STORAGE_BUFFER.
        /// </param>
        /// <param name="index">
        /// Specify the index of the binding point within the array specified by <paramref name="target" />.
        /// </param>
        /// <param name="buffer">
        /// The name of a buffer object to bind to the specified binding point.
        /// </param>
        /// <param name="offset">
        /// The starting offset in basic machine units into the buffer object <paramref name="buffer" />.
        /// </param>
        /// <param name="size">
        /// The amount of data in machine units that can be read from the buffer object while used as an indexed target.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_VERSION_3_1")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_transform_feedback")]
        [RequiredByFeature("GL_NV_transform_feedback")]
        public static void BindBufferRange(BufferTarget target, uint index, uint buffer, IntPtr offset, uint size)
        {
            Assert(Delegates.pglBindBufferRange != null, "pglBindBufferRange not implemented");
            Delegates.pglBindBufferRange((int) target, index, buffer, offset, size);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glBindBufferBase: bind a buffer object to an indexed buffer target
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specify the target of the bind operation. <paramref name="target" /> must be one of Gl.ATOMIC_COUNTER_BUFFER,
        /// Gl.TRANSFORM_FEEDBACK_BUFFER, Gl.UNIFORM_BUFFER or Gl.SHADER_STORAGE_BUFFER.
        /// </param>
        /// <param name="index">
        /// Specify the index of the binding point within the array specified by <paramref name="target" />.
        /// </param>
        /// <param name="buffer">
        /// The name of a buffer object to bind to the specified binding point.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_VERSION_3_1")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_transform_feedback")]
        [RequiredByFeature("GL_NV_transform_feedback")]
        public static void BindBufferBase(BufferTarget target, uint index, uint buffer)
        {
            Assert(Delegates.pglBindBufferBase != null, "pglBindBufferBase not implemented");
            Delegates.pglBindBufferBase((int) target, index, buffer);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glTransformFeedbackVaryings: specify values to record in transform feedback buffers
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// The name of the target program object.
        /// </param>
        /// <param name="varyings">
        /// An array of zero-terminated strings specifying the names of the varying variables to use for transform feedback.
        /// </param>
        /// <param name="bufferMode">
        /// Identifies the mode used to capture the varying variables when transform feedback is active.
        /// <paramref
        ///     name="bufferMode" />
        /// must be Gl.INTERLEAVED_ATTRIBS or Gl.SEPARATE_ATTRIBS.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_transform_feedback")]
        public static void TransformFeedbackVaryings(uint program, string[] varyings, int bufferMode)
        {
            Assert(Delegates.pglTransformFeedbackVaryings != null, "pglTransformFeedbackVaryings not implemented");
            Delegates.pglTransformFeedbackVaryings(program, varyings.Length, varyings, bufferMode);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTransformFeedbackVarying: retrieve information about varying variables selected for transform
        ///     feedback
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// The name of the target program object.
        /// </param>
        /// <param name="index">
        /// The index of the varying variable whose information to retrieve.
        /// </param>
        /// <param name="bufSize">
        /// The maximum number of characters, including the null terminator, that may be written into <paramref name="name" />.
        /// </param>
        /// <param name="length">
        /// The address of a variable which will receive the number of characters written into <paramref name="name" />, excluding
        /// the null-terminator. If <paramref name="length" /> is Gl.L no length is returned.
        /// </param>
        /// <param name="size">
        /// The address of a variable that will receive the size of the varying.
        /// </param>
        /// <param name="type">
        /// The address of a variable that will recieve the type of the varying.
        /// </param>
        /// <param name="name">
        /// The address of a buffer into which will be written the name of the varying.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_transform_feedback")]
        public static void GetTransformFeedbackVarying(uint program, uint index, int bufSize, out int length, out int size, out int type, StringBuilder name)
        {
            unsafe
            {
                fixed (int* p_length = &length)
                fixed (int* p_size = &size)
                fixed (int* p_type = &type)
                {
                    Assert(Delegates.pglGetTransformFeedbackVarying != null, "pglGetTransformFeedbackVarying not implemented");
                    Delegates.pglGetTransformFeedbackVarying(program, index, bufSize, p_length, p_size, p_type, name);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glClampColor: specify whether data read via glReadPixels should be clamped
        /// </summary>
        /// <param name="target">
        /// Target for color clamping. <paramref name="target" /> must be Gl.CLAMP_READ_COLOR.
        /// </param>
        /// <param name="clamp">
        /// Specifies whether to apply color clamping. <paramref name="clamp" /> must be Gl.TRUE or Gl.FALSE.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ARB_color_buffer_float")]
        public static void ClampColor(int target, int clamp)
        {
            Assert(Delegates.pglClampColor != null, "pglClampColor not implemented");
            Delegates.pglClampColor(target, clamp);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glBeginConditionalRender: start conditional rendering
        /// </summary>
        /// <param name="id">
        /// Specifies the name of an occlusion query object whose results are used to determine if the rendering commands are
        /// discarded.
        /// </param>
        /// <param name="mode">
        /// Specifies how Gl.BeginConditionalRender interprets the results of the occlusion query.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_conditional_render", Api = "gl|glcore|gles2")]
        public static void BeginConditionalRender(uint id, ConditionalQueryMode mode)
        {
            Assert(Delegates.pglBeginConditionalRender != null, "pglBeginConditionalRender not implemented");
            Delegates.pglBeginConditionalRender(id, (int) mode);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glEndConditionalRender: start conditional rendering
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NVX_conditional_render")]
        [RequiredByFeature("GL_NV_conditional_render", Api = "gl|glcore|gles2")]
        public static void EndConditionalRender()
        {
            Assert(Delegates.pglEndConditionalRender != null, "pglEndConditionalRender not implemented");
            Delegates.pglEndConditionalRender();
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glVertexAttribIPointer: define an array of generic vertex attribute data
        ///     </para>
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="size">
        /// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic
        /// constant
        /// Gl.BGRA is accepted by Gl.VertexAttribPointer. The initial value is 4.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of each component in the array. The symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT,
        /// Gl.UNSIGNED_SHORT, Gl.INT, and Gl.UNSIGNED_INT are accepted by Gl.VertexAttribPointer and Gl.VertexAttribIPointer.
        /// Additionally Gl.HALF_FLOAT, Gl.FLOAT, Gl.DOUBLE, Gl.FIXED, Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV and
        /// Gl.UNSIGNED_INT_10F_11F_11F_REV are accepted by Gl.VertexAttribPointer. Gl.DOUBLE is also accepted by
        /// Gl.VertexAttribLPointer and is the only token accepted by the <paramref name="type" /> parameter for that function. The
        /// initial value is Gl.FLOAT.
        /// </param>
        /// <param name="stride">
        /// Specifies the byte offset between consecutive generic vertex attributes. If <paramref name="stride" /> is 0, the
        /// generic
        /// vertex attributes are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">
        /// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the
        /// buffer currently bound to the Gl.ARRAY_BUFFER target. The initial value is 0.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribIPointer(uint index, int size, VertexAttribType type, int stride, IntPtr pointer)
        {
            Assert(Delegates.pglVertexAttribIPointer != null, "pglVertexAttribIPointer not implemented");
            Delegates.pglVertexAttribIPointer(index, size, (int) type, stride, pointer);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glVertexAttribIPointer: define an array of generic vertex attribute data
        ///     </para>
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="size">
        /// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic
        /// constant
        /// Gl.BGRA is accepted by Gl.VertexAttribPointer. The initial value is 4.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of each component in the array. The symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT,
        /// Gl.UNSIGNED_SHORT, Gl.INT, and Gl.UNSIGNED_INT are accepted by Gl.VertexAttribPointer and Gl.VertexAttribIPointer.
        /// Additionally Gl.HALF_FLOAT, Gl.FLOAT, Gl.DOUBLE, Gl.FIXED, Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV and
        /// Gl.UNSIGNED_INT_10F_11F_11F_REV are accepted by Gl.VertexAttribPointer. Gl.DOUBLE is also accepted by
        /// Gl.VertexAttribLPointer and is the only token accepted by the <paramref name="type" /> parameter for that function. The
        /// initial value is Gl.FLOAT.
        /// </param>
        /// <param name="stride">
        /// Specifies the byte offset between consecutive generic vertex attributes. If <paramref name="stride" /> is 0, the
        /// generic
        /// vertex attributes are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">
        /// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the
        /// buffer currently bound to the Gl.ARRAY_BUFFER target. The initial value is 0.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribIPointer(uint index, int size, VertexAttribType type, int stride, object pointer)
        {
            GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                VertexAttribIPointer(index, size, type, stride, pin_pointer.AddrOfPinnedObject());
            }
            finally
            {
                pin_pointer.Free();
            }
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetVertexAttribIiv: Return a generic vertex attribute parameter
        ///     </para>
        /// </summary>
        /// <param name="index">
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are
        /// Gl.VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, Gl.VERTEX_ATTRIB_ARRAY_SIZE,
        /// Gl.VERTEX_ATTRIB_ARRAY_STRIDE, Gl.VERTEX_ATTRIB_ARRAY_TYPE, Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED,
        /// Gl.VERTEX_ATTRIB_ARRAY_INTEGER, Gl.VERTEX_ATTRIB_ARRAY_DIVISOR, or Gl.CURRENT_VERTEX_ATTRIB.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void GetVertexAttribI(uint index, VertexAttribEnum pname, out int @params)
        {
            unsafe
            {
                fixed (int* p_params = &@params)
                {
                    Assert(Delegates.pglGetVertexAttribIiv != null, "pglGetVertexAttribIiv not implemented");
                    Delegates.pglGetVertexAttribIiv(index, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetVertexAttribIuiv: Return a generic vertex attribute parameter
        ///     </para>
        /// </summary>
        /// <param name="index">
        /// Specifies the generic vertex attribute parameter to be queried.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are
        /// Gl.VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, Gl.VERTEX_ATTRIB_ARRAY_SIZE,
        /// Gl.VERTEX_ATTRIB_ARRAY_STRIDE, Gl.VERTEX_ATTRIB_ARRAY_TYPE, Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED,
        /// Gl.VERTEX_ATTRIB_ARRAY_INTEGER, Gl.VERTEX_ATTRIB_ARRAY_DIVISOR, or Gl.CURRENT_VERTEX_ATTRIB.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void GetVertexAttribI(uint index, VertexAttribEnum pname, out uint @params)
        {
            unsafe
            {
                fixed (uint* p_params = &@params)
                {
                    Assert(Delegates.pglGetVertexAttribIuiv != null, "pglGetVertexAttribIuiv not implemented");
                    Delegates.pglGetVertexAttribIuiv(index, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI1i: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x">
        /// A <see cref="T:int" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI1(uint index, int x)
        {
            Assert(Delegates.pglVertexAttribI1i != null, "pglVertexAttribI1i not implemented");
            Delegates.pglVertexAttribI1i(index, x);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI2i: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="y">
        /// A <see cref="T:int" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI2(uint index, int x, int y)
        {
            Assert(Delegates.pglVertexAttribI2i != null, "pglVertexAttribI2i not implemented");
            Delegates.pglVertexAttribI2i(index, x, y);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI3i: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="y">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="z">
        /// A <see cref="T:int" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI3(uint index, int x, int y, int z)
        {
            Assert(Delegates.pglVertexAttribI3i != null, "pglVertexAttribI3i not implemented");
            Delegates.pglVertexAttribI3i(index, x, y, z);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glVertexAttribI4i: Specifies the value of a generic vertex attribute
        ///     </para>
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="y">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="z">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="w">
        /// A <see cref="T:int" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI4(uint index, int x, int y, int z, int w)
        {
            Assert(Delegates.pglVertexAttribI4i != null, "pglVertexAttribI4i not implemented");
            Delegates.pglVertexAttribI4i(index, x, y, z, w);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI1ui: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI1(uint index, uint x)
        {
            Assert(Delegates.pglVertexAttribI1ui != null, "pglVertexAttribI1ui not implemented");
            Delegates.pglVertexAttribI1ui(index, x);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI2ui: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="y">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI2(uint index, uint x, uint y)
        {
            Assert(Delegates.pglVertexAttribI2ui != null, "pglVertexAttribI2ui not implemented");
            Delegates.pglVertexAttribI2ui(index, x, y);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI3ui: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="y">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="z">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI3(uint index, uint x, uint y, uint z)
        {
            Assert(Delegates.pglVertexAttribI3ui != null, "pglVertexAttribI3ui not implemented");
            Delegates.pglVertexAttribI3ui(index, x, y, z);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glVertexAttribI4ui: Specifies the value of a generic vertex attribute
        ///     </para>
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="x">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="y">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="z">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="w">
        /// A <see cref="T:uint" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI4(uint index, uint x, uint y, uint z, uint w)
        {
            Assert(Delegates.pglVertexAttribI4ui != null, "pglVertexAttribI4ui not implemented");
            Delegates.pglVertexAttribI4ui(index, x, y, z, w);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI1iv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI1(uint index, int[] v)
        {
            Assert(v.Length >= 1);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Assert(Delegates.pglVertexAttribI1iv != null, "pglVertexAttribI1iv not implemented");
                    Delegates.pglVertexAttribI1iv(index, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI1iv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static unsafe void VertexAttribI1(uint index, int* v)
        {
            Assert(Delegates.pglVertexAttribI1iv != null, "pglVertexAttribI1iv not implemented");
            Delegates.pglVertexAttribI1iv(index, v);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI1iv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI1i<T>(uint index, T v) where T : struct
        {
            Assert(Delegates.pglVertexAttribI1iv != null, "pglVertexAttribI1iv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(v);
			try {
				unsafe {
					Delegates.pglVertexAttribI1iv(index, (int*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refV = __makeref(v);
                IntPtr refVPtr = *(IntPtr*) (&refV);
                Delegates.pglVertexAttribI1iv(index, (int*) refVPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI2iv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI2(uint index, int[] v)
        {
            Assert(v.Length >= 2);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Assert(Delegates.pglVertexAttribI2iv != null, "pglVertexAttribI2iv not implemented");
                    Delegates.pglVertexAttribI2iv(index, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI2iv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static unsafe void VertexAttribI2(uint index, int* v)
        {
            Assert(Delegates.pglVertexAttribI2iv != null, "pglVertexAttribI2iv not implemented");
            Delegates.pglVertexAttribI2iv(index, v);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI2iv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI2i<T>(uint index, T v) where T : struct
        {
            Assert(Delegates.pglVertexAttribI2iv != null, "pglVertexAttribI2iv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(v);
			try {
				unsafe {
					Delegates.pglVertexAttribI2iv(index, (int*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refV = __makeref(v);
                IntPtr refVPtr = *(IntPtr*) (&refV);

                Delegates.pglVertexAttribI2iv(index, (int*) refVPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI3iv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI3(uint index, int[] v)
        {
            Assert(v.Length >= 3);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Assert(Delegates.pglVertexAttribI3iv != null, "pglVertexAttribI3iv not implemented");
                    Delegates.pglVertexAttribI3iv(index, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI3iv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static unsafe void VertexAttribI3(uint index, int* v)
        {
            Assert(Delegates.pglVertexAttribI3iv != null, "pglVertexAttribI3iv not implemented");
            Delegates.pglVertexAttribI3iv(index, v);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI3iv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI3i<T>(uint index, T v) where T : struct
        {
            Assert(Delegates.pglVertexAttribI3iv != null, "pglVertexAttribI3iv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(v);
			try {
				unsafe {
					Delegates.pglVertexAttribI3iv(index, (int*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refV = __makeref(v);
                IntPtr refVPtr = *(IntPtr*) (&refV);

                Delegates.pglVertexAttribI3iv(index, (int*) refVPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glVertexAttribI4iv: Specifies the value of a generic vertex attribute
        ///     </para>
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI4(uint index, int[] v)
        {
            Assert(v.Length >= 4);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Assert(Delegates.pglVertexAttribI4iv != null, "pglVertexAttribI4iv not implemented");
                    Delegates.pglVertexAttribI4iv(index, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glVertexAttribI4iv: Specifies the value of a generic vertex attribute
        ///     </para>
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static unsafe void VertexAttribI4(uint index, int* v)
        {
            Assert(Delegates.pglVertexAttribI4iv != null, "pglVertexAttribI4iv not implemented");
            Delegates.pglVertexAttribI4iv(index, v);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glVertexAttribI4iv: Specifies the value of a generic vertex attribute
        ///     </para>
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI4i<T>(uint index, T v) where T : struct
        {
            Assert(Delegates.pglVertexAttribI4iv != null, "pglVertexAttribI4iv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(v);
			try {
				unsafe {
					Delegates.pglVertexAttribI4iv(index, (int*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refV = __makeref(v);
                IntPtr refVPtr = *(IntPtr*) (&refV);

                Delegates.pglVertexAttribI4iv(index, (int*) refVPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI1uiv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI1(uint index, uint[] v)
        {
            Assert(v.Length >= 1);
            unsafe
            {
                fixed (uint* p_v = v)
                {
                    Assert(Delegates.pglVertexAttribI1uiv != null, "pglVertexAttribI1uiv not implemented");
                    Delegates.pglVertexAttribI1uiv(index, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI1uiv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static unsafe void VertexAttribI1(uint index, uint* v)
        {
            Assert(Delegates.pglVertexAttribI1uiv != null, "pglVertexAttribI1uiv not implemented");
            Delegates.pglVertexAttribI1uiv(index, v);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI1uiv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI1ui<T>(uint index, T v) where T : struct
        {
            Assert(Delegates.pglVertexAttribI1uiv != null, "pglVertexAttribI1uiv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(v);
			try {
				unsafe {
					Delegates.pglVertexAttribI1uiv(index, (uint*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refV = __makeref(v);
                IntPtr refVPtr = *(IntPtr*) (&refV);

                Delegates.pglVertexAttribI1uiv(index, (uint*) refVPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI2uiv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI2(uint index, uint[] v)
        {
            Assert(v.Length >= 2);
            unsafe
            {
                fixed (uint* p_v = v)
                {
                    Assert(Delegates.pglVertexAttribI2uiv != null, "pglVertexAttribI2uiv not implemented");
                    Delegates.pglVertexAttribI2uiv(index, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI2uiv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static unsafe void VertexAttribI2(uint index, uint* v)
        {
            Assert(Delegates.pglVertexAttribI2uiv != null, "pglVertexAttribI2uiv not implemented");
            Delegates.pglVertexAttribI2uiv(index, v);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI2uiv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI2ui<T>(uint index, T v) where T : struct
        {
            Assert(Delegates.pglVertexAttribI2uiv != null, "pglVertexAttribI2uiv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(v);
			try {
				unsafe {
					Delegates.pglVertexAttribI2uiv(index, (uint*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refV = __makeref(v);
                IntPtr refVPtr = *(IntPtr*) (&refV);

                Delegates.pglVertexAttribI2uiv(index, (uint*) refVPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI3uiv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI3(uint index, uint[] v)
        {
            Assert(v.Length >= 3);
            unsafe
            {
                fixed (uint* p_v = v)
                {
                    Assert(Delegates.pglVertexAttribI3uiv != null, "pglVertexAttribI3uiv not implemented");
                    Delegates.pglVertexAttribI3uiv(index, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI3uiv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static unsafe void VertexAttribI3(uint index, uint* v)
        {
            Assert(Delegates.pglVertexAttribI3uiv != null, "pglVertexAttribI3uiv not implemented");
            Delegates.pglVertexAttribI3uiv(index, v);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI3uiv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI3ui<T>(uint index, T v) where T : struct
        {
            Assert(Delegates.pglVertexAttribI3uiv != null, "pglVertexAttribI3uiv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(v);
			try {
				unsafe {
					Delegates.pglVertexAttribI3uiv(index, (uint*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refV = __makeref(v);
                IntPtr refVPtr = *(IntPtr*) (&refV);

                Delegates.pglVertexAttribI3uiv(index, (uint*) refVPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glVertexAttribI4uiv: Specifies the value of a generic vertex attribute
        ///     </para>
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI4(uint index, uint[] v)
        {
            Assert(v.Length >= 4);
            unsafe
            {
                fixed (uint* p_v = v)
                {
                    Assert(Delegates.pglVertexAttribI4uiv != null, "pglVertexAttribI4uiv not implemented");
                    Delegates.pglVertexAttribI4uiv(index, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glVertexAttribI4uiv: Specifies the value of a generic vertex attribute
        ///     </para>
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static unsafe void VertexAttribI4(uint index, uint* v)
        {
            Assert(Delegates.pglVertexAttribI4uiv != null, "pglVertexAttribI4uiv not implemented");
            Delegates.pglVertexAttribI4uiv(index, v);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glVertexAttribI4uiv: Specifies the value of a generic vertex attribute
        ///     </para>
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI4ui<T>(uint index, T v) where T : struct
        {
            Assert(Delegates.pglVertexAttribI4uiv != null, "pglVertexAttribI4uiv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(v);
			try {
				unsafe {
					Delegates.pglVertexAttribI4uiv(index, (uint*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refV = __makeref(v);
                IntPtr refVPtr = *(IntPtr*) (&refV);

                Delegates.pglVertexAttribI4uiv(index, (uint*) refVPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI4bv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI4(uint index, sbyte[] v)
        {
            Assert(v.Length >= 4);
            unsafe
            {
                fixed (sbyte* p_v = v)
                {
                    Assert(Delegates.pglVertexAttribI4bv != null, "pglVertexAttribI4bv not implemented");
                    Delegates.pglVertexAttribI4bv(index, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI4bv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static unsafe void VertexAttribI4(uint index, sbyte* v)
        {
            Assert(Delegates.pglVertexAttribI4bv != null, "pglVertexAttribI4bv not implemented");
            Delegates.pglVertexAttribI4bv(index, v);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI4bv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI4b<T>(uint index, T v) where T : struct
        {
            Assert(Delegates.pglVertexAttribI4bv != null, "pglVertexAttribI4bv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(v);
			try {
				unsafe {
					Delegates.pglVertexAttribI4bv(index, (sbyte*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refV = __makeref(v);
                IntPtr refVPtr = *(IntPtr*) (&refV);

                Delegates.pglVertexAttribI4bv(index, (sbyte*) refVPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI4sv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI4(uint index, short[] v)
        {
            Assert(v.Length >= 4);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Assert(Delegates.pglVertexAttribI4sv != null, "pglVertexAttribI4sv not implemented");
                    Delegates.pglVertexAttribI4sv(index, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI4sv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static unsafe void VertexAttribI4(uint index, short* v)
        {
            Assert(Delegates.pglVertexAttribI4sv != null, "pglVertexAttribI4sv not implemented");
            Delegates.pglVertexAttribI4sv(index, v);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI4sv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI4s<T>(uint index, T v) where T : struct
        {
            Assert(Delegates.pglVertexAttribI4sv != null, "pglVertexAttribI4sv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(v);
			try {
				unsafe {
					Delegates.pglVertexAttribI4sv(index, (short*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refV = __makeref(v);
                IntPtr refVPtr = *(IntPtr*) (&refV);

                Delegates.pglVertexAttribI4sv(index, (short*) refVPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI4ubv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI4(uint index, byte[] v)
        {
            Assert(v.Length >= 4);
            unsafe
            {
                fixed (byte* p_v = v)
                {
                    Assert(Delegates.pglVertexAttribI4ubv != null, "pglVertexAttribI4ubv not implemented");
                    Delegates.pglVertexAttribI4ubv(index, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI4ubv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static unsafe void VertexAttribI4(uint index, byte* v)
        {
            Assert(Delegates.pglVertexAttribI4ubv != null, "pglVertexAttribI4ubv not implemented");
            Delegates.pglVertexAttribI4ubv(index, v);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI4ubv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI4ub<T>(uint index, T v) where T : struct
        {
            Assert(Delegates.pglVertexAttribI4ubv != null, "pglVertexAttribI4ubv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(v);
			try {
				unsafe {
					Delegates.pglVertexAttribI4ubv(index, (byte*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refV = __makeref(v);
                IntPtr refVPtr = *(IntPtr*) (&refV);

                Delegates.pglVertexAttribI4ubv(index, (byte*) refVPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI4usv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI4(uint index, ushort[] v)
        {
            Assert(v.Length >= 4);
            unsafe
            {
                fixed (ushort* p_v = v)
                {
                    Assert(Delegates.pglVertexAttribI4usv != null, "pglVertexAttribI4usv not implemented");
                    Delegates.pglVertexAttribI4usv(index, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI4usv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static unsafe void VertexAttribI4(uint index, ushort* v)
        {
            Assert(Delegates.pglVertexAttribI4usv != null, "pglVertexAttribI4usv not implemented");
            Delegates.pglVertexAttribI4usv(index, v);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribI4usv: Specifies the value of a generic vertex attribute
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic
        /// vertex
        /// attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_NV_vertex_program4")]
        public static void VertexAttribI4us<T>(uint index, T v) where T : struct
        {
            Assert(Delegates.pglVertexAttribI4usv != null, "pglVertexAttribI4usv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(v);
			try {
				unsafe {
					Delegates.pglVertexAttribI4usv(index, (ushort*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refV = __makeref(v);
                IntPtr refVPtr = *(IntPtr*) (&refV);

                Delegates.pglVertexAttribI4usv(index, (ushort*) refVPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetUniformuiv: Returns the value of a uniform variable
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be queried.
        /// </param>
        /// <param name="params">
        /// Returns the value of the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static void GetUniform(uint program, int location, [Out] uint[] @params)
        {
            unsafe
            {
                fixed (uint* p_params = @params)
                {
                    Assert(Delegates.pglGetUniformuiv != null, "pglGetUniformuiv not implemented");
                    Delegates.pglGetUniformuiv(program, location, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetUniformuiv: Returns the value of a uniform variable
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be queried.
        /// </param>
        /// <param name="params">
        /// Returns the value of the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static unsafe void GetUniform(uint program, int location, [Out] uint* @params)
        {
            Assert(Delegates.pglGetUniformuiv != null, "pglGetUniformuiv not implemented");
            Delegates.pglGetUniformuiv(program, location, @params);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetUniformuiv: Returns the value of a uniform variable
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be queried.
        /// </param>
        /// <param name="params">
        /// Returns the value of the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static void GetUniformui<T>(uint program, int location, out T @params) where T : struct
        {
            Assert(Delegates.pglGetUniformuiv != null, "pglGetUniformuiv not implemented");
            @params = default;
            unsafe
            {
                TypedReference refParams = __makeref(@params);
                IntPtr refParamsPtr = *(IntPtr*) (&refParams);

                Delegates.pglGetUniformuiv(program, location, (uint*) refParamsPtr.ToPointer());
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glBindFragDataLocation: bind a user-defined varying out variable to a fragment shader color number
        /// </summary>
        /// <param name="program">
        /// The name of the program containing varying out variable whose binding to modify
        /// </param>
        /// <param name="color">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="name">
        /// The name of the user-defined varying out variable whose binding to modify
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static void BindFragDataLocation(uint program, uint color, string name)
        {
            Assert(Delegates.pglBindFragDataLocation != null, "pglBindFragDataLocation not implemented");
            Delegates.pglBindFragDataLocation(program, color, name);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetFragDataLocation: query the bindings of color numbers to user-defined varying out variables
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// The name of the program containing varying out variable whose binding to query
        /// </param>
        /// <param name="name">
        /// The name of the user-defined varying out variable whose binding to query
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static int GetFragDataLocation(uint program, string name)
        {
            int retValue;

            Assert(Delegates.pglGetFragDataLocation != null, "pglGetFragDataLocation not implemented");
            retValue = Delegates.pglGetFragDataLocation(program, name);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glUniform1ui: Specify the value of a uniform variable for the current program object
        ///     </para>
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static void Uniform1(int location, uint v0)
        {
            Assert(Delegates.pglUniform1ui != null, "pglUniform1ui not implemented");
            Delegates.pglUniform1ui(location, v0);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glUniform2ui: Specify the value of a uniform variable for the current program object
        ///     </para>
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v1">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static void Uniform2(int location, uint v0, uint v1)
        {
            Assert(Delegates.pglUniform2ui != null, "pglUniform2ui not implemented");
            Delegates.pglUniform2ui(location, v0, v1);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glUniform3ui: Specify the value of a uniform variable for the current program object
        ///     </para>
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v1">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v2">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static void Uniform3(int location, uint v0, uint v1, uint v2)
        {
            Assert(Delegates.pglUniform3ui != null, "pglUniform3ui not implemented");
            Delegates.pglUniform3ui(location, v0, v1, v2);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glUniform4ui: Specify the value of a uniform variable for the current program object
        ///     </para>
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="v0">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v1">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v2">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        /// <param name="v3">
        /// For the scalar commands, specifies the new values to be used for the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static void Uniform4(int location, uint v0, uint v1, uint v2, uint v3)
        {
            Assert(Delegates.pglUniform4ui != null, "pglUniform4ui not implemented");
            Delegates.pglUniform4ui(location, v0, v1, v2, v3);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glUniform1uiv: Specify the value of a uniform variable for the current program object
        ///     </para>
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static void Uniform1(int location, uint[] value)
        {
            unsafe
            {
                fixed (uint* p_value = value)
                {
                    Assert(Delegates.pglUniform1uiv != null, "pglUniform1uiv not implemented");
                    Delegates.pglUniform1uiv(location, value.Length, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glUniform1uiv: Specify the value of a uniform variable for the current program object
        ///     </para>
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if
        /// the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static unsafe void Uniform1(int location, int count, uint* value)
        {
            Assert(Delegates.pglUniform1uiv != null, "pglUniform1uiv not implemented");
            Delegates.pglUniform1uiv(location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glUniform1uiv: Specify the value of a uniform variable for the current program object
        ///     </para>
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if
        /// the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static void Uniform1ui<T>(int location, int count, T value) where T : struct
        {
            Assert(Delegates.pglUniform1uiv != null, "pglUniform1uiv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglUniform1uiv(location, count, (uint*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglUniform1uiv(location, count, (uint*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glUniform2uiv: Specify the value of a uniform variable for the current program object
        ///     </para>
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static void Uniform2(int location, uint[] value)
        {
            Assert(value.Length > 0 && value.Length % 2 == 0, "empty or not multiple of 2");
            unsafe
            {
                fixed (uint* p_value = value)
                {
                    Assert(Delegates.pglUniform2uiv != null, "pglUniform2uiv not implemented");
                    Delegates.pglUniform2uiv(location, value.Length / 2, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glUniform2uiv: Specify the value of a uniform variable for the current program object
        ///     </para>
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if
        /// the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static unsafe void Uniform2(int location, int count, uint* value)
        {
            Assert(Delegates.pglUniform2uiv != null, "pglUniform2uiv not implemented");
            Delegates.pglUniform2uiv(location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glUniform2uiv: Specify the value of a uniform variable for the current program object
        ///     </para>
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if
        /// the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static void Uniform2ui<T>(int location, int count, T value) where T : struct
        {
            Assert(Delegates.pglUniform2uiv != null, "pglUniform2uiv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglUniform2uiv(location, count, (uint*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglUniform2uiv(location, count, (uint*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glUniform3uiv: Specify the value of a uniform variable for the current program object
        ///     </para>
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static void Uniform3(int location, uint[] value)
        {
            Assert(value.Length > 0 && value.Length % 3 == 0, "empty or not multiple of 3");
            unsafe
            {
                fixed (uint* p_value = value)
                {
                    Assert(Delegates.pglUniform3uiv != null, "pglUniform3uiv not implemented");
                    Delegates.pglUniform3uiv(location, value.Length / 3, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glUniform3uiv: Specify the value of a uniform variable for the current program object
        ///     </para>
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if
        /// the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static unsafe void Uniform3(int location, int count, uint* value)
        {
            Assert(Delegates.pglUniform3uiv != null, "pglUniform3uiv not implemented");
            Delegates.pglUniform3uiv(location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glUniform3uiv: Specify the value of a uniform variable for the current program object
        ///     </para>
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if
        /// the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static void Uniform3ui<T>(int location, int count, T value) where T : struct
        {
            Assert(Delegates.pglUniform3uiv != null, "pglUniform3uiv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglUniform3uiv(location, count, (uint*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglUniform3uiv(location, count, (uint*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glUniform4uiv: Specify the value of a uniform variable for the current program object
        ///     </para>
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static void Uniform4(int location, uint[] value)
        {
            Assert(value.Length > 0 && value.Length % 4 == 0, "empty or not multiple of 4");
            unsafe
            {
                fixed (uint* p_value = value)
                {
                    Assert(Delegates.pglUniform4uiv != null, "pglUniform4uiv not implemented");
                    Delegates.pglUniform4uiv(location, value.Length / 4, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glUniform4uiv: Specify the value of a uniform variable for the current program object
        ///     </para>
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if
        /// the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static unsafe void Uniform4(int location, int count, uint* value)
        {
            Assert(Delegates.pglUniform4uiv != null, "pglUniform4uiv not implemented");
            Delegates.pglUniform4uiv(location, count, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glUniform4uiv: Specify the value of a uniform variable for the current program object
        ///     </para>
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="count">
        /// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if
        /// the targeted uniform variable is not an array, and 1 or more if it is an array.
        /// </param>
        /// <param name="value">
        /// Values that will be used to update the specified uniform variable.
        /// used
        /// to update the specified uniform variable.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_gpu_shader4")]
        public static void Uniform4ui<T>(int location, int count, T value) where T : struct
        {
            Assert(Delegates.pglUniform4uiv != null, "pglUniform4uiv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(value);
			try {
				unsafe {
					Delegates.pglUniform4uiv(location, count, (uint*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refValue = __makeref(value);
                IntPtr refValuePtr = *(IntPtr*) (&refValue);

                Delegates.pglUniform4uiv(location, count, (uint*) refValuePtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glTexParameterIiv: Binding for glTexParameterIiv.
        /// </summary>
        /// <param name="target">
        /// A <see cref="T:TextureTarget" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:TextureParameterName" />.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_integer")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void TexParameterI(TextureTarget target, TextureParameterName pname, int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Assert(Delegates.pglTexParameterIiv != null, "pglTexParameterIiv not implemented");
                    Delegates.pglTexParameterIiv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glTexParameterIiv: Binding for glTexParameterIiv.
        /// </summary>
        /// <param name="target">
        /// A <see cref="T:TextureTarget" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:TextureParameterName" />.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:int*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_integer")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static unsafe void TexParameterI(TextureTarget target, TextureParameterName pname, int* @params)
        {
            Assert(Delegates.pglTexParameterIiv != null, "pglTexParameterIiv not implemented");
            Delegates.pglTexParameterIiv((int) target, (int) pname, @params);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glTexParameterIiv: Binding for glTexParameterIiv.
        /// </summary>
        /// <param name="target">
        /// A <see cref="T:TextureTarget" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:TextureParameterName" />.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_integer")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void TexParameterIi<T>(TextureTarget target, TextureParameterName pname, T @params) where T : struct
        {
            Assert(Delegates.pglTexParameterIiv != null, "pglTexParameterIiv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(@params);
			try {
				unsafe {
					Delegates.pglTexParameterIiv((int)target, (int)pname, (int*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refParams = __makeref(@params);
                IntPtr refParamsPtr = *(IntPtr*) (&refParams);

                Delegates.pglTexParameterIiv((int) target, (int) pname, (int*) refParamsPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glTexParameterIuiv: Binding for glTexParameterIuiv.
        /// </summary>
        /// <param name="target">
        /// A <see cref="T:TextureTarget" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:TextureParameterName" />.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_integer")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void TexParameterI(TextureTarget target, TextureParameterName pname, uint[] @params)
        {
            unsafe
            {
                fixed (uint* p_params = @params)
                {
                    Assert(Delegates.pglTexParameterIuiv != null, "pglTexParameterIuiv not implemented");
                    Delegates.pglTexParameterIuiv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glTexParameterIuiv: Binding for glTexParameterIuiv.
        /// </summary>
        /// <param name="target">
        /// A <see cref="T:TextureTarget" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:TextureParameterName" />.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:uint*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_integer")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static unsafe void TexParameterI(TextureTarget target, TextureParameterName pname, uint* @params)
        {
            Assert(Delegates.pglTexParameterIuiv != null, "pglTexParameterIuiv not implemented");
            Delegates.pglTexParameterIuiv((int) target, (int) pname, @params);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL] glTexParameterIuiv: Binding for glTexParameterIuiv.
        /// </summary>
        /// <param name="target">
        /// A <see cref="T:TextureTarget" />.
        /// </param>
        /// <param name="pname">
        /// A <see cref="T:TextureParameterName" />.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_integer")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void TexParameterIui<T>(TextureTarget target, TextureParameterName pname, T @params) where T : struct
        {
            Assert(Delegates.pglTexParameterIuiv != null, "pglTexParameterIuiv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(@params);
			try {
				unsafe {
					Delegates.pglTexParameterIuiv((int)target, (int)pname, (uint*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refParams = __makeref(@params);
                IntPtr refParamsPtr = *(IntPtr*) (&refParams);

                Delegates.pglTexParameterIuiv((int) target, (int) pname, (uint*) refParamsPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexParameterIiv: return texture parameter values
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv,
        /// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP,
        /// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE,
        /// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC,
        /// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R,
        /// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET,
        /// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS,
        /// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the texture parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_integer")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void GetTexParameterI(TextureTarget target, GetTextureParameter pname, [Out] int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Assert(Delegates.pglGetTexParameterIiv != null, "pglGetTexParameterIiv not implemented");
                    Delegates.pglGetTexParameterIiv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexParameterIiv: return texture parameter values
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv,
        /// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP,
        /// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE,
        /// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC,
        /// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R,
        /// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET,
        /// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS,
        /// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the texture parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_integer")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void GetTexParameterI(TextureTarget target, GetTextureParameter pname, out int @params)
        {
            unsafe
            {
                fixed (int* p_params = &@params)
                {
                    Assert(Delegates.pglGetTexParameterIiv != null, "pglGetTexParameterIiv not implemented");
                    Delegates.pglGetTexParameterIiv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexParameterIiv: return texture parameter values
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv,
        /// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP,
        /// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE,
        /// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC,
        /// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R,
        /// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET,
        /// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS,
        /// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the texture parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_integer")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static unsafe void GetTexParameterI(TextureTarget target, GetTextureParameter pname, [Out] int* @params)
        {
            Assert(Delegates.pglGetTexParameterIiv != null, "pglGetTexParameterIiv not implemented");
            Delegates.pglGetTexParameterIiv((int) target, (int) pname, @params);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexParameterIiv: return texture parameter values
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv,
        /// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP,
        /// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE,
        /// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC,
        /// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R,
        /// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET,
        /// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS,
        /// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the texture parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_integer")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void GetTexParameterIi<T>(TextureTarget target, GetTextureParameter pname, out T @params) where T : struct
        {
            Assert(Delegates.pglGetTexParameterIiv != null, "pglGetTexParameterIiv not implemented");
            @params = default;
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(@params);
			try {
				unsafe {
					Delegates.pglGetTexParameterIiv((int)target, (int)pname, (int*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refParams = __makeref(@params);
                IntPtr refParamsPtr = *(IntPtr*) (&refParams);

                Delegates.pglGetTexParameterIiv((int) target, (int) pname, (int*) refParamsPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexParameterIuiv: return texture parameter values
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv,
        /// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP,
        /// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE,
        /// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC,
        /// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R,
        /// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET,
        /// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS,
        /// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the texture parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_integer")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void GetTexParameterI(TextureTarget target, GetTextureParameter pname, [Out] uint[] @params)
        {
            unsafe
            {
                fixed (uint* p_params = @params)
                {
                    Assert(Delegates.pglGetTexParameterIuiv != null, "pglGetTexParameterIuiv not implemented");
                    Delegates.pglGetTexParameterIuiv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexParameterIuiv: return texture parameter values
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv,
        /// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP,
        /// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE,
        /// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC,
        /// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R,
        /// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET,
        /// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS,
        /// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the texture parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_integer")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void GetTexParameterI(TextureTarget target, GetTextureParameter pname, out uint @params)
        {
            unsafe
            {
                fixed (uint* p_params = &@params)
                {
                    Assert(Delegates.pglGetTexParameterIuiv != null, "pglGetTexParameterIuiv not implemented");
                    Delegates.pglGetTexParameterIuiv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexParameterIuiv: return texture parameter values
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv,
        /// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP,
        /// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE,
        /// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC,
        /// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R,
        /// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET,
        /// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS,
        /// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the texture parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_integer")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static unsafe void GetTexParameterI(TextureTarget target, GetTextureParameter pname, [Out] uint* @params)
        {
            Assert(Delegates.pglGetTexParameterIuiv != null, "pglGetTexParameterIuiv not implemented");
            Delegates.pglGetTexParameterIuiv((int) target, (int) pname, @params);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexParameterIuiv: return texture parameter values
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv,
        /// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP,
        /// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE,
        /// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC,
        /// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R,
        /// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET,
        /// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS,
        /// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the texture parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_integer")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public static void GetTexParameterIui<T>(TextureTarget target, GetTextureParameter pname, out T @params) where T : struct
        {
            Assert(Delegates.pglGetTexParameterIuiv != null, "pglGetTexParameterIuiv not implemented");
            @params = default;
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(@params);
			try {
				unsafe {
					Delegates.pglGetTexParameterIuiv((int)target, (int)pname, (uint*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refParams = __makeref(@params);
                IntPtr refParamsPtr = *(IntPtr*) (&refParams);

                Delegates.pglGetTexParameterIuiv((int) target, (int) pname, (uint*) refParamsPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glClearBufferiv: clear individual buffers of a framebuffer
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glClearBufferiv: clear individual buffers of the currently bound draw framebuffer
        ///     </para>
        /// </summary>
        /// <param name="buffer">
        /// Specify the buffer to clear.
        /// </param>
        /// <param name="drawbuffer">
        /// Specify a particular draw buffer to clear.
        /// </param>
        /// <param name="value">
        /// A pointer to the value or values to clear the buffer to.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public static void ClearBuffer(Buffer buffer, int drawbuffer, int[] value)
        {
            unsafe
            {
                fixed (int* p_value = value)
                {
                    Assert(Delegates.pglClearBufferiv != null, "pglClearBufferiv not implemented");
                    Delegates.pglClearBufferiv((int) buffer, drawbuffer, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glClearBufferuiv: clear individual buffers of a framebuffer
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glClearBufferuiv: clear individual buffers of the currently bound draw framebuffer
        ///     </para>
        /// </summary>
        /// <param name="buffer">
        /// Specify the buffer to clear.
        /// </param>
        /// <param name="drawbuffer">
        /// Specify a particular draw buffer to clear.
        /// </param>
        /// <param name="value">
        /// A pointer to the value or values to clear the buffer to.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public static void ClearBuffer(Buffer buffer, int drawbuffer, uint[] value)
        {
            unsafe
            {
                fixed (uint* p_value = value)
                {
                    Assert(Delegates.pglClearBufferuiv != null, "pglClearBufferuiv not implemented");
                    Delegates.pglClearBufferuiv((int) buffer, drawbuffer, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glClearBufferfv: clear individual buffers of a framebuffer
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glClearBufferfv: clear individual buffers of the currently bound draw framebuffer
        ///     </para>
        /// </summary>
        /// <param name="buffer">
        /// Specify the buffer to clear.
        /// </param>
        /// <param name="drawbuffer">
        /// Specify a particular draw buffer to clear.
        /// </param>
        /// <param name="value">
        /// A pointer to the value or values to clear the buffer to.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public static void ClearBuffer(Buffer buffer, int drawbuffer, float[] value)
        {
            unsafe
            {
                fixed (float* p_value = value)
                {
                    Assert(Delegates.pglClearBufferfv != null, "pglClearBufferfv not implemented");
                    Delegates.pglClearBufferfv((int) buffer, drawbuffer, p_value);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glClearBufferfi: clear individual buffers of a framebuffer
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glClearBufferfi: clear individual buffers of the currently bound draw framebuffer
        ///     </para>
        /// </summary>
        /// <param name="buffer">
        /// Specify the buffer to clear.
        /// </param>
        /// <param name="drawbuffer">
        /// Specify a particular draw buffer to clear.
        /// </param>
        /// <param name="depth">
        /// The value to clear the depth buffer to.
        /// </param>
        /// <param name="stencil">
        /// The value to clear the stencil buffer to.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public static void ClearBuffer(Buffer buffer, int drawbuffer, float depth, int stencil)
        {
            Assert(Delegates.pglClearBufferfi != null, "pglClearBufferfi not implemented");
            Delegates.pglClearBufferfi((int) buffer, drawbuffer, depth, stencil);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetStringi: return a string describing the current GL connection
        ///     </para>
        /// </summary>
        /// <param name="name">
        /// Specifies a symbolic constant, one of Gl.VENDOR, Gl.RENDERER, Gl.VERSION, or Gl.SHADING_LANGUAGE_VERSION. Additionally,
        /// Gl.GetStringi accepts the Gl.EXTENSIONS token.
        /// </param>
        /// <param name="index">
        /// For Gl.GetStringi, specifies the index of the string to return.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public static string GetString(StringName name, uint index)
        {
            IntPtr retValue;

            Assert(Delegates.pglGetStringi != null, "pglGetStringi not implemented");
            retValue = Delegates.pglGetStringi((int) name, index);
            DebugCheckErrors(retValue);

            return NativeHelpers.StringFromPtr(retValue);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glIsRenderbuffer: determine if a name corresponds to a renderbuffer object
        ///     </para>
        /// </summary>
        /// <param name="renderbuffer">
        /// Specifies a value that may be the name of a renderbuffer object.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static bool IsRenderbuffer(uint renderbuffer)
        {
            bool retValue;

            Assert(Delegates.pglIsRenderbuffer != null, "pglIsRenderbuffer not implemented");
            retValue = Delegates.pglIsRenderbuffer(renderbuffer);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glBindRenderbuffer: bind a renderbuffer to a renderbuffer target
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the renderbuffer target of the binding operation. <paramref name="target" /> must be Gl.RENDERBUFFER.
        /// </param>
        /// <param name="renderbuffer">
        /// Specifies the name of the renderbuffer object to bind.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        public static void BindRenderbuffer(RenderbufferTarget target, uint renderbuffer)
        {
            Assert(Delegates.pglBindRenderbuffer != null, "pglBindRenderbuffer not implemented");
            Delegates.pglBindRenderbuffer((int) target, renderbuffer);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDeleteRenderbuffers: delete renderbuffer objects
        ///     </para>
        /// </summary>
        /// <param name="renderbuffers">
        /// A pointer to an array containing <paramref name="n" /> renderbuffer objects to be deleted.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static void DeleteRenderbuffers(params uint[] renderbuffers)
        {
            unsafe
            {
                fixed (uint* p_renderbuffers = renderbuffers)
                {
                    Assert(Delegates.pglDeleteRenderbuffers != null, "pglDeleteRenderbuffers not implemented");
                    Delegates.pglDeleteRenderbuffers(renderbuffers.Length, p_renderbuffers);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGenRenderbuffers: generate renderbuffer object names
        ///     </para>
        /// </summary>
        /// <param name="renderbuffers">
        /// Specifies an array in which the generated renderbuffer object names are stored.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static void GenRenderbuffers(uint[] renderbuffers)
        {
            unsafe
            {
                fixed (uint* p_renderbuffers = renderbuffers)
                {
                    Assert(Delegates.pglGenRenderbuffers != null, "pglGenRenderbuffers not implemented");
                    Delegates.pglGenRenderbuffers(renderbuffers.Length, p_renderbuffers);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGenRenderbuffers: generate renderbuffer object names
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static uint GenRenderbuffer()
        {
            uint retValue;
            unsafe
            {
                Delegates.pglGenRenderbuffers(1, &retValue);
            }

            DebugCheckErrors(null);
            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glRenderbufferStorage: establish data storage, format and dimensions of a renderbuffer object's image
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies a binding target of the allocation for Gl.RenderbufferStorage function. Must be Gl.RENDERBUFFER.
        /// </param>
        /// <param name="internalformat">
        /// Specifies the internal format to use for the renderbuffer object's image.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the renderbuffer, in pixels.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the renderbuffer, in pixels.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static void RenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, int width, int height)
        {
            Assert(Delegates.pglRenderbufferStorage != null, "pglRenderbufferStorage not implemented");
            Delegates.pglRenderbufferStorage((int) target, (int) internalformat, width, height);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glGetRenderbufferParameteriv: query a named parameter of a renderbuffer object
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glGetRenderbufferParameteriv: retrieve information about a bound renderbuffer object
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the renderbuffer object is bound for Gl.GetRenderbufferParameteriv.
        /// <paramref
        ///     name="target" />
        /// must be Gl.RENDERBUFFER.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of the renderbuffer object to query.
        /// </param>
        /// <param name="params">
        /// Returns the value of parameter <paramref name="pname" /> for the renderbuffer object.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static void GetRenderbufferParameter(RenderbufferTarget target, RenderbufferParameterName pname, [Out] int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Assert(Delegates.pglGetRenderbufferParameteriv != null, "pglGetRenderbufferParameteriv not implemented");
                    Delegates.pglGetRenderbufferParameteriv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glGetRenderbufferParameteriv: query a named parameter of a renderbuffer object
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glGetRenderbufferParameteriv: retrieve information about a bound renderbuffer object
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the renderbuffer object is bound for Gl.GetRenderbufferParameteriv.
        /// <paramref
        ///     name="target" />
        /// must be Gl.RENDERBUFFER.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of the renderbuffer object to query.
        /// </param>
        /// <param name="params">
        /// Returns the value of parameter <paramref name="pname" /> for the renderbuffer object.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static void GetRenderbufferParameter(RenderbufferTarget target, RenderbufferParameterName pname, out int @params)
        {
            unsafe
            {
                fixed (int* p_params = &@params)
                {
                    Assert(Delegates.pglGetRenderbufferParameteriv != null, "pglGetRenderbufferParameteriv not implemented");
                    Delegates.pglGetRenderbufferParameteriv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glGetRenderbufferParameteriv: query a named parameter of a renderbuffer object
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glGetRenderbufferParameteriv: retrieve information about a bound renderbuffer object
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the renderbuffer object is bound for Gl.GetRenderbufferParameteriv.
        /// <paramref
        ///     name="target" />
        /// must be Gl.RENDERBUFFER.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of the renderbuffer object to query.
        /// </param>
        /// <param name="params">
        /// Returns the value of parameter <paramref name="pname" /> for the renderbuffer object.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static unsafe void GetRenderbufferParameter(RenderbufferTarget target, RenderbufferParameterName pname, [Out] int* @params)
        {
            Assert(Delegates.pglGetRenderbufferParameteriv != null, "pglGetRenderbufferParameteriv not implemented");
            Delegates.pglGetRenderbufferParameteriv((int) target, (int) pname, @params);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glGetRenderbufferParameteriv: query a named parameter of a renderbuffer object
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glGetRenderbufferParameteriv: retrieve information about a bound renderbuffer object
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the renderbuffer object is bound for Gl.GetRenderbufferParameteriv.
        /// <paramref
        ///     name="target" />
        /// must be Gl.RENDERBUFFER.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of the renderbuffer object to query.
        /// </param>
        /// <param name="params">
        /// Returns the value of parameter <paramref name="pname" /> for the renderbuffer object.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static void GetRenderbufferParameteri<T>(RenderbufferTarget target, RenderbufferParameterName pname, out T @params) where T : struct
        {
            Assert(Delegates.pglGetRenderbufferParameteriv != null, "pglGetRenderbufferParameteriv not implemented");
            @params = default;
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(@params);
			try {
				unsafe {
					Delegates.pglGetRenderbufferParameteriv((int)target, (int)pname, (int*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refParams = __makeref(@params);
                IntPtr refParamsPtr = *(IntPtr*) (&refParams);

                Delegates.pglGetRenderbufferParameteriv((int) target, (int) pname, (int*) refParamsPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glIsFramebuffer: determine if a name corresponds to a framebuffer object
        ///     </para>
        /// </summary>
        /// <param name="framebuffer">
        /// Specifies a value that may be the name of a framebuffer object.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static bool IsFramebuffer(uint framebuffer)
        {
            bool retValue;

            Assert(Delegates.pglIsFramebuffer != null, "pglIsFramebuffer not implemented");
            retValue = Delegates.pglIsFramebuffer(framebuffer);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glBindFramebuffer: bind a framebuffer to a framebuffer target
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the framebuffer target of the binding operation.
        /// </param>
        /// <param name="framebuffer">
        /// Specifies the name of the framebuffer object to bind.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        public static void BindFramebuffer(FramebufferTarget target, uint framebuffer)
        {
            Assert(Delegates.pglBindFramebuffer != null, "pglBindFramebuffer not implemented");
            Delegates.pglBindFramebuffer((int) target, framebuffer);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDeleteFramebuffers: delete framebuffer objects
        ///     </para>
        /// </summary>
        /// <param name="framebuffers">
        /// A pointer to an array containing <paramref name="n" /> framebuffer objects to be deleted.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static void DeleteFramebuffers(params uint[] framebuffers)
        {
            unsafe
            {
                fixed (uint* p_framebuffers = framebuffers)
                {
                    Assert(Delegates.pglDeleteFramebuffers != null, "pglDeleteFramebuffers not implemented");
                    Delegates.pglDeleteFramebuffers(framebuffers.Length, p_framebuffers);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGenFramebuffers: generate framebuffer object names
        ///     </para>
        /// </summary>
        /// <param name="framebuffers">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static void GenFramebuffers(uint[] framebuffers)
        {
            unsafe
            {
                fixed (uint* p_framebuffers = framebuffers)
                {
                    Assert(Delegates.pglGenFramebuffers != null, "pglGenFramebuffers not implemented");
                    Delegates.pglGenFramebuffers(framebuffers.Length, p_framebuffers);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGenFramebuffers: generate framebuffer object names
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static uint GenFramebuffer()
        {
            uint retValue;
            unsafe
            {
                Delegates.pglGenFramebuffers(1, &retValue);
            }

            DebugCheckErrors(null);
            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glCheckFramebufferStatus: check the completeness status of a framebuffer
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specify the target to which the framebuffer is bound for Gl.CheckFramebufferStatus, and the target against which
        /// framebuffer completeness of <paramref name="framebuffer" /> is checked for Gl.CheckNamedFramebufferStatus.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static FramebufferStatus CheckFramebufferStatus(FramebufferTarget target)
        {
            int retValue;

            Assert(Delegates.pglCheckFramebufferStatus != null, "pglCheckFramebufferStatus not implemented");
            retValue = Delegates.pglCheckFramebufferStatus((int) target);
            DebugCheckErrors(retValue);

            return (FramebufferStatus) retValue;
        }

        /// <summary>
        /// [GL4] glFramebufferTexture1D: attach a level of a texture object as a logical buffer of a framebuffer object
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the framebuffer is bound for all commands exceptGl.NamedFramebufferTexture.
        /// </param>
        /// <param name="attachment">
        /// Specifies the attachment point of the framebuffer.
        /// </param>
        /// <param name="textarget">
        /// For Gl.FramebufferTexture1D, Gl.FramebufferTexture2D and Gl.FramebufferTexture3D, specifies what type of texture is
        /// expected in the <paramref name="texture" /> parameter, or for cube map textures, which face is to be attached.
        /// </param>
        /// <param name="texture">
        /// Specifies the name of an existing texture object to attach.
        /// </param>
        /// <param name="level">
        /// Specifies the mipmap level of the texture object to attach.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static void FramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level)
        {
            Assert(Delegates.pglFramebufferTexture1D != null, "pglFramebufferTexture1D not implemented");
            Delegates.pglFramebufferTexture1D((int) target, (int) attachment, (int) textarget, texture, level);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glFramebufferTexture2D: attach a level of a texture object as a logical buffer of a framebuffer object
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glFramebufferTexture2D: attach a level of a texture object as a logical buffer to the currently bound
        ///     framebuffer object
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the framebuffer is bound for all commands exceptGl.NamedFramebufferTexture.
        /// </param>
        /// <param name="attachment">
        /// Specifies the attachment point of the framebuffer.
        /// </param>
        /// <param name="textarget">
        /// For Gl.FramebufferTexture1D, Gl.FramebufferTexture2D and Gl.FramebufferTexture3D, specifies what type of texture is
        /// expected in the <paramref name="texture" /> parameter, or for cube map textures, which face is to be attached.
        /// </param>
        /// <param name="texture">
        /// Specifies the name of an existing texture object to attach.
        /// </param>
        /// <param name="level">
        /// Specifies the mipmap level of the texture object to attach.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level)
        {
            Assert(Delegates.pglFramebufferTexture2D != null, "pglFramebufferTexture2D not implemented");
            Delegates.pglFramebufferTexture2D((int) target, (int) attachment, (int) textarget, texture, level);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glFramebufferTexture3D: attach a level of a texture object as a logical buffer of a framebuffer object
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the framebuffer is bound for all commands exceptGl.NamedFramebufferTexture.
        /// </param>
        /// <param name="attachment">
        /// Specifies the attachment point of the framebuffer.
        /// </param>
        /// <param name="textarget">
        /// For Gl.FramebufferTexture1D, Gl.FramebufferTexture2D and Gl.FramebufferTexture3D, specifies what type of texture is
        /// expected in the <paramref name="texture" /> parameter, or for cube map textures, which face is to be attached.
        /// </param>
        /// <param name="texture">
        /// Specifies the name of an existing texture object to attach.
        /// </param>
        /// <param name="level">
        /// Specifies the mipmap level of the texture object to attach.
        /// </param>
        /// <param name="layer">
        /// A <see cref="T:int" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static void FramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int layer)
        {
            Assert(Delegates.pglFramebufferTexture3D != null, "pglFramebufferTexture3D not implemented");
            Delegates.pglFramebufferTexture3D((int) target, (int) attachment, (int) textarget, texture, level, layer);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glFramebufferRenderbuffer: attach a renderbuffer as a logical buffer of a framebuffer object
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glFramebufferRenderbuffer: attach a renderbuffer as a logical buffer to the currently bound framebuffer
        ///     object
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the framebuffer is bound for Gl.FramebufferRenderbuffer.
        /// </param>
        /// <param name="attachment">
        /// Specifies the attachment point of the framebuffer.
        /// </param>
        /// <param name="renderbuffertarget">
        /// Specifies the renderbuffer target. Must be Gl.RENDERBUFFER.
        /// </param>
        /// <param name="renderbuffer">
        /// Specifies the name of an existing renderbuffer object of type <paramref name="renderbuffertarget" /> to attach.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer)
        {
            Assert(Delegates.pglFramebufferRenderbuffer != null, "pglFramebufferRenderbuffer not implemented");
            Delegates.pglFramebufferRenderbuffer((int) target, (int) attachment, (int) renderbuffertarget, renderbuffer);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glGetFramebufferAttachmentParameteriv: retrieve information about attachments of a framebuffer object
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glGetFramebufferAttachmentParameteriv: retrieve information about attachments of a bound framebuffer
        ///     object
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the framebuffer object is bound for Gl.GetFramebufferAttachmentParameteriv.
        /// </param>
        /// <param name="attachment">
        /// Specifies the attachment of the framebuffer object to query.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of <paramref name="attachment" /> to query.
        /// </param>
        /// <param name="params">
        /// Returns the value of parameter <paramref name="pname" /> for <paramref name="attachment" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static void GetFramebufferAttachmentParameter(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, [Out] int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Assert(Delegates.pglGetFramebufferAttachmentParameteriv != null, "pglGetFramebufferAttachmentParameteriv not implemented");
                    Delegates.pglGetFramebufferAttachmentParameteriv((int) target, (int) attachment, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glGetFramebufferAttachmentParameteriv: retrieve information about attachments of a framebuffer object
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glGetFramebufferAttachmentParameteriv: retrieve information about attachments of a bound framebuffer
        ///     object
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the framebuffer object is bound for Gl.GetFramebufferAttachmentParameteriv.
        /// </param>
        /// <param name="attachment">
        /// Specifies the attachment of the framebuffer object to query.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of <paramref name="attachment" /> to query.
        /// </param>
        /// <param name="params">
        /// Returns the value of parameter <paramref name="pname" /> for <paramref name="attachment" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static void GetFramebufferAttachmentParameter(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, out int @params)
        {
            unsafe
            {
                fixed (int* p_params = &@params)
                {
                    Assert(Delegates.pglGetFramebufferAttachmentParameteriv != null, "pglGetFramebufferAttachmentParameteriv not implemented");
                    Delegates.pglGetFramebufferAttachmentParameteriv((int) target, (int) attachment, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glGetFramebufferAttachmentParameteriv: retrieve information about attachments of a framebuffer object
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glGetFramebufferAttachmentParameteriv: retrieve information about attachments of a bound framebuffer
        ///     object
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the framebuffer object is bound for Gl.GetFramebufferAttachmentParameteriv.
        /// </param>
        /// <param name="attachment">
        /// Specifies the attachment of the framebuffer object to query.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of <paramref name="attachment" /> to query.
        /// </param>
        /// <param name="params">
        /// Returns the value of parameter <paramref name="pname" /> for <paramref name="attachment" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static unsafe void GetFramebufferAttachmentParameter(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, [Out] int* @params)
        {
            Assert(Delegates.pglGetFramebufferAttachmentParameteriv != null, "pglGetFramebufferAttachmentParameteriv not implemented");
            Delegates.pglGetFramebufferAttachmentParameteriv((int) target, (int) attachment, (int) pname, @params);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glGetFramebufferAttachmentParameteriv: retrieve information about attachments of a framebuffer object
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glGetFramebufferAttachmentParameteriv: retrieve information about attachments of a bound framebuffer
        ///     object
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the framebuffer object is bound for Gl.GetFramebufferAttachmentParameteriv.
        /// </param>
        /// <param name="attachment">
        /// Specifies the attachment of the framebuffer object to query.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of <paramref name="attachment" /> to query.
        /// </param>
        /// <param name="params">
        /// Returns the value of parameter <paramref name="pname" /> for <paramref name="attachment" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static void GetFramebufferAttachmentParameteri<T>(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, out T @params) where T : struct
        {
            Assert(Delegates.pglGetFramebufferAttachmentParameteriv != null, "pglGetFramebufferAttachmentParameteriv not implemented");
            @params = default;
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(@params);
			try {
				unsafe {
					Delegates.pglGetFramebufferAttachmentParameteriv((int)target, (int)attachment, (int)pname, (int*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refParams = __makeref(@params);
                IntPtr refParamsPtr = *(IntPtr*) (&refParams);

                Delegates.pglGetFramebufferAttachmentParameteriv((int) target, (int) attachment, (int) pname, (int*) refParamsPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glGenerateMipmap: generate mipmaps for a specified texture object
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glGenerateMipmap: generate mipmaps for a specified texture target
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture object is bound for Gl.GenerateMipmap. Must be one of Gl.TEXTURE_1D,
        /// Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_CUBE_MAP, or
        /// Gl.TEXTURE_CUBE_MAP_ARRAY.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_object")]
        public static void GenerateMipmap(TextureTarget target)
        {
            Assert(Delegates.pglGenerateMipmap != null, "pglGenerateMipmap not implemented");
            Delegates.pglGenerateMipmap((int) target);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glBlitFramebuffer: copy a block of pixels from one framebuffer object to another
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glBlitFramebuffer: copy a block of pixels from the read framebuffer to the draw framebuffer
        ///     </para>
        /// </summary>
        /// <param name="srcX0">
        /// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
        /// </param>
        /// <param name="srcY0">
        /// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
        /// </param>
        /// <param name="srcX1">
        /// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
        /// </param>
        /// <param name="srcY1">
        /// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
        /// </param>
        /// <param name="dstX0">
        /// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
        /// </param>
        /// <param name="dstY0">
        /// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
        /// </param>
        /// <param name="dstX1">
        /// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
        /// </param>
        /// <param name="dstY1">
        /// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
        /// </param>
        /// <param name="mask">
        /// The bitwise OR of the flags indicating which buffers are to be copied. The allowed flags are Gl.COLOR_BUFFER_BIT,
        /// Gl.DEPTH_BUFFER_BIT and Gl.STENCIL_BUFFER_BIT.
        /// </param>
        /// <param name="filter">
        /// Specifies the interpolation to be applied if the image is stretched. Must be Gl.NEAREST or Gl.LINEAR.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_blit")]
        [RequiredByFeature("GL_NV_framebuffer_blit", Api = "gles2")]
        public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter)
        {
            Assert(Delegates.pglBlitFramebuffer != null, "pglBlitFramebuffer not implemented");
            Delegates.pglBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint) mask, (int) filter);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glRenderbufferStorageMultisample: establish data storage, format, dimensions and sample count of a
        ///     renderbuffer object's image
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies a binding target of the allocation for Gl.RenderbufferStorageMultisample function. Must be Gl.RENDERBUFFER.
        /// </param>
        /// <param name="samples">
        /// Specifies the number of samples to be used for the renderbuffer object's storage.
        /// </param>
        /// <param name="internalformat">
        /// Specifies the internal format to use for the renderbuffer object's image.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the renderbuffer, in pixels.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the renderbuffer, in pixels.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_framebuffer_multisample")]
        [RequiredByFeature("GL_EXT_multisampled_render_to_texture", Api = "gles1|gles2")]
        [RequiredByFeature("GL_NV_framebuffer_multisample", Api = "gles2")]
        public static void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height)
        {
            Assert(Delegates.pglRenderbufferStorageMultisample != null, "pglRenderbufferStorageMultisample not implemented");
            Delegates.pglRenderbufferStorageMultisample((int) target, samples, (int) internalformat, width, height);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glFramebufferTextureLayer: attach a single layer of a texture object as a logical buffer of a framebuffer
        ///     object
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glFramebufferTextureLayer: attach a single layer of a texture to a framebuffer
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the framebuffer is bound for Gl.FramebufferTextureLayer.
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
        /// <param name="layer">
        /// Specifies the layer of the texture object to attach.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_array")]
        [RequiredByFeature("GL_NV_geometry_program4")]
        public static void FramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer)
        {
            Assert(Delegates.pglFramebufferTextureLayer != null, "pglFramebufferTextureLayer not implemented");
            Delegates.pglFramebufferTextureLayer((int) target, (int) attachment, texture, level, layer);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glMapBufferRange: map all or part of a buffer object's data store into the client's address space
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glMapBufferRange: map a section of a buffer object's data store
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound for Gl.MapBufferRange, which must be one of the buffer binding
        /// targets in the following table:
        /// </param>
        /// <param name="offset">
        /// Specifies the starting offset within the buffer of the range to be mapped.
        /// </param>
        /// <param name="length">
        /// Specifies the length of the range to be mapped.
        /// </param>
        /// <param name="access">
        /// Specifies a combination of access flags indicating the desired access to the mapped range.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
        public static IntPtr MapBufferRange(BufferTarget target, IntPtr offset, uint length, BufferAccessMask access)
        {
            IntPtr retValue;

            Assert(Delegates.pglMapBufferRange != null, "pglMapBufferRange not implemented");
            retValue = Delegates.pglMapBufferRange((int) target, offset, length, (uint) access);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glFlushMappedBufferRange: indicate modifications to a range of a mapped buffer
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound for Gl.FlushMappedBufferRange, which must be one of the buffer
        /// binding targets in the following table:
        /// </param>
        /// <param name="offset">
        /// Specifies the start of the buffer subrange, in basic machine units.
        /// </param>
        /// <param name="length">
        /// Specifies the length of the buffer subrange, in basic machine units.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_flush_buffer_range")]
        [RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
        public static void FlushMappedBufferRange(BufferTarget target, IntPtr offset, uint length)
        {
            Assert(Delegates.pglFlushMappedBufferRange != null, "pglFlushMappedBufferRange not implemented");
            Delegates.pglFlushMappedBufferRange((int) target, offset, length);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glBindVertexArray: bind a vertex array object
        ///     </para>
        /// </summary>
        /// <param name="array">
        /// Specifies the name of the vertex array to bind.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2")]
        public static void BindVertexArray(uint array)
        {
            Assert(Delegates.pglBindVertexArray != null, "pglBindVertexArray not implemented");
            Delegates.pglBindVertexArray(array);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDeleteVertexArrays: delete vertex array objects
        ///     </para>
        /// </summary>
        /// <param name="arrays">
        /// Specifies the address of an array containing the <paramref name="n" /> names of the objects to be deleted.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_vertex_array_object")]
        [RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2")]
        public static void DeleteVertexArrays(params uint[] arrays)
        {
            unsafe
            {
                fixed (uint* p_arrays = arrays)
                {
                    Assert(Delegates.pglDeleteVertexArrays != null, "pglDeleteVertexArrays not implemented");
                    Delegates.pglDeleteVertexArrays(arrays.Length, p_arrays);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGenVertexArrays: generate vertex array object names
        ///     </para>
        /// </summary>
        /// <param name="arrays">
        /// Specifies an array in which the generated vertex array object names are stored.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_vertex_array_object")]
        [RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2")]
        public static void GenVertexArrays(uint[] arrays)
        {
            unsafe
            {
                fixed (uint* p_arrays = arrays)
                {
                    Assert(Delegates.pglGenVertexArrays != null, "pglGenVertexArrays not implemented");
                    Delegates.pglGenVertexArrays(arrays.Length, p_arrays);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGenVertexArrays: generate vertex array object names
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_vertex_array_object")]
        [RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2")]
        public static uint GenVertexArray()
        {
            uint retValue;
            unsafe
            {
                Delegates.pglGenVertexArrays(1, &retValue);
            }

            DebugCheckErrors(null);
            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glIsVertexArray: determine if a name corresponds to a vertex array object
        ///     </para>
        /// </summary>
        /// <param name="array">
        /// Specifies a value that may be the name of a vertex array object.
        /// </param>
        [RequiredByFeature("GL_VERSION_3_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_APPLE_vertex_array_object")]
        [RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2")]
        public static bool IsVertexArray(uint array)
        {
            bool retValue;

            Assert(Delegates.pglIsVertexArray != null, "pglIsVertexArray not implemented");
            retValue = Delegates.pglIsVertexArray(array);
            DebugCheckErrors(retValue);

            return retValue;
        }

        public static unsafe partial class Delegates
        {
            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_EXT_draw_buffers2")]
            [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
            [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glColorMaski(uint index, [MarshalAs(UnmanagedType.I1)] bool r, [MarshalAs(UnmanagedType.I1)] bool g, [MarshalAs(UnmanagedType.I1)] bool b,
                [MarshalAs(UnmanagedType.I1)] bool a);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_EXT_draw_buffers2", EntryPoint = "glColorMaskIndexedEXT")]
            [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2", EntryPoint = "glColorMaskiEXT")]
            [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2", EntryPoint = "glColorMaskiOES")]
            [ThreadStatic]
            public static glColorMaski pglColorMaski;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_draw_buffers2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetBooleani_v(int target, uint index, byte* data);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glGetBooleanIndexedvEXT")]
            [RequiredByFeature("GL_EXT_draw_buffers2", EntryPoint = "glGetBooleanIndexedvEXT")]
            [ThreadStatic]
            public static glGetBooleani_v pglGetBooleani_v;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_VERSION_3_1")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_draw_buffers2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetIntegeri_v(int target, uint index, int* data);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_VERSION_3_1")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glGetIntegerIndexedvEXT")]
            [RequiredByFeature("GL_EXT_draw_buffers2", EntryPoint = "glGetIntegerIndexedvEXT")]
            [ThreadStatic]
            public static glGetIntegeri_v pglGetIntegeri_v;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_draw_buffers2")]
            [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
            [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glEnablei(int target, uint index);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glEnableIndexedEXT")]
            [RequiredByFeature("GL_EXT_draw_buffers2", EntryPoint = "glEnableIndexedEXT")]
            [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2", EntryPoint = "glEnableiEXT")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2", EntryPoint = "glEnableiNV")]
            [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2", EntryPoint = "glEnableiOES")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2", EntryPoint = "glEnableiOES")]
            [ThreadStatic]
            public static glEnablei pglEnablei;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_draw_buffers2")]
            [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
            [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDisablei(int target, uint index);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glDisableIndexedEXT")]
            [RequiredByFeature("GL_EXT_draw_buffers2", EntryPoint = "glDisableIndexedEXT")]
            [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2", EntryPoint = "glDisableiEXT")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2", EntryPoint = "glDisableiNV")]
            [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2", EntryPoint = "glDisableiOES")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2", EntryPoint = "glDisableiOES")]
            [ThreadStatic]
            public static glDisablei pglDisablei;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_draw_buffers2")]
            [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
            [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.I1)]
            public delegate bool glIsEnabledi(int target, uint index);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore", EntryPoint = "glIsEnabledIndexedEXT")]
            [RequiredByFeature("GL_EXT_draw_buffers2", EntryPoint = "glIsEnabledIndexedEXT")]
            [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2", EntryPoint = "glIsEnablediEXT")]
            [RequiredByFeature("GL_NV_viewport_array", Api = "gles2", EntryPoint = "glIsEnablediNV")]
            [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2", EntryPoint = "glIsEnablediOES")]
            [RequiredByFeature("GL_OES_viewport_array", Api = "gles2", EntryPoint = "glIsEnablediOES")]
            [ThreadStatic]
            public static glIsEnabledi pglIsEnabledi;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_transform_feedback")]
            [RequiredByFeature("GL_NV_transform_feedback")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBeginTransformFeedback(int primitiveMode);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_transform_feedback", EntryPoint = "glBeginTransformFeedbackEXT")]
            [RequiredByFeature("GL_NV_transform_feedback", EntryPoint = "glBeginTransformFeedbackNV")]
            [ThreadStatic]
            public static glBeginTransformFeedback pglBeginTransformFeedback;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_transform_feedback")]
            [RequiredByFeature("GL_NV_transform_feedback")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glEndTransformFeedback();

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_transform_feedback", EntryPoint = "glEndTransformFeedbackEXT")]
            [RequiredByFeature("GL_NV_transform_feedback", EntryPoint = "glEndTransformFeedbackNV")]
            [ThreadStatic]
            public static glEndTransformFeedback pglEndTransformFeedback;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_VERSION_3_1")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_transform_feedback")]
            [RequiredByFeature("GL_NV_transform_feedback")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBindBufferRange(int target, uint index, uint buffer, IntPtr offset, uint size);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_VERSION_3_1")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_transform_feedback", EntryPoint = "glBindBufferRangeEXT")]
            [RequiredByFeature("GL_NV_transform_feedback", EntryPoint = "glBindBufferRangeNV")]
            [ThreadStatic]
            public static glBindBufferRange pglBindBufferRange;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_VERSION_3_1")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_transform_feedback")]
            [RequiredByFeature("GL_NV_transform_feedback")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBindBufferBase(int target, uint index, uint buffer);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_VERSION_3_1")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_transform_feedback", EntryPoint = "glBindBufferBaseEXT")]
            [RequiredByFeature("GL_NV_transform_feedback", EntryPoint = "glBindBufferBaseNV")]
            [ThreadStatic]
            public static glBindBufferBase pglBindBufferBase;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_transform_feedback")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glTransformFeedbackVaryings(uint program, int count, string[] varyings, int bufferMode);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_transform_feedback", EntryPoint = "glTransformFeedbackVaryingsEXT")]
            [ThreadStatic]
            public static glTransformFeedbackVaryings pglTransformFeedbackVaryings;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_transform_feedback")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, int* type, StringBuilder name);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_transform_feedback", EntryPoint = "glGetTransformFeedbackVaryingEXT")]
            [ThreadStatic]
            public static glGetTransformFeedbackVarying pglGetTransformFeedbackVarying;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ARB_color_buffer_float")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glClampColor(int target, int clamp);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ARB_color_buffer_float", EntryPoint = "glClampColorARB")] [ThreadStatic]
            public static glClampColor pglClampColor;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_NV_conditional_render", Api = "gl|glcore|gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBeginConditionalRender(uint id, int mode);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_conditional_render", Api = "gl|glcore|gles2", EntryPoint = "glBeginConditionalRenderNV")] [ThreadStatic]
            public static glBeginConditionalRender pglBeginConditionalRender;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_NVX_conditional_render")]
            [RequiredByFeature("GL_NV_conditional_render", Api = "gl|glcore|gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glEndConditionalRender();

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_NVX_conditional_render", EntryPoint = "glEndConditionalRenderNVX")]
            [RequiredByFeature("GL_NV_conditional_render", Api = "gl|glcore|gles2", EntryPoint = "glEndConditionalRenderNV")]
            [ThreadStatic]
            public static glEndConditionalRender pglEndConditionalRender;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribIPointer(uint index, int size, int type, int stride, IntPtr pointer);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribIPointerEXT")]
            [ThreadStatic]
            public static glVertexAttribIPointer pglVertexAttribIPointer;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetVertexAttribIiv(uint index, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glGetVertexAttribIivEXT")]
            [ThreadStatic]
            public static glGetVertexAttribIiv pglGetVertexAttribIiv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetVertexAttribIuiv(uint index, int pname, uint* @params);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glGetVertexAttribIuivEXT")]
            [ThreadStatic]
            public static glGetVertexAttribIuiv pglGetVertexAttribIuiv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI1i(uint index, int x);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI1iEXT")] [ThreadStatic]
            public static glVertexAttribI1i pglVertexAttribI1i;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI2i(uint index, int x, int y);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI2iEXT")] [ThreadStatic]
            public static glVertexAttribI2i pglVertexAttribI2i;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI3i(uint index, int x, int y, int z);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI3iEXT")] [ThreadStatic]
            public static glVertexAttribI3i pglVertexAttribI3i;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI4i(uint index, int x, int y, int z, int w);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI4iEXT")]
            [ThreadStatic]
            public static glVertexAttribI4i pglVertexAttribI4i;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI1ui(uint index, uint x);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI1uiEXT")] [ThreadStatic]
            public static glVertexAttribI1ui pglVertexAttribI1ui;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI2ui(uint index, uint x, uint y);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI2uiEXT")] [ThreadStatic]
            public static glVertexAttribI2ui pglVertexAttribI2ui;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI3ui(uint index, uint x, uint y, uint z);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI3uiEXT")] [ThreadStatic]
            public static glVertexAttribI3ui pglVertexAttribI3ui;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI4uiEXT")]
            [ThreadStatic]
            public static glVertexAttribI4ui pglVertexAttribI4ui;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI1iv(uint index, int* v);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI1ivEXT")] [ThreadStatic]
            public static glVertexAttribI1iv pglVertexAttribI1iv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI2iv(uint index, int* v);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI2ivEXT")] [ThreadStatic]
            public static glVertexAttribI2iv pglVertexAttribI2iv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI3iv(uint index, int* v);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI3ivEXT")] [ThreadStatic]
            public static glVertexAttribI3iv pglVertexAttribI3iv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI4iv(uint index, int* v);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI4ivEXT")]
            [ThreadStatic]
            public static glVertexAttribI4iv pglVertexAttribI4iv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI1uiv(uint index, uint* v);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI1uivEXT")] [ThreadStatic]
            public static glVertexAttribI1uiv pglVertexAttribI1uiv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI2uiv(uint index, uint* v);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI2uivEXT")] [ThreadStatic]
            public static glVertexAttribI2uiv pglVertexAttribI2uiv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI3uiv(uint index, uint* v);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI3uivEXT")] [ThreadStatic]
            public static glVertexAttribI3uiv pglVertexAttribI3uiv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI4uiv(uint index, uint* v);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI4uivEXT")]
            [ThreadStatic]
            public static glVertexAttribI4uiv pglVertexAttribI4uiv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI4bv(uint index, sbyte* v);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI4bvEXT")] [ThreadStatic]
            public static glVertexAttribI4bv pglVertexAttribI4bv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI4sv(uint index, short* v);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI4svEXT")] [ThreadStatic]
            public static glVertexAttribI4sv pglVertexAttribI4sv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI4ubv(uint index, byte* v);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI4ubvEXT")] [ThreadStatic]
            public static glVertexAttribI4ubv pglVertexAttribI4ubv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_NV_vertex_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribI4usv(uint index, ushort* v);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_NV_vertex_program4", EntryPoint = "glVertexAttribI4usvEXT")] [ThreadStatic]
            public static glVertexAttribI4usv pglVertexAttribI4usv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_gpu_shader4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetUniformuiv(uint program, int location, uint* @params);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4", EntryPoint = "glGetUniformuivEXT")] [ThreadStatic]
            public static glGetUniformuiv pglGetUniformuiv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
            [RequiredByFeature("GL_EXT_gpu_shader4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBindFragDataLocation(uint program, uint color, string name);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2", EntryPoint = "glBindFragDataLocationEXT")]
            [RequiredByFeature("GL_EXT_gpu_shader4", EntryPoint = "glBindFragDataLocationEXT")]
            [ThreadStatic]
            public static glBindFragDataLocation pglBindFragDataLocation;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_gpu_shader4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate int glGetFragDataLocation(uint program, string name);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_gpu_shader4", EntryPoint = "glGetFragDataLocationEXT")]
            [ThreadStatic]
            public static glGetFragDataLocation pglGetFragDataLocation;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_gpu_shader4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glUniform1ui(int location, uint v0);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4", EntryPoint = "glUniform1uiEXT")] [ThreadStatic]
            public static glUniform1ui pglUniform1ui;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_gpu_shader4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glUniform2ui(int location, uint v0, uint v1);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4", EntryPoint = "glUniform2uiEXT")] [ThreadStatic]
            public static glUniform2ui pglUniform2ui;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_gpu_shader4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glUniform3ui(int location, uint v0, uint v1, uint v2);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4", EntryPoint = "glUniform3uiEXT")] [ThreadStatic]
            public static glUniform3ui pglUniform3ui;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_gpu_shader4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glUniform4ui(int location, uint v0, uint v1, uint v2, uint v3);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4", EntryPoint = "glUniform4uiEXT")] [ThreadStatic]
            public static glUniform4ui pglUniform4ui;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_gpu_shader4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glUniform1uiv(int location, int count, uint* value);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4", EntryPoint = "glUniform1uivEXT")] [ThreadStatic]
            public static glUniform1uiv pglUniform1uiv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_gpu_shader4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glUniform2uiv(int location, int count, uint* value);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4", EntryPoint = "glUniform2uivEXT")] [ThreadStatic]
            public static glUniform2uiv pglUniform2uiv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_gpu_shader4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glUniform3uiv(int location, int count, uint* value);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4", EntryPoint = "glUniform3uivEXT")] [ThreadStatic]
            public static glUniform3uiv pglUniform3uiv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_EXT_gpu_shader4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glUniform4uiv(int location, int count, uint* value);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_gpu_shader4", EntryPoint = "glUniform4uivEXT")] [ThreadStatic]
            public static glUniform4uiv pglUniform4uiv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
            [RequiredByFeature("GL_EXT_texture_integer")]
            [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glTexParameterIiv(int target, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2", EntryPoint = "glTexParameterIivEXT")]
            [RequiredByFeature("GL_EXT_texture_integer", EntryPoint = "glTexParameterIivEXT")]
            [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2", EntryPoint = "glTexParameterIivOES")]
            [ThreadStatic]
            public static glTexParameterIiv pglTexParameterIiv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
            [RequiredByFeature("GL_EXT_texture_integer")]
            [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glTexParameterIuiv(int target, int pname, uint* @params);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2", EntryPoint = "glTexParameterIuivEXT")]
            [RequiredByFeature("GL_EXT_texture_integer", EntryPoint = "glTexParameterIuivEXT")]
            [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2", EntryPoint = "glTexParameterIuivOES")]
            [ThreadStatic]
            public static glTexParameterIuiv pglTexParameterIuiv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
            [RequiredByFeature("GL_EXT_texture_integer")]
            [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetTexParameterIiv(int target, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2", EntryPoint = "glGetTexParameterIivEXT")]
            [RequiredByFeature("GL_EXT_texture_integer", EntryPoint = "glGetTexParameterIivEXT")]
            [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2", EntryPoint = "glGetTexParameterIivOES")]
            [ThreadStatic]
            public static glGetTexParameterIiv pglGetTexParameterIiv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
            [RequiredByFeature("GL_EXT_texture_integer")]
            [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetTexParameterIuiv(int target, int pname, uint* @params);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2", EntryPoint = "glGetTexParameterIuivEXT")]
            [RequiredByFeature("GL_EXT_texture_integer", EntryPoint = "glGetTexParameterIuivEXT")]
            [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2", EntryPoint = "glGetTexParameterIuivOES")]
            [ThreadStatic]
            public static glGetTexParameterIuiv pglGetTexParameterIuiv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glClearBufferiv(int buffer, int drawbuffer, int* value);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [ThreadStatic]
            public static glClearBufferiv pglClearBufferiv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glClearBufferuiv(int buffer, int drawbuffer, uint* value);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [ThreadStatic]
            public static glClearBufferuiv pglClearBufferuiv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glClearBufferfv(int buffer, int drawbuffer, float* value);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [ThreadStatic]
            public static glClearBufferfv pglClearBufferfv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glClearBufferfi(int buffer, int drawbuffer, float depth, int stencil);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [ThreadStatic]
            public static glClearBufferfi pglClearBufferfi;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr glGetStringi(int name, uint index);

            [RequiredByFeature("GL_VERSION_3_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [ThreadStatic]
            public static glGetStringi pglGetStringi;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object")]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.I1)]
            public delegate bool glIsRenderbuffer(uint renderbuffer);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object", EntryPoint = "glIsRenderbufferEXT")]
            [ThreadStatic]
            public static glIsRenderbuffer pglIsRenderbuffer;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBindRenderbuffer(int target, uint renderbuffer);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [ThreadStatic]
            public static glBindRenderbuffer pglBindRenderbuffer;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDeleteRenderbuffers(int n, uint* renderbuffers);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object", EntryPoint = "glDeleteRenderbuffersEXT")]
            [ThreadStatic]
            public static glDeleteRenderbuffers pglDeleteRenderbuffers;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGenRenderbuffers(int n, uint* renderbuffers);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object", EntryPoint = "glGenRenderbuffersEXT")]
            [ThreadStatic]
            public static glGenRenderbuffers pglGenRenderbuffers;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glRenderbufferStorage(int target, int internalformat, int width, int height);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object", EntryPoint = "glRenderbufferStorageEXT")]
            [ThreadStatic]
            public static glRenderbufferStorage pglRenderbufferStorage;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetRenderbufferParameteriv(int target, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object", EntryPoint = "glGetRenderbufferParameterivEXT")]
            [ThreadStatic]
            public static glGetRenderbufferParameteriv pglGetRenderbufferParameteriv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object")]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.I1)]
            public delegate bool glIsFramebuffer(uint framebuffer);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object", EntryPoint = "glIsFramebufferEXT")]
            [ThreadStatic]
            public static glIsFramebuffer pglIsFramebuffer;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBindFramebuffer(int target, uint framebuffer);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [ThreadStatic]
            public static glBindFramebuffer pglBindFramebuffer;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDeleteFramebuffers(int n, uint* framebuffers);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object", EntryPoint = "glDeleteFramebuffersEXT")]
            [ThreadStatic]
            public static glDeleteFramebuffers pglDeleteFramebuffers;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGenFramebuffers(int n, uint* framebuffers);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object", EntryPoint = "glGenFramebuffersEXT")]
            [ThreadStatic]
            public static glGenFramebuffers pglGenFramebuffers;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate int glCheckFramebufferStatus(int target);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object", EntryPoint = "glCheckFramebufferStatusEXT")]
            [ThreadStatic]
            public static glCheckFramebufferStatus pglCheckFramebufferStatus;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glFramebufferTexture1D(int target, int attachment, int textarget, uint texture, int level);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object", EntryPoint = "glFramebufferTexture1DEXT")]
            [ThreadStatic]
            public static glFramebufferTexture1D pglFramebufferTexture1D;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glFramebufferTexture2D(int target, int attachment, int textarget, uint texture, int level);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object", EntryPoint = "glFramebufferTexture2DEXT")]
            [ThreadStatic]
            public static glFramebufferTexture2D pglFramebufferTexture2D;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glFramebufferTexture3D(int target, int attachment, int textarget, uint texture, int level, int zoffset);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object", EntryPoint = "glFramebufferTexture3DEXT")]
            [ThreadStatic]
            public static glFramebufferTexture3D pglFramebufferTexture3D;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glFramebufferRenderbuffer(int target, int attachment, int renderbuffertarget, uint renderbuffer);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object", EntryPoint = "glFramebufferRenderbufferEXT")]
            [ThreadStatic]
            public static glFramebufferRenderbuffer pglFramebufferRenderbuffer;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetFramebufferAttachmentParameteriv(int target, int attachment, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object", EntryPoint = "glGetFramebufferAttachmentParameterivEXT")]
            [ThreadStatic]
            public static glGetFramebufferAttachmentParameteriv pglGetFramebufferAttachmentParameteriv;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGenerateMipmap(int target);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_object", EntryPoint = "glGenerateMipmapEXT")]
            [ThreadStatic]
            public static glGenerateMipmap pglGenerateMipmap;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_blit")]
            [RequiredByFeature("GL_NV_framebuffer_blit", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, int filter);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_blit", EntryPoint = "glBlitFramebufferEXT")]
            [RequiredByFeature("GL_NV_framebuffer_blit", Api = "gles2", EntryPoint = "glBlitFramebufferNV")]
            [ThreadStatic]
            public static glBlitFramebuffer pglBlitFramebuffer;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_multisample")]
            [RequiredByFeature("GL_EXT_multisampled_render_to_texture", Api = "gles1|gles2")]
            [RequiredByFeature("GL_NV_framebuffer_multisample", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glRenderbufferStorageMultisample(int target, int samples, int internalformat, int width, int height);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_framebuffer_multisample", EntryPoint = "glRenderbufferStorageMultisampleEXT")]
            [RequiredByFeature("GL_EXT_multisampled_render_to_texture", Api = "gles1|gles2", EntryPoint = "glRenderbufferStorageMultisampleEXT")]
            [RequiredByFeature("GL_NV_framebuffer_multisample", Api = "gles2", EntryPoint = "glRenderbufferStorageMultisampleNV")]
            [ThreadStatic]
            public static glRenderbufferStorageMultisample pglRenderbufferStorageMultisample;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_texture_array")]
            [RequiredByFeature("GL_NV_geometry_program4")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glFramebufferTextureLayer(int target, int attachment, uint texture, int level, int layer);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore", EntryPoint = "glFramebufferTextureLayerARB")]
            [RequiredByFeature("GL_EXT_texture_array", EntryPoint = "glFramebufferTextureLayerEXT")]
            [RequiredByFeature("GL_NV_geometry_program4", EntryPoint = "glFramebufferTextureLayerEXT")]
            [ThreadStatic]
            public static glFramebufferTextureLayer pglFramebufferTextureLayer;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr glMapBufferRange(int target, IntPtr offset, uint length, uint access);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2", EntryPoint = "glMapBufferRangeEXT")]
            [ThreadStatic]
            public static glMapBufferRange pglMapBufferRange;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_flush_buffer_range")]
            [RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glFlushMappedBufferRange(int target, IntPtr offset, uint length);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_flush_buffer_range", EntryPoint = "glFlushMappedBufferRangeAPPLE")]
            [RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2", EntryPoint = "glFlushMappedBufferRangeEXT")]
            [ThreadStatic]
            public static glFlushMappedBufferRange pglFlushMappedBufferRange;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBindVertexArray(uint array);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2", EntryPoint = "glBindVertexArrayOES")]
            [ThreadStatic]
            public static glBindVertexArray pglBindVertexArray;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_vertex_array_object")]
            [RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDeleteVertexArrays(int n, uint* arrays);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_vertex_array_object", EntryPoint = "glDeleteVertexArraysAPPLE")]
            [RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2", EntryPoint = "glDeleteVertexArraysOES")]
            [ThreadStatic]
            public static glDeleteVertexArrays pglDeleteVertexArrays;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_vertex_array_object")]
            [RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGenVertexArrays(int n, uint* arrays);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_vertex_array_object", EntryPoint = "glGenVertexArraysAPPLE")]
            [RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2", EntryPoint = "glGenVertexArraysOES")]
            [ThreadStatic]
            public static glGenVertexArrays pglGenVertexArrays;

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_vertex_array_object")]
            [RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2")]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.I1)]
            public delegate bool glIsVertexArray(uint array);

            [RequiredByFeature("GL_VERSION_3_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_APPLE_vertex_array_object", EntryPoint = "glIsVertexArrayAPPLE")]
            [RequiredByFeature("GL_ARB_vertex_array_object", Api = "gl|glcore")]
            [RequiredByFeature("GL_OES_vertex_array_object", Api = "gles1|gles2", EntryPoint = "glIsVertexArrayOES")]
            [ThreadStatic]
            public static glIsVertexArray pglIsVertexArray;
        }
    }
}
#pragma warning restore CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type