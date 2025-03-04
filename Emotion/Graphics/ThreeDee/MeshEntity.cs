﻿#region Using

using Emotion.Game.Animation3D;

#endregion

namespace Emotion.Graphics.ThreeDee
{
    /// <summary>
    /// A collection of meshes which make up one visual object.
    /// Not all of the meshes are always visible.
    /// </summary>
    public class MeshEntity
    {
        public string Name { get; set; }
        public float Scale { get; set; }
        public Mesh[] Meshes { get; set; }

        public SkeletalAnimation[] Animations { get; set; }
        public SkeletonAnimRigNode AnimationRig { get; set; }
    }
}