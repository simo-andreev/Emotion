﻿#region Using

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Emotion.Common;

#endregion

namespace Emotion.UI
{
    public class UILoadingContext
    {
        public bool Running { get; protected set; }
        private List<Task> _loadingTasks = new List<Task>();

        public void AddLoadingTask(Task t)
        {
            if (t.IsCompleted) return;
            _loadingTasks.Add(t);
        }

        public async Task WaitForLoading()
        {
            Running = true;
            try
            {
                await Task.WhenAll(_loadingTasks);
            }
            catch (Exception ex)
            {
                Engine.Log.Error($"Window loading failed. {ex}", "UI");
            }

            Engine.Log.Info($"Loaded {_loadingTasks.Count} windows.", "UI");
            _loadingTasks.Clear();
            Running = false;
        }
    }
}