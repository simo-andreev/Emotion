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
        /// [GL4|GLES3.2] Gl.GetBufferParameter: params returns the size of the buffer object, measured in bytes. The initial value
        /// is 0.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public const int BUFFER_SIZE = 0x8764;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetBufferParameter: params returns the buffer object's usage pattern. The initial value is Gl.STATIC_DRAW.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetBufferParameter: params returns the buffer object's usage pattern.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public const int BUFFER_USAGE = 0x8765;

        /// <summary>
        /// [GL2.1] Gl.GetQuery: params returns the number of bits in the query counter used to accumulate passing samples. If the
        /// number of bits returned is 0, the implementation does not support a query counter, and the results obtained from
        /// Gl.GetQueryObject are useless.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_ARB_occlusion_query")] [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
        public const int QUERY_COUNTER_BITS = 0x8864;

        /// <summary>
        /// [GL2.1] Gl.GetQuery: params returns the name of the currently active occlusion query object. If no occlusion query is
        /// active, 0 is returned. The initial value is 0.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_occlusion_query")]
        [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
        [RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
        public const int CURRENT_QUERY = 0x8865;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetQueryObject: params returns the value of the query object's passed samples counter. The initial
        /// value is 0.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_occlusion_query")]
        [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
        [RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
        public const int QUERY_RESULT = 0x8866;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetQueryObject: params returns whether the passed samples counter is immediately available. If a delay
        ///     would
        ///     occur waiting for the query result, Gl.FALSE is returned. Otherwise, Gl.TRUE is returned, which also indicates that
        ///     the
        ///     results of all previous queries are available as well.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetQueryObject: params returns whether the passed samples counter is immediately available. If a delay
        ///     would occur waiting for the query result, Gl.FALSE is returned. Otherwise, Gl.TRUE is returned, which also
        ///     indicates
        ///     that the results of all previous queries of the same type are available as well.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_occlusion_query")]
        [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
        [RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
        public const int QUERY_RESULT_AVAILABLE = 0x8867;

        /// <summary>
        /// [GL] Value of GL_ARRAY_BUFFER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public const int ARRAY_BUFFER = 0x8892;

        /// <summary>
        /// [GL] Value of GL_ELEMENT_ARRAY_BUFFER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public const int ELEMENT_ARRAY_BUFFER = 0x8893;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single value, the name of the buffer object currently bound to the target
        /// Gl.ARRAY_BUFFER. If no buffer object is bound to this target, 0 is returned. The initial value is 0. See Gl.BindBuffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public const int ARRAY_BUFFER_BINDING = 0x8894;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single value, the name of the buffer object currently bound to the target
        /// Gl.ELEMENT_ARRAY_BUFFER. If no buffer object is bound to this target, 0 is returned. The initial value is 0. See
        /// Gl.BindBuffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public const int ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetVertexAttrib: params returns a single value, the name of the buffer object currently bound to the
        /// binding point corresponding to generic vertex attribute array index. If no buffer object is bound, 0 is returned. The
        /// initial value is 0.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public const int VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;

        /// <summary>
        /// [GL] Value of GL_READ_ONLY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public const int READ_ONLY = 0x88B8;

        /// <summary>
        /// [GL] Value of GL_WRITE_ONLY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_NV_shader_buffer_store", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        [RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
        public const int WRITE_ONLY = 0x88B9;

        /// <summary>
        /// [GL] Value of GL_READ_WRITE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_NV_shader_buffer_store", Api = "gl|glcore")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public const int READ_WRITE = 0x88BA;

        /// <summary>
        /// [GL4] Gl.GetBufferParameter: params returns the access policy set while mapping the buffer object (the value of the
        /// access parameter enum passed to glMapBuffer). If the buffer was mapped with glMapBufferRange, the access policy is
        /// determined by translating the bits in that access parameter to one of the supported enums for glMapBuffer as described
        /// in the OpenGL Specification.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_ARB_vertex_buffer_object")] [RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
        public const int BUFFER_ACCESS = 0x88BB;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetBufferParameter: params returns a flag indicating whether the buffer object is currently mapped.
        /// The
        /// initial value is Gl.FALSE.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        [RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
        public const int BUFFER_MAPPED = 0x88BC;

        /// <summary>
        /// [GL] Value of GL_BUFFER_MAP_POINTER symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        [RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
        public const int BUFFER_MAP_POINTER = 0x88BD;

        /// <summary>
        /// [GL] Value of GL_STREAM_DRAW symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public const int STREAM_DRAW = 0x88E0;

        /// <summary>
        /// [GL] Value of GL_STREAM_READ symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public const int STREAM_READ = 0x88E1;

        /// <summary>
        /// [GL] Value of GL_STREAM_COPY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public const int STREAM_COPY = 0x88E2;

        /// <summary>
        /// [GL] Value of GL_STATIC_DRAW symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public const int STATIC_DRAW = 0x88E4;

        /// <summary>
        /// [GL] Value of GL_STATIC_READ symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public const int STATIC_READ = 0x88E5;

        /// <summary>
        /// [GL] Value of GL_STATIC_COPY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public const int STATIC_COPY = 0x88E6;

        /// <summary>
        /// [GL] Value of GL_DYNAMIC_DRAW symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public const int DYNAMIC_DRAW = 0x88E8;

        /// <summary>
        /// [GL] Value of GL_DYNAMIC_READ symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public const int DYNAMIC_READ = 0x88E9;

        /// <summary>
        /// [GL] Value of GL_DYNAMIC_COPY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public const int DYNAMIC_COPY = 0x88EA;

        /// <summary>
        /// [GL] Value of GL_SAMPLES_PASSED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_ARB_occlusion_query")]
        public const int SAMPLES_PASSED = 0x8914;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single value, the name of the buffer object associated with the vertex array. This
        ///     buffer object would have been bound to the target Gl.ARRAY_BUFFER at the time of the most recent call to
        ///     Gl.VertexPointer. If no buffer object was bound to this target, 0 is returned. The initial value is 0. See
        ///     Gl.BindBuffer.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, the vertex array buffer binding. See Gl.VertexPointer.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_ARB_vertex_buffer_object")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int VERTEX_ARRAY_BUFFER_BINDING = 0x8896;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single value, the name of the buffer object associated with the normal array. This
        ///     buffer object would have been bound to the target Gl.ARRAY_BUFFER at the time of the most recent call to
        ///     Gl.NormalPointer. If no buffer object was bound to this target, 0 is returned. The initial value is 0. See
        ///     Gl.BindBuffer.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, the normal array buffer binding. See Gl.NormalPointer.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_ARB_vertex_buffer_object")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int NORMAL_ARRAY_BUFFER_BINDING = 0x8897;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single value, the name of the buffer object associated with the color array. This
        ///     buffer object would have been bound to the target Gl.ARRAY_BUFFER at the time of the most recent call to
        ///     Gl.ColorPointer. If no buffer object was bound to this target, 0 is returned. The initial value is 0. See
        ///     Gl.BindBuffer.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, the color array buffer binding. See Gl.ColorPointer.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_ARB_vertex_buffer_object")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int COLOR_ARRAY_BUFFER_BINDING = 0x8898;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns a single value, the name of the buffer object associated with the color index array.
        /// This
        /// buffer object would have been bound to the target Gl.ARRAY_BUFFER at the time of the most recent call to
        /// Gl.IndexPointer. If no buffer object was bound to this target, 0 is returned. The initial value is 0. See
        /// Gl.BindBuffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_ARB_vertex_buffer_object")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int INDEX_ARRAY_BUFFER_BINDING = 0x8899;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single value, the name of the buffer object associated with the texture coordinate
        ///     array. This buffer object would have been bound to the target Gl.ARRAY_BUFFER at the time of the most recent call
        ///     to
        ///     Gl.TexCoordPointer. If no buffer object was bound to this target, 0 is returned. The initial value is 0. See
        ///     Gl.BindBuffer.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, the texture coordinate array buffer binding. See Gl.TexCoordPointer.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_ARB_vertex_buffer_object")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns a single value, the name of the buffer object associated with the edge flag array. This
        /// buffer object would have been bound to the target Gl.ARRAY_BUFFER at the time of the most recent call to
        /// Gl.EdgeFlagPointer. If no buffer object was bound to this target, 0 is returned. The initial value is 0. See
        /// Gl.BindBuffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_ARB_vertex_buffer_object")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int EDGE_FLAG_ARRAY_BUFFER_BINDING = 0x889B;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns a single value, the name of the buffer object associated with the secondary color array.
        /// This buffer object would have been bound to the target Gl.ARRAY_BUFFER at the time of the most recent call to
        /// Gl.SecondaryColorPointer. If no buffer object was bound to this target, 0 is returned. The initial value is 0. See
        /// Gl.BindBuffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_ARB_vertex_buffer_object")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SECONDARY_COLOR_ARRAY_BUFFER_BINDING = 0x889C;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGenQueries: generate query object names
        ///     </para>
        /// </summary>
        /// <param name="ids">
        /// Specifies an array in which the generated query object names are stored.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_occlusion_query")]
        public static void GenQueries(uint[] ids)
        {
            unsafe
            {
                fixed (uint* p_ids = ids)
                {
                    Debug.Assert(Delegates.pglGenQueries != null, "pglGenQueries not implemented");
                    Delegates.pglGenQueries(ids.Length, p_ids);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGenQueries: generate query object names
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_occlusion_query")]
        public static uint GenQuery()
        {
            uint retValue;
            unsafe
            {
                Delegates.pglGenQueries(1, &retValue);
            }

            DebugCheckErrors(null);
            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDeleteQueries: delete named query objects
        ///     </para>
        /// </summary>
        /// <param name="ids">
        /// Specifies an array of query objects to be deleted.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_occlusion_query")]
        public static void DeleteQueries(params uint[] ids)
        {
            unsafe
            {
                fixed (uint* p_ids = ids)
                {
                    Debug.Assert(Delegates.pglDeleteQueries != null, "pglDeleteQueries not implemented");
                    Delegates.pglDeleteQueries(ids.Length, p_ids);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glIsQuery: determine if a name corresponds to a query object
        ///     </para>
        /// </summary>
        /// <param name="id">
        /// Specifies a value that may be the name of a query object.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_occlusion_query")]
        public static bool IsQuery(uint id)
        {
            bool retValue;

            Debug.Assert(Delegates.pglIsQuery != null, "pglIsQuery not implemented");
            retValue = Delegates.pglIsQuery(id);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glBeginQuery: delimit the boundaries of a query object
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target type of query object established between Gl.BeginQuery and the subsequent Gl.EndQuery. The
        /// symbolic
        /// constant must be one of Gl.SAMPLES_PASSED, Gl.ANY_SAMPLES_PASSED, Gl.ANY_SAMPLES_PASSED_CONSERVATIVE,
        /// Gl.PRIMITIVES_GENERATED, Gl.TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or Gl.TIME_ELAPSED.
        /// </param>
        /// <param name="id">
        /// Specifies the name of a query object.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_occlusion_query")]
        public static void BeginQuery(QueryTarget target, uint id)
        {
            Debug.Assert(Delegates.pglBeginQuery != null, "pglBeginQuery not implemented");
            Delegates.pglBeginQuery((int) target, id);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glEndQuery: delimit the boundaries of a query object
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target type of query object established between Gl.BeginQuery and the subsequent Gl.EndQuery. The
        /// symbolic
        /// constant must be one of Gl.SAMPLES_PASSED, Gl.ANY_SAMPLES_PASSED, Gl.ANY_SAMPLES_PASSED_CONSERVATIVE,
        /// Gl.PRIMITIVES_GENERATED, Gl.TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or Gl.TIME_ELAPSED.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_occlusion_query")]
        public static void EndQuery(QueryTarget target)
        {
            Debug.Assert(Delegates.pglEndQuery != null, "pglEndQuery not implemented");
            Delegates.pglEndQuery((int) target);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetQueryiv: return parameters of a query object target
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies a query object target. Must be Gl.SAMPLES_PASSED, Gl.ANY_SAMPLES_PASSED,
        /// Gl.ANY_SAMPLES_PASSED_CONSERVATIVEGl.PRIMITIVES_GENERATED, Gl.TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, Gl.TIME_ELAPSED,
        /// or
        /// Gl.TIMESTAMP.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a query object target parameter. Accepted values are Gl.CURRENT_QUERY or
        /// Gl.QUERY_COUNTER_BITS.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_occlusion_query")]
        public static void GetQuery(QueryTarget target, QueryParameterName pname, [Out] int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetQueryiv != null, "pglGetQueryiv not implemented");
                    Delegates.pglGetQueryiv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetQueryiv: return parameters of a query object target
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies a query object target. Must be Gl.SAMPLES_PASSED, Gl.ANY_SAMPLES_PASSED,
        /// Gl.ANY_SAMPLES_PASSED_CONSERVATIVEGl.PRIMITIVES_GENERATED, Gl.TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, Gl.TIME_ELAPSED,
        /// or
        /// Gl.TIMESTAMP.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a query object target parameter. Accepted values are Gl.CURRENT_QUERY or
        /// Gl.QUERY_COUNTER_BITS.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_occlusion_query")]
        public static void GetQuery(QueryTarget target, QueryParameterName pname, out int @params)
        {
            unsafe
            {
                fixed (int* p_params = &@params)
                {
                    Debug.Assert(Delegates.pglGetQueryiv != null, "pglGetQueryiv not implemented");
                    Delegates.pglGetQueryiv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetQueryObjectiv: return parameters of a query object
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
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ARB_occlusion_query")]
        [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
        public static void GetQueryObject(uint id, QueryObjectParameterName pname, [Out] int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetQueryObjectiv != null, "pglGetQueryObjectiv not implemented");
                    Delegates.pglGetQueryObjectiv(id, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetQueryObjectiv: return parameters of a query object
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
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ARB_occlusion_query")]
        [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
        public static void GetQueryObject(uint id, QueryObjectParameterName pname, out int @params)
        {
            unsafe
            {
                fixed (int* p_params = &@params)
                {
                    Debug.Assert(Delegates.pglGetQueryObjectiv != null, "pglGetQueryObjectiv not implemented");
                    Delegates.pglGetQueryObjectiv(id, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetQueryObjectuiv: return parameters of a query object
        ///     </para>
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
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_occlusion_query")]
        public static void GetQueryObject(uint id, QueryObjectParameterName pname, [Out] uint[] @params)
        {
            unsafe
            {
                fixed (uint* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetQueryObjectuiv != null, "pglGetQueryObjectuiv not implemented");
                    Delegates.pglGetQueryObjectuiv(id, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetQueryObjectuiv: return parameters of a query object
        ///     </para>
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
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_occlusion_query")]
        public static void GetQueryObject(uint id, QueryObjectParameterName pname, out uint @params)
        {
            unsafe
            {
                fixed (uint* p_params = &@params)
                {
                    Debug.Assert(Delegates.pglGetQueryObjectuiv != null, "pglGetQueryObjectuiv not implemented");
                    Delegates.pglGetQueryObjectuiv(id, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glBindBuffer: bind a named buffer object
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound, which must be one of the buffer binding targets in the
        /// following table:
        /// </param>
        /// <param name="buffer">
        /// Specifies the name of a buffer object.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public static void BindBuffer(BufferTarget target, uint buffer)
        {
            Debug.Assert(Delegates.pglBindBuffer != null, "pglBindBuffer not implemented");
            Delegates.pglBindBuffer((int) target, buffer);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDeleteBuffers: delete named buffer objects
        ///     </para>
        /// </summary>
        /// <param name="buffers">
        /// Specifies an array of buffer objects to be deleted.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public static void DeleteBuffers(params uint[] buffers)
        {
            unsafe
            {
                fixed (uint* p_buffers = buffers)
                {
                    Debug.Assert(Delegates.pglDeleteBuffers != null, "pglDeleteBuffers not implemented");
                    Delegates.pglDeleteBuffers(buffers.Length, p_buffers);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGenBuffers: generate buffer object names
        ///     </para>
        /// </summary>
        /// <param name="buffers">
        /// Specifies an array in which the generated buffer object names are stored.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public static void GenBuffers(uint[] buffers)
        {
            unsafe
            {
                fixed (uint* p_buffers = buffers)
                {
                    Debug.Assert(Delegates.pglGenBuffers != null, "pglGenBuffers not implemented");
                    Delegates.pglGenBuffers(buffers.Length, p_buffers);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGenBuffers: generate buffer object names
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public static uint GenBuffer()
        {
            uint retValue;
            unsafe
            {
                Delegates.pglGenBuffers(1, &retValue);
            }

            DebugCheckErrors(null);
            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glIsBuffer: determine if a name corresponds to a buffer object
        ///     </para>
        /// </summary>
        /// <param name="buffer">
        /// Specifies a value that may be the name of a buffer object.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public static bool IsBuffer(uint buffer)
        {
            bool retValue;

            Debug.Assert(Delegates.pglIsBuffer != null, "pglIsBuffer not implemented");
            retValue = Delegates.pglIsBuffer(buffer);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glBufferData: creates and initializes a buffer object's data store
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound for Gl.BufferData, which must be one of the buffer binding
        /// targets in the following table:
        /// </param>
        /// <param name="size">
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Gl.L if no data is to be
        /// copied.
        /// </param>
        /// <param name="usage">
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be Gl.STREAM_DRAW, Gl.STREAM_READ,
        /// Gl.STREAM_COPY, Gl.STATIC_DRAW, Gl.STATIC_READ, Gl.STATIC_COPY, Gl.DYNAMIC_DRAW, Gl.DYNAMIC_READ, or Gl.DYNAMIC_COPY.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public static void BufferData(BufferTarget target, uint size, IntPtr data, BufferUsage usage)
        {
            Debug.Assert(Delegates.pglBufferData != null, "pglBufferData not implemented");
            Delegates.pglBufferData((int) target, size, data, (int) usage);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glBufferData: creates and initializes a buffer object's data store
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound for Gl.BufferData, which must be one of the buffer binding
        /// targets in the following table:
        /// </param>
        /// <param name="size">
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Gl.L if no data is to be
        /// copied.
        /// </param>
        /// <param name="usage">
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be Gl.STREAM_DRAW, Gl.STREAM_READ,
        /// Gl.STREAM_COPY, Gl.STATIC_DRAW, Gl.STATIC_READ, Gl.STATIC_COPY, Gl.DYNAMIC_DRAW, Gl.DYNAMIC_READ, or Gl.DYNAMIC_COPY.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public static void BufferData(BufferTarget target, uint size, object data, BufferUsage usage)
        {
            GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                BufferData(target, size, pin_data.AddrOfPinnedObject(), usage);
            }
            finally
            {
                pin_data.Free();
            }
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glBufferSubData: updates a subset of a buffer object's data store
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound for Gl.BufferSubData, which must be one of the buffer binding
        /// targets in the following table:
        /// </param>
        /// <param name="offset">
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </param>
        /// <param name="size">
        /// Specifies the size in bytes of the data store region being replaced.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public static void BufferSubData(BufferTarget target, IntPtr offset, uint size, IntPtr data)
        {
            Debug.Assert(Delegates.pglBufferSubData != null, "pglBufferSubData not implemented");
            Delegates.pglBufferSubData((int) target, offset, size, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glBufferSubData: updates a subset of a buffer object's data store
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound for Gl.BufferSubData, which must be one of the buffer binding
        /// targets in the following table:
        /// </param>
        /// <param name="offset">
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </param>
        /// <param name="size">
        /// Specifies the size in bytes of the data store region being replaced.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public static void BufferSubData(BufferTarget target, IntPtr offset, uint size, object data)
        {
            GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                BufferSubData(target, offset, size, pin_data.AddrOfPinnedObject());
            }
            finally
            {
                pin_data.Free();
            }
        }

        /// <summary>
        /// [GL4] glGetBufferSubData: returns a subset of a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound for Gl.GetBufferSubData, which must be one of the buffer
        /// binding targets in the following table:
        /// </param>
        /// <param name="offset">
        /// Specifies the offset into the buffer object's data store from which data will be returned, measured in bytes.
        /// </param>
        /// <param name="size">
        /// Specifies the size in bytes of the data store region being returned.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the location where buffer object data is returned.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public static void GetBufferSubData(BufferTarget target, IntPtr offset, uint size, IntPtr data)
        {
            Debug.Assert(Delegates.pglGetBufferSubData != null, "pglGetBufferSubData not implemented");
            Delegates.pglGetBufferSubData((int) target, offset, size, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetBufferSubData: returns a subset of a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound for Gl.GetBufferSubData, which must be one of the buffer
        /// binding targets in the following table:
        /// </param>
        /// <param name="offset">
        /// Specifies the offset into the buffer object's data store from which data will be returned, measured in bytes.
        /// </param>
        /// <param name="size">
        /// Specifies the size in bytes of the data store region being returned.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the location where buffer object data is returned.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public static void GetBufferSubData(BufferTarget target, IntPtr offset, uint size, object data)
        {
            GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                GetBufferSubData(target, offset, size, pin_data.AddrOfPinnedObject());
            }
            finally
            {
                pin_data.Free();
            }
        }

        /// <summary>
        /// [GL4] glMapBuffer: map all of a buffer object's data store into the client's address space
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound for Gl.MapBuffer, which must be one of the buffer binding
        /// targets in the following table:
        /// </param>
        /// <param name="access">
        /// Specifies the access policy for Gl.MapBuffer and Gl.MapNamedBuffer, indicating whether it will be possible to read
        /// from,
        /// write to, or both read from and write to the buffer object's mapped data store. The symbolic constant must be
        /// Gl.READ_ONLY, Gl.WRITE_ONLY, or Gl.READ_WRITE.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        [RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
        public static IntPtr MapBuffer(BufferTarget target, BufferAccess access)
        {
            IntPtr retValue;

            Debug.Assert(Delegates.pglMapBuffer != null, "pglMapBuffer not implemented");
            retValue = Delegates.pglMapBuffer((int) target, (int) access);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glUnmapBuffer: release the mapping of a buffer object's data store into the client's address space
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glUnmapBuffer: map a section of a buffer object's data store
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound for Gl.UnmapBuffer, which must be one of the buffer binding
        /// targets in the following table:
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        [RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
        public static bool UnmapBuffer(BufferTarget target)
        {
            bool retValue;

            Debug.Assert(Delegates.pglUnmapBuffer != null, "pglUnmapBuffer not implemented");
            retValue = Delegates.pglUnmapBuffer((int) target);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetBufferParameteriv: return parameters of a buffer object
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
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public static void GetBufferParameter(BufferTarget target, int value, [Out] int[] data)
        {
            unsafe
            {
                fixed (int* p_params = data)
                {
                    Debug.Assert(Delegates.pglGetBufferParameteriv != null, "pglGetBufferParameteriv not implemented");
                    Delegates.pglGetBufferParameteriv((int) target, value, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetBufferParameteriv: return parameters of a buffer object
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
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public static void GetBufferParameter(BufferTarget target, int value, out int data)
        {
            unsafe
            {
                fixed (int* p_params = &data)
                {
                    Debug.Assert(Delegates.pglGetBufferParameteriv != null, "pglGetBufferParameteriv not implemented");
                    Delegates.pglGetBufferParameteriv((int) target, value, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetBufferParameteriv: return parameters of a buffer object
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
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public static unsafe void GetBufferParameter(BufferTarget target, int value, [Out] int* data)
        {
            Debug.Assert(Delegates.pglGetBufferParameteriv != null, "pglGetBufferParameteriv not implemented");
            Delegates.pglGetBufferParameteriv((int) target, value, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetBufferParameteriv: return parameters of a buffer object
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
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        public static void GetBufferParameteri<T>(BufferTarget target, int value, out T data) where T : unmanaged
        {
            Debug.Assert(Delegates.pglGetBufferParameteriv != null, "pglGetBufferParameteriv not implemented");

            unsafe
            {
                T d = default;
                Delegates.pglGetBufferParameteriv((int) target, value, (int*) &d);
                data = d;
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetBufferPointerv: return the pointer to a mapped buffer object's data store
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound for Gl.GetBufferPointerv, which must be one of the buffer
        /// binding targets in the following table:
        /// </param>
        /// <param name="pname">
        /// Specifies the name of the pointer to be returned. Must be Gl.BUFFER_MAP_POINTER.
        /// </param>
        /// <param name="params">
        /// Returns the pointer value specified by <paramref name="pname" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        [RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
        public static void GetBufferPointer(BufferTarget target, int pname, out IntPtr @params)
        {
            unsafe
            {
                fixed (IntPtr* p_params = &@params)
                {
                    Debug.Assert(Delegates.pglGetBufferPointerv != null, "pglGetBufferPointerv not implemented");
                    Delegates.pglGetBufferPointerv((int) target, pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetBufferPointerv: return the pointer to a mapped buffer object's data store
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the buffer object is bound for Gl.GetBufferPointerv, which must be one of the buffer
        /// binding targets in the following table:
        /// </param>
        /// <param name="pname">
        /// Specifies the name of the pointer to be returned. Must be Gl.BUFFER_MAP_POINTER.
        /// </param>
        /// <param name="params">
        /// Returns the pointer value specified by <paramref name="pname" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_5")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_ARB_vertex_buffer_object")]
        [RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
        public static void GetBufferPointer(BufferTarget target, int pname, object @params)
        {
            GCHandle pin_params = GCHandle.Alloc(@params, GCHandleType.Pinned);
            try
            {
                GetBufferPointer(target, pname, pin_params.AddrOfPinnedObject());
            }
            finally
            {
                pin_params.Free();
            }
        }

        public static unsafe partial class Delegates
        {
            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_occlusion_query")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGenQueries(int n, uint* ids);

            [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_occlusion_query", EntryPoint = "glGenQueriesARB")] [ThreadStatic]
            public static glGenQueries pglGenQueries;

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_occlusion_query")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDeleteQueries(int n, uint* ids);

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_occlusion_query", EntryPoint = "glDeleteQueriesARB")]
            [ThreadStatic]
            public static glDeleteQueries pglDeleteQueries;

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_occlusion_query")]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.I1)]
            public delegate bool glIsQuery(uint id);

            [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_occlusion_query", EntryPoint = "glIsQueryARB")] [ThreadStatic]
            public static glIsQuery pglIsQuery;

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_occlusion_query")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBeginQuery(int target, uint id);

            [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_occlusion_query", EntryPoint = "glBeginQueryARB")] [ThreadStatic]
            public static glBeginQuery pglBeginQuery;

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_occlusion_query")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glEndQuery(int target);

            [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_occlusion_query", EntryPoint = "glEndQueryARB")] [ThreadStatic]
            public static glEndQuery pglEndQuery;

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_occlusion_query")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetQueryiv(int target, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_ARB_occlusion_query", EntryPoint = "glGetQueryivARB")] [ThreadStatic]
            public static glGetQueryiv pglGetQueryiv;

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_ARB_occlusion_query")]
            [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetQueryObjectiv(uint id, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_ARB_occlusion_query", EntryPoint = "glGetQueryObjectivARB")]
            [RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2", EntryPoint = "glGetQueryObjectivEXT")]
            [ThreadStatic]
            public static glGetQueryObjectiv pglGetQueryObjectiv;

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_occlusion_query")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetQueryObjectuiv(uint id, int pname, uint* @params);

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_occlusion_query", EntryPoint = "glGetQueryObjectuivARB")]
            [ThreadStatic]
            public static glGetQueryObjectuiv pglGetQueryObjectuiv;

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBindBuffer(int target, uint buffer);

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object", EntryPoint = "glBindBufferARB")]
            [ThreadStatic]
            public static glBindBuffer pglBindBuffer;

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glDeleteBuffers(int n, uint* buffers);

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object", EntryPoint = "glDeleteBuffersARB")]
            [ThreadStatic]
            public static glDeleteBuffers pglDeleteBuffers;

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGenBuffers(int n, uint* buffers);

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object", EntryPoint = "glGenBuffersARB")]
            [ThreadStatic]
            public static glGenBuffers pglGenBuffers;

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object")]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.I1)]
            public delegate bool glIsBuffer(uint buffer);

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object", EntryPoint = "glIsBufferARB")]
            [ThreadStatic]
            public static glIsBuffer pglIsBuffer;

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBufferData(int target, uint size, IntPtr data, int usage);

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object", EntryPoint = "glBufferDataARB")]
            [ThreadStatic]
            public static glBufferData pglBufferData;

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glBufferSubData(int target, IntPtr offset, uint size, IntPtr data);

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object", EntryPoint = "glBufferSubDataARB")]
            [ThreadStatic]
            public static glBufferSubData pglBufferSubData;

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetBufferSubData(int target, IntPtr offset, uint size, IntPtr data);

            [RequiredByFeature("GL_VERSION_1_5")] [RequiredByFeature("GL_ARB_vertex_buffer_object", EntryPoint = "glGetBufferSubDataARB")] [ThreadStatic]
            public static glGetBufferSubData pglGetBufferSubData;

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object")]
            [RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr glMapBuffer(int target, int access);

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object", EntryPoint = "glMapBufferARB")]
            [RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2", EntryPoint = "glMapBufferOES")]
            [ThreadStatic]
            public static glMapBuffer pglMapBuffer;

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object")]
            [RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.I1)]
            public delegate bool glUnmapBuffer(int target);

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object", EntryPoint = "glUnmapBufferARB")]
            [RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2", EntryPoint = "glUnmapBufferOES")]
            [ThreadStatic]
            public static glUnmapBuffer pglUnmapBuffer;

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetBufferParameteriv(int target, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object", EntryPoint = "glGetBufferParameterivARB")]
            [ThreadStatic]
            public static glGetBufferParameteriv pglGetBufferParameteriv;

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object")]
            [RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
            [SuppressUnmanagedCodeSecurity]
            public delegate void glGetBufferPointerv(int target, int pname, IntPtr* @params);

            [RequiredByFeature("GL_VERSION_1_5")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [RequiredByFeature("GL_ARB_vertex_buffer_object", EntryPoint = "glGetBufferPointervARB")]
            [RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2", EntryPoint = "glGetBufferPointervOES")]
            [ThreadStatic]
            public static glGetBufferPointerv pglGetBufferPointerv;
        }
    }
}