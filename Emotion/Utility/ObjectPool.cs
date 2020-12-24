﻿#region Using

using System.Collections.Concurrent;
using System.Diagnostics;

#endregion

namespace Emotion.Utility
{
    public class ObjectPool<T> where T : new()
    {
        private readonly ConcurrentBag<T> _objects;

        public ObjectPool()
        {
            _objects = new ConcurrentBag<T>();
        }

        public T Get()
        {
            return _objects.TryTake(out T item) ? item : new T();
        }

        public void Return(T item)
        {
#if DEBUG
            foreach (T obj in _objects)
            {
                Debug.Assert(!obj.Equals(item));
            }
#endif

            _objects.Add(item);
        }
    }
}