﻿#region Using

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Threading.Tasks;
using Emotion.Common;
using Emotion.Common.Serialization;
using Emotion.Graphics;
using Emotion.Primitives;

#endregion

#nullable enable

namespace Emotion.Game.World2D
{
    [Flags]
    public enum Map2DObjectFlags : uint
    {
        None = 0,

        UpdateWorldTree = 2 << 0,
        Serializable = 2 << 1,
    }

    public enum ObjectState : byte
    {
        None = 0,
        Loading = 1,
        Alive = 2,
        Destroyed = 3
    }

    public class GameObject2D : Transform
    {
        /// <summary>
        /// The object's name. Should be unique map-wide, but
        /// isn't actually enforced.
        /// </summary>
        public string ObjectName { get; set; }

        /// <summary>
        /// The object's multiplicative color tint.
        /// </summary>
        public Color Tint { get; set; } = Color.White;

        #region Runtime

        /// <summary>
        /// The map this object is in. Is set after Init.
        /// </summary>
        public Map2D? Map { get; protected set; }

        /// <summary>
        /// The object state, managed by the map in runtime.
        /// </summary>
        [DontSerialize]
        public ObjectState ObjectState { get; set; }

        /// <summary>
        /// Object flags managed by the map in runtime.
        /// </summary>
        [DontSerialize]
        public Map2DObjectFlags MapFlags { get; set; }

        #endregion

        public GameObject2D(string name)
        {
            ObjectName = name;
        }

        // Serialization constructor.
        protected GameObject2D()
        {
            ObjectName = null!;
        }

        /// <summary>
        /// Init game data. All changes from this process shouldn't be serialized.
        /// </summary>
        public virtual void Init(Map2D map)
        {
            Map = map;
        }

        /// <summary>
        /// Free any resources and cleanup.
        /// </summary>
        public virtual void Destroy()
        {
        }

        protected override void Moved()
        {
            base.Moved();
            Map?.InvalidateObjectBounds(this);
        }

        protected override void Resized()
        {
            base.Resized();
            Map?.InvalidateObjectBounds(this);
        }

        public bool IsPartOfMapLayer(int layer)
        {
            return true;
        }

        public virtual Rectangle GetBoundsForLayer(int layer)
        {
            return Bounds;
        }

        public virtual Task LoadAssetsAsync()
        {
            return Task.CompletedTask;
        }

        public virtual void Update(float dt)
        {
        }

        public virtual void Render(RenderComposer c)
        {
            c.RenderSprite(Position, Size, Color.White);
        }

        public virtual void PreMapEditorSave()
        {
            // you can prepare the obj for serialization here.
        }
    }

    [DontSerialize]
    public class WorldTree2D
    {
        private Dictionary<int, WorldTreeRootNode> _rootNodes = new();
        private Vector2 _mapSize;

        private List<GameObject2D> _objects = new();

        public WorldTree2D(Vector2 mapSize)
        {
            _mapSize = mapSize;
            AddTreeLayer(0);
        }

        public void AddTreeLayer(int layerId)
        {
            var newLayerTopNode = new WorldTreeRootNode(new Rectangle(0, 0, _mapSize));
            _rootNodes.Add(layerId, newLayerTopNode);

            for (var i = 0; i < _objects.Count; i++)
            {
                GameObject2D obj = _objects[i];
                if (obj.IsPartOfMapLayer(layerId)) newLayerTopNode.AddObject(obj);
            }
        }

        public void AddObjectToTree(GameObject2D obj)
        {
            _objects.Add(obj);
            foreach (KeyValuePair<int, WorldTreeRootNode> rootNode in _rootNodes)
            {
                if (obj.IsPartOfMapLayer(rootNode.Key)) rootNode.Value.AddObject(obj);
            }
        }

        public void RemoveObjectFromTree(GameObject2D obj)
        {
            if (!_objects.Remove(obj)) return;
            foreach (KeyValuePair<int, WorldTreeRootNode> rootNode in _rootNodes)
            {
                if (obj.IsPartOfMapLayer(rootNode.Key)) rootNode.Value.RemoveObject(obj);
            }
        }

        public void UpdateObjectInTree(GameObject2D obj)
        {
            foreach (KeyValuePair<int, WorldTreeRootNode> rootNode in _rootNodes)
            {
                if (obj.IsPartOfMapLayer(rootNode.Key)) rootNode.Value.UpdateObject(obj);
            }
        }
    }

    public class WorldTreeRootNode : WorldTreeNode
    {
        protected Dictionary<GameObject2D, WorldTreeNode> _objToNode = new();

        public WorldTreeRootNode(Rectangle bounds) : base(bounds)
        {
        }

        public void UpdateObject(GameObject2D obj)
        {
        }
    }

    public class WorldTreeNode
    {
        public Rectangle Bounds;

        public WorldTreeNode TopLeft
        {
            get => ChildNodes[0];
        }

        public WorldTreeNode TopRight
        {
            get => ChildNodes[1];
        }

        public WorldTreeNode BottomLeft
        {
            get => ChildNodes[2];
        }

        public WorldTreeNode BottomRight
        {
            get => ChildNodes[3];
        }

        public WorldTreeNode[] ChildNodes;

        // Contains all objects in the node and it's children nodes.
        protected List<GameObject2D>? _objects;

        public WorldTreeNode(Rectangle bounds)
        {
            Bounds = bounds;
            ChildNodes = new WorldTreeNode[4];
        }

        public void AddObject(GameObject2D obj)
        {
        }

        public void RemoveObject(GameObject2D obj)
        {
        }
    }

    public class Map2D
    {
        /// <summary>
        /// The name of the map. Not to be confused with the asset name carried by the XMLAsset.
        /// </summary>
        public string MapName { get; set; }

        /// <summary>
        /// The size of the map in map units.
        /// </summary>
        [SerializeNonPublicGetSet]
        public Vector2 MapSize { get; protected set; }

        /// <summary>
        /// Contains tile information, if the map has a tile map portion.
        /// </summary>
        public Map2DTileMapData? TileData;

        /// <summary>
        /// Whether the map is loaded and ready to be used.
        /// </summary>
        public bool Initialized { get; protected set; }

        /// <summary>
        /// This list is only used for saving and initializing the map, and is managed by the map itself.
        /// Do not modify!
        /// </summary>
        [SerializeNonPublicGetSet]
        public List<GameObject2D> ObjectsToSerialize { get; protected set; }

        /// <summary>
        /// List of labeled points on the map.
        /// </summary>
        [SerializeNonPublicGetSet]
        public Dictionary<string, Vector2> NamedPoints { get; protected set; }

        #region Runtime State

        /// <summary>
        /// Whether the map is currently open in the editor.
        /// </summary>
        [DontSerialize] public bool EditorMode = false;

        /// <summary>
        /// The area of the map to render. By default this is initialized to the
        /// area visible by the 2D camera.
        /// </summary>
        [DontSerialize] public Rectangle? Clip = null;

        // This list contains all runtime objects.
        protected List<GameObject2D> _objects { get; set; }

        /// <summary>
        /// Quad tree used to speed up queries.
        /// </summary>
        protected WorldTree2D? _worldTree;

        #endregion

        public Map2D(Vector2 size)
        {
            MapName = "New Map";
            MapSize = size;

            _objects = new List<GameObject2D>();
            ObjectsToSerialize = new List<GameObject2D>();
            NamedPoints = new Dictionary<string, Vector2>();
        }

        // Serialization constructor
        protected Map2D()
        {
            MapName = "";
            _objects = null!;
            ObjectsToSerialize = null!;
            NamedPoints = null!;
        }

        #region Init

        /// <summary>
        /// Initialize the map. This will create the map internal structures, load assets, and fill caches.
        /// </summary>
        public async Task InitAsync()
        {
            var profiler = Stopwatch.StartNew();

            _worldTree = InitWorldTree();

            var objectAssetTasks = new Task[ObjectsToSerialize.Count];
            for (var i = 0; i < ObjectsToSerialize.Count; i++)
            {
                GameObject2D obj = ObjectsToSerialize[i];

                objectAssetTasks[i] = obj.LoadAssetsAsync();
                obj.Init(this);
                _worldTree.AddObjectToTree(obj);
                obj.ObjectState = ObjectState.Alive;
                obj.MapFlags |= Map2DObjectFlags.Serializable;
                _objects.Add(obj);
            }

            if (TileData != null)
            {
                Debug.Assert((TileData.SizeInTiles * TileData.TileSize).SmallerOrEqual(MapSize), "Tiles outside map.");
                await TileData.LoadTileDataAsync();
            }

            await Task.WhenAll(objectAssetTasks);

            PostMapLoad();
            Initialized = true;

            Engine.Log.Info($"Map {MapName} loaded in {profiler.ElapsedMilliseconds}ms", "Map2D");
        }

        protected virtual WorldTree2D InitWorldTree()
        {
            return new WorldTree2D(MapSize);
        }

        protected virtual void PreMapLoad()
        {
            // todo
        }

        protected virtual void PostMapLoad()
        {
        }

        #endregion

        #region Object Management

        private ConcurrentQueue<GameObject2D> _objectsToAdd = new();
        private ConcurrentQueue<GameObject2D> _objectsToRemove = new();
        private ConcurrentQueue<GameObject2D> _objectsToUpdate = new();
        private List<(GameObject2D, Task)> _objectLoading = new();

        public void AddObject(GameObject2D obj)
        {
            _objectsToAdd.Enqueue(obj);
        }

        public void RemoveObject(GameObject2D obj)
        {
            _objectsToRemove.Enqueue(obj);
        }

        public void InvalidateObjectBounds(GameObject2D obj)
        {
            if (obj.MapFlags.HasFlag(Map2DObjectFlags.UpdateWorldTree)) return;
            _objectsToUpdate.Enqueue(obj);
            obj.MapFlags |= Map2DObjectFlags.UpdateWorldTree;
        }

        protected virtual void ProcessObjectChanges()
        {
            Debug.Assert(_worldTree != null);

            // Check if objects we're waiting to load, have loaded.
            for (int i = _objectLoading.Count - 1; i >= 0; i--)
            {
                (GameObject2D? obj, Task? loadingTask) = _objectLoading[i];
                if (!loadingTask.IsCompleted) continue;

                _objectLoading.RemoveAt(i);
                _objectsToAdd.Enqueue(obj);
            }

            // Check objects to add.
            while (_objectsToAdd.TryDequeue(out GameObject2D? obj))
            {
                // Check if the object requires loading, and put it in that state first.
                if (obj.ObjectState == ObjectState.None)
                {
                    Task loading = Task.Run(obj.LoadAssetsAsync);
                    if (!loading.IsCompleted)
                    {
                        obj.ObjectState = ObjectState.Loading;
                        _objectLoading.Add((obj, loading));
                        continue;
                    }
                }

                _objects.Add(obj);
                obj.Init(this);
                _worldTree.AddObjectToTree(obj);
                obj.ObjectState = ObjectState.Alive;

                // Objects added during runtime are added to the map's serialization if the flag is turned on, off by default.
                // This should technically only concern objects added by the editor.
                if (obj.MapFlags.HasFlag(Map2DObjectFlags.Serializable)) ObjectsToSerialize.Add(obj);
            }

            // Check for objects to remove.
            while (_objectsToRemove.TryDequeue(out GameObject2D? obj))
            {
                _objects.Remove(obj);
                obj.Destroy();
                _worldTree.RemoveObjectFromTree(obj);
                obj.ObjectState = ObjectState.Destroyed;
            }

            // Check for objects that have moved within the world tree.
            while (_objectsToUpdate.TryDequeue(out GameObject2D? obj))
            {
                if (obj.ObjectState == ObjectState.Destroyed) continue;
                _worldTree.UpdateObjectInTree(obj);
            }
        }

        /// <summary>
        /// Get an object from the map by name.
        /// </summary>
        public GameObject2D? GetObjectByName(string name)
        {
            foreach (GameObject2D obj in GetObjects())
            {
                if (obj.ObjectName == name) return obj;
            }

            return null;
        }

        #endregion

        #region Iteration

        public IEnumerable<GameObject2D> GetObjects()
        {
            for (var i = 0; i < _objects.Count; i++)
            {
                yield return _objects[i];
            }
        }

        #endregion

        public virtual void Update(float dt)
        {
            if (!Initialized) return;

            ProcessObjectChanges();

            // todo: obj update, clipped?
            foreach (GameObject2D obj in GetObjects())
            {
                obj.Update(dt);
            }
        }

        public virtual void Render(RenderComposer c)
        {
            if (!Initialized) return;

            Rectangle clipArea = Clip ?? c.Camera.GetWorldBoundingRect();
            TileData?.RenderTileMap(c, clipArea);

            // todo: render clip
            foreach (GameObject2D obj in GetObjects())
            {
                obj.Render(c);
            }
        }

        public void RenderDebugWorldTree(RenderComposer c)
        {
            c.RenderOutline(new Rectangle(0, 0, MapSize), Color.Red);
        }
    }
}