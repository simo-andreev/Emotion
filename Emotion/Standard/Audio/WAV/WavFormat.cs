﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Emotion.Standard.Audio
{
    public static class WavFormat
    {
        /// <summary>
        /// The size of the magic for recognizing this file.
        /// </summary>
        public const int FILE_MAGIC_SIZE = 2;

        /// <summary>
        /// Verify whether the bytes are a wav file, by checking the magic.
        /// </summary>
        /// <param name="data">The data to check.</param>
        /// <returns>Whether the data fits the wav magic.</returns>
        public static bool IsWav(byte[] data)
        {
            var wav = false;
            if (data.Length >= 4)
                wav =
                    data[0] == 'R' &&
                    data[1] == 'I' &&
                    data[2] == 'F' &&
                    data[3] == 'F';

            return wav;
        }

        /// <summary>
        /// Encodes the provided sound data to a wav file.
        /// </summary>
        /// <param name="soundData">The date to encode.</param>
        /// <param name="format">The format of the data.</param>
        /// <returns>A 24bit BMP image as bytes.</returns>
        public static byte[] Encode(byte[] soundData, AudioFormat format)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Decodes the provided wav data to sound data.
        /// </summary>
        /// <param name="wavData">The data to decode.</param>
        /// <param name="format">The audio format.</param>
        /// <param name="duration">The duration of the sound in seconds.</param>
        /// <returns>The sound data.</returns>
        public static byte[] Decode(byte[] wavData, out AudioFormat format, out float duration)
        {
            format = new AudioFormat();

            using var stream = new MemoryStream(wavData);
            using var reader = new BinaryReader(stream);

            // Read RIFF header.
            var signature = new string(reader.ReadChars(4));
            if (signature != "RIFF") throw new Exception("Unsupported sound signature.");

            // Chunk size.
            reader.ReadInt32();

            var f = new string(reader.ReadChars(4));
            if (f != "WAVE") throw new Exception("Unsupported sound format.");

            // Read WAVE header.
            var formatSignature = new string(reader.ReadChars(4));

            // Skip junk.
            while (formatSignature != "fmt ")
            {
                int junkSize = reader.ReadInt32();
                reader.ReadBytes(junkSize);
                formatSignature = new string(reader.ReadChars(4));
            }

            // Format chunk size.
            int chunkSize = reader.ReadInt32();

            // Audio format.
            short soundFmt = reader.ReadInt16();
            format.IsFloat = soundFmt == 3;

            format.Channels = reader.ReadInt16();
            // Frequency.
            format.SampleRate = reader.ReadInt32();
            // Byte rate.
            reader.ReadInt32();
            // Block align. How many bytes is one sample - Channels * BitsPerSample / 8
            reader.ReadInt16();
            format.BitsPerSample = reader.ReadInt16();

            // Finish the rest of the chunk.
            reader.ReadBytes(chunkSize - 16);

            // Read the signature.
            formatSignature = new string(reader.ReadChars(4));

            // Find the data chunk.
            while (formatSignature != "data")
            {
                int junkSize = reader.ReadInt32();
                reader.ReadBytes(junkSize);
                formatSignature = new string(reader.ReadChars(4));
            }

            // Read the data chunk length.
            int dataLength = reader.ReadInt32();

            // Read the data.
            byte[] soundData = reader.ReadBytes(dataLength);

            // Calculate duration.
            duration = soundData.Length / (format.SampleRate * format.Channels * format.BitsPerSample / 8f);

            return soundData;
        }
    }
}
