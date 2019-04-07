﻿#region Using

using System.Diagnostics;
using System.Runtime.InteropServices;

#endregion

namespace Adfectus.Native
{
    /// <summary>
    /// Functions relating to the Unix family of OS.
    /// </summary>
    public static class UnixNative
    {
        /// <summary>
        /// Changes the current directory. Used for dynamic library mapping.
        /// </summary>
        /// <param name="path">Path to the new directory.</param>
        /// <returns>?</returns>
        [DllImport("libc", SetLastError = true)]
        public static extern int chdir(string path);

        /// <summary>
        /// Execute a bash command on Unix systems.
        /// </summary>
        /// <param name="command">The command to execute.</param>
        public static void ExecuteBashCommand(string command)
        {
            Process bashProcess = new Process
            {
                StartInfo =
                {
                    FileName = "/bin/bash",
                    Arguments = $"-c \"{command.Replace("\"", "\\\"")}\"",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            bashProcess.Start();
        }
    }
}