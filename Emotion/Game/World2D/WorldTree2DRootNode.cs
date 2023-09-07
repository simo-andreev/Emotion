﻿#nullable enable

#region Using

using Emotion.Game.World;

#endregion

namespace Emotion.Game.World2D
{
	public class WorldTree2DRootNode : WorldTree2DNode
	{
		protected Dictionary<BaseGameObject, WorldTree2DNode> _objToNode = new();

		public WorldTree2DRootNode(Rectangle bounds) : base(null, bounds)
		{
		}

		public void AddObjectToRoot(BaseGameObject obj)
		{
			Rectangle bounds = obj.GetBoundsForQuadTree();
			WorldTree2DNode node = GetNodeForBounds(bounds);
			node = node.AddObject(bounds, obj);

			// Crash prevention in error cases.
			if (_objToNode.ContainsKey(obj))
			{
				Assert(false, "Object already present in WorldTreeNode");
				return;
			}

			_objToNode.Add(obj, node);
		}

		public void RemoveObjectFromRoot(BaseGameObject obj)
		{
			if (!_objToNode.TryGetValue(obj, out WorldTree2DNode? node)) return;
			node.RemoveObject(obj);
			_objToNode.Remove(obj);
		}

		public WorldTree2DNode? GetNodeForObject(BaseGameObject obj)
		{
			_objToNode.TryGetValue(obj, out WorldTree2DNode? node);
			return node;
		}

		public void UpdateObject(BaseGameObject obj)
		{
			_objToNode.TryGetValue(obj, out WorldTree2DNode? node);
			AssertNotNull(node);

			Rectangle bounds = obj.GetBoundsForQuadTree();
			WorldTree2DNode newNode = GetNodeForBounds(bounds);
			if (newNode == node) return;

			// Remove from old node, and add to new.
			_objToNode.Remove(obj);
			node.RemoveObject(obj);
			newNode = newNode.AddObject(bounds, obj);
			_objToNode.Add(obj, newNode);
		}
	}
}