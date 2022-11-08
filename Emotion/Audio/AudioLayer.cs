﻿#region Using

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Emotion.Common;
using Emotion.IO;
using Emotion.Standard.Audio;
using Emotion.Standard.Logging;
using Emotion.Utility;
#if DEBUG
using System.Threading;
#endif

#endregion

#nullable enable

namespace Emotion.Audio
{
    /// <summary>
    /// Object for internal reference by the audio implementation of the platform.
    /// </summary>
    public abstract partial class AudioLayer
    {
        /// <summary>
        /// The layer's friendly name.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// The layer's volume modifier is applied to the current volume
        /// which in turn is controlled by things such as fades.
        /// [0-1]
        /// </summary>
        public float VolumeModifier { get; set; } = 1;

        /// <summary>
        /// Whether the layer is destroyed.
        /// </summary>
        public bool Disposed { get; protected set; }

        /// <summary>
        /// The status of the audio layer. This should be async from the actual state.
        /// </summary>
        public PlaybackStatus Status
        {
            get => _status;
            protected set
            {
                if (value != _status)
                {
                    OnStatusChanged?.Invoke(value, _status);
                    _status = value;
                }
            }
        }

        private PlaybackStatus _status = PlaybackStatus.NotPlaying;

        /// <summary>
        /// Whether the current track is being looped.
        /// </summary>
        public bool LoopingCurrent
        {
            get => _looping;
            set
            {
                if (_looping == value) return;
                _looping = value;
                InvalidateCurrentTrack();
            }
        }

        private bool _looping;

        /// <summary>
        /// The track currently playing - if any.
        /// </summary>
        public AudioTrack? CurrentTrack
        {
            get
            {
                if (_updateCurrentTrack)
                    lock (_playlist)
                    {
                        return _playlist.Count == 0 ? null : _playlist[0];
                    }

                return _currentTrack;
            }
        }

        /// <summary>
        /// What percentage (0-1) of the track has finished playing.
        /// </summary>
        public float Progress
        {
            get
            {
                if (_playHead == 0) return 0f;

                if (_updateCurrentTrack)
                    lock (_playlist)
                    {
                        AudioTrack? willBeCurrent = _playlist.Count == 0 ? null : _playlist[0];
                        if (willBeCurrent == _currentTrack)
                            return (float) _playHead / _totalSamplesConv;
                        return 0;
                    }

                return (float) _playHead / _totalSamplesConv;
            }
        }

        /// <summary>
        /// How far along the duration of the file the track has finished playing.
        /// </summary>
        public float Playback
        {
            get
            {
                AudioTrack? currentTrack = _currentTrack;
                if (currentTrack == null) return 0;
                return Progress * currentTrack.File.Duration;
            }
        }

        /// <summary>
        /// The current playlist.
        /// Do not use this except for debugging and such.
        /// To get the current track use "CurrentTrack"
        /// </summary>
        public AudioAsset[] Playlist
        {
            get
            {
                lock (_playlist)
                {
                    return _playlist.Select(x => x.File).ToArray();
                }
            }
        }

        /// <summary>
        /// Called when the current track loops.
        /// The input parameter is the track which looped.
        /// </summary>
        public event Action<AudioAsset>? OnTrackLoop;

        /// <summary>
        /// Called when the current track changes.
        /// The first parameter is the old track, the second is the new one.
        /// If there is no further track the new track parameter will be null.
        /// </summary>
        public event Action<AudioAsset?, AudioAsset?>? OnTrackChanged;

        /// <summary>
        /// Called when the layer status changes.
        /// </summary>
        public event Action<PlaybackStatus, PlaybackStatus>? OnStatusChanged;

        /// <summary>
        /// The audio format audio is streamed in. This is set by the backend.
        /// </summary>
        public AudioFormat CurrentStreamingFormat
        {
            get => _streamingFormat;
        }

        // For fade effects volume is calculated per chunk of frames, rather than for every frame.
        private const int VOLUME_MODULATION_FRAME_GRANULARITY = 100; //tudu delete
        private const int INITIAL_INTERNAL_BUFFER_SIZE = 4000; // 4 * sizeof(float) = 16kb

        private List<AudioTrack> _playlist = new(); // Always read and written in locks

        private float[] _internalBuffer; // Internal memory to keep resamples frames for applying post proc to.
        private float[] _internalBufferCrossFade; // Same memory, but for the second track when crossfading.

        private int _playHead; // The progress into the current track, relative to the converted format.
        private AudioFormat _streamingFormat; // The common format to emit samples in. Can be changed in any BackendGetData call
        private int _totalSamplesConv; // The total sample count in the dst format. Used to know where _playHead is relative to the total.

        // Track state
        private bool _updateCurrentTrack = true;
        private AudioTrack? _currentTrack;
        private AudioTrack? _nextTrack;
        private int _loopCount; // Number of times the current track has looped. 0 if it hasn't.

        // FX
        private FadeEffectData? _currentCrossFade; // Effect data for both triggered cross fades and configured ones
        private bool _triggerCrossFade; // Whether to trigger a cross fade at the current point in time.
        private float _triggerCrossFadeDurationSetting = -1; // The duration of the cross fade to trigger.

        private float _triggerStopWithFadeWithDuration = -1; // Whether to trigger a fade out at the current point in time.
        private StopAfterFadeEffectData? _currentFadeOutAndStop; // The current fade out effect, for both triggered and configured.
        private List<AudioTrack>? _playListAtFadeOutStop;

        protected AudioLayer(string name)
        {
            Name = name;
            _internalBuffer = new float[INITIAL_INTERNAL_BUFFER_SIZE];
            _internalBufferCrossFade = new float[INITIAL_INTERNAL_BUFFER_SIZE];

            _streamingFormat = new AudioFormat();
        }

        #region API

        /// <summary>
        /// Sets the track to be played next in the playlist. If the playlist is empty and the layer isn't paused the track is
        /// played immediately.
        /// </summary>
        /// <param name="track">The track to play next.</param>
        public void PlayNext(AudioTrack track)
        {
            if (track.File == null) return;

            track.CrossFade = 3;

            lock (_playlist)
            {
                if (_playlist.Count == 0)
                    _playlist.Add(track);
                else
                    _playlist.Insert(1, track);
            }

            InvalidateCurrentTrack();
            if (Status == PlaybackStatus.NotPlaying) Status = PlaybackStatus.Playing;
        }

        /// <inheritdoc cref="PlayNext(AudioTrack)" />
        public void PlayNext(AudioAsset file)
        {
            PlayNext(new AudioTrack(file));
        }

        /// <summary>
        /// Causes a crossfade transition from the current track into the next.
        /// If the current track doesn't have cross fade enabled you must supply a duration here.
        /// </summary>
        public bool FadeCurrentTrackIntoNext(int crossFadeSet = -1)
        {
            if (_nextTrack == null) return false;
            if (_currentCrossFade != null) return false;

            if (crossFadeSet != -1) _triggerCrossFadeDurationSetting = crossFadeSet;
            _triggerCrossFade = true;

            return false;
        }

        /// <summary>
        /// Adds the track to the back of the playlist. If the playlist is empty and the layer isn't paused the track is played
        /// immediately.
        /// </summary>
        /// <param name="track">The track to play.</param>
        public void AddToQueue(AudioTrack track)
        {
            if (track.File == null) return;

            lock (_playlist)
            {
                _playlist.Add(track);
            }

            InvalidateCurrentTrack();
            if (Status == PlaybackStatus.NotPlaying) Status = PlaybackStatus.Playing;
        }

        /// <inheritdoc cref="AddToQueue(AudioTrack)" />
        public void AddToQueue(AudioAsset file)
        {
            AddToQueue(new AudioTrack(file));
        }

        /// <summary>
        /// Stop all previous playback, clear the playlist, and play the provided track.
        /// This is essentially the same as calling Stop and then PlayNext but causes less state transitions and doesn't involve
        /// the platform.
        /// </summary>
        public void QuickPlay(AudioTrack track)
        {
            if (track.File == null) return;

            lock (_playlist)
            {
                _playlist.Clear();
                _playlist.Add(track);
            }

            InvalidateCurrentTrack();
            if (Status == PlaybackStatus.NotPlaying) Status = PlaybackStatus.Playing;
        }

        /// <inheritdoc cref="QuickPlay(AudioAsset)" />
        public void QuickPlay(AudioAsset file)
        {
            QuickPlay(new AudioTrack(file));
        }

        /// <summary>
        /// Resume playback, if paused. If currently playing nothing happens. If currently not playing - start playing.
        /// </summary>
        public void Resume()
        {
            Status = CurrentTrack != null ? PlaybackStatus.Playing : PlaybackStatus.NotPlaying;
        }

        /// <summary>
        /// Pause playback. If currently not playing anything the layer is paused anyway, and will need to be resumed.
        /// </summary>
        public void Pause()
        {
            Status = PlaybackStatus.Paused;
            InvalidateCurrentTrack();
        }

        /// <summary>
        /// Stop all playback, and clear the playlist.
        /// </summary>
        public void Stop()
        {
            lock (_playlist)
            {
                _playlist.Clear();
            }

            if (Status == PlaybackStatus.Playing) Status = PlaybackStatus.NotPlaying;
            InvalidateCurrentTrack();
        }

        /// <summary>
        /// Stop playing all tracks, after fading out the current one.
        /// </summary>
        public bool StopWithFade(float fadeDuration)
        {
            if (_currentTrack == null) return false;

            _playListAtFadeOutStop = new List<AudioTrack>();
            lock (_playlist)
            {
                _playListAtFadeOutStop.AddRange(_playlist);
            }

            _triggerStopWithFadeWithDuration = fadeDuration;
            return true;
        }

        #endregion

        #region Stream Logic

        /// <summary>
        /// The max number of blocks to sample ahead.
        /// Each block is between AudioUpdateRate and AudioUpdateRate * 2 ms of audio data
        /// But if too small, then blocks will be overriden before you hear them.
        /// Unless the driver is lagging significantly behind you should never have more than 1-2 blocks ready.
        /// </summary>
        public static int MaxDataBlocks = 10;

#if DEBUG
        /// <summary>
        /// Total bytes allocated for all data blocks. Blocks and memory are shared between audio layers.
        /// </summary>
        public static int MetricAllocatedDataBlocks;

        /// <summary>
        /// How many ms of data is currently stored in all ready blocks.
        /// </summary>
        public int MetricDataStoredInBlocks;

        /// <summary>
        /// How many frames were dropped because the backend didn't request them.
        /// </summary>
        public int MetricBackendMissedFrames;

        /// <summary>
        /// How many frames was the buffer starved of - AKA didn't get them from ready blocks
        /// but had to resample on the fly.
        /// </summary>
        public int MetricStarved;

#endif

        private static ObjectPool<AudioDataBlock> _dataPool = new ObjectPool<AudioDataBlock>(null, MaxDataBlocks);
        private Queue<AudioDataBlock> _readyBlocks = new Queue<AudioDataBlock>();
        private int _headBlockDataLeft;

        // Debug
        private Stopwatch? _updateTimer;
        private UpdateScopeTracker? _inUpdateLoop;

        private class UpdateScopeTracker : IDisposable
        {
            public bool Disposed;

            public void Dispose()
            {
                Disposed = true;
            }
        }

        private class AudioDataBlock
        {
            public byte[] Data = Array.Empty<byte>();
            public int FramesWritten;
            public int FramesRead;
        }

        /// <summary>
        /// Process audio data ahead.
        /// </summary>
        /// <param name="timePassed">Time to process, in milliseconds</param>
        public void Update(int timePassed)
        {
            using var updateLoopTrack = new UpdateScopeTracker();
            _inUpdateLoop = updateLoopTrack;

            UpdateCurrentTrack();

            // Update the backend. This will cause it to call BackendGetData
            UpdateBackend();

            if (Status != PlaybackStatus.Playing || _currentTrack == null) return;

#if DEBUG
            _updateTimer ??= Stopwatch.StartNew();

            if (_updateTimer.ElapsedMilliseconds > 1000)
            {
                MetricStarved = 0;

                MetricDataStoredInBlocks = 0;
                foreach (AudioDataBlock block in _readyBlocks)
                {
                    MetricDataStoredInBlocks += block.FramesWritten - block.FramesRead;
                }

                MetricDataStoredInBlocks = (int) (_streamingFormat.GetSoundDuration(MetricDataStoredInBlocks * _streamingFormat.FrameSize) * 1000);
                _updateTimer.Restart();
            }
#endif

            // Prevent spiral of death, hopefully.
            const int tooMuchTime = 50;
            if (timePassed > tooMuchTime)
            {
                int extraTime = timePassed - tooMuchTime;

                timePassed = tooMuchTime;

#if DEBUG
                MetricStarved += extraTime * _streamingFormat.SampleSize / 1000;
#endif
            }

            // Convert time to frames and bytes.
            int framesToGet = _streamingFormat.GetFrameCount(timePassed / 1000f);

            // If none blocks left or one block with little data in it, then do a larger request to prevent starvation.
            if (!_readyBlocks.TryPeek(out AudioDataBlock? topBlock) || (_readyBlocks.Count == 1 && topBlock.FramesWritten - topBlock.FramesRead < framesToGet))
                framesToGet *= 2;

            // Buffer data in advance, so the next update can be as fast as possible (just a copy).
            BufferDataInAdvance(framesToGet);
        }

        private void InvalidateCurrentTrack()
        {
            _updateCurrentTrack = true;
        }

        private void UpdateCurrentTrack()
        {
            if (!_updateCurrentTrack) return;
            _updateCurrentTrack = false;

            // Should only be called in the update loop, such as by GetDataToBuffer and Update
            Debug.Assert(_inUpdateLoop != null && !_inUpdateLoop.Disposed);

            // Get the currently playing track.
            AudioTrack? currentTrack;
            AudioTrack? nextTrack;
            lock (_playlist)
            {
                if (_playlist.Count == 0)
                {
                    currentTrack = null;
                    nextTrack = null;
                    InvalidateAudioBlocks();
                    if (Status == PlaybackStatus.Playing) Status = PlaybackStatus.NotPlaying;
                }
                else
                {
                    currentTrack = _playlist[0];

                    if (LoopingCurrent)
                        nextTrack = currentTrack;
                    else if (_playlist.Count > 1)
                        nextTrack = _playlist[1];
                    else
                        nextTrack = null;
                }
            }

            bool currentChanged = _currentTrack != currentTrack;
            bool nextChanged = _nextTrack != nextTrack;

            // If both the current and next changed (or just current if no next)
            // that means everything has changed. This usually happens when the current track
            // is over and we transition into the next one. It could also be the result of a stop + new playlist.
            if (currentChanged && (nextChanged || nextTrack == null))
            {
                _playHead = 0;

                // Reset various fx triggers since they no longer apply.
                _triggerCrossFade = false;
                _triggerCrossFadeDurationSetting = -1;
                _currentFadeOutAndStop = null;
                _playListAtFadeOutStop = null;
                _triggerStopWithFadeWithDuration = -1;

                // If the track didn't go into the next one, that means that cross fade was switched.
                // This is specially handled since we want cross fade effects to persist through track changes.
                if (currentTrack != _nextTrack) _currentCrossFade = null;
            }

            // If we have a new track.
            if (currentChanged && currentTrack != null)
            {
                AudioConverter converter = currentTrack.File.AudioConverter;
                _totalSamplesConv = converter.GetSampleCountInFormat(_streamingFormat);
                if (currentTrack.SetLoopingCurrent) LoopingCurrent = true;
                if (Status == PlaybackStatus.NotPlaying) Status = PlaybackStatus.Playing;
            }

            // if current changed at all.
            if (currentChanged)
            {
                OnTrackChanged?.Invoke(_currentTrack?.File, currentTrack?.File);
                _loopCount = 0;
                if (currentTrack != null) TrackChangedFx(currentTrack);
            }

            // Current changed, but we're not playing. If we don't
            // drop the cached audio then once we start playing a couple
            // of frames of the old current will leak.
            if (currentChanged && Status != PlaybackStatus.Playing) InvalidateAudioBlocks();

            _currentTrack = currentTrack;
            _nextTrack = nextTrack;
        }

        private void BufferDataInAdvance(int framesToGet)
        {
            int bytesToGet = framesToGet * _streamingFormat.FrameSize;
            if (bytesToGet == 0) return;

            // Get a data block to fill. If we're over the maximum blocks this might mean overriding one that was ready.
            // This will happen if the backend is lagging behind, which should never happen?
            AudioDataBlock dataBlock;
            if (_readyBlocks.Count >= MaxDataBlocks && _readyBlocks.TryDequeue(out AudioDataBlock? b))
            {
#if DEBUG
                MetricBackendMissedFrames += b.FramesWritten - b.FramesRead;
#endif
                dataBlock = b;
            }
            else
            {
                dataBlock = _dataPool.Get();
            }

            // Ensure the data block can fit the requested data.
            // The data a data block will usually carry is around AudioUpdateRate * 2 in time.
            if (dataBlock.Data.Length < bytesToGet)
            {
#if DEBUG
                Interlocked.Add(ref MetricAllocatedDataBlocks, -dataBlock.Data.Length + bytesToGet); // metric shared between threads (layers)
#endif
                Array.Resize(ref dataBlock.Data, bytesToGet);
            }

            int framesGotten = GetDataToBuffer(framesToGet, new Span<byte>(dataBlock.Data, 0, bytesToGet));

            // Nothing streamed, track is probably over.
            if (framesGotten == 0)
            {
                _dataPool.Return(dataBlock);
            }
            else
            {
                // Reset data block trackers so it can be used.
                dataBlock.FramesWritten = framesGotten;
                dataBlock.FramesRead = 0;
                _readyBlocks.Enqueue(dataBlock);

                if (_readyBlocks.Count == 1) _headBlockDataLeft = framesGotten;
            }
        }

        private void GoNextTrack(bool ignoreLoop = false)
        {
            // Check if looping.
            if (LoopingCurrent && !ignoreLoop)
            {
                // Manually update playhead as track wont change.
                _playHead = 0;
                _loopCount++;
                OnTrackLoop?.Invoke(_currentTrack!.File);
            }
            // Otherwise, go to next track.
            else
            {
                lock (_playlist)
                {
                    _playlist.Remove(_currentTrack!); // Don't remove by index as it is possible for current track to not be first via data race.
                }

                InvalidateCurrentTrack();
                UpdateCurrentTrack();
            }
        }

        protected int GetDataToBuffer(int framesRequested, Span<byte> dest, int framesOffset = 0)
        {
            // Check if the internal buffer needs to be resized to fit in the request.
            int samplesRequested = framesRequested * _streamingFormat.Channels;
            if (_internalBuffer.Length < samplesRequested)
            {
                Array.Resize(ref _internalBuffer, samplesRequested);
                Array.Resize(ref _internalBufferCrossFade, samplesRequested);
            }

#if DEBUG
            // Verify that the number of samples will fit in the buffer.
            // This should never happen and is considered a backend error.
            int bytesNeeded = framesRequested * _streamingFormat.FrameSize;
            if (dest.Length < bytesNeeded)
            {
                Engine.Log.Warning($"The provided buffer to the audio streamer is of invalid size {dest.Length} while {bytesNeeded} were requested.", MessageSource.Audio);
                framesRequested = dest.Length / _streamingFormat.FrameSize;
            }
#endif

            // Check for trigger FX.
            if (_currentTrack!.CrossFade.HasValue && _nextTrack != null && _currentCrossFade == null)
            {
                int startingFrame = _playHead / _streamingFormat.Channels;
                bool startFade = CheckIfShouldCrossFade(_streamingFormat, _currentTrack, _nextTrack, startingFrame);
                if (startFade) StartCrossFade(_currentTrack.CrossFade.Value);
            }

            if (_triggerCrossFade)
            {
                _triggerCrossFade = false;
                if (_currentCrossFade == null && _nextTrack != null) StartCrossFade(_triggerCrossFadeDurationSetting, true);
                _triggerCrossFadeDurationSetting = -1;
            }

            if (_triggerStopWithFadeWithDuration != -1 && _currentFadeOutAndStop == null)
            {
                Debug.Assert(_playListAtFadeOutStop != null);

                int startingFrame = _playHead / _streamingFormat.Channels;
                if (!CheckIfCurrentlyFadingOut(_streamingFormat, _currentTrack, startingFrame))
                {
                    if (_triggerStopWithFadeWithDuration < 0.0f) _triggerStopWithFadeWithDuration = _currentTrack.File.Duration * -_triggerStopWithFadeWithDuration;
                    _currentFadeOutAndStop = new StopAfterFadeEffectData(_currentTrack, startingFrame, _triggerStopWithFadeWithDuration, _playListAtFadeOutStop);

                    if (CheckIfInFadeInAndGetVolume(_streamingFormat, _currentTrack, startingFrame, out float startVolume))
                        _currentFadeOutAndStop.VolumeStart = startVolume;
                }

                _triggerStopWithFadeWithDuration = -1;
                _playListAtFadeOutStop = null;
            }
            else if (_currentFadeOutAndStop != null && CheckIfFadeOutOver(_streamingFormat, _currentTrack, _currentFadeOutAndStop))
            {
                _loopCount = 0;
                List<AudioTrack> playListToRemove = _currentFadeOutAndStop.PlaylistAtStop;
                lock (_playlist)
                {
                    for (var i = 0; i < playListToRemove.Count; i++)
                    {
                        _playlist.Remove(playListToRemove[i]);
                    }
                }

                InvalidateCurrentTrack();
                UpdateCurrentTrack();
            }

            if (_currentTrack == null) return 0;

            // Get post processed 32f buffer data.
            int framesOutput = GetProcessedFramesFromTrack(_streamingFormat, _currentTrack, framesRequested, _internalBuffer, ref _playHead);

            // Convert data to the destination sample size format.
            Span<byte> destBuffer = dest.Slice(framesOffset * _streamingFormat.FrameSize);
            var srcBuffer = new Span<float>(_internalBuffer, 0, samplesRequested);
            AudioUtil.SetBufferOfSamplesAsFloat(srcBuffer, destBuffer, _streamingFormat);

            // Check if the buffer was filled.
            // If less frames were drawn than the buffer can take - the current track is over.
            if (framesOutput == framesRequested) return framesOutput;

            GoNextTrack();

            // Fill rest of buffer with samples from the next track (which is now the current track).
            if (_currentTrack != null) framesOutput += GetDataToBuffer(framesRequested - framesOutput, dest, framesOutput);

            return framesOutput;
        }

        protected abstract void UpdateBackend();

        protected int BackendGetData(AudioFormat format, int getFrames, Span<byte> buffer)
        {
            if (Status != PlaybackStatus.Playing) return 0;

            // Make sure we're getting the samples in the format we think we are.
            if (!format.Equals(_streamingFormat))
            {
                AudioFormat oldFormat = _streamingFormat;
                float progress = _playHead != 0 ? (float) _playHead / _totalSamplesConv : 0;
                _streamingFormat = format;

                if (format.UnsupportedBitsPerSample())
                    Engine.Log.Warning($"Unsupported bits per sample format by streaming format - {_streamingFormat}", MessageSource.Audio, true);

                // Continue from last streaming position. This could cause a jump
                // depending on where the backend is.
                if (_currentTrack != null)
                {
                    AudioConverter streamer = _currentTrack.File.AudioConverter;
                    _totalSamplesConv = streamer.GetSampleCountInFormat(_streamingFormat);
                    FormatChangedRecalculateFx(_currentTrack, oldFormat, format);
                }
                else
                {
                    _totalSamplesConv = 0;
                }

                _playHead = (int) MathF.Floor(_totalSamplesConv * progress);

                // Readjust fade effect playheads if in use.
                _currentCrossFade?.AudioFormatChanged(oldFormat, format);
                _currentFadeOutAndStop?.AudioFormatChanged(oldFormat, format);
                

                InvalidateAudioBlocks();
            }

            // Verify dst size
            Debug.Assert(buffer.Length / format.FrameSize == getFrames);

            int framesLeft = getFrames;
            var framesGotten = 0;
            while (framesLeft > 0 && _readyBlocks.Count != 0)
            {
                if (_readyBlocks.TryPeek(out AudioDataBlock? b))
                {
                    int framesGot = b.FramesWritten - b.FramesRead;
                    int framesCanGet = Math.Min(framesGot, framesLeft);

                    int bufferCopyOffset = b.FramesRead * format.FrameSize;
                    int bufferCopyLength = framesCanGet * format.FrameSize;
                    new Span<byte>(b.Data).Slice(bufferCopyOffset, bufferCopyLength).CopyTo(buffer);
                    buffer = buffer[bufferCopyLength..];

                    b.FramesRead += framesCanGet;
                    framesGotten += framesCanGet;
                    framesLeft -= framesCanGet;

                    Debug.Assert(b.FramesRead <= b.FramesWritten);
                    if (b.FramesRead == b.FramesWritten)
                    {
                        _readyBlocks.TryDequeue(out AudioDataBlock? _);
                        _dataPool.Return(b);
                    }
                    else
                    {
                        _headBlockDataLeft = b.FramesWritten - b.FramesRead;
                    }
                }
            }

            // Buffer was starved, stream directly to it.
            // This occurs frequently when starting to play a new track as
            // the backend buffer requests data further into the future initially.
            if (framesLeft > 0 && _readyBlocks.Count == 0)
            {
#if DEBUG
                MetricStarved += framesLeft;
#endif

                int framesGot = GetDataToBuffer(framesLeft, buffer);
                framesGotten += framesGot;
            }

            return framesGotten;
        }

        protected void InvalidateAudioBlocks()
        {
            while (_readyBlocks.Count != 0 && _readyBlocks.TryDequeue(out AudioDataBlock? r))
                _dataPool.Return(r);

#if DEBUG
            MetricBackendMissedFrames = 0;
            MetricDataStoredInBlocks = 0;
#endif
            _headBlockDataLeft = 0;
        }

        #endregion

        #region CrossFade Helpers

        private class FadeEffectData
        {
            public AudioTrack Track;
            public int PlayHead;
            public float DurationSeconds;

            public FadeEffectData(AudioTrack track, int playHead, float durationSeconds)
            {
                Track = track;
                PlayHead = playHead;
                DurationSeconds = durationSeconds;
            }

            public void AudioFormatChanged(AudioFormat oldFormat, AudioFormat newFormat)
            {
                int crossFadePlayHead = PlayHead;
                float totalSamplesWere = Track.File.AudioConverter.GetSampleCountInFormat(oldFormat);
                float totalSamplesNow = Track.File.AudioConverter.GetSampleCountInFormat(newFormat);

                float progressCrossFade = crossFadePlayHead / totalSamplesWere;
                PlayHead = (int) MathF.Floor(progressCrossFade * totalSamplesNow);
            }
        }

        private class StopAfterFadeEffectData : FadeEffectData
        {
            public List<AudioTrack> PlaylistAtStop;
            public float VolumeStart = 1f;

            public StopAfterFadeEffectData(AudioTrack track, int playHead, float durationSeconds, List<AudioTrack> playlist) : base(track, playHead, durationSeconds)
            {
                PlaylistAtStop = playlist;
            }
        }

        private bool CheckIfShouldCrossFade(AudioFormat format, AudioTrack currentTrack, AudioTrack nextTrack, int startingFrame)
        {
            int channels = format.Channels;
            float currentTrackDuration = currentTrack.File.Duration;
            float nextTrackDuration = nextTrack.File.Duration;
            float crossFadeDuration = currentTrack.CrossFade!.Value;

            if (crossFadeDuration < 0.0f) crossFadeDuration = currentTrackDuration - currentTrackDuration * -crossFadeDuration;
            // Make sure there is enough duration in the next track to cross fade into. Leave at least one second so we don't exhaust the track.
            crossFadeDuration = Math.Min(crossFadeDuration, nextTrackDuration - 1);

            var crossFadeFrames = (int) MathF.Floor(crossFadeDuration * format.SampleRate);
            int crossFadeStartAtFrame = _totalSamplesConv / channels - crossFadeFrames;

            return crossFadeStartAtFrame <= startingFrame;
        }

        private bool StartCrossFade(float crossFadeDuration, bool forceNext = false)
        {
            if (_currentTrack == null || _nextTrack == null) return false;
            if (crossFadeDuration == -1) return false;

            float currentTrackDuration = _currentTrack.File.Duration;
            float nextTrackDuration = _nextTrack.File.Duration;

            // If the duration is a negative number then it is expected to be a percentage of the duration [0-1] (0-(-1))
            if (crossFadeDuration < 0.0f) crossFadeDuration = currentTrackDuration - currentTrackDuration * -crossFadeDuration;

            // Make sure there is enough duration in the next track to cross fade into. Leave at least one second so we don't exhaust the track.
            crossFadeDuration = Math.Min(crossFadeDuration, nextTrackDuration - 1);

            AudioTrack? currentTrack = _currentTrack;
            int playHead = _playHead;

            GoNextTrack(forceNext);

            _currentCrossFade = new FadeEffectData(currentTrack, playHead, crossFadeDuration);

            return true;
        }

        private bool CheckIfCurrentlyFadingOut(AudioFormat format, AudioTrack currentTrack, int startingFrame)
        {
            if (!currentTrack.FadeOut.HasValue) return false;

            int channels = format.Channels;
            float currentTrackDuration = currentTrack.File.Duration;
            float fadeOutDuration = currentTrack.FadeOut!.Value;

            if (fadeOutDuration < 0.0f) fadeOutDuration = currentTrackDuration * -fadeOutDuration;

            var fadeOutFrames = (int) MathF.Floor(fadeOutDuration * format.SampleRate);
            int fadeOutStartFrame = _totalSamplesConv / channels - fadeOutFrames;

            return fadeOutStartFrame <= startingFrame;
        }

        private bool CheckIfFadeOutOver(AudioFormat format, AudioTrack currentTrack, StopAfterFadeEffectData fadeData)
        {
            float fadeOutDuration = fadeData.DurationSeconds;
            var fadeOutFrames = (int) MathF.Floor(fadeOutDuration * format.SampleRate);
            int fadeOutStartFrame = fadeData.PlayHead;
            float currentFrame = _playHead / format.Channels;
            return fadeOutStartFrame + fadeOutFrames < currentFrame;
        }

        private bool CheckIfInFadeInAndGetVolume(AudioFormat format, AudioTrack currentTrack, int frameStart, out float volume)
        {
            volume = 0f;
            if (!currentTrack.FadeIn.HasValue) return false;

            float currentTrackDuration = currentTrack.File.Duration;
            float fadeInDuration = currentTrack.FadeIn!.Value;
            if (fadeInDuration < 0)
                fadeInDuration = currentTrackDuration * -fadeInDuration;

            var fadeInFrames = (int) MathF.Floor(fadeInDuration * format.SampleRate);

            if (frameStart >= fadeInFrames) return false;

            volume = (float) frameStart / fadeInFrames;
            volume *= volume;
            return true;
        }

        #endregion

        public virtual void Dispose()
        {
            Disposed = true;
            InvalidateAudioBlocks();
        }
    }
}