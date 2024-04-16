﻿#region Using

#endregion

#nullable enable

namespace Emotion.UI
{
    public enum MatrixSpecialFlag
    {
        None,
        RotateBoundsCenter,
        ScaleBoundsCenter,
        TranslationPositionReplace
    }

    /// <summary>
    /// A stack of 4x4 matrices. Each matrix pushed is multiplied by the last one in the stack.
    /// </summary>
    public sealed class NamedTransformationStack
    {
        /// <summary>
        /// Returns the top matrix.
        /// </summary>
        public Matrix4x4 CurrentMatrix { get; private set; } = Matrix4x4.Identity;

        /// <summary>
        /// Whether the matrix needs to be recalculated.
        /// </summary>
        public bool MatrixDirty { get; set; }

        private class MatrixWithId
        {
            public string Id;
            public Matrix4x4 Matrix;
            public bool ResetToIdentity;
            public MatrixSpecialFlag Flag = MatrixSpecialFlag.None;

            public MatrixWithId(Matrix4x4 mat, string id, bool reset)
            {
                Matrix = mat;
                Id = id;
                ResetToIdentity = reset;
            }
        }

        private List<MatrixWithId>? _stack;

        #region API

        /// <summary>
        /// Add or update a matrix in the stack.
        /// </summary>
        /// <param name="id">The id of the matrix.</param>
        /// <param name="matrix">The value of the matrix.</param>
        /// <param name="multiply">Whether to multiply the new matrix by the previous matrix.</param>
        /// <param name="flag">Special transformation to apply to the matrix when applying it to the UI window.</param>
        public void AddOrUpdate(string id, Matrix4x4 matrix, bool multiply = true, MatrixSpecialFlag flag = MatrixSpecialFlag.None)
        {
            _stack ??= new List<MatrixWithId>();

            MatrixWithId? matWithId = Get(id);
            if (matWithId != null)
            {
                matWithId.Matrix = matrix;
                matWithId.ResetToIdentity = !multiply;
                matWithId.Flag = flag;
            }
            else
            {
                matWithId = new MatrixWithId(matrix, id, !multiply);
                matWithId.Flag = flag;
                _stack.Add(matWithId);
            }

            MatrixDirty = true;
        }

        /// <summary>
        /// Get the matrix with the specified id.
        /// </summary>
        private MatrixWithId? Get(string id)
        {
            if (_stack == null) return null;

            for (var i = 0; i < _stack.Count; i++)
            {
                MatrixWithId matWithId = _stack[i];
                if (matWithId.Id == id) return matWithId;
            }

            return null;
        }

        /// <summary>
        /// Remove the matrix with the specified id.
        /// </summary>
        public void Remove(string id)
        {
            if (_stack == null) return;

            MatrixWithId? matWithId = Get(id);
            if (matWithId != null) _stack.Remove(matWithId);

            MatrixDirty = true;
        }

        /// <summary>
        /// Recalculate the current matrix. This should be done before getting CurrentMatrix when
        /// DirtyMatrix is true.
        /// </summary>
        public void RecalculateMatrix(float scale, Rectangle bounds, float z)
        {
            if (_stack == null)
            {
                CurrentMatrix = Matrix4x4.Identity;
                MatrixDirty = false;
                return;
            }

            Matrix4x4 mat = Matrix4x4.Identity;
            for (var i = 0; i < _stack.Count; i++)
            {
                MatrixWithId matWithId = _stack[i];
                if (matWithId.ResetToIdentity) mat = Matrix4x4.Identity;

                if (matWithId.Flag == MatrixSpecialFlag.RotateBoundsCenter ||
                    matWithId.Flag == MatrixSpecialFlag.ScaleBoundsCenter)
                {
                    var boundsCenter = bounds.Center / scale;
                    mat *= Matrix4x4.CreateTranslation(-boundsCenter.X, -boundsCenter.Y, -z) *
                           matWithId.Matrix *
                           Matrix4x4.CreateTranslation(boundsCenter.X, boundsCenter.Y, z);
                }
                else if (matWithId.Flag == MatrixSpecialFlag.TranslationPositionReplace)
                {
                    mat *= Matrix4x4.CreateTranslation(-bounds.X / scale, -bounds.Y / scale, 0) *
                           matWithId.Matrix;
                }
                else
                {
                    mat *= matWithId.Matrix;
                }
            }

            // Scale the matrix according to the UI scale.
            var scaleMatrix = Matrix4x4.CreateScale(scale, scale, 1f);
            CurrentMatrix = scaleMatrix.Inverted() * mat * scaleMatrix;
            MatrixDirty = false;
        }

        #endregion
    }
}