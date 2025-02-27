﻿#nullable enable

using Emotion.Game.Animation3D;
using Emotion.Graphics.Data;
using Emotion.Graphics.ThreeDee;
using Emotion.IO;
using Emotion.Utility;
using OpenGL;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace Emotion.Standard.GLTF;

public static partial class GLTFFormat
{
    private const string BASE64_DATA_PREFIX = "data:application/gltf-buffer;base64,";
    private const bool MAKE_LEFT_HANDED = true;
    private const float ANIM_TIME_SCALE = 1000; // We expect them to be in seconds, but emotion works in ms.

    public static MeshEntity? Decode(string rootFolder, ReadOnlyMemory<byte> fileData)
    {
        GLTFDocument? gltfDoc = JsonSerializer.Deserialize<GLTFDocument>(fileData.Span);
        if (gltfDoc == null) return null;

        // Read all byte buffers
        GLTFBuffer[] buffers = gltfDoc.Buffers;
        for (int i = 0; i < buffers.Length; i++)
        {
            GLTFBuffer buffer = buffers[i];
            string uri = buffer.Uri;

            ReadOnlyMemory<byte> content;
            if (uri.StartsWith(BASE64_DATA_PREFIX))
            {
                // todo: Convert.FromBase64String that takes in a span to save an allocation here.
                uri = uri.Replace(BASE64_DATA_PREFIX, "");
                content = new ReadOnlyMemory<byte>(Convert.FromBase64String(uri));
            }
            else
            {
                // todo: ONE assetloader async
                uri = AssetLoader.GetNonRelativePath(rootFolder, uri);
                OtherAsset? byteAsset = Engine.AssetLoader.Get<OtherAsset>(uri, false);
                if (byteAsset == null)
                    content = ReadOnlyMemory<byte>.Empty;
                else
                    content = byteAsset.Content;
            }

            buffer.Data = content;
        }

        // Read animation rig
        GLTFNode[] gltfRig = gltfDoc.Nodes;
        SkeletonAnimRigNode[] rigNodes = new SkeletonAnimRigNode[gltfRig.Length];
        for (int i = 0; i < rigNodes.Length; i++)
        {
            rigNodes[i] = new SkeletonAnimRigNode();
        }

        for (int i = 0; i < gltfRig.Length; i++)
        {
            GLTFNode gltfRigItem = gltfRig[i];
            SkeletonAnimRigNode thisNode = rigNodes[i];
            thisNode.Name = gltfRigItem.Name;

            bool hasLocalTransform = gltfRigItem.Translation != null || gltfRigItem.Rotation != null || gltfRigItem.Scale != null;
            if (hasLocalTransform)
            {
                Matrix4x4 scaleMat = Matrix4x4.Identity;
                float[]? scale = gltfRigItem.Scale;
                if (scale != null)
                {
                    scaleMat = Matrix4x4.CreateScale(scale[0], scale[1], scale[2]);
                }

                Matrix4x4 rotMat = Matrix4x4.Identity;
                float[]? rot = gltfRigItem.Rotation;
                if (rot != null)
                {
                    Quaternion quart = new Quaternion(rot[0], rot[1], rot[2], rot[3]);
                    if (MAKE_LEFT_HANDED) quart.Z = -quart.Z;
                    rotMat = Matrix4x4.CreateFromQuaternion(quart);
                }

                Matrix4x4 transMat = Matrix4x4.Identity;
                float[]? trans = gltfRigItem.Translation;
                if (trans != null)
                {
                    Vector3 pos = new Vector3(trans[0], trans[1], trans[2]);
                    if (MAKE_LEFT_HANDED) pos.Z = -pos.Z;
                    transMat = Matrix4x4.CreateTranslation(pos);
                }

                thisNode.LocalTransform = scaleMat * rotMat * transMat;
            }

            // Attach as parent to my children.
            int[]? children = gltfRigItem.Children;
            if (children != null)
            {
                for (int cIdx = 0; cIdx < children.Length; cIdx++)
                {
                    int childIdx = children[cIdx];
                    rigNodes[childIdx].ParentIdx = i;
                }
            }
        }

        // Read animations
        SkeletalAnimation[] animations = Array.Empty<SkeletalAnimation>();
        if (gltfDoc.Animations != null)
        {
            animations = new SkeletalAnimation[gltfDoc.Animations.Length];
            for (int i = 0; i < gltfDoc.Animations.Length; i++)
            {
                GLTFAnimation gltfAnim = gltfDoc.Animations[i];
                GLTFAnimationChannel[] gltfChannels = gltfAnim.Channels;

                int nextChannelAlloc = 0;
                SkeletonAnimChannel[] channels = new SkeletonAnimChannel[gltfChannels.Length];
                float animDuration = 0;

                for (int c = 0; c < gltfChannels.Length; c++)
                {
                    GLTFAnimationChannel gltf = gltfChannels[c];
                    int samplerIdx = gltf.Sampler;
                    GLTFAnimationSampler sampler = gltfAnim.Samplers[samplerIdx];

                    bool dontInterpolate = false;
                    string? interpolationMode = sampler.Interpolation;
                    switch (interpolationMode)
                    {
                        case "LINEAR": // Lerp
                            break;
                        case "STEP": // Constant value until next keyframe
                            dontInterpolate = true;
                            break;
                        default:
                            Assert(false, $"Unknown sampler interpolation type {interpolationMode} in animation {gltfAnim.Name}");
                            break;
                    }

                    int timestampAccessorId = sampler.Input;
                    GLTFAccessor timestampAccessor = gltfDoc.Accessors[timestampAccessorId];
                    AccessorReader<float> timestampData = GetAccessorDataAsType<float>(gltfDoc, timestampAccessor);
                    for (int t = 0; t < timestampData.Count; t++)
                    {
                        float time = timestampData.ReadElement(t) * ANIM_TIME_SCALE;
                        animDuration = MathF.Max(animDuration, time);
                    }

                    int dataId = sampler.Output;
                    GLTFAccessor dataAccessor = gltfDoc.Accessors[dataId];

                    GLTFAnimationChannel.GLTFAnimationChannelTarget target = gltf.Target;
                    int nodeIdx = target.Node;
                    SkeletonAnimRigNode node = rigNodes[nodeIdx];

                    SkeletonAnimChannel? channel = null;
                    foreach (SkeletonAnimChannel existingChannel in channels)
                    {
                        if (existingChannel != null && existingChannel.Name == node.Name)
                        {
                            channel = existingChannel;
                            break;
                        }
                    }
                    if (channel == null)
                    {
                        channel = new SkeletonAnimChannel();
                        channel.Name = node.Name ?? string.Empty; // todo
                        channels[nextChannelAlloc] = channel;
                        nextChannelAlloc++;
                    }

                    string path = target.Path;
                    switch (path)
                    {
                        case "rotation":
                            {
                                AccessorReader<Vector4> samplerData = GetAccessorDataAsType<Vector4>(gltfDoc, dataAccessor);
                                MeshAnimBoneRotation[] rotations = new MeshAnimBoneRotation[samplerData.Count];
                                for (int s = 0; s < samplerData.Count; s++)
                                {
                                    Vector4 data = samplerData.ReadElement(s);
                                    if (MAKE_LEFT_HANDED)
                                    {
                                        data.X = -data.X;
                                        data.Y = -data.Y;
                                    }

                                    rotations[s] = new MeshAnimBoneRotation()
                                    {
                                        Rotation = new Quaternion(data.X, data.Y, data.Z, data.W),
                                        Timestamp = timestampData.ReadElement(s) * ANIM_TIME_SCALE,
                                        DontInterpolate = dontInterpolate
                                    };
                                }
                                channel.Rotations = rotations;
                                break;
                            }
                        case "translation":
                            {
                                AccessorReader<Vector3> samplerData = GetAccessorDataAsType<Vector3>(gltfDoc, dataAccessor);
                                MeshAnimBoneTranslation[] translations = new MeshAnimBoneTranslation[samplerData.Count];
                                for (int s = 0; s < samplerData.Count; s++)
                                {
                                    Vector3 data = samplerData.ReadElement(s);
                                    if (MAKE_LEFT_HANDED) data.Z = -data.Z;

                                    translations[s] = new MeshAnimBoneTranslation()
                                    {
                                        Position = data,
                                        Timestamp = timestampData.ReadElement(s) * ANIM_TIME_SCALE,
                                        DontInterpolate = dontInterpolate
                                    };
                                }
                                channel.Positions = translations;
                                break;
                            }
                        case "scale":
                            {
                                AccessorReader<Vector3> samplerData = GetAccessorDataAsType<Vector3>(gltfDoc, dataAccessor);
                                MeshAnimBoneScale[] scales = new MeshAnimBoneScale[samplerData.Count];
                                for (int s = 0; s < samplerData.Count; s++)
                                {
                                    Vector3 data = samplerData.ReadElement(s);

                                    scales[s] = new MeshAnimBoneScale()
                                    {
                                        Scale = data,
                                        Timestamp = timestampData.ReadElement(s) * ANIM_TIME_SCALE,
                                        DontInterpolate = dontInterpolate
                                    };
                                }
                                channel.Scales = scales;
                                break;
                            }
                        default:
                            Assert(false, $"Unknown channel path {path} in animation {gltfAnim.Name}");
                            break;
                    }
                }

                Array.Resize(ref channels, nextChannelAlloc);
                SkeletalAnimation anim = new SkeletalAnimation()
                {
                    Name = gltfAnim.Name,
                    AnimChannels = channels,
                    Duration = animDuration
                };
                animations[i] = anim;
            }
        }

        // Read images
        GLTFImage[] images = gltfDoc.Images ?? Array.Empty<GLTFImage>();
        Texture[] imagesRead = new Texture[images.Length];
        for (int i = 0; i < images.Length; i++)
        {
            GLTFImage image = images[i];
            string uri = image.Uri;

            uri = AssetLoader.NameToEngineName(uri);
            uri = AssetLoader.GetNonRelativePath(rootFolder, uri);
            TextureAsset? textureAsset = Engine.AssetLoader.Get<TextureAsset>(uri, false);
            if (textureAsset != null) textureAsset.Texture.Smooth = true; // todo

            imagesRead[i] = textureAsset == null ? Texture.EmptyWhiteTexture : textureAsset.Texture;
        }

        // Read materials
        GLTFMaterial[] gltfMaterials = gltfDoc.Materials ?? Array.Empty<GLTFMaterial>();
        MeshMaterial[] materials = new MeshMaterial[gltfMaterials.Length];
        for (int i = 0; i < gltfMaterials.Length; i++)
        {
            GLTFMaterial gltfMaterial = gltfMaterials[i];
            GLTFMaterial.GLTFPBRMetallicRoughness pbr = gltfMaterial.PBRMetallicRoughness;
            AssertNotNull(pbr);

            GLTFMaterial.GLTFBaseColorTexture baseColorTexture = pbr.BaseColorTexture;
            AssertNotNull(baseColorTexture);

            int textureIndex = baseColorTexture.Index;
            GLTFTexture texture = gltfDoc.Textures[textureIndex];
            GLTFImage image = images[texture.Source];
            string assetPath = AssetLoader.JoinPath(rootFolder, image.Uri);

            Texture imageRead = imagesRead[texture.Source];

            MeshMaterial material = new MeshMaterial()
            {
                Name = gltfMaterial.Name,
                DiffuseColor = Color.White,

                DiffuseTexture = imageRead,
                DiffuseTextureName = assetPath,
            };
            materials[i] = material;
        }

        // Read meshes
        GLTFMesh[] gltfMeshes = gltfDoc.Meshes;

        // Dirty hack/optimization
        // Sometimes the data is stored in a single buffer and accessed by each mesh.
        // This is actually better than what we do (which is to have separate buffers for each mesh)
        // and allows for all the meshes to be batched in a single draw call.
        // The reason they are still separate meshes is probably to be able to turn off/on each one
        // individually. Currently Emotion doesn't support having this one buffer (todo) so we should
        // trim the single buffer into many smaller ones to avoid each mesh carrying all the data.
        bool mappingIntoSingleBuffer = true;
        if (gltfMeshes.Length > 1)
        {
            GLTFMesh firstMesh = gltfMeshes[0];
            GLTFMeshPrimitives[] primitives = firstMesh.Primitives;
            GLTFMeshPrimitives primitive = primitives[0];
            Dictionary<string, int> attributes = primitive.Attributes;

            for (int m = 0; m < gltfMeshes.Length; m++)
            {
                GLTFMesh otherMesh = gltfMeshes[m];
                GLTFMeshPrimitives[] otherPrimitives = otherMesh.Primitives;
                GLTFMeshPrimitives otherPrimitive = otherPrimitives[0];
                Dictionary<string, int> otherAttributes = otherPrimitive.Attributes;
                foreach (KeyValuePair<string, int> attribute in otherAttributes)
                {
                    int accessor = attribute.Value;

                    bool success = attributes.TryGetValue(attribute.Key, out int firstMeshAccessor);
                    if (!success || accessor != firstMeshAccessor)
                    {
                        mappingIntoSingleBuffer = false;
                        break;
                    }
                }

                if (!mappingIntoSingleBuffer) break;
            }
        }
        else
        {
            mappingIntoSingleBuffer = false;
        }

        Mesh[] meshes = new Mesh[gltfMeshes.Length];
        for (int m = 0; m < gltfMeshes.Length; m++)
        {
            GLTFMesh gltfMesh = gltfMeshes[m];
            GLTFMeshPrimitives[] primitives = gltfMesh.Primitives;
            GLTFMeshPrimitives primitive = primitives[0]; // ??? What does it mean to have multiple
            Dictionary<string, int> attributes = primitive.Attributes;

            // Read indices
            GLTFAccessor indexAccessor = gltfDoc.Accessors[primitive.Indices];
            Assert(indexAccessor.Type == "SCALAR");
            ushort[] indices = new ushort[indexAccessor.Count];

            if (indexAccessor.ComponentType == Gl.UNSIGNED_BYTE)
            {
                ReadOnlyMemory<byte> indicesData = GetAccessorData(gltfDoc, indexAccessor);
                ReadOnlySpan<byte> indicesSpan = indicesData.Span;
                for (int idx = 0; idx < indicesSpan.Length; idx++)
                    indices[idx] = indicesSpan[idx];
            }
            else
            {
                Assert(indexAccessor.ComponentType == Gl.UNSIGNED_SHORT);
                ReadOnlyMemory<byte> indicesData = GetAccessorData(gltfDoc, indexAccessor);
                ReadOnlySpan<ushort> indicesAsUshort = MemoryMarshal.Cast<byte, ushort>(indicesData.Span);
                indicesAsUshort.CopyTo(indices);
            }

            // Determine vertex count from largest attribute
            bool isSkinned = false;
            int vertexCount = 0;
            foreach (KeyValuePair<string, int> attribute in attributes)
            {
                GLTFAccessor accessor = gltfDoc.Accessors[attribute.Value];
                vertexCount = Math.Max(vertexCount, accessor.Count);

                if (attribute.Key == "JOINTS_0" || attribute.Key == "WEIGHTS_0")
                    isSkinned = true;
            }

            // Split buffer if mapping into single buffer
            int vertexOffset = 0;
            if (mappingIntoSingleBuffer)
            {
                int smallestVertexUsed = vertexCount;
                int largestVertexUsed = 0;
                for (int i = 0; i < indices.Length; i++)
                {
                    ushort vIdx = indices[i];
                    if (vIdx > largestVertexUsed) largestVertexUsed = vIdx;
                    if (vIdx < smallestVertexUsed) smallestVertexUsed = vIdx;
                }

                vertexOffset = smallestVertexUsed;
                vertexCount = (largestVertexUsed - smallestVertexUsed) + 1;

                for (int i = 0; i < indices.Length; i++)
                {
                    ushort vIdx = indices[i];
                    indices[i] -= (ushort)vertexOffset;
                }
            }

            // Initialize vertices array
            VertexData[] vertices = new VertexData[vertexCount];
            VertexDataMesh3DExtra[] verticesExtraData = new VertexDataMesh3DExtra[vertexCount];
            for (int i = 0; i < vertices.Length; i++)
            {
                ref VertexData vert = ref vertices[i];
                vert.Color = Color.WhiteUint;
            }

            Mesh3DVertexDataBones[]? boneData = null;
            if (isSkinned)
            {
                boneData = new Mesh3DVertexDataBones[vertexCount];

                foreach (KeyValuePair<string, int> attribute in attributes)
                {
                    GLTFAccessor accessor = gltfDoc.Accessors[attribute.Value];
                    string attributeKey = attribute.Key;
                    switch (attributeKey)
                    {
                        case "POSITION":
                        case "NORMAL":
                            {
                                AccessorReader<Vector3> accessorData = GetAccessorDataAsType<Vector3>(gltfDoc, accessor);

                                for (int i = 0; i < vertexCount; i++)
                                {
                                    Vector3 pos = accessorData.ReadElement(vertexOffset + i);
                                    if (MAKE_LEFT_HANDED) pos.Z = -pos.Z;

                                    if (attributeKey == "POSITION")
                                    {
                                        ref VertexData vert = ref vertices[i];
                                        vert.Vertex = pos;
                                    }
                                    else if (attributeKey == "NORMAL")
                                    {
                                        ref VertexDataMesh3DExtra vert = ref verticesExtraData[i];
                                        vert.Normal = pos;
                                    }
                                }
                                break;
                            }
                        case "TEXCOORD_0":
                        case "TEXCOORD_1": // todo
                            {
                                AccessorReader<Vector2> accessorData = GetAccessorDataAsType<Vector2>(gltfDoc, accessor);

                                for (int i = 0; i < vertexCount; i++)
                                {
                                    Vector2 pos = accessorData.ReadElement(vertexOffset + i);

                                    if (attributeKey == "TEXCOORD_0")
                                    {
                                        ref VertexData vert = ref vertices[i];
                                        vert.UV = pos;
                                    }
                                }
                                break;
                            }
                        case "JOINTS_0":
                            {
                                AccessorReader<Vector4> accessorData = GetAccessorDataAsType<Vector4>(gltfDoc, accessor);

                                for (int i = 0; i < vertexCount; i++)
                                {
                                    Vector4 joints = accessorData.ReadElement(vertexOffset + i);

                                    ref Mesh3DVertexDataBones vert = ref boneData[i];
                                    vert.BoneIds = joints;
                                }
                                break;
                            }
                        case "WEIGHTS_0":
                            {
                                AccessorReader<Vector4> accessorData = GetAccessorDataAsType<Vector4>(gltfDoc, accessor);

                                for (int i = 0; i < vertexCount; i++)
                                {
                                    Vector4 weights = accessorData.ReadElement(vertexOffset + i);

                                    ref Mesh3DVertexDataBones vert = ref boneData[i];
                                    vert.BoneWeights = weights;
                                }
                                break;
                            }
                    }
                }
            }

            int materialIndex = primitive.Material;
            MeshMaterial material = materials.Length > 0 ? materials[materialIndex] : MeshMaterial.DefaultMaterial;

            Mesh mesh = new Mesh($"Mesh {m}", vertices, verticesExtraData, indices);
            mesh.Material = material;
            if (isSkinned) mesh.BoneData = boneData;
            meshes[m] = mesh;
        }

        GLTFSkins[] gltfSkins = gltfDoc.Skins ?? Array.Empty<GLTFSkins>();
        SkeletalAnimationSkin[] skins = new SkeletalAnimationSkin[gltfSkins.Length];
        for (int skinIdx = 0; skinIdx < gltfSkins.Length; skinIdx++)
        {
            GLTFSkins gltfSkin = gltfSkins[skinIdx];
            SkeletalAnimationSkin skin = new SkeletalAnimationSkin();
            skin.Name = gltfSkin.Name;

            int bindMatricesAccessorId = gltfSkin.InverseBindMatrices;
            GLTFAccessor bindMatrices = gltfDoc.Accessors[bindMatricesAccessorId];
            AccessorReader<Matrix4x4> bindMatrixData = GetAccessorDataAsType<Matrix4x4>(gltfDoc, bindMatrices);

            int[] gltfJoints = gltfSkin.Joints;
            var joints = new SkeletalAnimationSkinJoint[gltfJoints.Length];
            for (int jIdx = 0; jIdx < gltfJoints.Length; jIdx++)
            {
                ref SkeletalAnimationSkinJoint joint = ref joints[jIdx];
                int gltfJointId = gltfJoints[jIdx];
                joint.RigNodeIdx = gltfJointId;

                Matrix4x4 offsetMatrix = bindMatrixData.ReadElement(jIdx);
                if (MAKE_LEFT_HANDED)
                {
                    offsetMatrix.M13 *= -1;
                    offsetMatrix.M23 *= -1;
                    offsetMatrix.M43 *= -1;

                    offsetMatrix.M31 *= -1;
                    offsetMatrix.M32 *= -1;
                    offsetMatrix.M34 *= -1;
                }

                joint.OffsetMatrix = offsetMatrix;
            }

            skin.Joints = joints;
            skins[skinIdx] = skin;
        }

        MeshEntity entity = new MeshEntity()
        {
            Name = "Unknown Entity Name",
            LocalTransform = Matrix4x4.CreateRotationX(90 * Maths.DEG2_RAD), // Y up to Z up
            Meshes = meshes,
            AnimationRigOne = rigNodes,
            Animations = animations,
            AnimationSkins = skins
        };

        return entity;
    }

    private static ReadOnlyMemory<byte> GetAccessorData(GLTFDocument gltfDoc, GLTFAccessor accessor)
    {
        int bufferViewIdx = accessor.BufferView;
        GLTFBufferView bufferView = gltfDoc.BufferViews[bufferViewIdx];
        int bufferIdx = bufferView.Buffer;
        GLTFBuffer buffer = gltfDoc.Buffers[bufferIdx];
        ReadOnlyMemory<byte> data = buffer.Data;

        return data.Slice(bufferView.ByteOffset, bufferView.ByteLength).Slice(accessor.ByteOffset);
    }

    private static AccessorReader<T> GetAccessorDataAsType<T>(GLTFDocument gltfDoc, GLTFAccessor accessor) where T : unmanaged
    {
        string accessorType = accessor.Type;
        string requestedType = TypeToGlType<T>();

        // Type mismatch
        if (accessorType != requestedType) return AccessorReader<T>.Empty;

        int bufferViewIdx = accessor.BufferView;
        GLTFBufferView bufferView = gltfDoc.BufferViews[bufferViewIdx];

        int bufferIdx = bufferView.Buffer;
        GLTFBuffer buffer = gltfDoc.Buffers[bufferIdx];

        ReadOnlyMemory<byte> data = buffer.Data;
        ReadOnlyMemory<byte> dataInView = data.Slice(bufferView.ByteOffset, bufferView.ByteLength).Slice(accessor.ByteOffset);

        int componentType = accessor.ComponentType;
        AccessorReader<T> reader = new AccessorReader<T>
        {
            Data = dataInView,
            ReaderFunc = GetComponentReader(componentType),
            ComponentCount = GetComponentCount(accessorType),
            ComponentSize = GetComponentSize(componentType),
            Stride = Math.Max(bufferView.ByteStride, GetComponentCount(accessorType) * GetComponentSize(componentType)),
            Count = accessor.Count,
            Normalized = accessor.Normalized,
        };

        return reader;
    }

    public static int GetComponentSize(int componentType)
    {
        switch (componentType)
        {
            case Gl.FLOAT:
                return 4;
            case Gl.UNSIGNED_BYTE:
                return 1;
            case Gl.UNSIGNED_SHORT:
                return 2;
        }

        return 0;
    }

    public static int GetComponentCount(string type)
    {
        switch (type)
        {
            case "VEC4":
                return 4;
            case "VEC3":
                return 3;
            case "VEC2":
                return 2;
            case "SCALAR":
                return 1;
            case "MAT4":
                return 4 * 4;
        }

        return 0;
    }

    public static string TypeToGlType<T>() where T : unmanaged
    {
        if (typeof(T) == typeof(Vector4))
            return "VEC4";
        else if (typeof(T) == typeof(Vector3))
            return "VEC3";
        else if (typeof(T) == typeof(Vector2))
            return "VEC2";
        else if (typeof(T) == typeof(float))
            return "SCALAR";
        else if (typeof(T) == typeof(Matrix4x4))
            return "MAT4";

        return string.Empty;
    }

    public static Func<ReadOnlyMemory<byte>, bool, float> GetComponentReader(int componentType)
    {
        switch (componentType)
        {
            case Gl.FLOAT:
                return GLTFAccessorReadComponent<float>;
            case Gl.UNSIGNED_SHORT:
                return GLTFAccessorReadComponent<ushort>;
            case Gl.UNSIGNED_BYTE:
                return GLTFAccessorReadComponent<byte>;
        }

        return null!;
    }

    private static unsafe float GLTFAccessorReadComponent<TActualType>(ReadOnlyMemory<byte> data, bool normalize)
        where TActualType : unmanaged, INumber<TActualType>, IMinMaxValue<TActualType>
    {
        var span = data.Span;
        var spanActualType = MemoryMarshal.Cast<byte, TActualType>(span);
        TActualType actualTypeValue = spanActualType[0];

        float valAsFloat = (float)Convert.ChangeType(actualTypeValue, typeof(float));

        // Cast the number to a float and divide it by its max value to normalize it.
        if (normalize && typeof(TActualType) != typeof(float))
        {
            float valMax = (float)Convert.ChangeType(TActualType.MaxValue, typeof(float));
            valAsFloat = valAsFloat / valMax;
        }

        return valAsFloat;
    }
}
