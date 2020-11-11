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
// ReSharper disable IdentifierTypo
namespace OpenGL
{
    public partial class Gl
    {
        /// <summary>
        /// [GL] Value of GL_MAX_VERTEX_ATTRIB_STRIDE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        public const int MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;

        /// <summary>
        /// [GL] Value of GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
        public const int PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;

        /// <summary>
        /// [GLES3.2] Gl.Get: data returns a single value, the name of the buffer object currently bound to the target
        /// Gl.TEXTURE_BUFFER. If no buffer object is bound to this target, 0 is returned. The initial value is 0. See
        /// Gl.BindBuffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_buffer", Api = "gles2")]
        public const int TEXTURE_BUFFER_BINDING = 0x8C2A;

        /// <summary>
        /// [GL] Value of GL_MAP_PERSISTENT_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
        public const int MAP_PERSISTENT_BIT = 0x0040;

        /// <summary>
        /// [GL] Value of GL_MAP_COHERENT_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
        public const int MAP_COHERENT_BIT = 0x0080;

        /// <summary>
        /// [GL] Value of GL_DYNAMIC_STORAGE_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
        public const int DYNAMIC_STORAGE_BIT = 0x0100;

        /// <summary>
        /// [GL] Value of GL_CLIENT_STORAGE_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
        public const int CLIENT_STORAGE_BIT = 0x0200;

        /// <summary>
        /// [GL] Value of GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
        public const uint CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000;

        /// <summary>
        /// [GL4] Gl.GetBufferParameter: params returns a boolean flag indicating whether the buffer object is immutable. The
        /// initial value is Gl.FALSE.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
        public const int BUFFER_IMMUTABLE_STORAGE = 0x821F;

        /// <summary>
        /// [GL4] Gl.GetBufferParameter: params returns a bitfield indicating the storage flags for the buffer object. If the
        /// buffer
        /// object is immutable, the value returned will be that specified when the data store was established with
        /// glBufferStorage.
        /// If the data store was established with glBufferData, the value will be Gl.MAP_READ_BIT | Gl.MAP_WRITE_BIT |
        /// Gl.DYNAMIC_STORAGE_BIT | Gl.MAP_WRITE_BIT. The initial value is zero.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")] [RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
        public const int BUFFER_STORAGE_FLAGS = 0x8220;

        /// <summary>
        /// [GL] Value of GL_CLEAR_TEXTURE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_clear_texture", Api = "gl|glcore")]
        public const int CLEAR_TEXTURE = 0x9365;

        /// <summary>
        /// [GL] Value of GL_LOCATION_COMPONENT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_enhanced_layouts", Api = "gl|glcore")]
        public const int LOCATION_COMPONENT = 0x934A;

        /// <summary>
        /// [GL] Value of GL_TRANSFORM_FEEDBACK_BUFFER_INDEX symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_enhanced_layouts", Api = "gl|glcore")]
        public const int TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B;

        /// <summary>
        /// [GL] Value of GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_enhanced_layouts", Api = "gl|glcore")]
        public const int TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C;

        /// <summary>
        /// [GL] Value of GL_QUERY_BUFFER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_query_buffer_object", Api = "gl|glcore")] [RequiredByFeature("GL_AMD_query_buffer_object")]
        public const int QUERY_BUFFER = 0x9192;

        /// <summary>
        /// [GL] Value of GL_QUERY_BUFFER_BARRIER_BIT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_query_buffer_object", Api = "gl|glcore")]
        public const uint QUERY_BUFFER_BARRIER_BIT = 0x00008000;

        /// <summary>
        /// [GL] Value of GL_QUERY_BUFFER_BINDING symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_query_buffer_object", Api = "gl|glcore")] [RequiredByFeature("GL_AMD_query_buffer_object")]
        public const int QUERY_BUFFER_BINDING = 0x9193;

        /// <summary>
        /// [GL4] Gl.GetQueryObject: If the result of the query is available (that is, a query of Gl.QUERY_RESULT_AVAILABLE would
        /// return non-zero), then params returns the value of the query object's passed samples counter, otherwise, the data
        /// referred to by params is not modified. The initial value is 0.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_query_buffer_object", Api = "gl|glcore")] [RequiredByFeature("GL_AMD_query_buffer_object")]
        public const int QUERY_RESULT_NO_WAIT = 0x9194;

        /// <summary>
        /// [GL] Value of GL_MIRROR_CLAMP_TO_EDGE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ARB_texture_mirror_clamp_to_edge", Api = "gl|glcore")]
        [RequiredByFeature("GL_ATI_texture_mirror_once")]
        [RequiredByFeature("GL_EXT_texture_mirror_clamp")]
        [RequiredByFeature("GL_EXT_texture_mirror_clamp_to_edge", Api = "gles2")]
        public const int MIRROR_CLAMP_TO_EDGE = 0x8743;

        /// <summary>
        /// [GL4] glBufferStorage: creates and initializes a buffer object's immutable data store
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound for Gl.BufferStorage, which must be one of the buffer binding
        /// targets in the following table:
        /// </param>
        /// <param name="size">
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Gl.L if no data is to be
        /// copied.
        /// </param>
        /// <param name="flags">
        /// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags.
        /// Gl.DYNAMIC_STORAGE_BIT, Gl.MAP_READ_BITGl.MAP_WRITE_BIT, Gl.MAP_PERSISTENT_BIT, Gl.MAP_COHERENT_BIT, and
        /// Gl.CLIENT_STORAGE_BIT.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
        public static void BufferStorage(BufferTarget target, uint size, IntPtr data, MapBufferUsageMask flags)
        {
            Debug.Assert(Delegates.pglBufferStorage != null, "pglBufferStorage not implemented");
            Delegates.pglBufferStorage((int) target, size, data, (uint) flags);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glBufferStorage: creates and initializes a buffer object's immutable data store
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound for Gl.BufferStorage, which must be one of the buffer binding
        /// targets in the following table:
        /// </param>
        /// <param name="size">
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Gl.L if no data is to be
        /// copied.
        /// </param>
        /// <param name="flags">
        /// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags.
        /// Gl.DYNAMIC_STORAGE_BIT, Gl.MAP_READ_BITGl.MAP_WRITE_BIT, Gl.MAP_PERSISTENT_BIT, Gl.MAP_COHERENT_BIT, and
        /// Gl.CLIENT_STORAGE_BIT.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
        public static void BufferStorage(BufferTarget target, uint size, object data, MapBufferUsageMask flags)
        {
            GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                BufferStorage(target, size, pin_data.AddrOfPinnedObject(), flags);
            }
            finally
            {
                pin_data.Free();
            }
        }

        /// <summary>
        /// [GL4] glClearTexImage: fills all a texture image with a constant value
        /// </summary>
        /// <param name="texture">
        /// The name of an existing texture object containing the image to be cleared.
        /// </param>
        /// <param name="level">
        /// The level of <paramref name="texture" /> containing the region to be cleared.
        /// </param>
        /// <param name="format">
        /// The format of the data whose address in memory is given by <paramref name="data" />.
        /// </param>
        /// <param name="type">
        /// The type of the data whose address in memory is given by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// The address in memory of the data to be used to clear the specified region.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ARB_clear_texture", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_clear_texture", Api = "gles2")]
        public static void ClearTexImage(uint texture, int level, PixelFormat format, PixelType type, IntPtr data)
        {
            Debug.Assert(Delegates.pglClearTexImage != null, "pglClearTexImage not implemented");
            Delegates.pglClearTexImage(texture, level, (int) format, (int) type, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glClearTexImage: fills all a texture image with a constant value
        /// </summary>
        /// <param name="texture">
        /// The name of an existing texture object containing the image to be cleared.
        /// </param>
        /// <param name="level">
        /// The level of <paramref name="texture" /> containing the region to be cleared.
        /// </param>
        /// <param name="format">
        /// The format of the data whose address in memory is given by <paramref name="data" />.
        /// </param>
        /// <param name="type">
        /// The type of the data whose address in memory is given by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// The address in memory of the data to be used to clear the specified region.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ARB_clear_texture", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_clear_texture", Api = "gles2")]
        public static void ClearTexImage(uint texture, int level, PixelFormat format, PixelType type, object data)
        {
            GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                ClearTexImage(texture, level, format, type, pin_data.AddrOfPinnedObject());
            }
            finally
            {
                pin_data.Free();
            }
        }

        /// <summary>
        /// [GL4] glClearTexSubImage: fills all or part of a texture image with a constant value
        /// </summary>
        /// <param name="texture">
        /// The name of an existing texture object containing the image to be cleared.
        /// </param>
        /// <param name="level">
        /// The level of <paramref name="texture" /> containing the region to be cleared.
        /// </param>
        /// <param name="xoffset">
        /// The coordinate of the left edge of the region to be cleared.
        /// </param>
        /// <param name="yoffset">
        /// The coordinate of the lower edge of the region to be cleared.
        /// </param>
        /// <param name="zoffset">
        /// The coordinate of the front of the region to be cleared.
        /// </param>
        /// <param name="width">
        /// The width of the region to be cleared.
        /// </param>
        /// <param name="height">
        /// The height of the region to be cleared.
        /// </param>
        /// <param name="depth">
        /// The depth of the region to be cleared.
        /// </param>
        /// <param name="format">
        /// The format of the data whose address in memory is given by <paramref name="data" />.
        /// </param>
        /// <param name="type">
        /// The type of the data whose address in memory is given by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// The address in memory of the data to be used to clear the specified region.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ARB_clear_texture", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_clear_texture", Api = "gles2")]
        public static void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr data)
        {
            Debug.Assert(Delegates.pglClearTexSubImage != null, "pglClearTexSubImage not implemented");
            Delegates.pglClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, (int) format, (int) type, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glClearTexSubImage: fills all or part of a texture image with a constant value
        /// </summary>
        /// <param name="texture">
        /// The name of an existing texture object containing the image to be cleared.
        /// </param>
        /// <param name="level">
        /// The level of <paramref name="texture" /> containing the region to be cleared.
        /// </param>
        /// <param name="xoffset">
        /// The coordinate of the left edge of the region to be cleared.
        /// </param>
        /// <param name="yoffset">
        /// The coordinate of the lower edge of the region to be cleared.
        /// </param>
        /// <param name="zoffset">
        /// The coordinate of the front of the region to be cleared.
        /// </param>
        /// <param name="width">
        /// The width of the region to be cleared.
        /// </param>
        /// <param name="height">
        /// The height of the region to be cleared.
        /// </param>
        /// <param name="depth">
        /// The depth of the region to be cleared.
        /// </param>
        /// <param name="format">
        /// The format of the data whose address in memory is given by <paramref name="data" />.
        /// </param>
        /// <param name="type">
        /// The type of the data whose address in memory is given by <paramref name="data" />.
        /// </param>
        /// <param name="data">
        /// The address in memory of the data to be used to clear the specified region.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ARB_clear_texture", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_clear_texture", Api = "gles2")]
        public static void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, object data)
        {
            GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pin_data.AddrOfPinnedObject());
            }
            finally
            {
                pin_data.Free();
            }
        }

        /// <summary>
        /// [GL4] glBindBuffersBase: bind one or more buffer objects to a sequence of indexed buffer targets
        /// </summary>
        /// <param name="target">
        /// Specify the target of the bind operation. <paramref name="target" /> must be one of Gl.ATOMIC_COUNTER_BUFFER,
        /// Gl.TRANSFORM_FEEDBACK_BUFFER, Gl.UNIFORM_BUFFER or Gl.SHADER_STORAGE_BUFFER.
        /// </param>
        /// <param name="first">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="count">
        /// Specify the number of contiguous binding points to which to bind buffers.
        /// </param>
        /// <param name="buffers">
        /// A pointer to an array of names of buffer objects to bind to the targets on the specified binding point, or Gl.L.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
        public static void BindBuffersBase(BufferTarget target, uint first, int count, uint[] buffers)
        {
            unsafe
            {
                fixed (uint* p_buffers = buffers)
                {
                    Debug.Assert(Delegates.pglBindBuffersBase != null, "pglBindBuffersBase not implemented");
                    Delegates.pglBindBuffersBase((int) target, first, count, p_buffers);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glBindBuffersBase: bind one or more buffer objects to a sequence of indexed buffer targets
        /// </summary>
        /// <param name="target">
        /// Specify the target of the bind operation. <paramref name="target" /> must be one of Gl.ATOMIC_COUNTER_BUFFER,
        /// Gl.TRANSFORM_FEEDBACK_BUFFER, Gl.UNIFORM_BUFFER or Gl.SHADER_STORAGE_BUFFER.
        /// </param>
        /// <param name="first">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="buffers">
        /// A pointer to an array of names of buffer objects to bind to the targets on the specified binding point, or Gl.L.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
        public static void BindBuffersBase(BufferTarget target, uint first, uint[] buffers)
        {
            unsafe
            {
                fixed (uint* p_buffers = buffers)
                {
                    Debug.Assert(Delegates.pglBindBuffersBase != null, "pglBindBuffersBase not implemented");
                    Delegates.pglBindBuffersBase((int) target, first, buffers.Length, p_buffers);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glBindBuffersRange: bind ranges of one or more buffer objects to a sequence of indexed buffer targets
        /// </summary>
        /// <param name="target">
        /// Specify the target of the bind operation. <paramref name="target" /> must be one of Gl.ATOMIC_COUNTER_BUFFER,
        /// Gl.TRANSFORM_FEEDBACK_BUFFER, Gl.UNIFORM_BUFFER or Gl.SHADER_STORAGE_BUFFER.
        /// </param>
        /// <param name="first">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="count">
        /// Specify the number of contiguous binding points to which to bind buffers.
        /// </param>
        /// <param name="buffers">
        /// A pointer to an array of names of buffer objects to bind to the targets on the specified binding point, or Gl.L.
        /// </param>
        /// <param name="offsets">
        /// A pointer to an array of offsets into the corresponding buffer in <paramref name="buffers" /> to bind, or Gl.L if
        /// <paramref name="buffers" /> is Gl.L.
        /// </param>
        /// <param name="sizes">
        /// A pointer to an array of sizes of the corresponding buffer in <paramref name="buffers" /> to bind, or Gl.L if
        /// <paramref
        ///     name="buffers" />
        /// is Gl.L.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
        public static void BindBuffersRange(BufferTarget target, uint first, int count, uint[] buffers, IntPtr[] offsets, uint[] sizes)
        {
            unsafe
            {
                fixed (uint* p_buffers = buffers)
                fixed (IntPtr* p_offsets = offsets)
                fixed (uint* p_sizes = sizes)
                {
                    Debug.Assert(Delegates.pglBindBuffersRange != null, "pglBindBuffersRange not implemented");
                    Delegates.pglBindBuffersRange((int) target, first, count, p_buffers, p_offsets, p_sizes);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glBindBuffersRange: bind ranges of one or more buffer objects to a sequence of indexed buffer targets
        /// </summary>
        /// <param name="target">
        /// Specify the target of the bind operation. <paramref name="target" /> must be one of Gl.ATOMIC_COUNTER_BUFFER,
        /// Gl.TRANSFORM_FEEDBACK_BUFFER, Gl.UNIFORM_BUFFER or Gl.SHADER_STORAGE_BUFFER.
        /// </param>
        /// <param name="first">
        /// A <see cref="T:uint" />.
        /// </param>
        /// <param name="buffers">
        /// A pointer to an array of names of buffer objects to bind to the targets on the specified binding point, or Gl.L.
        /// </param>
        /// <param name="offsets">
        /// A pointer to an array of offsets into the corresponding buffer in <paramref name="buffers" /> to bind, or Gl.L if
        /// <paramref name="buffers" /> is Gl.L.
        /// </param>
        /// <param name="sizes">
        /// A pointer to an array of sizes of the corresponding buffer in <paramref name="buffers" /> to bind, or Gl.L if
        /// <paramref
        ///     name="buffers" />
        /// is Gl.L.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
        public static void BindBuffersRange(BufferTarget target, uint first, uint[] buffers, IntPtr[] offsets, uint[] sizes)
        {
            unsafe
            {
                fixed (uint* p_buffers = buffers)
                fixed (IntPtr* p_offsets = offsets)
                fixed (uint* p_sizes = sizes)
                {
                    Debug.Assert(Delegates.pglBindBuffersRange != null, "pglBindBuffersRange not implemented");
                    Delegates.pglBindBuffersRange((int) target, first, buffers.Length, p_buffers, p_offsets, p_sizes);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glBindTextures: bind one or more named textures to a sequence of consecutive texture units
        /// </summary>
        /// <param name="first">
        /// Specifies the first texture unit to which a texture is to be bound.
        /// </param>
        /// <param name="textures">
        /// Specifies the address of an array of names of existing texture objects.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
        public static void BindTextures(uint first, params uint[] textures)
        {
            unsafe
            {
                fixed (uint* p_textures = textures)
                {
                    Debug.Assert(Delegates.pglBindTextures != null, "pglBindTextures not implemented");
                    Delegates.pglBindTextures(first, textures.Length, p_textures);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glBindSamplers: bind one or more named sampler objects to a sequence of consecutive sampler units
        /// </summary>
        /// <param name="first">
        /// Specifies the first sampler unit to which a sampler object is to be bound.
        /// </param>
        /// <param name="samplers">
        /// Specifies the address of an array of names of existing sampler objects.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
        public static void BindSamplers(uint first, params uint[] samplers)
        {
            unsafe
            {
                fixed (uint* p_samplers = samplers)
                {
                    Debug.Assert(Delegates.pglBindSamplers != null, "pglBindSamplers not implemented");
                    Delegates.pglBindSamplers(first, samplers.Length, p_samplers);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glBindImageTextures: bind one or more named texture images to a sequence of consecutive image units
        /// </summary>
        /// <param name="first">
        /// Specifies the first image unit to which a texture is to be bound.
        /// </param>
        /// <param name="textures">
        /// Specifies the address of an array of names of existing texture objects.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
        public static void BindImageTextures(uint first, params uint[] textures)
        {
            unsafe
            {
                fixed (uint* p_textures = textures)
                {
                    Debug.Assert(Delegates.pglBindImageTextures != null, "pglBindImageTextures not implemented");
                    Delegates.pglBindImageTextures(first, textures.Length, p_textures);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glBindVertexBuffers: attach multiple buffer objects to a vertex array object
        /// </summary>
        /// <param name="first">
        /// Specifies the first vertex buffer binding point to which a buffer object is to be bound.
        /// </param>
        /// <param name="buffers">
        /// Specifies the address of an array of names of existing buffer objects.
        /// </param>
        /// <param name="offsets">
        /// Specifies the address of an array of offsets to associate with the binding points.
        /// </param>
        /// <param name="strides">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
        public static void BindVertexBuffers(uint first, uint[] buffers, IntPtr[] offsets, params int[] strides)
        {
            unsafe
            {
                fixed (uint* p_buffers = buffers)
                fixed (IntPtr* p_offsets = offsets)
                fixed (int* p_strides = strides)
                {
                    Debug.Assert(Delegates.pglBindVertexBuffers != null, "pglBindVertexBuffers not implemented");
                    Delegates.pglBindVertexBuffers(first, buffers.Length, p_buffers, p_offsets, p_strides);
                }
            }

            DebugCheckErrors(null);
        }

        public static unsafe partial class Delegates
        {
            [RequiredByFeature("GL_VERSION_4_4")]
            [RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBufferStorage(int target, uint size, IntPtr data, uint flags);

            [RequiredByFeature("GL_VERSION_4_4")]
            [RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2", EntryPoint = "glBufferStorageEXT")]
            [ThreadStatic]
            public static glBufferStorage pglBufferStorage;

            [RequiredByFeature("GL_VERSION_4_4")]
            [RequiredByFeature("GL_ARB_clear_texture", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_clear_texture", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glClearTexImage(uint texture, int level, int format, int type, IntPtr data);

            [RequiredByFeature("GL_VERSION_4_4")]
            [RequiredByFeature("GL_ARB_clear_texture", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_clear_texture", Api = "gles2", EntryPoint = "glClearTexImageEXT")]
            [ThreadStatic]
            public static glClearTexImage pglClearTexImage;

            [RequiredByFeature("GL_VERSION_4_4")]
            [RequiredByFeature("GL_ARB_clear_texture", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_clear_texture", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int format, int type, IntPtr data);

            [RequiredByFeature("GL_VERSION_4_4")]
            [RequiredByFeature("GL_ARB_clear_texture", Api = "gl|glcore")]
            [RequiredByFeature("GL_EXT_clear_texture", Api = "gles2", EntryPoint = "glClearTexSubImageEXT")]
            [ThreadStatic]
            public static glClearTexSubImage pglClearTexSubImage;

            [RequiredByFeature("GL_VERSION_4_4")]
            [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBindBuffersBase(int target, uint first, int count, uint* buffers);

            [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")] [ThreadStatic]
            public static glBindBuffersBase pglBindBuffersBase;

            [RequiredByFeature("GL_VERSION_4_4")]
            [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBindBuffersRange(int target, uint first, int count, uint* buffers, IntPtr* offsets, uint* sizes);

            [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")] [ThreadStatic]
            public static glBindBuffersRange pglBindBuffersRange;

            [RequiredByFeature("GL_VERSION_4_4")]
            [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBindTextures(uint first, int count, uint* textures);

            [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")] [ThreadStatic]
            public static glBindTextures pglBindTextures;

            [RequiredByFeature("GL_VERSION_4_4")]
            [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBindSamplers(uint first, int count, uint* samplers);

            [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")] [ThreadStatic]
            public static glBindSamplers pglBindSamplers;

            [RequiredByFeature("GL_VERSION_4_4")]
            [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBindImageTextures(uint first, int count, uint* textures);

            [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")] [ThreadStatic]
            public static glBindImageTextures pglBindImageTextures;

            [RequiredByFeature("GL_VERSION_4_4")]
            [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBindVertexBuffers(uint first, int count, uint* buffers, IntPtr* offsets, int* strides);

            [RequiredByFeature("GL_VERSION_4_4")] [RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")] [ThreadStatic]
            public static glBindVertexBuffers pglBindVertexBuffers;
        }
    }
}