using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace RuRayFacebook.Services
{
    /// <summary>
    /// Defines the <see cref="ServiceTask" />.
    /// </summary>
    public class ServiceTask
    {
        /// <summary>
        /// The CloseTask.
        /// When closing task, it should not contains file extension. 
        /// </summary>
        /// <param name="taskName">The taskName<see cref="string"/>.</param>
        public static void CloseTask(string taskName)
        {
            foreach (var process in Process.GetProcessesByName(taskName))
            {
                process.Kill();
            }
        }

        /// <summary>
        /// The RunScript.
        /// </summary>
        /// <param name="fileName">The fileName<see cref="string"/>.</param>
        /// <param name="args">The args<see cref="string"/>.</param>
        /// <param name="copyToAppFolder">The copyToAppFolder<see cref="bool"/>.</param>
        public static void RunScript(
            string fileName, 
            bool runFromBinFolder = false,
            string args = "", 
            bool copyToAppFolder = true)
        {
            // copy the script to a location where it can be run.
            // running ps1 scripts from bin folder is not relaible.
            // By default all the scripts reside in PS1 folder
            
            var file = Path.Combine(EnvironmentSettings.DirectoryPath, fileName);
            var asm = Assembly.GetExecutingAssembly();
            var sourceFile = Path.Combine(Path.GetDirectoryName(asm.Location), fileName);
            if (copyToAppFolder && !File.Exists(file))
            {
                Directory.CreateDirectory(Path.Combine(EnvironmentSettings.DirectoryPath, "PS1"));
                File.Copy(sourceFile, file);
            }

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = @"powershell.exe",
                Arguments = runFromBinFolder
                ? sourceFile
                : $@"& '{Path.Combine(EnvironmentSettings.DirectoryPath, fileName)}' '{args}'",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process process = new Process
            {
                StartInfo = startInfo
            };
            process.Start();
        }
    }
}
