﻿#region Using

using Emotion.Editor.EditorHelpers;
using Emotion.Game.World3D;
using Emotion.Graphics.ThreeDee;

#endregion

namespace Emotion.Editor.EditorWindows.ModelViewerUtil
{
	public class MeshVisibleCheckboxListItem : EditorCheckboxListItem
	{
		public bool Checked
		{
			get => _visible;
			set
			{
				if (_visible == value) return;
				_visible = value;

				if (_obj.EntityMetaState != null)
					_obj.EntityMetaState.RenderMesh[_meshIndex] = value;
			}
		}

		public string Name { get; set; }

		protected bool _visible = true;
		protected GameObject3D _obj;
		protected Mesh _mesh;
		protected int _meshIndex;

		protected MeshVisibleCheckboxListItem(GameObject3D obj, Mesh mesh, int index)
		{
			Name = mesh.Name;
			_obj = obj;
			_mesh = mesh;
			_meshIndex = index;
		}

		public static EditorCheckboxListItem[] CreateItemsFromObject3D(GameObject3D obj)
		{
			MeshEntity entity = obj.Entity;
			Mesh[] meshes = entity?.Meshes ?? Array.Empty<Mesh>();

			var checkboxItemList = new EditorCheckboxListItem[meshes.Length];
			for (var i = 0; i < meshes.Length; i++)
			{
				Mesh mesh = meshes[i];
				checkboxItemList[i] = new MeshVisibleCheckboxListItem(obj, mesh, i);
			}

			return checkboxItemList;
		}
	}
}