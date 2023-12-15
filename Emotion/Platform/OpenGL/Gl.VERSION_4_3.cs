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
        /// [GL] Value of GL_NUM_SHADING_LANGUAGE_VERSIONS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] public const int NUM_SHADING_LANGUAGE_VERSIONS = 0x82E9;

        /// <summary>
        /// [GL] Value of GL_VERTEX_ATTRIB_ARRAY_LONG symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] public const int VERTEX_ATTRIB_ARRAY_LONG = 0x874E;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_RGB8_ETC2 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
        public const int COMPRESSED_RGB8_ETC2 = 0x9274;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_SRGB8_ETC2 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
        public const int COMPRESSED_SRGB8_ETC2 = 0x9275;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
        public const int COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
        public const int COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_RGBA8_ETC2_EAC symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
        public const int COMPRESSED_RGBA8_ETC2_EAC = 0x9278;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
        public const int COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_R11_EAC symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
        public const int COMPRESSED_R11_EAC = 0x9270;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_SIGNED_R11_EAC symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
        public const int COMPRESSED_SIGNED_R11_EAC = 0x9271;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_RG11_EAC symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
        public const int COMPRESSED_RG11_EAC = 0x9272;

        /// <summary>
        /// [GL] Value of GL_COMPRESSED_SIGNED_RG11_EAC symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
        public const int COMPRESSED_SIGNED_RG11_EAC = 0x9273;

        /// <summary>
        /// [GLES3.2] Gl.Get: data returns a single boolean value indicating whether primitive restart with a fixed index is
        /// enabled. The initial value is Gl.FALSE.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
        public const int PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;

        /// <summary>
        /// [GL] Value of GL_ANY_SAMPLES_PASSED_CONSERVATIVE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
        public const int ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns a single value, the maximum index that may be specified during the transfer of generic
        ///     vertex
        ///     attributes to the GL.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the maximum index supported by the implementation. The value must be at
        ///     least
        ///     224-1.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
        public const int MAX_ELEMENT_INDEX = 0x8D6B;

        /// <summary>
        /// [GL] Value of GL_COMPUTE_SHADER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public const int COMPUTE_SHADER = 0x91B9;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of uniform blocks per compute shader. The value must
        /// be
        /// at least 14. See Gl.UniformBlockBinding.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public const int MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum supported texture image units that can be used to access
        /// texture maps from the compute shader. The value may be at least 16. See Gl.ActiveTexture.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public const int MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;

        /// <summary>
        /// [GLES3.2] Gl.Get: data returns one value, the maximum supported number of image variables in compute shaders.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public const int MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;

        /// <summary>
        /// [GL] Value of GL_MAX_COMPUTE_SHARED_MEMORY_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public const int MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of individual floating-point, integer, or boolean
        /// values that can be held in uniform variable storage for a compute shader. The value must be at least 1024. See
        /// Gl.Uniform.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public const int MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counter buffers that may be accessed by
        /// a compute shader.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public const int MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counters available to compute shaders.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public const int MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the number of words for compute shader uniform variables in all uniform
        /// blocks (including default). The value must be at least 1. See Gl.Uniform.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public const int MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the number of invocations in a single local work group (i.e., the product
        /// of the three dimensions) that may be dispatched to a compute shader.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public const int MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: Accepted by the indexed versions of glGet. data the maximum number of work groups that may be
        /// dispatched to a compute shader. Indices 0, 1, and 2 correspond to the X, Y and Z dimensions, respectively.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public const int MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: Accepted by the indexed versions of glGet. data the maximum size of a work groups that may be
        /// used
        /// during compilation of a compute shader. Indices 0, 1, and 2 correspond to the X, Y and Z dimensions, respectively.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public const int MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetProgram: params returns an array of three integers containing the local work group size of the
        /// compute program as specified by its input layout qualifier(s). program must be the name of a program object that has
        /// been previously linked successfully and contains a binary for the compute shader stage.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public const int COMPUTE_WORK_GROUP_SIZE = 0x8267;

        /// <summary>
        /// [GL] Value of GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public const int UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;

        /// <summary>
        /// [GL] Value of GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;

        /// <summary>
        /// [GL] Value of GL_DISPATCH_INDIRECT_BUFFER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public const int DISPATCH_INDIRECT_BUFFER = 0x90EE;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single value, the name of the buffer object currently bound to the target
        /// Gl.DISPATCH_INDIRECT_BUFFER. If no buffer object is bound to this target, 0 is returned. The initial value is 0. See
        /// Gl.BindBuffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public const int DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;

        /// <summary>
        /// [GL] Value of GL_COMPUTE_SHADER_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public const uint COMPUTE_SHADER_BIT = 0x00000020;

        /// <summary>
        /// [GL] Value of GL_DEBUG_OUTPUT_SYNCHRONOUS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;

        /// <summary>
        /// [GLES3.2] Gl.Get: data returns a single value, the length, including the NULL terminator, of the oldest message in the
        /// debug log.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetPointer: Returns the current callback function set with the callback argument of
        /// Gl.DebugMessageCallback.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_CALLBACK_FUNCTION = 0x8244;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetPointer: Returns the user parameter to the current callback function set with the userParam
        /// argument
        /// of Gl.DebugMessageCallback.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_CALLBACK_USER_PARAM = 0x8245;

        /// <summary>
        /// [GL] Value of GL_DEBUG_SOURCE_API symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_SOURCE_API = 0x8246;

        /// <summary>
        /// [GL] Value of GL_DEBUG_SOURCE_WINDOW_SYSTEM symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247;

        /// <summary>
        /// [GL] Value of GL_DEBUG_SOURCE_SHADER_COMPILER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_SOURCE_SHADER_COMPILER = 0x8248;

        /// <summary>
        /// [GL] Value of GL_DEBUG_SOURCE_THIRD_PARTY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_SOURCE_THIRD_PARTY = 0x8249;

        /// <summary>
        /// [GL] Value of GL_DEBUG_SOURCE_APPLICATION symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_SOURCE_APPLICATION = 0x824A;

        /// <summary>
        /// [GL] Value of GL_DEBUG_SOURCE_OTHER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_SOURCE_OTHER = 0x824B;

        /// <summary>
        /// [GL] Value of GL_DEBUG_TYPE_ERROR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_TYPE_ERROR = 0x824C;

        /// <summary>
        /// [GL] Value of GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;

        /// <summary>
        /// [GL] Value of GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E;

        /// <summary>
        /// [GL] Value of GL_DEBUG_TYPE_PORTABILITY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_TYPE_PORTABILITY = 0x824F;

        /// <summary>
        /// [GL] Value of GL_DEBUG_TYPE_PERFORMANCE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_TYPE_PERFORMANCE = 0x8250;

        /// <summary>
        /// [GL] Value of GL_DEBUG_TYPE_OTHER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_TYPE_OTHER = 0x8251;

        /// <summary>
        /// [GLES3.2] Gl.Get: data returns a single value, the maximum length of a debug message string, including its null
        /// terminator.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_AMD_debug_output")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int MAX_DEBUG_MESSAGE_LENGTH = 0x9143;

        /// <summary>
        /// [GLES3.2] Gl.Get: data returns a single value, the maximum number of messages stored in the debug message log.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_AMD_debug_output")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int MAX_DEBUG_LOGGED_MESSAGES = 0x9144;

        /// <summary>
        /// [GLES3.2] Gl.Get: data returns a single value, the number of messages currently in the debug log.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_AMD_debug_output")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_LOGGED_MESSAGES = 0x9145;

        /// <summary>
        /// [GL] Value of GL_DEBUG_SEVERITY_HIGH symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_AMD_debug_output")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_SEVERITY_HIGH = 0x9146;

        /// <summary>
        /// [GL] Value of GL_DEBUG_SEVERITY_MEDIUM symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_AMD_debug_output")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_SEVERITY_MEDIUM = 0x9147;

        /// <summary>
        /// [GL] Value of GL_DEBUG_SEVERITY_LOW symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RequiredByFeature("GL_AMD_debug_output")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        public const int DEBUG_SEVERITY_LOW = 0x9148;

        /// <summary>
        /// [GL] Value of GL_DEBUG_TYPE_MARKER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")] [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        public const int DEBUG_TYPE_MARKER = 0x8268;

        /// <summary>
        /// [GL] Value of GL_DEBUG_TYPE_PUSH_GROUP symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")] [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        public const int DEBUG_TYPE_PUSH_GROUP = 0x8269;

        /// <summary>
        /// [GL] Value of GL_DEBUG_TYPE_POP_GROUP symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")] [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        public const int DEBUG_TYPE_POP_GROUP = 0x826A;

        /// <summary>
        /// [GL] Value of GL_DEBUG_SEVERITY_NOTIFICATION symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")] [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        public const int DEBUG_SEVERITY_NOTIFICATION = 0x826B;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single value, the maximum depth of the debug message group stack.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")] [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        public const int MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single value, the current depth of the debug message group stack.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")] [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        public const int DEBUG_GROUP_STACK_DEPTH = 0x826D;

        /// <summary>
        /// [GL] Value of GL_BUFFER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")] [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        public const int BUFFER = 0x82E0;

        /// <summary>
        /// [GL] Value of GL_SHADER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")] [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        public const int SHADER = 0x82E1;

        /// <summary>
        /// [GL] Value of GL_PROGRAM symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")] [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        public const int PROGRAM = 0x82E2;

        /// <summary>
        /// [GL] Value of GL_QUERY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")] [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        public const int QUERY = 0x82E3;

        /// <summary>
        /// [GL] Value of GL_PROGRAM_PIPELINE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")] [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        public const int PROGRAM_PIPELINE = 0x82E4;

        /// <summary>
        /// [GL] Value of GL_SAMPLER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_debug_label", Api = "gl|glcore|gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        public const int SAMPLER = 0x82E6;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the maximum length of a label that may be assigned to an object. See
        ///     Gl.ObjectLabel and Gl.ObjectPtrLabel.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns a single value, the maximum length of a label string.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")] [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        public const int MAX_LABEL_LENGTH = 0x82E8;

        /// <summary>
        /// [GL] Value of GL_DEBUG_OUTPUT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")] [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        public const int DEBUG_OUTPUT = 0x92E0;

        /// <summary>
        /// [GL] Value of GL_CONTEXT_FLAG_DEBUG_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")] [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        public const uint CONTEXT_FLAG_DEBUG_BIT = 0x00000002;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of explicitly assignable uniform locations, which must
        /// be at least 1024.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_explicit_uniform_location", Api = "gl|glcore")]
        public const int MAX_UNIFORM_LOCATIONS = 0x826E;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.FramebufferParameter: param specifies the assumed with for a framebuffer object with no attachments. If a
        ///     framebuffer has attachments then the width of those attachments is used, otherwise the value of
        ///     Gl.FRAMEBUFFER_DEFAULT_WIDTH is used for the framebuffer. param must be greater than or equal to zero and less than
        ///     or
        ///     equal to the value of Gl.MAX_FRAMEBUFFER_WIDTH.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetFramebufferParameter: params returns the value of Gl.FRAMEBUFFER_DEFAULT_WIDTH for the framebuffer
        ///     object.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.FramebufferParameter: param specifies the assumed with for a framebuffer object with no attachments.
        ///     If a
        ///     framebuffer has attachments then the width of those attachments is used, otherwise the value of
        ///     Gl.FRAMEBUFFER_DEFAULT_WIDTH is used for the framebuffer. param must be greater than or equal to zero and less than
        ///     or
        ///     equal to the value of Gl.MAX_FRAMEBUFFER_WIDTH.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetFramebufferParameter: The value of Gl.FRAMEBUFFER_DEFAULT_WIDTH for the framebuffer is written to
        ///     the
        ///     single integer variable whose address is given by params.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
        public const int FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.FramebufferParameter: param specifies the assumed height for a framebuffer object with no attachments. If
        ///     a
        ///     framebuffer has attachments then the height of those attachments is used, otherwise the value of
        ///     Gl.FRAMEBUFFER_DEFAULT_HEIGHT is used for the framebuffer. param must be greater than or equal to zero and less
        ///     than or
        ///     equal to the value of Gl.MAX_FRAMEBUFFER_HEIGHT.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetFramebufferParameter: params returns the value of Gl.FRAMEBUFFER_DEFAULT_HEIGHT for the framebuffer
        ///     object.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.FramebufferParameter: param specifies the assumed height for a framebuffer object with no attachments.
        ///     If a
        ///     framebuffer has attachments then the height of those attachments is used, otherwise the value of
        ///     Gl.FRAMEBUFFER_DEFAULT_HEIGHT is used for the framebuffer. param must be greater than or equal to zero and less
        ///     than or
        ///     equal to the value of Gl.MAX_FRAMEBUFFER_HEIGHT.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetFramebufferParameter: The value of Gl.FRAMEBUFFER_DEFAULT_HEIGHT for the framebuffer is written to
        ///     the
        ///     single integer variable whose address is given by params.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
        public const int FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.FramebufferParameter: param specifies the assumed number of layers for a framebuffer object with no
        ///     attachments. If a framebuffer has attachments then the layer count of those attachments is used, otherwise the
        ///     value of
        ///     Gl.FRAMEBUFFER_DEFAULT_LAYERS is used for the framebuffer. param must be greater than or equal to zero and less
        ///     than or
        ///     equal to the value of Gl.MAX_FRAMEBUFFER_LAYERS.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetFramebufferParameter: params returns the value of Gl.FRAMEBUFFER_DEFAULT_LAYERS for the framebuffer
        ///     object.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.FramebufferParameter: param specifies the assumed number of layers for a framebuffer object with no
        ///     attachments. If a framebuffer has attachments then the layer count of those attachments is used, otherwise the
        ///     value of
        ///     Gl.FRAMEBUFFER_DEFAULT_LAYERS is used for the framebuffer. param must be greater than or equal to zero and less
        ///     than or
        ///     equal to the value of Gl.MAX_FRAMEBUFFER_LAYERS.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetFramebufferParameter: params returns the value of Gl.FRAMEBUFFER_DEFAULT_LAYERS for the
        ///     framebuffer.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.FramebufferParameter: param specifies the assumed number of samples in a framebuffer object with no
        ///     attachments. If a framebuffer has attachments then the sample count of those attachments is used, otherwise the
        ///     value of
        ///     Gl.FRAMEBUFFER_DEFAULT_SAMPLES is used for the framebuffer. param must be greater than or equal to zero and less
        ///     than or
        ///     equal to the value of Gl.MAX_FRAMEBUFFER_SAMPLE.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetFramebufferParameter: params returns the value of Gl.FRAMEBUFFER_DEFAULT_SAMPLES for the framebuffer
        ///     object.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.FramebufferParameter: param specifies the assumed number of samples in a framebuffer object with no
        ///     attachments. If a framebuffer has attachments then the sample count of those attachments is used, otherwise the
        ///     value of
        ///     Gl.FRAMEBUFFER_DEFAULT_SAMPLES is used for the framebuffer. param must be greater than or equal to zero and less
        ///     than or
        ///     equal to the value of Gl.MAX_FRAMEBUFFER_SAMPLE.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetFramebufferParameter: The value of Gl.FRAMEBUFFER_DEFAULT_SAMPLES for the framebuffer is written to
        ///     the
        ///     single integer variable whose address is given by params.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
        public const int FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.FramebufferParameter: param specifies whether the framebuffer should assume identical sample locations and
        ///     the
        ///     same number of samples for all texels in the virtual image. If param is zero, then the implementation may vary the
        ///     position or the count of samples within the virtual image from pixel to pixel, otherwise it will use the same
        ///     sample
        ///     position and count for all pixels in the virtual image.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetFramebufferParameter: params returns the boolean value of
        ///     Gl.FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.FramebufferParameter: param specifies whether the framebuffer should assume identical sample locations
        ///     and
        ///     the same number of samples for all texels in the virtual image. If param is zero, then the implementation may vary
        ///     the
        ///     position or the count of samples within the virtual image from pixel to pixel, otherwise it will use the same
        ///     sample
        ///     position and count for all pixels in the virtual image.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetFramebufferParameter: If the value of Gl.FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS for the
        ///     framebuffer
        ///     is Gl.TRUE then the single integer variable whose address is in params is set to one, otherwise it is set to zero.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
        public const int FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the maximum width for a framebuffer that has no attachments, which must be at
        ///     least 16384. See glFramebufferParameter.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the maximum width for a framebuffer that has no attachments, which must
        ///     be at
        ///     least 16384. See Gl.FramebufferParameteri.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
        public const int MAX_FRAMEBUFFER_WIDTH = 0x9315;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the maximum height for a framebuffer that has no attachments, which must be
        ///     at
        ///     least 16384. See glFramebufferParameter.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the maximum height for a framebuffer that has no attachments, which must
        ///     be at
        ///     least 16384. See Gl.FramebufferParameteri.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
        public const int MAX_FRAMEBUFFER_HEIGHT = 0x9316;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the maximum number of layers for a framebuffer that has no attachments, which
        ///     must
        ///     be at least 2048. See glFramebufferParameter.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the maximum number of layers for a framebuffer that has no attachments,
        ///     which
        ///     must be at least 256. See Gl.FramebufferParameteri.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int MAX_FRAMEBUFFER_LAYERS = 0x9317;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the maximum samples in a framebuffer that has no attachments, which must be
        ///     at
        ///     least 4. See glFramebufferParameter.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the maximum samples in a framebuffer that has no attachments, which must
        ///     be at
        ///     least 4. See Gl.FramebufferParameteri.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
        public const int MAX_FRAMEBUFFER_SAMPLES = 0x9318;

        /// <summary>
        /// [GL] Value of GL_INTERNALFORMAT_SUPPORTED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int INTERNALFORMAT_SUPPORTED = 0x826F;

        /// <summary>
        /// [GL] Value of GL_INTERNALFORMAT_PREFERRED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int INTERNALFORMAT_PREFERRED = 0x8270;

        /// <summary>
        /// [GL] Value of GL_INTERNALFORMAT_RED_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int INTERNALFORMAT_RED_SIZE = 0x8271;

        /// <summary>
        /// [GL] Value of GL_INTERNALFORMAT_GREEN_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int INTERNALFORMAT_GREEN_SIZE = 0x8272;

        /// <summary>
        /// [GL] Value of GL_INTERNALFORMAT_BLUE_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int INTERNALFORMAT_BLUE_SIZE = 0x8273;

        /// <summary>
        /// [GL] Value of GL_INTERNALFORMAT_ALPHA_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int INTERNALFORMAT_ALPHA_SIZE = 0x8274;

        /// <summary>
        /// [GL] Value of GL_INTERNALFORMAT_DEPTH_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int INTERNALFORMAT_DEPTH_SIZE = 0x8275;

        /// <summary>
        /// [GL] Value of GL_INTERNALFORMAT_STENCIL_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int INTERNALFORMAT_STENCIL_SIZE = 0x8276;

        /// <summary>
        /// [GL] Value of GL_INTERNALFORMAT_SHARED_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int INTERNALFORMAT_SHARED_SIZE = 0x8277;

        /// <summary>
        /// [GL] Value of GL_INTERNALFORMAT_RED_TYPE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int INTERNALFORMAT_RED_TYPE = 0x8278;

        /// <summary>
        /// [GL] Value of GL_INTERNALFORMAT_GREEN_TYPE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int INTERNALFORMAT_GREEN_TYPE = 0x8279;

        /// <summary>
        /// [GL] Value of GL_INTERNALFORMAT_BLUE_TYPE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int INTERNALFORMAT_BLUE_TYPE = 0x827A;

        /// <summary>
        /// [GL] Value of GL_INTERNALFORMAT_ALPHA_TYPE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int INTERNALFORMAT_ALPHA_TYPE = 0x827B;

        /// <summary>
        /// [GL] Value of GL_INTERNALFORMAT_DEPTH_TYPE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int INTERNALFORMAT_DEPTH_TYPE = 0x827C;

        /// <summary>
        /// [GL] Value of GL_INTERNALFORMAT_STENCIL_TYPE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int INTERNALFORMAT_STENCIL_TYPE = 0x827D;

        /// <summary>
        /// [GL] Value of GL_MAX_WIDTH symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int MAX_WIDTH = 0x827E;

        /// <summary>
        /// [GL] Value of GL_MAX_HEIGHT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int MAX_HEIGHT = 0x827F;

        /// <summary>
        /// [GL] Value of GL_MAX_DEPTH symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int MAX_DEPTH = 0x8280;

        /// <summary>
        /// [GL] Value of GL_MAX_LAYERS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int MAX_LAYERS = 0x8281;

        /// <summary>
        /// [GL] Value of GL_MAX_COMBINED_DIMENSIONS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int MAX_COMBINED_DIMENSIONS = 0x8282;

        /// <summary>
        /// [GL] Value of GL_COLOR_COMPONENTS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int COLOR_COMPONENTS = 0x8283;

        /// <summary>
        /// [GL] Value of GL_DEPTH_COMPONENTS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int DEPTH_COMPONENTS = 0x8284;

        /// <summary>
        /// [GL] Value of GL_STENCIL_COMPONENTS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int STENCIL_COMPONENTS = 0x8285;

        /// <summary>
        /// [GL] Value of GL_COLOR_RENDERABLE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int COLOR_RENDERABLE = 0x8286;

        /// <summary>
        /// [GL] Value of GL_DEPTH_RENDERABLE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int DEPTH_RENDERABLE = 0x8287;

        /// <summary>
        /// [GL] Value of GL_STENCIL_RENDERABLE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int STENCIL_RENDERABLE = 0x8288;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_RENDERABLE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int FRAMEBUFFER_RENDERABLE = 0x8289;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_RENDERABLE_LAYERED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A;

        /// <summary>
        /// [GL] Value of GL_FRAMEBUFFER_BLEND symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int FRAMEBUFFER_BLEND = 0x828B;

        /// <summary>
        /// [GL] Value of GL_READ_PIXELS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int READ_PIXELS = 0x828C;

        /// <summary>
        /// [GL] Value of GL_READ_PIXELS_FORMAT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int READ_PIXELS_FORMAT = 0x828D;

        /// <summary>
        /// [GL] Value of GL_READ_PIXELS_TYPE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int READ_PIXELS_TYPE = 0x828E;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_IMAGE_FORMAT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int TEXTURE_IMAGE_FORMAT = 0x828F;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_IMAGE_TYPE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int TEXTURE_IMAGE_TYPE = 0x8290;

        /// <summary>
        /// [GL] Value of GL_GET_TEXTURE_IMAGE_FORMAT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int GET_TEXTURE_IMAGE_FORMAT = 0x8291;

        /// <summary>
        /// [GL] Value of GL_GET_TEXTURE_IMAGE_TYPE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int GET_TEXTURE_IMAGE_TYPE = 0x8292;

        /// <summary>
        /// [GL] Value of GL_MIPMAP symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int MIPMAP = 0x8293;

        /// <summary>
        /// [GL] Value of GL_MANUAL_GENERATE_MIPMAP symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int MANUAL_GENERATE_MIPMAP = 0x8294;

        /// <summary>
        /// [GL] Value of GL_AUTO_GENERATE_MIPMAP symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int AUTO_GENERATE_MIPMAP = 0x8295;

        /// <summary>
        /// [GL] Value of GL_COLOR_ENCODING symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int COLOR_ENCODING = 0x8296;

        /// <summary>
        /// [GL] Value of GL_SRGB_READ symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int SRGB_READ = 0x8297;

        /// <summary>
        /// [GL] Value of GL_SRGB_WRITE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int SRGB_WRITE = 0x8298;

        /// <summary>
        /// [GL] Value of GL_FILTER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int FILTER = 0x829A;

        /// <summary>
        /// [GL] Value of GL_VERTEX_TEXTURE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int VERTEX_TEXTURE = 0x829B;

        /// <summary>
        /// [GL] Value of GL_TESS_CONTROL_TEXTURE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int TESS_CONTROL_TEXTURE = 0x829C;

        /// <summary>
        /// [GL] Value of GL_TESS_EVALUATION_TEXTURE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int TESS_EVALUATION_TEXTURE = 0x829D;

        /// <summary>
        /// [GL] Value of GL_GEOMETRY_TEXTURE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int GEOMETRY_TEXTURE = 0x829E;

        /// <summary>
        /// [GL] Value of GL_FRAGMENT_TEXTURE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int FRAGMENT_TEXTURE = 0x829F;

        /// <summary>
        /// [GL] Value of GL_COMPUTE_TEXTURE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int COMPUTE_TEXTURE = 0x82A0;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_SHADOW symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int TEXTURE_SHADOW = 0x82A1;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_GATHER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int TEXTURE_GATHER = 0x82A2;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_GATHER_SHADOW symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int TEXTURE_GATHER_SHADOW = 0x82A3;

        /// <summary>
        /// [GL] Value of GL_SHADER_IMAGE_LOAD symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int SHADER_IMAGE_LOAD = 0x82A4;

        /// <summary>
        /// [GL] Value of GL_SHADER_IMAGE_STORE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int SHADER_IMAGE_STORE = 0x82A5;

        /// <summary>
        /// [GL] Value of GL_SHADER_IMAGE_ATOMIC symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int SHADER_IMAGE_ATOMIC = 0x82A6;

        /// <summary>
        /// [GL] Value of GL_IMAGE_TEXEL_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int IMAGE_TEXEL_SIZE = 0x82A7;

        /// <summary>
        /// [GL] Value of GL_IMAGE_COMPATIBILITY_CLASS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int IMAGE_COMPATIBILITY_CLASS = 0x82A8;

        /// <summary>
        /// [GL] Value of GL_IMAGE_PIXEL_FORMAT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int IMAGE_PIXEL_FORMAT = 0x82A9;

        /// <summary>
        /// [GL] Value of GL_IMAGE_PIXEL_TYPE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int IMAGE_PIXEL_TYPE = 0x82AA;

        /// <summary>
        /// [GL] Value of GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC;

        /// <summary>
        /// [GL] Value of GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD;

        /// <summary>
        /// [GL] Value of GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE;

        /// <summary>
        /// [GL] Value of GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_COMPRESSED_BLOCK_WIDTH symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_COMPRESSED_BLOCK_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3;

        /// <summary>
        /// [GL] Value of GL_CLEAR_BUFFER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int CLEAR_BUFFER = 0x82B4;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_VIEW symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int TEXTURE_VIEW = 0x82B5;

        /// <summary>
        /// [GL] Value of GL_VIEW_COMPATIBILITY_CLASS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int VIEW_COMPATIBILITY_CLASS = 0x82B6;

        /// <summary>
        /// [GL] Value of GL_FULL_SUPPORT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int FULL_SUPPORT = 0x82B7;

        /// <summary>
        /// [GL] Value of GL_CAVEAT_SUPPORT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int CAVEAT_SUPPORT = 0x82B8;

        /// <summary>
        /// [GL] Value of GL_IMAGE_CLASS_4_X_32 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int IMAGE_CLASS_4_X_32 = 0x82B9;

        /// <summary>
        /// [GL] Value of GL_IMAGE_CLASS_2_X_32 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int IMAGE_CLASS_2_X_32 = 0x82BA;

        /// <summary>
        /// [GL] Value of GL_IMAGE_CLASS_1_X_32 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int IMAGE_CLASS_1_X_32 = 0x82BB;

        /// <summary>
        /// [GL] Value of GL_IMAGE_CLASS_4_X_16 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int IMAGE_CLASS_4_X_16 = 0x82BC;

        /// <summary>
        /// [GL] Value of GL_IMAGE_CLASS_2_X_16 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int IMAGE_CLASS_2_X_16 = 0x82BD;

        /// <summary>
        /// [GL] Value of GL_IMAGE_CLASS_1_X_16 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int IMAGE_CLASS_1_X_16 = 0x82BE;

        /// <summary>
        /// [GL] Value of GL_IMAGE_CLASS_4_X_8 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int IMAGE_CLASS_4_X_8 = 0x82BF;

        /// <summary>
        /// [GL] Value of GL_IMAGE_CLASS_2_X_8 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int IMAGE_CLASS_2_X_8 = 0x82C0;

        /// <summary>
        /// [GL] Value of GL_IMAGE_CLASS_1_X_8 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int IMAGE_CLASS_1_X_8 = 0x82C1;

        /// <summary>
        /// [GL] Value of GL_IMAGE_CLASS_11_11_10 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int IMAGE_CLASS_11_11_10 = 0x82C2;

        /// <summary>
        /// [GL] Value of GL_IMAGE_CLASS_10_10_10_2 symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int IMAGE_CLASS_10_10_10_2 = 0x82C3;

        /// <summary>
        /// [GL] Value of GL_VIEW_CLASS_128_BITS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int VIEW_CLASS_128_BITS = 0x82C4;

        /// <summary>
        /// [GL] Value of GL_VIEW_CLASS_96_BITS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int VIEW_CLASS_96_BITS = 0x82C5;

        /// <summary>
        /// [GL] Value of GL_VIEW_CLASS_64_BITS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int VIEW_CLASS_64_BITS = 0x82C6;

        /// <summary>
        /// [GL] Value of GL_VIEW_CLASS_48_BITS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int VIEW_CLASS_48_BITS = 0x82C7;

        /// <summary>
        /// [GL] Value of GL_VIEW_CLASS_32_BITS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int VIEW_CLASS_32_BITS = 0x82C8;

        /// <summary>
        /// [GL] Value of GL_VIEW_CLASS_24_BITS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int VIEW_CLASS_24_BITS = 0x82C9;

        /// <summary>
        /// [GL] Value of GL_VIEW_CLASS_16_BITS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int VIEW_CLASS_16_BITS = 0x82CA;

        /// <summary>
        /// [GL] Value of GL_VIEW_CLASS_8_BITS symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int VIEW_CLASS_8_BITS = 0x82CB;

        /// <summary>
        /// [GL] Value of GL_VIEW_CLASS_S3TC_DXT1_RGB symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC;

        /// <summary>
        /// [GL] Value of GL_VIEW_CLASS_S3TC_DXT1_RGBA symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD;

        /// <summary>
        /// [GL] Value of GL_VIEW_CLASS_S3TC_DXT3_RGBA symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE;

        /// <summary>
        /// [GL] Value of GL_VIEW_CLASS_S3TC_DXT5_RGBA symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF;

        /// <summary>
        /// [GL] Value of GL_VIEW_CLASS_RGTC1_RED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int VIEW_CLASS_RGTC1_RED = 0x82D0;

        /// <summary>
        /// [GL] Value of GL_VIEW_CLASS_RGTC2_RG symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int VIEW_CLASS_RGTC2_RG = 0x82D1;

        /// <summary>
        /// [GL] Value of GL_VIEW_CLASS_BPTC_UNORM symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int VIEW_CLASS_BPTC_UNORM = 0x82D2;

        /// <summary>
        /// [GL] Value of GL_VIEW_CLASS_BPTC_FLOAT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int VIEW_CLASS_BPTC_FLOAT = 0x82D3;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetProgramInterface: The query is targeted at the set of active uniforms within program.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetProgramResourceIndex: The query is targeted at the set of active uniforms within program.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetProgramResourceName: The query is targeted at the set of active uniforms within program.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramInterface: The query is targeted at the set of active uniforms within program.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramResourceIndex: The query is targeted at the set of active uniforms within program.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramResourceName: The query is targeted at the set of active uniforms within program.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int UNIFORM = 0x92E1;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetProgramInterface: The query is targeted at the set of active uniform blocks within program.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetProgramResourceIndex: The query is targeted at the set of active uniform blocks within program.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetProgramResourceName: The query is targeted at the set of active uniform blocks within program.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramInterface: The query is targeted at the set of active uniform blocks within program.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramResourceIndex: The query is targeted at the set of active uniform blocks within program.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramResourceName: The query is targeted at the set of active uniform blocks within program.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int UNIFORM_BLOCK = 0x92E2;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetProgramInterface: The query is targeted at the set of active input variables used by the first shader
        ///     stage
        ///     of program. If program contains multiple shader stages then input variables from any stage other than the first
        ///     will not
        ///     be enumerated.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetProgramResourceIndex: The query is targeted at the set of active input variables used by the first
        ///     shader
        ///     stage of program. If program contains multiple shader stages then input variables from any stage other than the
        ///     first
        ///     will not be enumerated.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetProgramResourceName: The query is targeted at the set of active input variables used by the first
        ///     shader
        ///     stage of program. If program contains multiple shader stages then input variables from any stage other than the
        ///     first
        ///     will not be enumerated.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramInterface: The query is targeted at the set of active input variables used by the first
        ///     shader
        ///     stage of program. If program contains multiple shader stages then input variables from any stage other than the
        ///     first
        ///     will not be enumerated.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramResourceIndex: The query is targeted at the set of active input variables used by the first
        ///     shader stage of program. If program contains multiple shader stages then input variables from any stage other than
        ///     the
        ///     first will not be enumerated.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramResourceName: The query is targeted at the set of active input variables used by the first
        ///     shader
        ///     stage of program. If program contains multiple shader stages then input variables from any stage other than the
        ///     first
        ///     will not be enumerated.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int PROGRAM_INPUT = 0x92E3;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetProgramInterface: The query is targeted at the set of active output variables produced by the last
        ///     shader
        ///     stage of program. If program contains multiple shader stages then output variables from any stage other than the
        ///     last
        ///     will not be enumerated.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetProgramResourceIndex: The query is targeted at the set of active output variables produced by the last
        ///     shader stage of program. If program contains multiple shader stages then output variables from any stage other than
        ///     the
        ///     last will not be enumerated.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetProgramResourceName: The query is targeted at the set of active output variables produced by the last
        ///     shader
        ///     stage of program. If program contains multiple shader stages then output variables from any stage other than the
        ///     last
        ///     will not be enumerated.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramInterface: The query is targeted at the set of active output variables produced by the last
        ///     shader stage of program. If program contains multiple shader stages then output variables from any stage other than
        ///     the
        ///     last will not be enumerated.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramResourceIndex: The query is targeted at the set of active output variables produced by the
        ///     last
        ///     shader stage of program. If program contains multiple shader stages then output variables from any stage other than
        ///     the
        ///     last will not be enumerated.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramResourceName: The query is targeted at the set of active output variables produced by the
        ///     last
        ///     shader stage of program. If program contains multiple shader stages then output variables from any stage other than
        ///     the
        ///     last will not be enumerated.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int PROGRAM_OUTPUT = 0x92E4;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetProgramInterface: The query is targeted at the set of active buffer variables used by program.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetProgramResourceIndex: The query is targeted at the set of active buffer variables used by program.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetProgramResourceName: The query is targeted at the set of active buffer variables used by program.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramInterface: The query is targeted at the set of active buffer variables used by program.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramResourceIndex: The query is targeted at the set of active buffer variables used by program.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramResourceName: The query is targeted at the set of active buffer variables used by program.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int BUFFER_VARIABLE = 0x92E5;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetProgramInterface: The query is targeted at the set of active shader storage blocks used by program.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetProgramResourceIndex: The query is targeted at the set of active shader storage blocks used by program.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetProgramResourceName: The query is targeted at the set of active shader storage blocks used by program.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramInterface: The query is targeted at the set of active shader storage blocks used by program.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramResourceIndex: The query is targeted at the set of active shader storage blocks used by
        ///     program.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramResourceName: The query is targeted at the set of active shader storage blocks used by
        ///     program.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int SHADER_STORAGE_BLOCK = 0x92E6;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetProgramInterface: The query is targeted at the set of active subroutines for the vertex, tessellation
        ///     control, tessellation evaluation, geometry, fragment and compute shader stages of program, respectively.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetProgramResourceIndex: The query is targeted at the set of active subroutines for the vertex,
        ///     tessellation
        ///     control, tessellation evaluation, geometry, fragment and compute shader stages of program, respectively.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetProgramResourceName: The query is targeted at the set of active subroutines for the vertex,
        ///     tessellation
        ///     control, tessellation evaluation, geometry, fragment and compute shader stages of program, respectively.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int VERTEX_SUBROUTINE = 0x92E8;

        /// <summary>
        /// [GL] Value of GL_TESS_CONTROL_SUBROUTINE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int TESS_CONTROL_SUBROUTINE = 0x92E9;

        /// <summary>
        /// [GL] Value of GL_TESS_EVALUATION_SUBROUTINE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int TESS_EVALUATION_SUBROUTINE = 0x92EA;

        /// <summary>
        /// [GL] Value of GL_GEOMETRY_SUBROUTINE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int GEOMETRY_SUBROUTINE = 0x92EB;

        /// <summary>
        /// [GL] Value of GL_FRAGMENT_SUBROUTINE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int FRAGMENT_SUBROUTINE = 0x92EC;

        /// <summary>
        /// [GL] Value of GL_COMPUTE_SUBROUTINE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int COMPUTE_SUBROUTINE = 0x92ED;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetProgramInterface: The query is targeted at the set of active subroutine uniform variables used by the
        ///     vertex, tessellation control, tessellation evaluation, geometry, fragment and compute shader stages of program,
        ///     respectively.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetProgramResourceIndex: The query is targeted at the set of active subroutine uniform variables used by
        ///     the
        ///     vertex, tessellation control, tessellation evaluation, geometry, fragment and compute shader stages of program,
        ///     respectively.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetProgramResourceName: The query is targeted at the set of active subroutine uniform variables used by
        ///     the
        ///     vertex, tessellation control, tessellation evaluation, geometry, fragment and compute shader stages of program,
        ///     respectively.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int VERTEX_SUBROUTINE_UNIFORM = 0x92EE;

        /// <summary>
        /// [GL] Value of GL_TESS_CONTROL_SUBROUTINE_UNIFORM symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF;

        /// <summary>
        /// [GL] Value of GL_TESS_EVALUATION_SUBROUTINE_UNIFORM symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0;

        /// <summary>
        /// [GL] Value of GL_GEOMETRY_SUBROUTINE_UNIFORM symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1;

        /// <summary>
        /// [GL] Value of GL_FRAGMENT_SUBROUTINE_UNIFORM symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2;

        /// <summary>
        /// [GL] Value of GL_COMPUTE_SUBROUTINE_UNIFORM symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int COMPUTE_SUBROUTINE_UNIFORM = 0x92F3;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetProgramInterface: The query is targeted at the set of output variables from the last non-fragment stage
        ///     of
        ///     program that would be captured if transform feedback were active.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetProgramResourceIndex: The query is targeted at the set of output variables from the last non-fragment
        ///     stage
        ///     of program that would be captured if transform feedback were active.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetProgramResourceName: The query is targeted at the set of output variables from the last non-fragment
        ///     stage
        ///     of program that would be captured if transform feedback were active.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramInterface: The query is targeted at the set of output variables from the last non-fragment
        ///     stage
        ///     of program that would be captured if transform feedback were active.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramResourceIndex: The query is targeted at the set of output variables from the vertex stage of
        ///     program that would be captured if transform feedback were active.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetProgramResourceName: The query is targeted at the set of output variables from vertex stage of
        ///     program
        ///     that would be captured if transform feedback were active.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int TRANSFORM_FEEDBACK_VARYING = 0x92F4;

        /// <summary>
        /// [GL] Value of GL_ACTIVE_RESOURCES symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int ACTIVE_RESOURCES = 0x92F5;

        /// <summary>
        /// [GL] Value of GL_MAX_NAME_LENGTH symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int MAX_NAME_LENGTH = 0x92F6;

        /// <summary>
        /// [GL] Value of GL_MAX_NUM_ACTIVE_VARIABLES symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int MAX_NUM_ACTIVE_VARIABLES = 0x92F7;

        /// <summary>
        /// [GL] Value of GL_MAX_NUM_COMPATIBLE_SUBROUTINES symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8;

        /// <summary>
        /// [GL] Value of GL_NAME_LENGTH symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int NAME_LENGTH = 0x92F9;

        /// <summary>
        /// [GL] Value of GL_TYPE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int TYPE = 0x92FA;

        /// <summary>
        /// [GL] Value of GL_ARRAY_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int ARRAY_SIZE = 0x92FB;

        /// <summary>
        /// [GL] Value of GL_OFFSET symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int OFFSET = 0x92FC;

        /// <summary>
        /// [GL] Value of GL_BLOCK_INDEX symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int BLOCK_INDEX = 0x92FD;

        /// <summary>
        /// [GL] Value of GL_ARRAY_STRIDE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int ARRAY_STRIDE = 0x92FE;

        /// <summary>
        /// [GL] Value of GL_MATRIX_STRIDE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int MATRIX_STRIDE = 0x92FF;

        /// <summary>
        /// [GL] Value of GL_IS_ROW_MAJOR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int IS_ROW_MAJOR = 0x9300;

        /// <summary>
        /// [GL] Value of GL_ATOMIC_COUNTER_BUFFER_INDEX symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;

        /// <summary>
        /// [GL] Value of GL_BUFFER_BINDING symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int BUFFER_BINDING = 0x9302;

        /// <summary>
        /// [GL] Value of GL_BUFFER_DATA_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int BUFFER_DATA_SIZE = 0x9303;

        /// <summary>
        /// [GL] Value of GL_NUM_ACTIVE_VARIABLES symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int NUM_ACTIVE_VARIABLES = 0x9304;

        /// <summary>
        /// [GL] Value of GL_ACTIVE_VARIABLES symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int ACTIVE_VARIABLES = 0x9305;

        /// <summary>
        /// [GL] Value of GL_REFERENCED_BY_VERTEX_SHADER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int REFERENCED_BY_VERTEX_SHADER = 0x9306;

        /// <summary>
        /// [GL] Value of GL_REFERENCED_BY_TESS_CONTROL_SHADER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
        public const int REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;

        /// <summary>
        /// [GL] Value of GL_REFERENCED_BY_TESS_EVALUATION_SHADER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
        public const int REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;

        /// <summary>
        /// [GL] Value of GL_REFERENCED_BY_GEOMETRY_SHADER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int REFERENCED_BY_GEOMETRY_SHADER = 0x9309;

        /// <summary>
        /// [GL] Value of GL_REFERENCED_BY_FRAGMENT_SHADER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int REFERENCED_BY_FRAGMENT_SHADER = 0x930A;

        /// <summary>
        /// [GL] Value of GL_REFERENCED_BY_COMPUTE_SHADER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int REFERENCED_BY_COMPUTE_SHADER = 0x930B;

        /// <summary>
        /// [GL] Value of GL_TOP_LEVEL_ARRAY_SIZE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int TOP_LEVEL_ARRAY_SIZE = 0x930C;

        /// <summary>
        /// [GL] Value of GL_TOP_LEVEL_ARRAY_STRIDE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int TOP_LEVEL_ARRAY_STRIDE = 0x930D;

        /// <summary>
        /// [GL] Value of GL_LOCATION symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public const int LOCATION = 0x930E;

        /// <summary>
        /// [GL] Value of GL_LOCATION_INDEX symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
        public const int LOCATION_INDEX = 0x930F;

        /// <summary>
        /// [GL] Value of GL_IS_PER_PATCH symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
        public const int IS_PER_PATCH = 0x92E7;

        /// <summary>
        /// [GL] Value of GL_SHADER_STORAGE_BUFFER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
        public const int SHADER_STORAGE_BUFFER = 0x90D2;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: When used with non-indexed variants of glGet (such as glGetIntegerv), data returns a single
        /// value,
        /// the name of the buffer object currently bound to the target Gl.SHADER_STORAGE_BUFFER. If no buffer object is bound to
        /// this target, 0 is returned. When used with indexed variants of glGet (such as glGetIntegeri_v), data returns a single
        /// value, the name of the buffer object bound to the indexed shader storage buffer binding points. The initial value is 0
        /// for all targets. See Gl.BindBuffer, Gl.BindBufferBase, and Gl.BindBufferRange.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
        public const int SHADER_STORAGE_BUFFER_BINDING = 0x90D3;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: When used with indexed variants of glGet (such as glGetInteger64i_v), data returns a single
        /// value,
        /// the start offset of the binding range for each indexed shader storage buffer binding. The initial value is 0 for all
        /// bindings. See Gl.BindBufferRange.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
        public const int SHADER_STORAGE_BUFFER_START = 0x90D4;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: When used with indexed variants of glGet (such as glGetInteger64i_v), data returns a single
        /// value,
        /// the size of the binding range for each indexed shader storage buffer binding. The initial value is 0 for all bindings.
        /// See Gl.BindBufferRange.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
        public const int SHADER_STORAGE_BUFFER_SIZE = 0x90D5;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed
        /// by
        /// a vertex shader.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
        public const int MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed
        /// by
        /// a geometry shader.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
        public const int MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed
        /// by
        /// a tessellation control shader.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
        public const int MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed
        /// by
        /// a tessellation evaluation shader.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
        public const int MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed by a
        ///     fragment shader.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed
        ///     by a
        ///     fragment shader. In GL ES 3.1, the minimum value is 0. in GL ES 3.2, the minimum value is 4.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
        public const int MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed
        /// by
        /// a compute shader.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
        public const int MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum total number of active shader storage blocks that may be
        /// accessed by all active shaders.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
        public const int MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of shader storage buffer binding points on the
        /// context,
        /// which must be at least 8.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
        public const int MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;

        /// <summary>
        /// [GLES3.2] Gl.Get: data returns one value, the maximum size in basic machine units of a shader storage block. The value
        /// must be at least 227.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
        public const int MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns a single value, the minimum required alignment for shader storage buffer sizes and
        ///     offset.
        ///     The initial value is 1. See Gl.ShaderStorageBlockBinding.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns a single value, the minimum required alignment for shader storage buffer sizes and
        ///     offset. The initial value is 1. See Gl.ShaderStorateBlockBinding.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
        public const int SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;

        /// <summary>
        /// [GL] Value of GL_SHADER_STORAGE_BARRIER_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
        public const uint SHADER_STORAGE_BARRIER_BIT = 0x00002000;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetTexParameter: Returns the single-value depth stencil texture mode, a symbolic constant. The initial
        /// value is Gl.DEPTH_COMPONENT.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_stencil_texturing", Api = "gl|glcore")]
        public const int DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetTexLevelParameter: params returns a single integer value, the offset into the data store of the buffer
        ///     bound
        ///     to a buffer texture. Gl.TexBufferRange.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetTexLevelParameter: params returns a single integer value, the offset into the data store of the
        ///     buffer
        ///     bound to a buffer texture. See Gl.TexBufferRange
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_buffer_range", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_buffer", Api = "gles2")]
        public const int TEXTURE_BUFFER_OFFSET = 0x919D;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetTexLevelParameter: params returns a single integer value, the size of the range of a data store of the
        ///     buffer bound to a buffer texture. Gl.TexBufferRange.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetTexLevelParameter: params returns a single integer value, the size of the range of a data store of
        ///     the
        ///     buffer bound to a buffer texture. See Gl.TexBufferRange
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_buffer_range", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_buffer", Api = "gles2")]
        public const int TEXTURE_BUFFER_SIZE = 0x919E;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single value, the minimum required alignment for texture buffer sizes and offset.
        /// The initial value is 1. See Gl.UniformBlockBinding.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_buffer_range", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_buffer", Api = "gles2")]
        public const int TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;

        /// <summary>
        /// [GL4] Gl.GetTexParameter: Returns a single-valued base level of a texture view relative to its parent. The initial
        /// value
        /// is 0. See Gl.TextureView.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ARB_texture_view", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_view", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_view", Api = "gles2")]
        public const int TEXTURE_VIEW_MIN_LEVEL = 0x82DB;

        /// <summary>
        /// [GL4] Gl.GetTexParameter: Returns a single-valued number of levels of detail of a texture view. See Gl.TextureView.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ARB_texture_view", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_view", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_view", Api = "gles2")]
        public const int TEXTURE_VIEW_NUM_LEVELS = 0x82DC;

        /// <summary>
        /// [GL4] Gl.GetTexParameter: Returns a single-valued first level of a texture array view relative to its parent. See
        /// Gl.TextureView.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ARB_texture_view", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_view", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_view", Api = "gles2")]
        public const int TEXTURE_VIEW_MIN_LAYER = 0x82DD;

        /// <summary>
        /// [GL4] Gl.GetTexParameter: Returns a single-valued number of layers in a texture array view. See Gl.TextureView.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ARB_texture_view", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_view", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_view", Api = "gles2")]
        public const int TEXTURE_VIEW_NUM_LAYERS = 0x82DE;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetTexParameter: Returns a single-valued number of immutable texture levels in a texture view. See
        ///     Gl.TextureView.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetTexParameter: Returns a single-valued number of texture levels in an immutable texture. See
        ///     Gl.TexStorage2D.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_view", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_view", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_view", Api = "gles2")]
        public const int TEXTURE_IMMUTABLE_LEVELS = 0x82DF;

        /// <summary>
        /// [GLES3.2] Gl.GetVertexAttrib: params returns a single value that is the current vertex buffer binding of the vertex
        /// attribute. See Gl.VertexAttribBinding.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
        public const int VERTEX_ATTRIB_BINDING = 0x82D4;

        /// <summary>
        /// [GL] Value of GL_VERTEX_ATTRIB_RELATIVE_OFFSET symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
        public const int VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: Accepted by the indexed forms. data returns a single integer value representing the instance step
        /// divisor of the first element in the bound buffer's data store for vertex attribute bound to index.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
        public const int VERTEX_BINDING_DIVISOR = 0x82D6;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: Accepted by the indexed forms. data returns a single integer value representing the byte offset
        /// of
        /// the first element in the bound buffer's data store for vertex attribute bound to index.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
        public const int VERTEX_BINDING_OFFSET = 0x82D7;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: Accepted by the indexed forms. data returns a single integer value representing the byte offset
        /// between the start of each element in the bound buffer's data store for vertex attribute bound to index.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
        public const int VERTEX_BINDING_STRIDE = 0x82D8;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single integer value containing the maximum offset that may be added to a vertex
        /// binding offset.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
        public const int MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single integer value containing the maximum number of vertex buffers that may be
        /// bound.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
        public const int MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;

        /// <summary>
        /// [GL] Value of GL_VERTEX_BINDING_BUFFER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        public const int VERTEX_BINDING_BUFFER = 0x8F4F;

        /// <summary>
        /// [GL] Value of GL_DISPLAY_LIST symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        public const int DISPLAY_LIST = 0x82E7;

        /// <summary>
        /// [GL4] glClearBufferData: fill a buffer object's data store with a fixed value
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound for Gl.ClearBufferData, which must must be one of the buffer
        /// binding targets in the following table:
        /// </param>
        /// <param name="internalformat">
        /// The internal format with which the data will be stored in the buffer object.
        /// </param>
        /// <param name="format">
        /// The format of the data in memory addressed by <paramref name="data" />.
        /// </param>
        /// <param name="type">
        /// The type of the data in memory addressed by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// The address of a memory location storing the data to be replicated into the buffer's data store.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ARB_clear_buffer_object", Api = "gl|glcore")]
        public static void ClearBufferData(BufferTarget target, InternalFormat internalformat, PixelFormat format, PixelType type, IntPtr data)
        {
            Assert(Delegates.pglClearBufferData != null, "pglClearBufferData not implemented");
            Delegates.pglClearBufferData((int) target, (int) internalformat, (int) format, (int) type, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glClearBufferData: fill a buffer object's data store with a fixed value
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound for Gl.ClearBufferData, which must must be one of the buffer
        /// binding targets in the following table:
        /// </param>
        /// <param name="internalformat">
        /// The internal format with which the data will be stored in the buffer object.
        /// </param>
        /// <param name="format">
        /// The format of the data in memory addressed by <paramref name="data" />.
        /// </param>
        /// <param name="type">
        /// The type of the data in memory addressed by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// The address of a memory location storing the data to be replicated into the buffer's data store.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ARB_clear_buffer_object", Api = "gl|glcore")]
        public static void ClearBufferData(BufferTarget target, InternalFormat internalformat, PixelFormat format, PixelType type, object data)
        {
            GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                ClearBufferData(target, internalformat, format, type, pin_data.AddrOfPinnedObject());
            }
            finally
            {
                pin_data.Free();
            }
        }

        /// <summary>
        /// [GL4] glClearBufferSubData: fill all or part of buffer object's data store with a fixed value
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound for Gl.ClearBufferSubData, which must be one of the buffer
        /// binding targets in the following table:
        /// </param>
        /// <param name="internalformat">
        /// The internal format with which the data will be stored in the buffer object.
        /// </param>
        /// <param name="offset">
        /// The offset in basic machine units into the buffer object's data store at which to start filling.
        /// </param>
        /// <param name="size">
        /// The size in basic machine units of the range of the data store to fill.
        /// </param>
        /// <param name="format">
        /// The format of the data in memory addressed by <paramref name="data" />.
        /// </param>
        /// <param name="type">
        /// The type of the data in memory addressed by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// The address of a memory location storing the data to be replicated into the buffer's data store.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ARB_clear_buffer_object", Api = "gl|glcore")]
        public static void ClearBufferSubData(int target, InternalFormat internalformat, IntPtr offset, uint size, PixelFormat format, PixelType type, IntPtr data)
        {
            Assert(Delegates.pglClearBufferSubData != null, "pglClearBufferSubData not implemented");
            Delegates.pglClearBufferSubData(target, (int) internalformat, offset, size, (int) format, (int) type, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glClearBufferSubData: fill all or part of buffer object's data store with a fixed value
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound for Gl.ClearBufferSubData, which must be one of the buffer
        /// binding targets in the following table:
        /// </param>
        /// <param name="internalformat">
        /// The internal format with which the data will be stored in the buffer object.
        /// </param>
        /// <param name="offset">
        /// The offset in basic machine units into the buffer object's data store at which to start filling.
        /// </param>
        /// <param name="size">
        /// The size in basic machine units of the range of the data store to fill.
        /// </param>
        /// <param name="format">
        /// The format of the data in memory addressed by <paramref name="data" />.
        /// </param>
        /// <param name="type">
        /// The type of the data in memory addressed by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// The address of a memory location storing the data to be replicated into the buffer's data store.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ARB_clear_buffer_object", Api = "gl|glcore")]
        public static void ClearBufferSubData(int target, InternalFormat internalformat, IntPtr offset, uint size, PixelFormat format, PixelType type, object data)
        {
            GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                ClearBufferSubData(target, internalformat, offset, size, format, type, pin_data.AddrOfPinnedObject());
            }
            finally
            {
                pin_data.Free();
            }
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDispatchCompute: launch one or more compute work groups
        ///     </para>
        /// </summary>
        /// <param name="num_groups_x">
        /// The number of work groups to be launched in the X dimension.
        /// </param>
        /// <param name="num_groups_y">
        /// The number of work groups to be launched in the Y dimension.
        /// </param>
        /// <param name="num_groups_z">
        /// The number of work groups to be launched in the Z dimension.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public static void DispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z)
        {
            Assert(Delegates.pglDispatchCompute != null, "pglDispatchCompute not implemented");
            Delegates.pglDispatchCompute(num_groups_x, num_groups_y, num_groups_z);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDispatchComputeIndirect: launch one or more compute work groups using parameters stored in a buffer
        ///     </para>
        /// </summary>
        /// <param name="indirect">
        /// The offset into the buffer object currently bound to the Gl.DISPATCH_INDIRECT_BUFFER buffer target at which the
        /// dispatch
        /// parameters are stored.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
        public static void DispatchComputeIndirect(IntPtr indirect)
        {
            Assert(Delegates.pglDispatchComputeIndirect != null, "pglDispatchComputeIndirect not implemented");
            Delegates.pglDispatchComputeIndirect(indirect);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glCopyImageSubData: perform a raw data copy between two images
        ///     </para>
        /// </summary>
        /// <param name="srcName">
        /// The name of a texture or renderbuffer object from which to copy.
        /// </param>
        /// <param name="srcTarget">
        /// The target representing the namespace of the source name <paramref name="srcName" />.
        /// </param>
        /// <param name="srcLevel">
        /// The mipmap level to read from the source.
        /// </param>
        /// <param name="srcX">
        /// The X coordinate of the left edge of the souce region to copy.
        /// </param>
        /// <param name="srcY">
        /// The Y coordinate of the top edge of the souce region to copy.
        /// </param>
        /// <param name="srcZ">
        /// The Z coordinate of the near edge of the souce region to copy.
        /// </param>
        /// <param name="dstName">
        /// The name of a texture or renderbuffer object to which to copy.
        /// </param>
        /// <param name="dstTarget">
        /// The target representing the namespace of the destination name <paramref name="dstName" />.
        /// </param>
        /// <param name="dstLevel">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="dstX">
        /// The X coordinate of the left edge of the destination region.
        /// </param>
        /// <param name="dstY">
        /// The Y coordinate of the top edge of the destination region.
        /// </param>
        /// <param name="dstZ">
        /// The Z coordinate of the near edge of the destination region.
        /// </param>
        /// <param name="srcWidth">
        /// The width of the region to be copied.
        /// </param>
        /// <param name="srcHeight">
        /// The height of the region to be copied.
        /// </param>
        /// <param name="srcDepth">
        /// The depth of the region to be copied.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_copy_image", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_copy_image", Api = "gles2")]
        [RequiredByFeature("GL_OES_copy_image", Api = "gles2")]
        public static void CopyImageSubData(uint srcName, BufferTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, BufferTarget dstTarget, int dstLevel, int dstX, int dstY,
            int dstZ, int srcWidth, int srcHeight, int srcDepth)
        {
            Assert(Delegates.pglCopyImageSubData != null, "pglCopyImageSubData not implemented");
            Delegates.pglCopyImageSubData(srcName, (int) srcTarget, srcLevel, srcX, srcY, srcZ, dstName, (int) dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glFramebufferParameteri: set a named parameter of a framebuffer object
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glFramebufferParameteri: set a named parameter of a framebuffer
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the framebuffer is bound for Gl.FramebufferParameteri.
        /// </param>
        /// <param name="pname">
        /// Specifies the framebuffer parameter to be modified.
        /// </param>
        /// <param name="param">
        /// The new value for the parameter named <paramref name="pname" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
        public static void FramebufferParameter(FramebufferTarget target, FramebufferParameterName pname, int param)
        {
            Assert(Delegates.pglFramebufferParameteri != null, "pglFramebufferParameteri not implemented");
            Delegates.pglFramebufferParameteri((int) target, (int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glGetFramebufferParameteriv: query a named parameter of a framebuffer object
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glGetFramebufferParameteriv: retrieve a named parameter from a framebuffer
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the framebuffer object is bound for Gl.GetFramebufferParameteriv.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of the framebuffer object to query.
        /// </param>
        /// <param name="params">
        /// Returns the value of parameter <paramref name="pname" /> for the framebuffer object.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
        public static void GetFramebufferParameter(FramebufferTarget target, FramebufferAttachmentParameterName pname, [Out] int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Assert(Delegates.pglGetFramebufferParameteriv != null, "pglGetFramebufferParameteriv not implemented");
                    Delegates.pglGetFramebufferParameteriv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glGetFramebufferParameteriv: query a named parameter of a framebuffer object
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glGetFramebufferParameteriv: retrieve a named parameter from a framebuffer
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the framebuffer object is bound for Gl.GetFramebufferParameteriv.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of the framebuffer object to query.
        /// </param>
        /// <param name="params">
        /// Returns the value of parameter <paramref name="pname" /> for the framebuffer object.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
        public static void GetFramebufferParameter(FramebufferTarget target, FramebufferAttachmentParameterName pname, out int @params)
        {
            unsafe
            {
                fixed (int* p_params = &@params)
                {
                    Assert(Delegates.pglGetFramebufferParameteriv != null, "pglGetFramebufferParameteriv not implemented");
                    Delegates.pglGetFramebufferParameteriv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glGetFramebufferParameteriv: query a named parameter of a framebuffer object
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glGetFramebufferParameteriv: retrieve a named parameter from a framebuffer
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the framebuffer object is bound for Gl.GetFramebufferParameteriv.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of the framebuffer object to query.
        /// </param>
        /// <param name="params">
        /// Returns the value of parameter <paramref name="pname" /> for the framebuffer object.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
        public static unsafe void GetFramebufferParameter(FramebufferTarget target, FramebufferAttachmentParameterName pname, [Out] int* @params)
        {
            Assert(Delegates.pglGetFramebufferParameteriv != null, "pglGetFramebufferParameteriv not implemented");
            Delegates.pglGetFramebufferParameteriv((int) target, (int) pname, @params);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glGetFramebufferParameteriv: query a named parameter of a framebuffer object
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glGetFramebufferParameteriv: retrieve a named parameter from a framebuffer
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the framebuffer object is bound for Gl.GetFramebufferParameteriv.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of the framebuffer object to query.
        /// </param>
        /// <param name="params">
        /// Returns the value of parameter <paramref name="pname" /> for the framebuffer object.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
        public static void GetFramebufferParameteri<T>(FramebufferTarget target, FramebufferAttachmentParameterName pname, out T @params) where T : struct
        {
            Assert(Delegates.pglGetFramebufferParameteriv != null, "pglGetFramebufferParameteriv not implemented");
            @params = default;
            unsafe
            {
                TypedReference refParams = __makeref(@params);
                IntPtr refParamsPtr = *(IntPtr*) (&refParams);

                Delegates.pglGetFramebufferParameteriv((int) target, (int) pname, (int*) refParamsPtr.ToPointer());
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetInternalformati64v: retrieve information about implementation-dependent support for internal formats
        /// </summary>
        /// <param name="target">
        /// Indicates the usage of the internal format. <paramref name="target" /> must be Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY,
        /// Gl.TEXTURE_2D, Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP, Gl.TEXTURE_CUBE_MAP_ARRAY,
        /// Gl.TEXTURE_RECTANGLE,
        /// Gl.TEXTURE_BUFFER, Gl.RENDERBUFFER, Gl.TEXTURE_2D_MULTISAMPLE or Gl.TEXTURE_2D_MULTISAMPLE_ARRAY.
        /// </param>
        /// <param name="internalformat">
        /// Specifies the internal format about which to retrieve information.
        /// </param>
        /// <param name="pname">
        /// Specifies the type of information to query.
        /// </param>
        /// <param name="bufSize">
        /// Specifies the maximum number of integers of the specified width that may be written to <paramref name="params" /> by
        /// the
        /// function.
        /// </param>
        /// <param name="params">
        /// Specifies the address of a variable into which to write the retrieved information.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public static void GetInternalformat(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int bufSize, [Out] long[] @params)
        {
            unsafe
            {
                fixed (long* p_params = @params)
                {
                    Assert(Delegates.pglGetInternalformati64v != null, "pglGetInternalformati64v not implemented");
                    Delegates.pglGetInternalformati64v((int) target, (int) internalformat, (int) pname, bufSize, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetInternalformati64v: retrieve information about implementation-dependent support for internal formats
        /// </summary>
        /// <param name="target">
        /// Indicates the usage of the internal format. <paramref name="target" /> must be Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY,
        /// Gl.TEXTURE_2D, Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP, Gl.TEXTURE_CUBE_MAP_ARRAY,
        /// Gl.TEXTURE_RECTANGLE,
        /// Gl.TEXTURE_BUFFER, Gl.RENDERBUFFER, Gl.TEXTURE_2D_MULTISAMPLE or Gl.TEXTURE_2D_MULTISAMPLE_ARRAY.
        /// </param>
        /// <param name="internalformat">
        /// Specifies the internal format about which to retrieve information.
        /// </param>
        /// <param name="pname">
        /// Specifies the type of information to query.
        /// </param>
        /// <param name="params">
        /// Specifies the address of a variable into which to write the retrieved information.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public static void GetInternalformat(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, [Out] long[] @params)
        {
            unsafe
            {
                fixed (long* p_params = @params)
                {
                    Assert(Delegates.pglGetInternalformati64v != null, "pglGetInternalformati64v not implemented");
                    Delegates.pglGetInternalformati64v((int) target, (int) internalformat, (int) pname, @params.Length, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glInvalidateTexSubImage: invalidate a region of a texture image
        /// </summary>
        /// <param name="texture">
        /// The name of a texture object a subregion of which to invalidate.
        /// </param>
        /// <param name="level">
        /// The level of detail of the texture object within which the region resides.
        /// </param>
        /// <param name="xoffset">
        /// The X offset of the region to be invalidated.
        /// </param>
        /// <param name="yoffset">
        /// The Y offset of the region to be invalidated.
        /// </param>
        /// <param name="zoffset">
        /// The Z offset of the region to be invalidated.
        /// </param>
        /// <param name="width">
        /// The width of the region to be invalidated.
        /// </param>
        /// <param name="height">
        /// The height of the region to be invalidated.
        /// </param>
        /// <param name="depth">
        /// The depth of the region to be invalidated.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")]
        public static void InvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth)
        {
            Assert(Delegates.pglInvalidateTexSubImage != null, "pglInvalidateTexSubImage not implemented");
            Delegates.pglInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glInvalidateTexImage: invalidate the entirety a texture image
        /// </summary>
        /// <param name="texture">
        /// The name of a texture object to invalidate.
        /// </param>
        /// <param name="level">
        /// The level of detail of the texture object to invalidate.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")]
        public static void InvalidateTexImage(uint texture, int level)
        {
            Assert(Delegates.pglInvalidateTexImage != null, "pglInvalidateTexImage not implemented");
            Delegates.pglInvalidateTexImage(texture, level);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glInvalidateBufferSubData: invalidate a region of a buffer object's data store
        /// </summary>
        /// <param name="buffer">
        /// The name of a buffer object, a subrange of whose data store to invalidate.
        /// </param>
        /// <param name="offset">
        /// The offset within the buffer's data store of the start of the range to be invalidated.
        /// </param>
        /// <param name="length">
        /// The length of the range within the buffer's data store to be invalidated.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")]
        public static void InvalidateBufferSubData(uint buffer, IntPtr offset, uint length)
        {
            Assert(Delegates.pglInvalidateBufferSubData != null, "pglInvalidateBufferSubData not implemented");
            Delegates.pglInvalidateBufferSubData(buffer, offset, length);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glInvalidateBufferData: invalidate the content of a buffer object's data store
        /// </summary>
        /// <param name="buffer">
        /// The name of a buffer object whose data store to invalidate.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")]
        public static void InvalidateBufferData(uint buffer)
        {
            Assert(Delegates.pglInvalidateBufferData != null, "pglInvalidateBufferData not implemented");
            Delegates.pglInvalidateBufferData(buffer);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glInvalidateFramebuffer: invalidate the content of some or all of a framebuffer's attachments
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glInvalidateFramebuffer: Invalidate the contents of attachments within a framebuffer
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the framebuffer object is attached for Gl.InvalidateFramebuffer.
        /// </param>
        /// <param name="numAttachments">
        /// Specifies the number of entries in the <paramref name="attachments" /> array.
        /// </param>
        /// <param name="attachments">
        /// Specifies a pointer to an array identifying the attachments to be invalidated.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")]
        public static void InvalidateFramebuffer(FramebufferTarget target, int numAttachments, params int[] attachments)
        {
            unsafe
            {
                fixed (int* p_attachments = attachments)
                {
                    Assert(Delegates.pglInvalidateFramebuffer != null, "pglInvalidateFramebuffer not implemented");
                    Delegates.pglInvalidateFramebuffer((int) target, numAttachments, p_attachments);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glInvalidateFramebuffer: invalidate the content of some or all of a framebuffer's attachments
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glInvalidateFramebuffer: Invalidate the contents of attachments within a framebuffer
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the framebuffer object is attached for Gl.InvalidateFramebuffer.
        /// </param>
        /// <param name="attachments">
        /// Specifies a pointer to an array identifying the attachments to be invalidated.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")]
        public static void InvalidateFramebuffer(FramebufferTarget target, params int[] attachments)
        {
            unsafe
            {
                fixed (int* p_attachments = attachments)
                {
                    Assert(Delegates.pglInvalidateFramebuffer != null, "pglInvalidateFramebuffer not implemented");
                    Delegates.pglInvalidateFramebuffer((int) target, attachments.Length, p_attachments);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glInvalidateSubFramebuffer: invalidate the content of a region of some or all of a framebuffer's attachments
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glInvalidateSubFramebuffer: Invalidate portions of the contents of attachments within a framebuffer
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the framebuffer object is attached for Gl.InvalidateSubFramebuffer.
        /// </param>
        /// <param name="attachments">
        /// Specifies a pointer to an array identifying the attachments to be invalidated.
        /// </param>
        /// <param name="x">
        /// Specifies the X offset of the region to be invalidated.
        /// </param>
        /// <param name="y">
        /// Specifies the Y offset of the region to be invalidated.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the region to be invalidated.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the region to be invalidated.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")]
        public static void InvalidateSubFramebuffer(int target, int[] attachments, int x, int y, int width, int height)
        {
            unsafe
            {
                fixed (int* p_attachments = attachments)
                {
                    Assert(Delegates.pglInvalidateSubFramebuffer != null, "pglInvalidateSubFramebuffer not implemented");
                    Delegates.pglInvalidateSubFramebuffer(target, attachments.Length, p_attachments, x, y, width, height);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glMultiDrawArraysIndirect: render multiple sets of primitives from array data, taking parameters from memory
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES,
        /// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES,
        /// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, and Gl.PATCHES are accepted.
        /// </param>
        /// <param name="indirect">
        /// Specifies the address of an array of structures containing the draw parameters.
        /// </param>
        /// <param name="drawcount">
        /// Specifies the the number of elements in the array of draw parameter structures.
        /// </param>
        /// <param name="stride">
        /// Specifies the distance in basic machine units between elements of the draw parameter array.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_AMD_multi_draw_indirect")]
        [RequiredByFeature("GL_ARB_multi_draw_indirect", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_multi_draw_indirect", Api = "gles2")]
        public static void MultiDrawArraysIndirect(PrimitiveType mode, IntPtr indirect, int drawcount, int stride)
        {
            Assert(Delegates.pglMultiDrawArraysIndirect != null, "pglMultiDrawArraysIndirect not implemented");
            Delegates.pglMultiDrawArraysIndirect((int) mode, indirect, drawcount, stride);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glMultiDrawArraysIndirect: render multiple sets of primitives from array data, taking parameters from memory
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES,
        /// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES,
        /// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, and Gl.PATCHES are accepted.
        /// </param>
        /// <param name="indirect">
        /// Specifies the address of an array of structures containing the draw parameters.
        /// </param>
        /// <param name="drawcount">
        /// Specifies the the number of elements in the array of draw parameter structures.
        /// </param>
        /// <param name="stride">
        /// Specifies the distance in basic machine units between elements of the draw parameter array.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_AMD_multi_draw_indirect")]
        [RequiredByFeature("GL_ARB_multi_draw_indirect", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_multi_draw_indirect", Api = "gles2")]
        public static void MultiDrawArraysIndirect(PrimitiveType mode, object indirect, int drawcount, int stride)
        {
            GCHandle pin_indirect = GCHandle.Alloc(indirect, GCHandleType.Pinned);
            try
            {
                MultiDrawArraysIndirect(mode, pin_indirect.AddrOfPinnedObject(), drawcount, stride);
            }
            finally
            {
                pin_indirect.Free();
            }
        }

        /// <summary>
        /// [GL4] glMultiDrawElementsIndirect: render indexed primitives from array data, taking parameters from memory
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES,
        /// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES,
        /// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, and Gl.PATCHES are accepted.
        /// </param>
        /// <param name="type">
        /// Specifies the type of data in the buffer bound to the Gl.ELEMENT_ARRAY_BUFFER binding.
        /// </param>
        /// <param name="indirect">
        /// Specifies the address of a structure containing an array of draw parameters.
        /// </param>
        /// <param name="drawcount">
        /// Specifies the number of elements in the array addressed by <paramref name="indirect" />.
        /// </param>
        /// <param name="stride">
        /// Specifies the distance in basic machine units between elements of the draw parameter array.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_AMD_multi_draw_indirect")]
        [RequiredByFeature("GL_ARB_multi_draw_indirect", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_multi_draw_indirect", Api = "gles2")]
        public static void MultiDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, IntPtr indirect, int drawcount, int stride)
        {
            Assert(Delegates.pglMultiDrawElementsIndirect != null, "pglMultiDrawElementsIndirect not implemented");
            Delegates.pglMultiDrawElementsIndirect((int) mode, (int) type, indirect, drawcount, stride);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glMultiDrawElementsIndirect: render indexed primitives from array data, taking parameters from memory
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES,
        /// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES,
        /// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, and Gl.PATCHES are accepted.
        /// </param>
        /// <param name="type">
        /// Specifies the type of data in the buffer bound to the Gl.ELEMENT_ARRAY_BUFFER binding.
        /// </param>
        /// <param name="indirect">
        /// Specifies the address of a structure containing an array of draw parameters.
        /// </param>
        /// <param name="drawcount">
        /// Specifies the number of elements in the array addressed by <paramref name="indirect" />.
        /// </param>
        /// <param name="stride">
        /// Specifies the distance in basic machine units between elements of the draw parameter array.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_AMD_multi_draw_indirect")]
        [RequiredByFeature("GL_ARB_multi_draw_indirect", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_multi_draw_indirect", Api = "gles2")]
        public static void MultiDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, object indirect, int drawcount, int stride)
        {
            GCHandle pin_indirect = GCHandle.Alloc(indirect, GCHandleType.Pinned);
            try
            {
                MultiDrawElementsIndirect(mode, type, pin_indirect.AddrOfPinnedObject(), drawcount, stride);
            }
            finally
            {
                pin_indirect.Free();
            }
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetProgramInterfaceiv: query a property of an interface in a program
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// The name of a program object whose interface to query.
        /// </param>
        /// <param name="programInterface">
        /// A token identifying the interface within <paramref name="program" /> to query.
        /// </param>
        /// <param name="pname">
        /// The name of the parameter within <paramref name="programInterface" /> to query.
        /// </param>
        /// <param name="params">
        /// The address of a variable to retrieve the value of <paramref name="pname" /> for the program interface.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public static void GetProgramInterface(uint program, ProgramInterface programInterface, ProgramInterfacePName pname, [Out] int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Assert(Delegates.pglGetProgramInterfaceiv != null, "pglGetProgramInterfaceiv not implemented");
                    Delegates.pglGetProgramInterfaceiv(program, (int) programInterface, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetProgramInterfaceiv: query a property of an interface in a program
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// The name of a program object whose interface to query.
        /// </param>
        /// <param name="programInterface">
        /// A token identifying the interface within <paramref name="program" /> to query.
        /// </param>
        /// <param name="pname">
        /// The name of the parameter within <paramref name="programInterface" /> to query.
        /// </param>
        /// <param name="params">
        /// The address of a variable to retrieve the value of <paramref name="pname" /> for the program interface.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public static void GetProgramInterface(uint program, ProgramInterface programInterface, ProgramInterfacePName pname, out int @params)
        {
            unsafe
            {
                fixed (int* p_params = &@params)
                {
                    Assert(Delegates.pglGetProgramInterfaceiv != null, "pglGetProgramInterfaceiv not implemented");
                    Delegates.pglGetProgramInterfaceiv(program, (int) programInterface, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetProgramResourceIndex: query the index of a named resource within a program
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// The name of a program object whose resources to query.
        /// </param>
        /// <param name="programInterface">
        /// A token identifying the interface within <paramref name="program" /> containing the resource named
        /// <paramref
        ///     name="name" />
        /// .
        /// </param>
        /// <param name="name">
        /// The name of the resource to query the index of.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public static uint GetProgramResourceIndex(uint program, ProgramInterface programInterface, string name)
        {
            uint retValue;

            Assert(Delegates.pglGetProgramResourceIndex != null, "pglGetProgramResourceIndex not implemented");
            retValue = Delegates.pglGetProgramResourceIndex(program, (int) programInterface, name);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetProgramResourceName: query the name of an indexed resource within a program
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// The name of a program object whose resources to query.
        /// </param>
        /// <param name="programInterface">
        /// A token identifying the interface within <paramref name="program" /> containing the indexed resource.
        /// </param>
        /// <param name="index">
        /// The index of the resource within <paramref name="programInterface" /> of <paramref name="program" />.
        /// </param>
        /// <param name="bufSize">
        /// The size of the character array whose address is given by <paramref name="name" />.
        /// </param>
        /// <param name="length">
        /// The address of a variable which will receive the length of the resource name.
        /// </param>
        /// <param name="name">
        /// The address of a character array into which will be written the name of the resource.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public static void GetProgramResourceName(uint program, ProgramInterface programInterface, uint index, int bufSize, out int length, StringBuilder name)
        {
            unsafe
            {
                fixed (int* p_length = &length)
                {
                    Assert(Delegates.pglGetProgramResourceName != null, "pglGetProgramResourceName not implemented");
                    Delegates.pglGetProgramResourceName(program, (int) programInterface, index, bufSize, p_length, name);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetProgramResourceiv: retrieve values for multiple properties of a single active resource within a
        ///     program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// The name of a program object whose resources to query.
        /// </param>
        /// <param name="programInterface">
        /// A token identifying the interface within <paramref name="program" /> containing the resource named
        /// <paramref
        ///     name="name" />
        /// .
        /// </param>
        /// <param name="index">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="propCount">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="props">
        /// A <see cref="T:int[]" />.
        /// </param>
        /// <param name="bufSize">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="length">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public static void GetProgramResource(uint program, ProgramInterface programInterface, uint index, int propCount, int[] props, int bufSize, out int length, [Out] int[] @params)
        {
            unsafe
            {
                fixed (int* p_props = props)
                fixed (int* p_length = &length)
                fixed (int* p_params = @params)
                {
                    Assert(Delegates.pglGetProgramResourceiv != null, "pglGetProgramResourceiv not implemented");
                    Delegates.pglGetProgramResourceiv(program, (int) programInterface, index, propCount, p_props, bufSize, p_length, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetProgramResourceiv: retrieve values for multiple properties of a single active resource within a
        ///     program object
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// The name of a program object whose resources to query.
        /// </param>
        /// <param name="programInterface">
        /// A token identifying the interface within <paramref name="program" /> containing the resource named
        /// <paramref
        ///     name="name" />
        /// .
        /// </param>
        /// <param name="index">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="props">
        /// A <see cref="T:int[]" />.
        /// </param>
        /// <param name="length">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public static void GetProgramResource(uint program, ProgramInterface programInterface, uint index, int[] props, out int length, [Out] int[] @params)
        {
            unsafe
            {
                fixed (int* p_props = props)
                fixed (int* p_length = &length)
                fixed (int* p_params = @params)
                {
                    Assert(Delegates.pglGetProgramResourceiv != null, "pglGetProgramResourceiv not implemented");
                    Delegates.pglGetProgramResourceiv(program, (int) programInterface, index, props.Length, p_props, @params.Length, p_length, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetProgramResourceLocation: query the location of a named resource within a program
        ///     </para>
        /// </summary>
        /// <param name="program">
        /// The name of a program object whose resources to query.
        /// </param>
        /// <param name="programInterface">
        /// A token identifying the interface within <paramref name="program" /> containing the resource named
        /// <paramref
        ///     name="name" />
        /// .
        /// </param>
        /// <param name="name">
        /// The name of the resource to query the location of.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public static int GetProgramResourceLocation(uint program, ProgramInterface programInterface, string name)
        {
            int retValue;

            Assert(Delegates.pglGetProgramResourceLocation != null, "pglGetProgramResourceLocation not implemented");
            retValue = Delegates.pglGetProgramResourceLocation(program, (int) programInterface, name);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        /// [GL4] glGetProgramResourceLocationIndex: query the fragment color index of a named variable within a program
        /// </summary>
        /// <param name="program">
        /// The name of a program object whose resources to query.
        /// </param>
        /// <param name="programInterface">
        /// A token identifying the interface within <paramref name="program" /> containing the resource named
        /// <paramref
        ///     name="name" />
        /// .
        /// </param>
        /// <param name="name">
        /// The name of the resource to query the location of.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
        public static int GetProgramResourceLocationIndex(uint program, ProgramInterface programInterface, string name)
        {
            int retValue;

            Assert(Delegates.pglGetProgramResourceLocationIndex != null, "pglGetProgramResourceLocationIndex not implemented");
            retValue = Delegates.pglGetProgramResourceLocationIndex(program, (int) programInterface, name);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        /// [GL4] glShaderStorageBlockBinding: change an active shader storage block binding
        /// </summary>
        /// <param name="program">
        /// The name of the program containing the block whose binding to change.
        /// </param>
        /// <param name="storageBlockIndex">
        /// The index storage block within the program.
        /// </param>
        /// <param name="storageBlockBinding">
        /// The index storage block binding to associate with the specified storage block.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
        public static void ShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding)
        {
            Assert(Delegates.pglShaderStorageBlockBinding != null, "pglShaderStorageBlockBinding not implemented");
            Delegates.pglShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glTexBufferRange: attach a range of a buffer object's data store to a buffer texture object
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture object is bound for Gl.TexBufferRange. Must be Gl.TEXTURE_BUFFER.
        /// </param>
        /// <param name="internalformat">
        /// A <see cref="T:InternalFormat" />.
        /// </param>
        /// <param name="buffer">
        /// Specifies the name of the buffer object whose storage to attach to the active buffer texture.
        /// </param>
        /// <param name="offset">
        /// Specifies the offset of the start of the range of the buffer's data store to attach.
        /// </param>
        /// <param name="size">
        /// Specifies the size of the range of the buffer's data store to attach.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_buffer_range", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_buffer", Api = "gles2")]
        public static void TexBufferRange(TextureTarget target, InternalFormat internalformat, uint buffer, IntPtr offset, uint size)
        {
            Assert(Delegates.pglTexBufferRange != null, "pglTexBufferRange not implemented");
            Delegates.pglTexBufferRange((int) target, (int) internalformat, buffer, offset, size);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glTexStorage2DMultisample: specify storage for a two-dimensional multisample texture
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture object is bound for Gl.TexStorage2DMultisample. Must be one of
        /// Gl.TEXTURE_2D_MULTISAMPLE or Gl.PROXY_TEXTURE_2D_MULTISAMPLE.
        /// </param>
        /// <param name="samples">
        /// Specify the number of samples in the texture.
        /// </param>
        /// <param name="internalformat">
        /// Specifies the sized internal format to be used to store texture image data.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture, in texels.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the texture, in texels.
        /// </param>
        /// <param name="fixedsamplelocations">
        /// Specifies whether the image will use identical sample locations and the same number of samples for all texels in the
        /// image, and the sample locations will not depend on the internal format or size of the image.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_storage_multisample", Api = "gl|glcore")]
        public static void TexStorage2DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, bool fixedsamplelocations)
        {
            Assert(Delegates.pglTexStorage2DMultisample != null, "pglTexStorage2DMultisample not implemented");
            Delegates.pglTexStorage2DMultisample((int) target, samples, (int) internalformat, width, height, fixedsamplelocations);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glTexStorage3DMultisample: specify storage for a two-dimensional multisample array texture
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture object is bound for Gl.TexStorage3DMultisample. Must be one of
        /// Gl.TEXTURE_2D_MULTISAMPLE_ARRAY or Gl.PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY.
        /// </param>
        /// <param name="samples">
        /// Specify the number of samples in the texture.
        /// </param>
        /// <param name="internalformat">
        /// Specifies the sized internal format to be used to store texture image data.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture, in texels.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the texture, in texels.
        /// </param>
        /// <param name="depth">
        /// Specifies the depth of the texture, in layers.
        /// </param>
        /// <param name="fixedsamplelocations">
        /// Specifies whether the image will use identical sample locations and the same number of samples for all texels in the
        /// image, and the sample locations will not depend on the internal format or size of the image.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_storage_multisample", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_texture_storage_multisample_2d_array", Api = "gles2")]
        public static void TexStorage3DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations)
        {
            Assert(Delegates.pglTexStorage3DMultisample != null, "pglTexStorage3DMultisample not implemented");
            Delegates.pglTexStorage3DMultisample((int) target, samples, (int) internalformat, width, height, depth, fixedsamplelocations);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glTextureView: initialize a texture as a data alias of another texture's data store
        /// </summary>
        /// <param name="texture">
        /// Specifies the texture object to be initialized as a view.
        /// </param>
        /// <param name="target">
        /// Specifies the target to be used for the newly initialized texture.
        /// </param>
        /// <param name="origtexture">
        /// Specifies the name of a texture object of which to make a view.
        /// </param>
        /// <param name="internalformat">
        /// A <see cref="T:InternalFormat" />.
        /// </param>
        /// <param name="minlevel">
        /// Specifies lowest level of detail of the view.
        /// </param>
        /// <param name="numlevels">
        /// Specifies the number of levels of detail to include in the view.
        /// </param>
        /// <param name="minlayer">
        /// Specifies the index of the first layer to include in the view.
        /// </param>
        /// <param name="numlayers">
        /// Specifies the number of layers to include in the view.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ARB_texture_view", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_texture_view", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_view", Api = "gles2")]
        public static void TextureView(uint texture, TextureTarget target, uint origtexture, InternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers)
        {
            Assert(Delegates.pglTextureView != null, "pglTextureView not implemented");
            Delegates.pglTextureView(texture, (int) target, origtexture, (int) internalformat, minlevel, numlevels, minlayer, numlayers);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glBindVertexBuffer: bind a buffer to a vertex buffer bind point
        ///     </para>
        /// </summary>
        /// <param name="bindingindex">
        /// The index of the vertex buffer binding point to which to bind the buffer.
        /// </param>
        /// <param name="buffer">
        /// The name of a buffer to bind to the vertex buffer binding point.
        /// </param>
        /// <param name="offset">
        /// The offset of the first element of the buffer.
        /// </param>
        /// <param name="stride">
        /// The distance between elements within the buffer.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
        public static void BindVertexBuffer(uint bindingindex, uint buffer, IntPtr offset, int stride)
        {
            Assert(Delegates.pglBindVertexBuffer != null, "pglBindVertexBuffer not implemented");
            Delegates.pglBindVertexBuffer(bindingindex, buffer, offset, stride);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glVertexAttribFormat: specify the organization of vertex arrays
        ///     </para>
        /// </summary>
        /// <param name="attribindex">
        /// The generic vertex attribute array being described.
        /// </param>
        /// <param name="size">
        /// The number of values per vertex that are stored in the array.
        /// </param>
        /// <param name="type">
        /// The type of the data stored in the array.
        /// </param>
        /// <param name="normalized">
        /// Specifies whether fixed-point data values should be normalized (Gl.TRUE) or converted directly as fixed-point values
        /// (Gl.FALSE) when they are accessed. This parameter is ignored if <paramref name="type" /> is Gl.FIXED.
        /// </param>
        /// <param name="relativeoffset">
        /// The distance between elements within the buffer.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
        public static void VertexAttribFormat(uint attribindex, int size, int type, bool normalized, uint relativeoffset)
        {
            Assert(Delegates.pglVertexAttribFormat != null, "pglVertexAttribFormat not implemented");
            Delegates.pglVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glVertexAttribIFormat: specify the organization of vertex arrays
        ///     </para>
        /// </summary>
        /// <param name="attribindex">
        /// The generic vertex attribute array being described.
        /// </param>
        /// <param name="size">
        /// The number of values per vertex that are stored in the array.
        /// </param>
        /// <param name="type">
        /// The type of the data stored in the array.
        /// </param>
        /// <param name="relativeoffset">
        /// The distance between elements within the buffer.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
        public static void VertexAttribIFormat(uint attribindex, int size, int type, uint relativeoffset)
        {
            Assert(Delegates.pglVertexAttribIFormat != null, "pglVertexAttribIFormat not implemented");
            Delegates.pglVertexAttribIFormat(attribindex, size, type, relativeoffset);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glVertexAttribLFormat: specify the organization of vertex arrays
        /// </summary>
        /// <param name="attribindex">
        /// The generic vertex attribute array being described.
        /// </param>
        /// <param name="size">
        /// The number of values per vertex that are stored in the array.
        /// </param>
        /// <param name="type">
        /// The type of the data stored in the array.
        /// </param>
        /// <param name="relativeoffset">
        /// The distance between elements within the buffer.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
        public static void VertexAttribLFormat(uint attribindex, int size, VertexAttribType type, uint relativeoffset)
        {
            Assert(Delegates.pglVertexAttribLFormat != null, "pglVertexAttribLFormat not implemented");
            Delegates.pglVertexAttribLFormat(attribindex, size, (int) type, relativeoffset);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glVertexAttribBinding: associate a vertex attribute and a vertex buffer binding for a vertex array object
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glVertexAttribBinding: associate a vertex attribute and a vertex buffer binding
        ///     </para>
        /// </summary>
        /// <param name="attribindex">
        /// The index of the attribute to associate with a vertex buffer binding.
        /// </param>
        /// <param name="bindingindex">
        /// The index of the vertex buffer binding with which to associate the generic vertex attribute.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
        public static void VertexAttribBinding(uint attribindex, uint bindingindex)
        {
            Assert(Delegates.pglVertexAttribBinding != null, "pglVertexAttribBinding not implemented");
            Delegates.pglVertexAttribBinding(attribindex, bindingindex);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glVertexBindingDivisor: modify the rate at which generic vertex attributes advance
        ///     </para>
        /// </summary>
        /// <param name="bindingindex">
        /// The index of the binding whose divisor to modify.
        /// </param>
        /// <param name="divisor">
        /// The new value for the instance step rate to apply.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
        public static void VertexBindingDivisor(uint bindingindex, uint divisor)
        {
            Assert(Delegates.pglVertexBindingDivisor != null, "pglVertexBindingDivisor not implemented");
            Delegates.pglVertexBindingDivisor(bindingindex, divisor);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDebugMessageControl: control the reporting of debug messages in a debug context
        ///     </para>
        /// </summary>
        /// <param name="source">
        /// The source of debug messages to enable or disable.
        /// </param>
        /// <param name="type">
        /// The type of debug messages to enable or disable.
        /// </param>
        /// <param name="severity">
        /// The severity of debug messages to enable or disable.
        /// </param>
        /// <param name="count">
        /// The length of the array <paramref name="ids" />.
        /// </param>
        /// <param name="ids">
        /// The address of an array of unsigned integers contianing the ids of the messages to enable or disable.
        /// </param>
        /// <param name="enabled">
        /// A Boolean flag determining whether the selected messages should be enabled or disabled.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        [RequiredByFeature("GL_KHR_debug")]
        [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
        public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint[] ids, bool enabled)
        {
            unsafe
            {
                fixed (uint* p_ids = ids)
                {
                    Assert(Delegates.pglDebugMessageControl != null, "pglDebugMessageControl not implemented");
                    Delegates.pglDebugMessageControl((int) source, (int) type, (int) severity, count, p_ids, enabled);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDebugMessageControl: control the reporting of debug messages in a debug context
        ///     </para>
        /// </summary>
        /// <param name="source">
        /// The source of debug messages to enable or disable.
        /// </param>
        /// <param name="type">
        /// The type of debug messages to enable or disable.
        /// </param>
        /// <param name="severity">
        /// The severity of debug messages to enable or disable.
        /// </param>
        /// <param name="ids">
        /// The address of an array of unsigned integers contianing the ids of the messages to enable or disable.
        /// </param>
        /// <param name="enabled">
        /// A Boolean flag determining whether the selected messages should be enabled or disabled.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        [RequiredByFeature("GL_KHR_debug")]
        [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
        public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, uint[] ids, bool enabled)
        {
            unsafe
            {
                fixed (uint* p_ids = ids)
                {
                    Assert(Delegates.pglDebugMessageControl != null, "pglDebugMessageControl not implemented");
                    Delegates.pglDebugMessageControl((int) source, (int) type, (int) severity, ids.Length, p_ids, enabled);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDebugMessageInsert: inject an application-supplied message into the debug message queue
        ///     </para>
        /// </summary>
        /// <param name="source">
        /// The source of the debug message to insert.
        /// </param>
        /// <param name="type">
        /// The type of the debug message insert.
        /// </param>
        /// <param name="id">
        /// The user-supplied identifier of the message to insert.
        /// </param>
        /// <param name="severity">
        /// The severity of the debug messages to insert.
        /// </param>
        /// <param name="length">
        /// The length string contained in the character array whose address is given by <paramref name="message" />.
        /// </param>
        /// <param name="buf">
        /// A <see cref="T:string" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        [RequiredByFeature("GL_KHR_debug")]
        [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
        public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, string buf)
        {
            Assert(Delegates.pglDebugMessageInsert != null, "pglDebugMessageInsert not implemented");
            Delegates.pglDebugMessageInsert((int) source, (int) type, id, (int) severity, length, buf);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDebugMessageCallback: specify a callback to receive debugging messages from the GL
        ///     </para>
        /// </summary>
        /// <param name="callback">
        /// The address of a callback function that will be called when a debug message is generated.
        /// </param>
        /// <param name="userParam">
        /// A user supplied pointer that will be passed on each invocation of <paramref name="callback" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        [RequiredByFeature("GL_KHR_debug")]
        [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
        public static void DebugMessageCallback(DebugProc callback, IntPtr userParam)
        {
            Assert(Delegates.pglDebugMessageCallback != null, "pglDebugMessageCallback not implemented");
            Delegates.pglDebugMessageCallback(callback, userParam);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDebugMessageCallback: specify a callback to receive debugging messages from the GL
        ///     </para>
        /// </summary>
        /// <param name="callback">
        /// The address of a callback function that will be called when a debug message is generated.
        /// </param>
        /// <param name="userParam">
        /// A user supplied pointer that will be passed on each invocation of <paramref name="callback" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        [RequiredByFeature("GL_KHR_debug")]
        [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
        public static void DebugMessageCallback(DebugProc callback, object userParam)
        {
            GCHandle pin_userParam = GCHandle.Alloc(userParam, GCHandleType.Pinned);
            try
            {
                DebugMessageCallback(callback, pin_userParam.AddrOfPinnedObject());
            }
            finally
            {
                pin_userParam.Free();
            }
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetDebugMessageLog: retrieve messages from the debug message log
        ///     </para>
        /// </summary>
        /// <param name="bufSize">
        /// The size of the buffer whose address is given by <paramref name="messageLog" />.
        /// </param>
        /// <param name="sources">
        /// The address of an array of variables to receive the sources of the retrieved messages.
        /// </param>
        /// <param name="types">
        /// The address of an array of variables to receive the types of the retrieved messages.
        /// </param>
        /// <param name="ids">
        /// The address of an array of unsigned integers to receive the ids of the retrieved messages.
        /// </param>
        /// <param name="severities">
        /// The address of an array of variables to receive the severites of the retrieved messages.
        /// </param>
        /// <param name="lengths">
        /// The address of an array of variables to receive the lengths of the received messages.
        /// </param>
        /// <param name="messageLog">
        /// The address of an array of characters that will receive the messages.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
        [RequiredByFeature("GL_KHR_debug")]
        [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
        public static uint GetDebugMessageLog(int bufSize, [Out] int[] sources, [Out] int[] types, [Out] uint[] ids, [Out] int[] severities, [Out] int[] lengths, StringBuilder messageLog)
        {
            uint retValue;

            unsafe
            {
                fixed (int* p_sources = sources)
                fixed (int* p_types = types)
                fixed (uint* p_ids = ids)
                fixed (int* p_severities = severities)
                fixed (int* p_lengths = lengths)
                {
                    Assert(Delegates.pglGetDebugMessageLog != null, "pglGetDebugMessageLog not implemented");
                    retValue = Delegates.pglGetDebugMessageLog((uint) sources.Length, bufSize, p_sources, p_types, p_ids, p_severities, p_lengths, messageLog);
                }
            }

            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glPushDebugGroup: push a named debug group into the command stream
        ///     </para>
        /// </summary>
        /// <param name="source">
        /// The source of the debug message.
        /// </param>
        /// <param name="id">
        /// The identifier of the message.
        /// </param>
        /// <param name="length">
        /// The length of the message to be sent to the debug output stream.
        /// </param>
        /// <param name="message">
        /// The a string containing the message to be sent to the debug output stream.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug")]
        [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
        public static void PushDebugGroup(DebugSource source, uint id, int length, string message)
        {
            Assert(Delegates.pglPushDebugGroup != null, "pglPushDebugGroup not implemented");
            Delegates.pglPushDebugGroup((int) source, id, length, message);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glPopDebugGroup: pop the active debug group
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug")]
        [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
        public static void PopDebugGroup()
        {
            Assert(Delegates.pglPopDebugGroup != null, "pglPopDebugGroup not implemented");
            Delegates.pglPopDebugGroup();
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glObjectLabel: label a named object identified within a namespace
        ///     </para>
        /// </summary>
        /// <param name="identifier">
        /// The namespace from which the name of the object is allocated.
        /// </param>
        /// <param name="name">
        /// The name of the object to label.
        /// </param>
        /// <param name="length">
        /// The length of the label to be used for the object.
        /// </param>
        /// <param name="label">
        /// The address of a string containing the label to assign to the object.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug")]
        [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
        public static void ObjectLabel(ObjectIdentifier identifier, uint name, int length, string label)
        {
            Assert(Delegates.pglObjectLabel != null, "pglObjectLabel not implemented");
            Delegates.pglObjectLabel((int) identifier, name, length, label);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetObjectLabel: retrieve the label of a named object identified within a namespace
        ///     </para>
        /// </summary>
        /// <param name="identifier">
        /// The namespace from which the name of the object is allocated.
        /// </param>
        /// <param name="name">
        /// The name of the object whose label to retrieve.
        /// </param>
        /// <param name="bufSize">
        /// The length of the buffer whose address is in <paramref name="label" />.
        /// </param>
        /// <param name="length">
        /// The address of a variable to receive the length of the object label.
        /// </param>
        /// <param name="label">
        /// The address of a string that will receive the object label.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug")]
        [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
        public static void GetObjectLabel(int identifier, uint name, int bufSize, out int length, StringBuilder label)
        {
            unsafe
            {
                fixed (int* p_length = &length)
                {
                    Assert(Delegates.pglGetObjectLabel != null, "pglGetObjectLabel not implemented");
                    Delegates.pglGetObjectLabel(identifier, name, bufSize, p_length, label);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glObjectPtrLabel: label a a sync object identified by a pointer
        ///     </para>
        /// </summary>
        /// <param name="ptr">
        /// A pointer identifying a sync object.
        /// </param>
        /// <param name="length">
        /// The length of the label to be used for the object.
        /// </param>
        /// <param name="label">
        /// The address of a string containing the label to assign to the object.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug")]
        [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
        public static void ObjectPtrLabel(IntPtr ptr, int length, string label)
        {
            Assert(Delegates.pglObjectPtrLabel != null, "pglObjectPtrLabel not implemented");
            Delegates.pglObjectPtrLabel(ptr, length, label);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glObjectPtrLabel: label a a sync object identified by a pointer
        ///     </para>
        /// </summary>
        /// <param name="ptr">
        /// A pointer identifying a sync object.
        /// </param>
        /// <param name="length">
        /// The length of the label to be used for the object.
        /// </param>
        /// <param name="label">
        /// The address of a string containing the label to assign to the object.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug")]
        [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
        public static void ObjectPtrLabel(object ptr, int length, string label)
        {
            GCHandle pin_ptr = GCHandle.Alloc(ptr, GCHandleType.Pinned);
            try
            {
                ObjectPtrLabel(pin_ptr.AddrOfPinnedObject(), length, label);
            }
            finally
            {
                pin_ptr.Free();
            }
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetObjectPtrLabel: retrieve the label of a sync object identified by a pointer
        ///     </para>
        /// </summary>
        /// <param name="ptr">
        /// The name of the sync object whose label to retrieve.
        /// </param>
        /// <param name="bufSize">
        /// The length of the buffer whose address is in <paramref name="label" />.
        /// </param>
        /// <param name="length">
        /// The address of a variable to receive the length of the object label.
        /// </param>
        /// <param name="label">
        /// The address of a string that will receive the object label.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug")]
        [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
        public static void GetObjectPtrLabel(IntPtr ptr, int bufSize, out int length, StringBuilder label)
        {
            unsafe
            {
                fixed (int* p_length = &length)
                {
                    Assert(Delegates.pglGetObjectPtrLabel != null, "pglGetObjectPtrLabel not implemented");
                    Delegates.pglGetObjectPtrLabel(ptr, bufSize, p_length, label);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetObjectPtrLabel: retrieve the label of a sync object identified by a pointer
        ///     </para>
        /// </summary>
        /// <param name="ptr">
        /// The name of the sync object whose label to retrieve.
        /// </param>
        /// <param name="bufSize">
        /// The length of the buffer whose address is in <paramref name="label" />.
        /// </param>
        /// <param name="length">
        /// The address of a variable to receive the length of the object label.
        /// </param>
        /// <param name="label">
        /// The address of a string that will receive the object label.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug")]
        [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
        public static void GetObjectPtrLabel(object ptr, int bufSize, out int length, StringBuilder label)
        {
            GCHandle pin_ptr = GCHandle.Alloc(ptr, GCHandleType.Pinned);
            try
            {
                GetObjectPtrLabel(pin_ptr.AddrOfPinnedObject(), bufSize, out length, label);
            }
            finally
            {
                pin_ptr.Free();
            }
        }

        public static unsafe partial class Delegates
        {
            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ARB_clear_buffer_object", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glClearBufferData(int target, int internalformat, int format, int type, IntPtr data);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_clear_buffer_object", Api = "gl|glcore")] [ThreadStatic]
            public static glClearBufferData pglClearBufferData;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ARB_clear_buffer_object", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glClearBufferSubData(int target, int internalformat, IntPtr offset, uint size, int format, int type, IntPtr data);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_clear_buffer_object", Api = "gl|glcore")] [ThreadStatic]
            public static glClearBufferSubData pglClearBufferSubData;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")] [ThreadStatic]
            public static glDispatchCompute pglDispatchCompute;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDispatchComputeIndirect(IntPtr indirect);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")] [ThreadStatic]
            public static glDispatchComputeIndirect pglDispatchComputeIndirect;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_copy_image", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_copy_image", Api = "gles2")]
            [RequiredByFeature("GL_OES_copy_image", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glCopyImageSubData(uint srcName, int srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, int dstTarget, int dstLevel, int dstX, int dstY, int dstZ,
                int srcWidth, int srcHeight, int srcDepth);

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_copy_image", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_copy_image", Api = "gles2", EntryPoint = "glCopyImageSubDataEXT")]
            [RequiredByFeature("GL_OES_copy_image", Api = "gles2", EntryPoint = "glCopyImageSubDataOES")]
            [ThreadStatic]
            public static glCopyImageSubData pglCopyImageSubData;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glFramebufferParameteri(int target, int pname, int param);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")] [ThreadStatic]
            public static glFramebufferParameteri pglFramebufferParameteri;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetFramebufferParameteriv(int target, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")] [ThreadStatic]
            public static glGetFramebufferParameteriv pglGetFramebufferParameteriv;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetInternalformati64v(int target, int internalformat, int pname, int bufSize, long* @params);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")] [ThreadStatic]
            public static glGetInternalformati64v pglGetInternalformati64v;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glInvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")] [ThreadStatic]
            public static glInvalidateTexSubImage pglInvalidateTexSubImage;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glInvalidateTexImage(uint texture, int level);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")] [ThreadStatic]
            public static glInvalidateTexImage pglInvalidateTexImage;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glInvalidateBufferSubData(uint buffer, IntPtr offset, uint length);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")] [ThreadStatic]
            public static glInvalidateBufferSubData pglInvalidateBufferSubData;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glInvalidateBufferData(uint buffer);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")] [ThreadStatic]
            public static glInvalidateBufferData pglInvalidateBufferData;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glInvalidateFramebuffer(int target, int numAttachments, int* attachments);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")] [ThreadStatic]
            public static glInvalidateFramebuffer pglInvalidateFramebuffer;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glInvalidateSubFramebuffer(int target, int numAttachments, int* attachments, int x, int y, int width, int height);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_invalidate_subdata", Api = "gl|glcore")] [ThreadStatic]
            public static glInvalidateSubFramebuffer pglInvalidateSubFramebuffer;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_AMD_multi_draw_indirect")]
            [RequiredByFeature("GL_ARB_multi_draw_indirect", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_multi_draw_indirect", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glMultiDrawArraysIndirect(int mode, IntPtr indirect, int drawcount, int stride);

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_AMD_multi_draw_indirect", EntryPoint = "glMultiDrawArraysIndirectAMD")]
            [RequiredByFeature("GL_ARB_multi_draw_indirect", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_multi_draw_indirect", Api = "gles2", EntryPoint = "glMultiDrawArraysIndirectEXT")]
            [ThreadStatic]
            public static glMultiDrawArraysIndirect pglMultiDrawArraysIndirect;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_AMD_multi_draw_indirect")]
            [RequiredByFeature("GL_ARB_multi_draw_indirect", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_multi_draw_indirect", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glMultiDrawElementsIndirect(int mode, int type, IntPtr indirect, int drawcount, int stride);

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_AMD_multi_draw_indirect", EntryPoint = "glMultiDrawElementsIndirectAMD")]
            [RequiredByFeature("GL_ARB_multi_draw_indirect", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_multi_draw_indirect", Api = "gles2", EntryPoint = "glMultiDrawElementsIndirectEXT")]
            [ThreadStatic]
            public static glMultiDrawElementsIndirect pglMultiDrawElementsIndirect;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetProgramInterfaceiv(uint program, int programInterface, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")] [ThreadStatic]
            public static glGetProgramInterfaceiv pglGetProgramInterfaceiv;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate uint glGetProgramResourceIndex(uint program, int programInterface, string name);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")] [ThreadStatic]
            public static glGetProgramResourceIndex pglGetProgramResourceIndex;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetProgramResourceName(uint program, int programInterface, uint index, int bufSize, int* length, StringBuilder name);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")] [ThreadStatic]
            public static glGetProgramResourceName pglGetProgramResourceName;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetProgramResourceiv(uint program, int programInterface, uint index, int propCount, int* props, int bufSize, int* length, int* @params);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")] [ThreadStatic]
            public static glGetProgramResourceiv pglGetProgramResourceiv;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate int glGetProgramResourceLocation(uint program, int programInterface, string name);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")] [ThreadStatic]
            public static glGetProgramResourceLocation pglGetProgramResourceLocation;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate int glGetProgramResourceLocationIndex(uint program, int programInterface, string name);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")] [ThreadStatic]
            public static glGetProgramResourceLocationIndex pglGetProgramResourceLocationIndex;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")] [ThreadStatic]
            public static glShaderStorageBlockBinding pglShaderStorageBlockBinding;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_texture_buffer_range", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2")]
            [RequiredByFeature("GL_OES_texture_buffer", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glTexBufferRange(int target, int internalformat, uint buffer, IntPtr offset, uint size);

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_texture_buffer_range", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2", EntryPoint = "glTexBufferRangeEXT")]
            [RequiredByFeature("GL_OES_texture_buffer", Api = "gles2", EntryPoint = "glTexBufferRangeOES")]
            [ThreadStatic]
            public static glTexBufferRange pglTexBufferRange;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_texture_storage_multisample", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glTexStorage2DMultisample(int target, int samples, int internalformat, int width, int height, [MarshalAs(UnmanagedType.I1)] bool fixedsamplelocations);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_texture_storage_multisample", Api = "gl|glcore")] [ThreadStatic]
            public static glTexStorage2DMultisample pglTexStorage2DMultisample;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_texture_storage_multisample", Api = "gl|glcore")]
            [RequiredByFeature("GL_OES_texture_storage_multisample_2d_array", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glTexStorage3DMultisample(int target, int samples, int internalformat, int width, int height, int depth, [MarshalAs(UnmanagedType.I1)] bool fixedsamplelocations);

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_texture_storage_multisample", Api = "gl|glcore")]
            [RequiredByFeature("GL_OES_texture_storage_multisample_2d_array", Api = "gles2", EntryPoint = "glTexStorage3DMultisampleOES")]
            [ThreadStatic]
            public static glTexStorage3DMultisample pglTexStorage3DMultisample;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ARB_texture_view", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_texture_view", Api = "gles2")]
            [RequiredByFeature("GL_OES_texture_view", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glTextureView(uint texture, int target, uint origtexture, int internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ARB_texture_view", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_texture_view", Api = "gles2", EntryPoint = "glTextureViewEXT")]
            [RequiredByFeature("GL_OES_texture_view", Api = "gles2", EntryPoint = "glTextureViewOES")]
            [ThreadStatic]
            public static glTextureView pglTextureView;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBindVertexBuffer(uint bindingindex, uint buffer, IntPtr offset, int stride);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")] [ThreadStatic]
            public static glBindVertexBuffer pglBindVertexBuffer;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribFormat(uint attribindex, int size, int type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint relativeoffset);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")] [ThreadStatic]
            public static glVertexAttribFormat pglVertexAttribFormat;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribIFormat(uint attribindex, int size, int type, uint relativeoffset);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")] [ThreadStatic]
            public static glVertexAttribIFormat pglVertexAttribIFormat;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribLFormat(uint attribindex, int size, int type, uint relativeoffset);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")] [ThreadStatic]
            public static glVertexAttribLFormat pglVertexAttribLFormat;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexAttribBinding(uint attribindex, uint bindingindex);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")] [ThreadStatic]
            public static glVertexAttribBinding pglVertexAttribBinding;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glVertexBindingDivisor(uint bindingindex, uint divisor);

            [RequiredByFeature("GL_VERSION_4_3")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")] [ThreadStatic]
            public static glVertexBindingDivisor pglVertexBindingDivisor;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDebugMessageControl(int source, int type, int severity, int count, uint* ids, [MarshalAs(UnmanagedType.I1)] bool enabled);

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore", EntryPoint = "glDebugMessageControlARB")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2", EntryPoint = "glDebugMessageControlKHR")]
            [ThreadStatic]
            public static glDebugMessageControl pglDebugMessageControl;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDebugMessageInsert(int source, int type, uint id, int severity, int length, string buf);

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore", EntryPoint = "glDebugMessageInsertARB")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2", EntryPoint = "glDebugMessageInsertKHR")]
            [ThreadStatic]
            public static glDebugMessageInsert pglDebugMessageInsert;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDebugMessageCallback(DebugProc callback, IntPtr userParam);

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore", EntryPoint = "glDebugMessageCallbackARB")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2", EntryPoint = "glDebugMessageCallbackKHR")]
            [ThreadStatic]
            public static glDebugMessageCallback pglDebugMessageCallback;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate uint glGetDebugMessageLog(uint count, int bufSize, int* sources, int* types, uint* ids, int* severities, int* lengths, StringBuilder messageLog);

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore", EntryPoint = "glGetDebugMessageLogARB")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2", EntryPoint = "glGetDebugMessageLogKHR")]
            [ThreadStatic]
            public static glGetDebugMessageLog pglGetDebugMessageLog;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glPushDebugGroup(int source, uint id, int length, string message);

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2", EntryPoint = "glPushDebugGroupKHR")]
            [ThreadStatic]
            public static glPushDebugGroup pglPushDebugGroup;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glPopDebugGroup();

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2", EntryPoint = "glPopDebugGroupKHR")]
            [ThreadStatic]
            public static glPopDebugGroup pglPopDebugGroup;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glObjectLabel(int identifier, uint name, int length, string label);

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2", EntryPoint = "glObjectLabelKHR")]
            [ThreadStatic]
            public static glObjectLabel pglObjectLabel;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetObjectLabel(int identifier, uint name, int bufSize, int* length, StringBuilder label);

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2", EntryPoint = "glGetObjectLabelKHR")]
            [ThreadStatic]
            public static glGetObjectLabel pglGetObjectLabel;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glObjectPtrLabel(IntPtr ptr, int length, string label);

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2", EntryPoint = "glObjectPtrLabelKHR")]
            [ThreadStatic]
            public static glObjectPtrLabel pglObjectPtrLabel;

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetObjectPtrLabel(IntPtr ptr, int bufSize, int* length, StringBuilder label);

            [RequiredByFeature("GL_VERSION_4_3")]
            [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
            [RequiredByFeature("GL_KHR_debug")]
            [RequiredByFeature("GL_KHR_debug", Api = "gles2", EntryPoint = "glGetObjectPtrLabelKHR")]
            [ThreadStatic]
            public static glGetObjectPtrLabel pglGetObjectPtrLabel;
        }
    }
}