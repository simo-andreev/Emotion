﻿#region Using

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Emotion.Graphics;
using Emotion.Primitives;

#endregion

#nullable enable

namespace Emotion.Game.World2D
{
    public class WorldTree2DNode
    {
        public Rectangle Bounds;
        public int Capacity;
        public int MaxDepth;

        public WorldTree2DNode? Parent;
        public WorldTree2DNode[]? ChildNodes;

        // Node objects if undivided, and objects which span multiple nodes if divided.
        protected List<GameObject2D>? _objects;

        public WorldTree2DNode(WorldTree2DNode? parent, Rectangle bounds, int capacity = 3, int maxDepth = 5)
        {
            Parent = parent;
            Bounds = bounds;
            Capacity = capacity;
            MaxDepth = maxDepth;
        }

        public WorldTree2DNode GetNodeForBounds(Rectangle bounds)
        {
            if (ChildNodes == null) return this;

            for (var i = 0; i < ChildNodes.Length; i++)
            {
                WorldTree2DNode node = ChildNodes[i];
                if (node.Bounds.ContainsInclusive(bounds)) return node.GetNodeForBounds(bounds);
            }

            return this;
        }

        public WorldTree2DNode AddObject(Rectangle bounds, GameObject2D obj)
        {
            _objects ??= new List<GameObject2D>();
            if (_objects.Count + 1 > Capacity && ChildNodes == null && MaxDepth > 0)
            {
                float halfWidth = Bounds.Width / 2;
                float halfHeight = Bounds.Height / 2;

                ChildNodes = new WorldTree2DNode[4];
                ChildNodes[0] = new WorldTree2DNode(this, new Rectangle(Bounds.X, Bounds.Y, halfWidth, halfHeight), Capacity, MaxDepth - 1);
                ChildNodes[1] = new WorldTree2DNode(this, new Rectangle(Bounds.X + halfWidth, Bounds.Y, halfWidth, halfHeight), Capacity, MaxDepth - 1);
                ChildNodes[2] = new WorldTree2DNode(this, new Rectangle(Bounds.X, Bounds.Y + halfHeight, halfWidth, halfHeight), Capacity, MaxDepth - 1);
                ChildNodes[3] = new WorldTree2DNode(this, new Rectangle(Bounds.X + halfWidth, Bounds.Y + halfHeight, halfWidth, halfHeight), Capacity, MaxDepth - 1);

                WorldTree2DNode subNode = GetNodeForBounds(bounds);
                return subNode.AddObject(bounds, obj);
            }

            Debug.Assert(_objects.IndexOf(obj) == -1);
            _objects.Add(obj);
            return this;
        }

        public void RemoveObject(GameObject2D obj)
        {
            _objects?.Remove(obj);
        }

        public void AddObjectsIntersectingShape(IList list, IShape shape, QueryFlags queryFlags = 0)
        {
            if (_objects == null) return;

            for (var i = 0; i < _objects.Count; i++)
            {
                GameObject2D obj = _objects[i];
                Rectangle bounds = obj.GetBoundsForQuadTree();
                if (!shape.Intersects(ref bounds)) continue;
                if (queryFlags.HasFlag(QueryFlags.Unique) && list.Contains(obj)) continue;

                list.Add(obj);
            }

            if (ChildNodes == null) return;
            for (var i = 0; i < ChildNodes.Length; i++)
            {
                WorldTree2DNode node = ChildNodes[i];
                if (shape.Intersects(ref node.Bounds)) node.AddObjectsIntersectingShape(list, shape, queryFlags);
            }
        }

        public void RenderDebug(RenderComposer c)
        {
            c.RenderOutline(Bounds, Color.Blue);
            if (ChildNodes == null) return;
            for (var i = 0; i < ChildNodes.Length; i++)
            {
                WorldTree2DNode node = ChildNodes[i];
                node.RenderDebug(c);
            }
        }
    }
}