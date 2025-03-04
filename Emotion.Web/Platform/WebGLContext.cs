﻿#region Using

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using Emotion.Common;
using Emotion.Platform;
using Emotion.Utility;
using Emotion.Web.Models;
using Microsoft.JSInterop;
using OpenGL;

#endregion

namespace Emotion.Web.Platform
{
    public unsafe class WebGLContext : GraphicsContext
    {
        private IJSUnmarshalledRuntime _gl;
        private Dictionary<string, Delegate> _webGlFuncDictionary = new Dictionary<string, Delegate>();
        private IntPtr _objectGenPtrHolder;

        // State
        private Dictionary<int, uint> _boundBuffers = new Dictionary<int, uint>(); // <Target, BufferId>
        private Dictionary<uint, int> _bufferUsage = new Dictionary<uint, int>(); // <BufferId, UsageType>
        private Dictionary<uint, BufferMappingState> _bufferMapping = new Dictionary<uint, BufferMappingState>(); // <BufferId, state>

        public WebGLContext(IJSUnmarshalledRuntime glContext)
        {
            Native = false;
            _gl = glContext;

            const int maxGenAtOnce = 5;
            _objectGenPtrHolder = UnmanagedMemoryAllocator.MemAlloc(sizeof(uint) * maxGenAtOnce);

            _webGlFuncDictionary.Add("glGetError", (Gl.Delegates.glGetError) GetError);
            _webGlFuncDictionary.Add("glGetString", (Gl.Delegates.glGetString) GetString);
            _webGlFuncDictionary.Add("glGetIntegerv", (Gl.Delegates.glGetIntegerv) GetInteger);
            _webGlFuncDictionary.Add("glGetFloatv", (Gl.Delegates.glGetFloatv) GetFloat);

            _webGlFuncDictionary.Add("glGenBuffers", (Gl.Delegates.glGenBuffers) GenBuffers);
            _webGlFuncDictionary.Add("glBindBuffer", (Gl.Delegates.glBindBuffer) BindBuffer);
            _webGlFuncDictionary.Add("glBufferData", (Gl.Delegates.glBufferData) BufferData);
            _webGlFuncDictionary.Add("glBufferSubData", (Gl.Delegates.glBufferSubData) BufferSubData);

            _webGlFuncDictionary.Add("glMapBuffer", (Gl.Delegates.glMapBuffer) MapBuffer);
            _webGlFuncDictionary.Add("glMapBufferRange", (Gl.Delegates.glMapBufferRange) MapBufferRange);
            _webGlFuncDictionary.Add("glUnmapBuffer", (Gl.Delegates.glUnmapBuffer) UnmapBuffer);
            _webGlFuncDictionary.Add("glFlushMappedBufferRange", (Gl.Delegates.glFlushMappedBufferRange) FlushMappedRange);

            _webGlFuncDictionary.Add("glClear", (Gl.Delegates.glClear) Clear);
            _webGlFuncDictionary.Add("glClearColor", (Gl.Delegates.glClearColor) SetClearColor);
            _webGlFuncDictionary.Add("glEnable", (Gl.Delegates.glEnable) Enable);
            _webGlFuncDictionary.Add("glDisable", (Gl.Delegates.glDisable) Disable);
            _webGlFuncDictionary.Add("glDepthFunc", (Gl.Delegates.glDepthFunc) DepthFunc);
            _webGlFuncDictionary.Add("glStencilMask", (Gl.Delegates.glStencilMask) StencilMask);
            _webGlFuncDictionary.Add("glStencilFunc", (Gl.Delegates.glStencilFunc) StencilFunc);
            _webGlFuncDictionary.Add("glStencilOp", (Gl.Delegates.glStencilOp) StencilOpF);
            _webGlFuncDictionary.Add("glBlendFuncSeparate", (Gl.Delegates.glBlendFuncSeparate) BlendFuncSeparate);
            _webGlFuncDictionary.Add("glViewport", (Gl.Delegates.glViewport) Viewport);

            _webGlFuncDictionary.Add("glCreateShader", (Gl.Delegates.glCreateShader) CreateShader);
            _webGlFuncDictionary.Add("glShaderSource", (Gl.Delegates.glShaderSource) ShaderSource);
            _webGlFuncDictionary.Add("glCompileShader", (Gl.Delegates.glCompileShader) CompileShader);
            _webGlFuncDictionary.Add("glGetShaderiv", (Gl.Delegates.glGetShaderiv) ShaderGetParam);
            _webGlFuncDictionary.Add("glGetShaderInfoLog", (Gl.Delegates.glGetShaderInfoLog) ShaderInfoLog);

            _webGlFuncDictionary.Add("glCreateProgram", (Gl.Delegates.glCreateProgram) CreateProgram);
            _webGlFuncDictionary.Add("glUseProgram", (Gl.Delegates.glUseProgram) UseProgram);
            _webGlFuncDictionary.Add("glAttachShader", (Gl.Delegates.glAttachShader) AttachShader);
            _webGlFuncDictionary.Add("glBindAttribLocation", (Gl.Delegates.glBindAttribLocation) BindAttributeLocation);
            _webGlFuncDictionary.Add("glLinkProgram", (Gl.Delegates.glLinkProgram) LinkProgram);
            _webGlFuncDictionary.Add("glGetProgramInfoLog", (Gl.Delegates.glGetProgramInfoLog) ProgramInfoLog);
            _webGlFuncDictionary.Add("glGetProgramiv", (Gl.Delegates.glGetProgramiv) ProgramGetParam);
            _webGlFuncDictionary.Add("glGetUniformLocation", (Gl.Delegates.glGetUniformLocation) GetUniformLocation);
            _webGlFuncDictionary.Add("glUniform1iv", (Gl.Delegates.glUniform1iv) UploadUniform);
            _webGlFuncDictionary.Add("glUniform1f", (Gl.Delegates.glUniform1f) UploadUniform);
            _webGlFuncDictionary.Add("glUniform2f", (Gl.Delegates.glUniform2f) UploadUniform);
            _webGlFuncDictionary.Add("glUniform1i", (Gl.Delegates.glUniform1i) UploadUniform);
            _webGlFuncDictionary.Add("glUniform3f", (Gl.Delegates.glUniform3f) UploadUniform);
            _webGlFuncDictionary.Add("glUniform4f", (Gl.Delegates.glUniform4f) UploadUniform);
            _webGlFuncDictionary.Add("glUniform1fv", (Gl.Delegates.glUniform1fv) UploadUniform);
            _webGlFuncDictionary.Add("glUniform2fv", (Gl.Delegates.glUniform2fv) UploadUniformFloatArrayMultiComponent2);
            _webGlFuncDictionary.Add("glUniform3fv", (Gl.Delegates.glUniform3fv) UploadUniformFloatArrayMultiComponent3);
            _webGlFuncDictionary.Add("glUniform4fv", (Gl.Delegates.glUniform4fv) UploadUniformFloatArrayMultiComponent4);
            _webGlFuncDictionary.Add("glUniformMatrix4fv", (Gl.Delegates.glUniformMatrix4fv) UploadUniformMat4);

            _webGlFuncDictionary.Add("glGenFramebuffers", (Gl.Delegates.glGenFramebuffers) CreateFramebuffer);
            _webGlFuncDictionary.Add("glBindFramebuffer", (Gl.Delegates.glBindFramebuffer) BindFramebuffer);
            _webGlFuncDictionary.Add("glFramebufferTexture2D", (Gl.Delegates.glFramebufferTexture2D) FramebufferUploadTexture2D);
            _webGlFuncDictionary.Add("glCheckFramebufferStatus", (Gl.Delegates.glCheckFramebufferStatus) FramebufferStatus);
            _webGlFuncDictionary.Add("glDrawBuffers", (Gl.Delegates.glDrawBuffers) DrawBuffers);

            _webGlFuncDictionary.Add("glGenVertexArrays", (Gl.Delegates.glGenVertexArrays) GenVertexArrays);
            _webGlFuncDictionary.Add("glBindVertexArray", (Gl.Delegates.glBindVertexArray) BindVertexArray);
            _webGlFuncDictionary.Add("glEnableVertexAttribArray", (Gl.Delegates.glEnableVertexAttribArray) EnableVertexAttribArray);
            _webGlFuncDictionary.Add("glVertexAttribPointer", (Gl.Delegates.glVertexAttribPointer) VertexAttribPointer);

            _webGlFuncDictionary.Add("glDrawElements", (Gl.Delegates.glDrawElements) DrawElements);
            _webGlFuncDictionary.Add("glDrawArrays", (Gl.Delegates.glDrawArrays) DrawArrays);

            _webGlFuncDictionary.Add("glFenceSync", (Gl.Delegates.glFenceSync) FenceSync);
            _webGlFuncDictionary.Add("glClientWaitSync", (Gl.Delegates.glClientWaitSync) ClientWaitSync);

            _webGlFuncDictionary.Add("glGenTextures", (Gl.Delegates.glGenTextures) CreateTexture);
            _webGlFuncDictionary.Add("glBindTexture", (Gl.Delegates.glBindTexture) BindTexture);
            _webGlFuncDictionary.Add("glActiveTexture", (Gl.Delegates.glActiveTexture) ActiveTexture);
            _webGlFuncDictionary.Add("glTexImage2D", (Gl.Delegates.glTexImage2D) UploadTexture);
            _webGlFuncDictionary.Add("glTexParameteri", (Gl.Delegates.glTexParameteri) TexParameterInteger);

            _webGlFuncDictionary.Add("glGenRenderbuffers", (Gl.Delegates.glGenRenderbuffers) CreateRenderbuffer);
            _webGlFuncDictionary.Add("glBindRenderbuffer", (Gl.Delegates.glBindRenderbuffer) BindRenderbuffer);
            _webGlFuncDictionary.Add("glRenderbufferStorage", (Gl.Delegates.glRenderbufferStorage) RenderbufferStorage);
            _webGlFuncDictionary.Add("glFramebufferRenderbuffer", (Gl.Delegates.glFramebufferRenderbuffer) FramebufferRenderbuffer);

            Valid = true;
        }

        protected override void SetSwapIntervalPlatform(int interval)
        {
            // Have no control over
        }

        public override void MakeCurrent()
        {
            // Always current
        }

        public override void SwapBuffers()
        {
            // Have no control over.
        }

        // Unused
        public override IntPtr GetProcAddress(string func)
        {
            return IntPtr.Zero;
        }

        public override Delegate GetProcAddressNonNative(string func)
        {
            if (_webGlFuncDictionary.ContainsKey(func))
                //Engine.Log.Trace($"Returning func {func}", "");
                return _webGlFuncDictionary[func];

            //Engine.Log.Trace($"Missing WebGL function {func}", "WebGL");
            return base.GetProcAddressNonNative(func);
        }

        private int GetError()
        {
            return _gl.InvokeUnmarshalled<int>("glGetError");
        }

        private IntPtr GetString(int paramId)
        {
            var stringGetMemoryName = $"glGetString{paramId}";

            // Check if already gotten and allocated memory for it.
            IntPtr ptr = UnmanagedMemoryAllocator.GetNamedMemory(stringGetMemoryName, out int _);
            if (ptr != IntPtr.Zero) return ptr;

            // Extensions are gotten from another function.
            string value;
            if (paramId == (int) StringName.Extensions)
                value = _gl.InvokeUnmarshalled<string>("GetGLExtensions");
            else
                value = _gl.InvokeUnmarshalled<int, string>("glGet", paramId);

            //Engine.Log.Trace($"String query {(StringName) paramId} got {value}", "WebGLInternal");
            ptr = NativeHelpers.StringToPtr(value);
            UnmanagedMemoryAllocator.RegisterAllocatedMemory(ptr, stringGetMemoryName, value.Length * sizeof(char));
            return ptr;
        }

        private void GetInteger(int paramId, int* data)
        {
            int[] value = _gl.InvokeUnmarshalled<int, int[]>("glGet", paramId);
            //Engine.Log.Trace($"Integer query {(GetPName) paramId} got {string.Join(", ", value)}", "WebGLInternal");
            Marshal.Copy(value, 0, (IntPtr) data, value.Length);
        }

        private void GetFloat(int paramId, float* data)
        {
            float[] value = _gl.InvokeUnmarshalled<int, float[]>("glGet", paramId);
            //Engine.Log.Trace($"Float query {(GetPName) paramId} got {string.Join(", ", value)}", "WebGLInternal");
            Marshal.Copy(value, 0, (IntPtr) data, value.Length);
        }

        private void GenBuffers(int count, uint* resp)
        {
            uint[] value = _gl.InvokeUnmarshalled<int, uint[]>("glGenBuffers", count);
            for (var i = 0; i < value.Length; i++)
            {
                Marshal.WriteInt64((IntPtr) (resp + i * sizeof(uint)), value[i]);
            }
        }

        private void BindBuffer(int target, uint bufferId)
        {
            _gl.InvokeUnmarshalled<int, uint, object>("glBindBuffer", target, bufferId);

            if (_boundBuffers.ContainsKey(target))
                _boundBuffers[target] = bufferId;
            else
                _boundBuffers.Add(target, bufferId);
        }

        private void BufferData(int target, uint size, IntPtr ptr, int usage)
        {
            _boundBuffers.TryGetValue(target, out uint boundBuffer);
            var memoryName = $"DataBuffer{target}|{boundBuffer}";
            if (ptr == IntPtr.Zero)
            {
                ptr = UnmanagedMemoryAllocator.MemAllocOrReAllocNamed((int) size, memoryName);
            }
            else
            {
                // Pointer passed from outside. Copy its data.
                IntPtr allocatedMemory = UnmanagedMemoryAllocator.MemAllocOrReAllocNamed((int) size, memoryName);
                NativeHelpers.MemCopy(ptr, allocatedMemory, (int) size);
                ptr = allocatedMemory;
            }

            if (usage != -1)
                _bufferUsage[boundBuffer] = usage;
            else
                usage = _bufferUsage[boundBuffer];

            var args = new BufferDataArgs
            {
                Usage = usage,
                SizeWholeBuffer = size,
                Ptr = ptr,
                Target = target,
                Offset = 0,
                Length = size
            };
            _gl.InvokeUnmarshalled<BufferDataArgs, object>("glBufferData", args);
        }

        private void BufferSubData(int target, IntPtr offset, uint size, IntPtr ptr)
        {
            _boundBuffers.TryGetValue(target, out uint boundBuffer);
            var memoryName = $"DataBuffer{target}|{boundBuffer}";
            var offsetInt = (int) offset;

            // It is assumed that the offset and size are valid per the already allocated buffer.
            // Check just in case.
            IntPtr wholeBuffer = UnmanagedMemoryAllocator.GetNamedMemory(memoryName, out int allocatedSize);
            if (offsetInt + size > allocatedSize)
            {
                Engine.Log.Error($"Invalid uploading sub data of {boundBuffer} in range {offsetInt}:{size}. Buffer is {allocatedSize} long.", "WebGLInternal");
                return;
            }

            // Update driver copy, in case of mapping. This could potentially be useless as mapping might not be used.
            NativeHelpers.MemCopy(ptr, IntPtr.Add(wholeBuffer, offsetInt), (int) size);

            var args = new BufferDataArgs
            {
                Ptr = ptr,
                Target = target,
                Offset = offsetInt,
                Length = size
            };
            _gl.InvokeUnmarshalled<BufferDataArgs, object>("glBufferSubData", args);
        }

        private IntPtr MapBuffer(int target, int access)
        {
            _boundBuffers.TryGetValue(target, out uint boundBuffer);
            var memoryName = $"DataBuffer{target}|{boundBuffer}";
            IntPtr memory = UnmanagedMemoryAllocator.GetNamedMemory(memoryName, out int bufferSize);

            _bufferMapping.TryGetValue(boundBuffer, out BufferMappingState state);
            if (state == null)
            {
                state = new BufferMappingState();
                _bufferMapping.Add(boundBuffer, state);
            }

            state.Mapping = true;
            state.RangeStart = 0;
            state.RangeLength = bufferSize;

            return memory;
        }

        private IntPtr MapBufferRange(int target, IntPtr offset, uint length, uint access)
        {
            _boundBuffers.TryGetValue(target, out uint boundBuffer);
            var memoryName = $"DataBuffer{target}|{boundBuffer}";
            IntPtr memory = UnmanagedMemoryAllocator.GetNamedMemory(memoryName, out int _);

            _bufferMapping.TryGetValue(boundBuffer, out BufferMappingState state);
            if (state == null)
            {
                state = new BufferMappingState();
                _bufferMapping.Add(boundBuffer, state);
            }

            state.Mapping = true;
            state.RangeStart = (int) offset;
            state.RangeLength = (int) length;

            //Engine.Log.Info($"Starting map range of buffer {boundBuffer} in range {offset}:{length}", "WebGLInternal");

            return memory + state.RangeStart;
        }

        private bool UnmapBuffer(int target)
        {
            _boundBuffers.TryGetValue(target, out uint boundBuffer);
            var memoryName = $"DataBuffer{target}|{boundBuffer}";
            IntPtr memory = UnmanagedMemoryAllocator.GetNamedMemory(memoryName, out int size);

            _bufferMapping.TryGetValue(boundBuffer, out BufferMappingState state);
            if (state == null || !state.Mapping) return true;
            state.Mapping = false;
            state.RangeStart = 0;
            state.RangeLength = 0;

            //Engine.Log.Info($"Flushing buffer {boundBuffer}");

            var args = new BufferDataArgs
            {
                //Usage = _bufferUsage[boundBuffer],
                //SizeWholeBuffer = (uint) bufferSize,
                Ptr = memory,
                Target = target,
                Offset = 0,
                Length = (uint) size
            };
            _gl.InvokeUnmarshalled<BufferDataArgs, object>("glBufferSubData", args);
            return true;
        }

        private void FlushMappedRange(int target, IntPtr offset, uint length)
        {
            _boundBuffers.TryGetValue(target, out uint boundBuffer);
            var memoryName = $"DataBuffer{target}|{boundBuffer}";
            IntPtr ptr = UnmanagedMemoryAllocator.GetNamedMemory(memoryName, out int _);

            _bufferMapping.TryGetValue(boundBuffer, out BufferMappingState state);
            if (state == null || !state.Mapping) return;
            int bufferStart = (int) offset + state.RangeStart;
            state.Mapping = false;
            state.RangeStart = 0;
            state.RangeLength = 0;

            //Engine.Log.Infoe($"Flushing buffer {boundBuffer} in range {offset}:{length}");
            //if (target == (int) BufferTarget.ArrayBuffer)
            //{
            //    var test = new Span<VertexData>((void*)(ptr + (int)offset), (int) length / VertexData.SizeInBytes);
            //    for (var i = 0; i < test.Length; i++)
            //    {
            //        Console.Write(test[i].Vertex + ", ");
            //    }
            //    Console.Write("\n");
            //}
            //else if (target == (int) BufferTarget.ElementArrayBuffer)
            //{
            //    var test = new Span<ushort>((void*)(ptr + (int)offset), (int) length / sizeof(ushort));
            //    for (var i = 0; i < test.Length; i++)
            //    {
            //        Console.Write(test[i] + ", ");
            //    }
            //    Console.Write("\n");
            //}

            var args = new BufferDataArgs
            {
                //Usage = _bufferUsage[boundBuffer],
                //SizeWholeBuffer = (uint) bufferSize,
                Ptr = ptr + bufferStart,
                Target = target,
                Offset = bufferStart,
                Length = length
            };
            _gl.InvokeUnmarshalled<BufferDataArgs, object>("glBufferSubData", args);
        }

        private void Clear(uint mask)
        {
            _gl.InvokeUnmarshalled<uint, object>("glClear", mask);
        }

        private void SetClearColor(float r, float g, float b, float a)
        {
            _gl.InvokeUnmarshalled<Vector4, object>("glClearColor", new Vector4(r, g, b, a));
        }

        private void Enable(int feature)
        {
            _gl.InvokeUnmarshalled<int, object>("glEnable", feature);
        }

        private void Disable(int feature)
        {
            _gl.InvokeUnmarshalled<int, object>("glDisable", feature);
        }

        private void DepthFunc(int funcId)
        {
            _gl.InvokeUnmarshalled<int, object>("glDepthFunc", funcId);
        }

        private void StencilMask(uint maskType)
        {
            _gl.InvokeUnmarshalled<uint, object>("glStencilMask", maskType);
        }

        private void StencilFunc(int funcId, int refV, uint mask)
        {
            _gl.InvokeUnmarshalled<int, int, uint, object>("glStencilFunc", funcId, refV, mask);
        }

        private void StencilOpF(int fail, int zFail, int pass)
        {
            _gl.InvokeUnmarshalled<int, int, int, object>("glStencilOp", fail, zFail, pass);
        }

        private void Viewport(int x, int y, int width, int height)
        {
            var param = new IntegerVector4
            {
                X = x,
                Y = y,
                Z = width,
                W = height
            };
            _gl.InvokeUnmarshalled<IntegerVector4, object>("glViewport", param);
        }

        private void BlendFuncSeparate(int srcRgb, int dstRgb, int srcAlpha, int dstAlpha)
        {
            var param = new IntegerVector4
            {
                X = srcRgb,
                Y = dstRgb,
                Z = srcAlpha,
                W = dstAlpha
            };
            _gl.InvokeUnmarshalled<IntegerVector4, object>("glBlendFuncSeparate", param);
        }

        private uint CreateShader(int type)
        {
            return _gl.InvokeUnmarshalled<int, uint>("glCreateShader", type);
        }

        private void ShaderSource(uint shader, int count, string[] data, int* length)
        {
            string shaderSource = data.Length > 1 ? string.Join(' ', data) : data[0];
            _gl.InvokeUnmarshalled<uint, string, object>("glShaderSource", shader, shaderSource);
        }

        private void CompileShader(uint shader)
        {
            _gl.InvokeUnmarshalled<uint, object>("glCompileShader", shader);
        }

        private void ShaderGetParam(uint shader, int paramId, int* data)
        {
            int[] value;

            // Unsupported in WebGL. Invent a number if the shader compiled unsuccessfully, otherwise return 0 (for no log).
            if (paramId == (int) ShaderParameterName.InfoLogLength)
            {
                value = _gl.InvokeUnmarshalled<uint, int, int[]>("glGetShaderParam", shader, (int) ShaderParameterName.CompileStatus);
                if (value == null || value[0] == 1)
                {
                    *data = 0;
                    return;
                }

                // Dummy size.
                *data = 1024 * 4;
                return;
            }

            value = _gl.InvokeUnmarshalled<uint, int, int[]>("glGetShaderParam", shader, paramId);
            //Engine.Log.Trace($"Shader query {(ShaderParameterName) paramId} got {string.Join(", ", value)}", "WebGLInternal");
            Marshal.Copy(value, 0, (IntPtr) data, value.Length);
        }

        private void ShaderInfoLog(uint shaderId, int bufSize, int* length, StringBuilder logData)
        {
            string log = _gl.InvokeUnmarshalled<uint, string>("glGetShaderInfo", shaderId);
            *length = log.Length;
            if (log.Length == 0) return;
            logData.Append(log, 0, Math.Min(log.Length, bufSize));
        }

        private uint CreateProgram()
        {
            return _gl.InvokeUnmarshalled<uint>("glCreateProgram");
        }

        private void UseProgram(uint programId)
        {
            _gl.InvokeUnmarshalled<uint, object>("glUseProgram", programId);
        }

        private void AttachShader(uint program, uint shader)
        {
            _gl.InvokeUnmarshalled<uint, uint, object>("glAttachShader", program, shader);
        }

        private void BindAttributeLocation(uint program, uint index, string name)
        {
            _gl.InvokeUnmarshalled<uint, uint, string, object>("glBindAttribLocation", program, index, name);
        }

        private void LinkProgram(uint program)
        {
            _gl.InvokeUnmarshalled<uint, object>("glLinkProgram", program);
        }

        private void ProgramInfoLog(uint programId, int bufSize, int* length, StringBuilder logData)
        {
            string log = _gl.InvokeUnmarshalled<uint, string>("glGetProgramInfo", programId);
            *length = log.Length;
            if (log.Length == 0) return;
            logData.Append(log, 0, Math.Min(log.Length, bufSize));
        }

        private void ProgramGetParam(uint program, int paramId, int* data)
        {
            int[] value = _gl.InvokeUnmarshalled<uint, int, int[]>("glGetProgramParam", program, paramId);
            //Engine.Log.Trace($"Program query {(ProgramProperty) paramId} got {string.Join(", ", value)}", "WebGLInternal");
            Marshal.Copy(value, 0, (IntPtr) data, value.Length);
        }

        private int GetUniformLocation(uint program, string name)
        {
            return _gl.InvokeUnmarshalled<uint, string, int>("glGetUniformLoc", program, name);
        }

        private void UploadUniform(int location, int count, int* value)
        {
            _gl.InvokeUnmarshalled<int, int, IntPtr, object>("glUniformIntArray", location, count, (IntPtr) value);
        }

        private void UploadUniform(int location, int value)
        {
            _gl.InvokeUnmarshalled<int, int, object>("glUniformInt", location, value);
        }

        private void UploadUniform(int location, float value)
        {
            _gl.InvokeUnmarshalled<int, BoxedFloat, object>("glUniformFloat", location, new BoxedFloat(value));
        }

        private void UploadUniform(int location, float value, float value2)
        {
            _gl.InvokeUnmarshalled<int, Vector2, object>("glUniformFloat2", location, new Vector2(value, value2));
        }

        private void UploadUniform(int location, float value, float value2, float value3)
        {
            _gl.InvokeUnmarshalled<int, Vector3, object>("glUniformFloat3", location, new Vector3(value, value2, value3));
        }

        private void UploadUniform(int location, float value, float value2, float value3, float value4)
        {
            _gl.InvokeUnmarshalled<int, Vector4, object>("glUniformFloat4", location, new Vector4(value, value2, value3, value4));
        }

        private void UploadUniform(int location, int count, float* value)
        {
            _gl.InvokeUnmarshalled<int, int, IntPtr, object>("glUniformFloatArray", location, count, (IntPtr) value);
        }

        private void UploadUniformFloatArrayMultiComponent(int componentCount, int location, int count, float* value)
        {
            var uploadData = new MatrixUniformUploadData
            {
                ComponentCount = componentCount,
                ArrayLength = count,
                Data = (IntPtr) value,
            };
            _gl.InvokeUnmarshalled<int, MatrixUniformUploadData, object>("glUniformMultiFloatArray", location, uploadData);
        }

        private void UploadUniformFloatArrayMultiComponent2(int location, int count, float* value)
        {
            UploadUniformFloatArrayMultiComponent(2, location, count, value);
        }

        private void UploadUniformFloatArrayMultiComponent3(int location, int count, float* value)
        {
            UploadUniformFloatArrayMultiComponent(3, location, count, value);
        }

        private void UploadUniformFloatArrayMultiComponent4(int location, int count, float* value)
        {
            UploadUniformFloatArrayMultiComponent(4, location, count, value);
        }

        private void UploadUniformMat4(int location, int count, bool transpose, float* value)
        {
            var uploadData = new MatrixUniformUploadData
            {
                ComponentCount = 4,
                ArrayLength = count,
                Data = (IntPtr) value,
                Transpose = transpose
            };
            _gl.InvokeUnmarshalled<int, MatrixUniformUploadData, object>("glUniformMatrix", location, uploadData);
        }

        private void CreateFramebuffer(int count, uint* resp)
        {
            uint[] value = _gl.InvokeUnmarshalled<int, uint[]>("glGenFramebuffers", count);
            for (var i = 0; i < value.Length; i++)
            {
                Marshal.WriteInt64((IntPtr) (resp + i * sizeof(uint)), value[i]);
            }
        }

        private void BindFramebuffer(int target, uint bufferId)
        {
            _gl.InvokeUnmarshalled<int, uint, object>("glBindFramebuffer", target, bufferId);
        }

        private void FramebufferUploadTexture2D(int target, int attachment, int textarget, uint texture, int level)
        {
            var data = new IntegerVector4
            {
                X = target,
                Y = attachment,
                Z = textarget,
                W = level
            };
            _gl.InvokeUnmarshalled<IntegerVector4, uint, object>("glFramebufferTexture2D", data, texture);
        }

        private int FramebufferStatus(int target)
        {
            return _gl.InvokeUnmarshalled<int, int>("glCheckFramebufferStatus", target);
        }

        private void DrawBuffers(int count, int* modes)
        {
            _gl.InvokeUnmarshalled<IntPtr, int, object>("glDrawBuffers", (IntPtr) modes, count);
        }

        private void GenVertexArrays(int count, uint* resp)
        {
            uint[] value = _gl.InvokeUnmarshalled<int, uint[]>("glGenVertexArrays", count);
            for (var i = 0; i < value.Length; i++)
            {
                Marshal.WriteInt64((IntPtr) (resp + i * sizeof(uint)), value[i]);
            }
        }

        private void BindVertexArray(uint bufferId)
        {
            _gl.InvokeUnmarshalled<uint, object>("glBindVertexArray", bufferId);
        }

        private void EnableVertexAttribArray(uint attribute)
        {
            _gl.InvokeUnmarshalled<uint, object>("glEnableVertexAttribArray", attribute);
        }

        private void VertexAttribPointer(uint index, int size, int type, bool normalized, int stride, IntPtr offset)
        {
            var data = new VertexAttribData
            {
                Index = index,
                Size = size,
                Type = type,
                Normalized = normalized,
                Stride = stride,
                Offset = (int) offset
            };
            _gl.InvokeUnmarshalled<VertexAttribData, object>("glVertexAttribPointer", data);
        }

        private void DrawElements(int mode, int count, int type, IntPtr offset)
        {
            var data = new IntegerVector4
            {
                X = mode,
                Y = count,
                Z = type,
                W = (int) offset
            };
            _gl.InvokeUnmarshalled<IntegerVector4, object>("glDrawElements", data);
        }

        private void DrawArrays(int mode, int first, int count)
        {
            _gl.InvokeUnmarshalled<int, int, int, object>("glDrawArrays", mode, first, count);
        }

        // Because of the nature of the WebGL render loop the rendering is always synchronized, and these functions aren't really needed.
        private IntPtr FenceSync(int condition, uint flags)
        {
            return IntPtr.Zero;
        }

        private int ClientWaitSync(IntPtr condition, uint flags, ulong timeout)
        {
            return (int) SyncStatus.AlreadySignaled;
        }

        private void CreateTexture(int count, uint* resp)
        {
            uint[] value = _gl.InvokeUnmarshalled<int, uint[]>("glGenTextures", count);
            for (var i = 0; i < value.Length; i++)
            {
                Marshal.WriteInt64((IntPtr) (resp + i * sizeof(uint)), value[i]);
            }
        }

        private void BindTexture(int slot, uint pointer)
        {
            _gl.InvokeUnmarshalled<int, uint, object>("glBindTexture", slot, pointer);
        }

        private void ActiveTexture(int textureSlot)
        {
            _gl.InvokeUnmarshalled<int, object>("glActiveTexture", textureSlot);
        }

        private void UploadTexture(int target, int level, int internalFormat, int width, int height, int border, int format, int type, IntPtr pixels)
        {
            var uploadArgs = new TextureUploadArgs
            {
                Target = target,
                Level = level,
                InternalFormat = internalFormat,
                Width = width,
                Height = height,
                Border = border,
                Format = format,
                Type = type,
                PixelsPointer = pixels,
                PixelsByteSize = width * height * Gl.PixelFormatToComponentCount((PixelFormat) format) * Gl.PixelTypeToByteCount((PixelType) type)
            };
            _gl.InvokeUnmarshalled<TextureUploadArgs, object>("glUploadTexture2D", uploadArgs);
        }

        private void TexParameterInteger(int target, int param, int value)
        {
            _gl.InvokeUnmarshalled<int, int, int, object>("glTextureParameteri", target, param, value);
        }

        private void CreateRenderbuffer(int count, uint* resp)
        {
            uint[] value = _gl.InvokeUnmarshalled<int, uint[]>("glGenRenderbuffers", count);
            for (var i = 0; i < value.Length; i++)
            {
                Marshal.WriteInt64((IntPtr) (resp + i * sizeof(uint)), value[i]);
            }
        }

        private void BindRenderbuffer(int target, uint bufferId)
        {
            _gl.InvokeUnmarshalled<int, uint, object>("glBindRenderbuffer", target, bufferId);
        }

        private void RenderbufferStorage(int target, int format, int width, int height)
        {
            var data = new IntegerVector4
            {
                X = target,
                Y = format,
                Z = width,
                W = height
            };
            _gl.InvokeUnmarshalled<IntegerVector4, object>("glRenderbufferStorage", data);
        }

        private void FramebufferRenderbuffer(int target, int attachment, int renderbufferTarget, uint renderbuffer)
        {
            var data = new IntegerVector4
            {
                X = target,
                Y = attachment,
                Z = renderbufferTarget,
            };
            _gl.InvokeUnmarshalled<IntegerVector4, uint, object>("glFramebufferRenderbuffer", data, renderbuffer);
        }
    }
}