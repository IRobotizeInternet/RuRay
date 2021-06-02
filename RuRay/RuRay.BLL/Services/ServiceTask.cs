using System;
using System.Diagnostics;
using System.IO;

namespace RuRayFacebook.Services
{
    public class ServiceTask
    {
        public static void CloseTask(string taskName)
        {
            foreach (var process in Process.GetProcessesByName(taskName))
            {
                process.Kill();
            }
        }

        public static void RunScript(string fileName, string arg = "", bool copyToAppFolder = true)
        {
            // copy the script to a location where it can be run.
            // running ps1 scripts from bin folder is not relaible.
            // By default all the scripts reside in PS1 folder
            var file = Path.Combine(EnvironmentSettings.DirectoryPath, fileName);
            Directory.CreateDirectory(Path.Combine(EnvironmentSettings.DirectoryPath, "PS1"));
            if (copyToAppFolder && !File.Exists(file))
            {
                File.Copy(fileName, file);
            }

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = @"powershell.exe",
                Arguments = $@"& '{Path.Combine(Environment.CurrentDirectory, fileName)}' '{arg}'",
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
