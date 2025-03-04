﻿#region Using

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Threading;
using Emotion.Primitives;

#endregion

namespace Emotion.Game.QuadTree
{
    /// <summary>
    /// A QuadTree Object that provides fast and efficient storage of objects in a world space.
    /// </summary>
    /// <typeparam name="T">Any object implementing Transform.</typeparam>
    public class QuadTreeNode<T> where T : IQuadTreeObject
    {
        /// <summary>
        /// The number of objects a node can contain before it subdivides.
        /// </summary>
        public readonly int NodeCapacity;

        /// <summary>
        /// Whether the node will cleanup and deallocate the four quadrants
        /// when empty.
        /// </summary>
        public bool CleanupWhenEmpty { get; set; } = false;

        /// <summary>
        /// Whether this node is allowed to subdivide.
        /// </summary>
        public bool CanSubdivide { get; protected set; } = true;

        /// <summary>
        /// The subdivision depth of this node.
        /// </summary>
        public int Depth { get; protected set; }

        /// <summary>
        /// The area this QuadTree represents.
        /// </summary>
        public Rectangle QuadRect
        {
            get => _quadRect;
        }

        protected Rectangle _quadRect; // Non auto-property so reference can be gotten.

        /// <summary>
        /// The top left child for this QuadTree
        /// </summary>
        public QuadTreeNode<T> TopLeftChild { get; private set; }

        /// <summary>
        /// The top right child for this QuadTree
        /// </summary>
        public QuadTreeNode<T> TopRightChild { get; private set; }

        /// <summary>
        /// The bottom left child for this QuadTree
        /// </summary>
        public QuadTreeNode<T> BottomLeftChild { get; private set; }

        /// <summary>
        /// The bottom right child for this QuadTree
        /// </summary>
        public QuadTreeNode<T> BottomRightChild { get; private set; }

        /// <summary>
        /// This QuadTree's parent
        /// </summary>
        public QuadTreeNode<T> Parent { get; }

        /// <summary>
        /// How many total objects are contained within this QuadTree (ie, includes children)
        /// </summary>
        public int Count
        {
            get => ObjectCount();
        }

        /// <summary>
        /// Returns true if this is a empty leaf node
        /// </summary>
        public bool EmptyLeaf
        {
            get => Count == 0 && TopLeftChild == null;
        }

        /// <summary>
        /// The objects in this QuadTree
        /// </summary>
        protected List<QuadTreeObject<T>> _objects;

        /// <summary>
        /// The number of queries currently running on this node.
        /// </summary>
        protected int _runningQueryCount;

        /// <summary>
        /// Creates a QuadTree for the specified area.
        /// </summary>
        /// <param name="rect">The area this QuadTree object will encompass.</param>
        /// <param name="nodeCapacity">The number of objects a node can contain before it subdivides.</param>
        protected QuadTreeNode(Rectangle rect, int nodeCapacity)
        {
            _quadRect = rect;
            NodeCapacity = nodeCapacity;
        }

        /// <summary>
        /// Creates a QuadTree for the specified area.
        /// </summary>
        /// <param name="x">The top-left position of the area rectangle.</param>
        /// <param name="y">The top-right position of the area rectangle.</param>
        /// <param name="width">The width of the area rectangle.</param>
        /// <param name="height">The height of the area rectangle.</param>
        /// <param name="nodeCapacity">The number of objects a node can contain before it subdivides.</param>
        protected QuadTreeNode(int x, int y, int width, int height, int nodeCapacity) : this(new Rectangle(x, y, width, height), nodeCapacity)
        {
        }

        protected QuadTreeNode(QuadTreeNode<T> parent, Rectangle rect) : this(rect, parent.NodeCapacity)
        {
            Parent = parent;
            Depth = parent.Depth + 1;
            if (Depth > 10) CanSubdivide = false;
        }

        /// <summary>
        /// Get the total for all objects in this QuadTree, including children.
        /// </summary>
        /// <returns>The number of objects contained within this QuadTree and its children.</returns>
        protected virtual int ObjectCount()
        {
            var count = 0;

            // Add the objects at this level
            if (_objects != null) count += _objects.Count;

            // Add the objects that are contained in the children
            if (TopLeftChild == null) return count;
            count += TopLeftChild.ObjectCount();
            count += TopRightChild.ObjectCount();
            count += BottomLeftChild.ObjectCount();
            count += BottomRightChild.ObjectCount();

            return count;
        }

        /// <summary>
        /// Clear the quad tree node and define a new rect for it.
        /// </summary>
        /// <param name="rect">The new quad rect.</param>
        public void Reset(Rectangle rect)
        {
            Clear();
            _quadRect = rect;
        }

        /// <summary>
        /// Clears the QuadTree of all objects, including any objects living in its children.
        /// </summary>
        public virtual void Clear()
        {
            // Clear out the children, if we have any
            if (TopLeftChild != null)
            {
                TopLeftChild.Clear();
                TopRightChild.Clear();
                BottomLeftChild.Clear();
                BottomRightChild.Clear();
            }

            // Clear any objects at this level
            if (_objects != null)
            {
                _objects.Clear();
                _objects = null;
            }

            // Set the children to null
            TopLeftChild = null;
            TopRightChild = null;
            BottomLeftChild = null;
            BottomRightChild = null;
        }

        /// <summary>
        /// Get the child quad that would contain the provided object bounds.
        /// </summary>
        [SuppressMessage("ReSharper", "ConvertIfStatementToReturnStatement")]
        protected QuadTreeNode<T> GetContainingChild(Rectangle bounds)
        {
            if (TopLeftChild.QuadRect.ContainsInclusive(bounds))
                return TopLeftChild;
            if (TopRightChild.QuadRect.ContainsInclusive(bounds))
                return TopRightChild;
            if (BottomLeftChild.QuadRect.ContainsInclusive(bounds))
                return BottomLeftChild;
            if (BottomRightChild.QuadRect.ContainsInclusive(bounds))
                return BottomRightChild;

            // If a child can't contain an object, it will live in this Quad
            return this;
        }

        /// <summary>
        /// Remove an item from the object list of this tree node.
        /// Will not remove empty nodes. Is called internally by the QuadTree
        /// </summary>
        /// <param name="item">The object to remove.</param>
        public void Remove(QuadTreeObject<T> item)
        {
            Debug.Assert(item.Owner == this);
            if (_objects == null) return;
            int removeIndex = _objects.IndexOf(item);
            if (removeIndex < 0) return;
            _objects[removeIndex] = _objects[^1];
            _objects.RemoveAt(_objects.Count - 1);
        }

        /// <summary>
        /// Remove empty leaves.
        /// </summary>
        public void RemoveEmptyLeavesUpwards()
        {
            if (TopLeftChild != null && CleanupWhenEmpty && TopLeftChild.EmptyLeaf && TopRightChild!.EmptyLeaf && BottomLeftChild!.EmptyLeaf && BottomRightChild!.EmptyLeaf)
            {
                TopLeftChild = null;
                TopRightChild = null;
                BottomLeftChild = null;
                BottomRightChild = null;
            }

            if (Parent != null && Count == 0)
                Parent.RemoveEmptyLeavesUpwards();
        }

        /// <summary>
        /// Insert an item into this QuadTree object.
        /// </summary>
        /// <param name="item">The item to insert.</param>
        protected void Insert(QuadTreeObject<T> item)
        {
            Rectangle bounds = item.Data.GetBoundsForQuadTree();

            // Can't subdivide, add to this level.
            if (!CanSubdivide)
            {
                InsertInternal(item);
            }
            // This object is outside of the QuadTree bounds, add it if at root level.
            else if (!QuadRect.ContainsInclusive(bounds) && Parent == null)
            {
                InsertInternal(item);
            }
            // If there's room to add the object, just add it
            else if (_objects == null || TopLeftChild == null && _objects.Count + 1 <= NodeCapacity)
            {
                InsertInternal(item);
            }
            else
            {
                // No quads, create them and bump objects down where appropriate
                if (TopLeftChild == null) Subdivide();

                // Find out which tree this object should go in and add it there
                QuadTreeNode<T> destTree = GetContainingChild(bounds);

                // If the item is already there, don't add it again.
                // This can happen when an out of bounds item is redirected due to a subdivision
                // or when an item is in between multiple children.
                if (item.Owner == destTree) return;

                if (destTree == this)
                    InsertInternal(item);
                else
                    destTree.Insert(item);
            }
        }

        private void InsertInternal(QuadTreeObject<T> item)
        {
            _objects ??= new List<QuadTreeObject<T>>();

            Debug.Assert(_objects.IndexOf(item) == -1);
            item.Owner = this;
            _objects.Add(item);
        }

        /// <summary>
        /// Subdivide this QuadTree and move it's children into the appropriate Quads where applicable.
        /// </summary>
        private void Subdivide()
        {
            Debug.Assert(_runningQueryCount == 0, "Quad tree node is subdividing while a query is running on it. Expect problems.");

            // We've reached capacity, subdivide...
            var size = new Vector2(QuadRect.Width / 2, QuadRect.Height / 2);
            var mid = new Vector2(QuadRect.X + size.X, QuadRect.Y + size.Y);

            TopLeftChild = new QuadTreeNode<T>(this, new Rectangle(QuadRect.X, QuadRect.Y, size.X, size.Y));
            TopRightChild = new QuadTreeNode<T>(this, new Rectangle(mid.X, QuadRect.Y, size.X, size.Y));
            BottomLeftChild = new QuadTreeNode<T>(this, new Rectangle(QuadRect.X, mid.Y, size.X, size.Y));
            BottomRightChild = new QuadTreeNode<T>(this, new Rectangle(mid.X, mid.Y, size.X, size.Y));

            // If they're completely contained by the quad, bump objects down
            for (var i = 0; i < _objects.Count; i++)
            {
                QuadTreeObject<T> obj = _objects[i];
                QuadTreeNode<T> destTree = GetContainingChild(obj.Data.GetBoundsForQuadTree());
                if (destTree == this) continue;

                // Insert to the appropriate tree, remove the object, and back up one in the loop
                Remove(obj);
                destTree.Insert(obj);
                i--;
            }
        }

        /// <summary>
        /// Moves the QuadTree object up the tree to wherever it should actually be.
        /// Should be called whenever an object moves to make sure the tree is consistent.
        /// </summary>
        public void Relocate(QuadTreeObject<T> item)
        {
            Debug.Assert(_runningQueryCount == 0, "Object is moving across nodes while a query is running on its node. Expect problems.");

            // Are we still inside our parent?
            // If there is no parent and the object isn't contained, that means it went out of our bounds and should join the parent.
            Rectangle bounds = item.Data.GetBoundsForQuadTree();
            if (QuadRect.ContainsInclusive(bounds) || Parent == null)
            {
                // Good, have we moved inside any of our children?
                if (TopLeftChild == null) return;
                QuadTreeNode<T> dest = GetContainingChild(bounds);
                if (item.Owner == dest) return;
                // Delete the item from its owner (which is either me or a child of mine) and add it to the child where it should be.
                // Note: Do NOT clean during this call, it can potentially delete our destination quad
                QuadTreeNode<T> formerOwner = item.Owner;
                formerOwner.Remove(item);
                dest.Insert(item);
                Debug.Assert(formerOwner != null || Parent == null);

                // Clean up the former owner manually.
                formerOwner.RemoveEmptyLeavesUpwards();
            }
            else
            {
                Parent.Relocate(item);
            }
        }

        #region Query

        /// <summary>
        /// Execute a query on the quad tree.
        /// </summary>
        /// <param name="query"></param>
        public void ExecuteQuery(QuadTreeQuery<T> query)
        {
            // We can't do anything if the results list doesn't exist
            if (query.Results == null) return;

#if DEBUG
            // Used to detect object changes while a query is running.
            Interlocked.Increment(ref _runningQueryCount);
#endif

            IShape searchArea = query.SearchArea;
            List<T> results = query.Results;

            if (searchArea.ContainsInclusive(ref _quadRect))
            {
                // If the search area completely contains this quad, just get every object in this quad and all its children
                GetAllObjects(results);
            }
            else if (searchArea.Intersects(ref _quadRect) || _quadRect == Rectangle.Empty)
            {
                // Otherwise, check intersections between the search area and the objects in this quad.
                if (_objects != null)
                    for (var i = 0; i < _objects.Count; i++)
                    {
                        T obj = _objects[i].Data;
                        Debug.Assert(results.IndexOf(obj) == -1, "QuadTree object found twice in query. Was it added twice?");
                        Rectangle bounds = obj.GetBoundsForQuadTree();
                        if (searchArea.Intersects(ref bounds)) results.Add(obj);
                    }

                // Search for objects in the children (if any)
                if (TopLeftChild != null)
                {
                    TopLeftChild.ExecuteQuery(query);
                    TopRightChild.ExecuteQuery(query);
                    BottomLeftChild.ExecuteQuery(query);
                    BottomRightChild.ExecuteQuery(query);
                }
            }

#if DEBUG
            Interlocked.Decrement(ref _runningQueryCount);
#endif
        }

        // Cached instance to prevent allocations.
        [ThreadStatic]
        private static QuadTreeQuery<T> _legacyMethodQuery;

        /// <summary>
        /// Get all objects in a bound. This is a legacy function, please use ExecuteQuery.
        /// </summary>
        public List<T> GetObjects<TBound>(TBound searchArea) where TBound : IShape
        {
            _legacyMethodQuery ??= new QuadTreeQuery<T>();
            _legacyMethodQuery.Results = new List<T>();
            _legacyMethodQuery.SearchArea = searchArea;
            ExecuteQuery(_legacyMethodQuery);
            return _legacyMethodQuery.Results;
        }

        /// <summary>
        /// Get all objects in a bound, and place them in a provided list (to prevent allocating one).
        /// This is a legacy function, please use ExecuteQuery.
        /// </summary>
        public void GetObjects<TBound>(TBound searchArea, List<T> results) where TBound : IShape
        {
            _legacyMethodQuery ??= new QuadTreeQuery<T>();
            _legacyMethodQuery.Results = results;
            _legacyMethodQuery.SearchArea = searchArea;
            ExecuteQuery(_legacyMethodQuery);
        }

        /// <summary>
        /// Get all objects in this Quad, and it's children.
        /// </summary>
        public List<T> GetAllObjects()
        {
            var l = new List<T>();
            GetAllObjects(l);
            return l;
        }

        /// <summary>
        /// Get all objects in this Quad, and it's children.
        /// </summary>
        /// <param name="results">A reference to a list in which to store the objects.</param>
        public virtual void GetAllObjects(List<T> results)
        {
            // If this Quad has objects, add them
            if (_objects != null)
                // ReSharper disable once LoopCanBeConvertedToQuery
                for (var i = 0; i < _objects.Count; i++)
                {
                    results.Add(_objects[i].Data);
                }

            // If we have children, get their objects too
            if (TopLeftChild == null) return;
            TopLeftChild.GetAllObjects(results);
            TopRightChild.GetAllObjects(results);
            BottomLeftChild.GetAllObjects(results);
            BottomRightChild.GetAllObjects(results);
        }

        #endregion
    }
}