using System;
using System.Diagnostics;
using System.IO;

namespace RobotizeFacebook.Services
{
    public class ServiceTask
    {
        public static void CloseTask(string taskName)
        {
            foreach (var process in Process.GetProcessesByName(taskName)) process.Kill();
        }

        public static void RunScript(string fileName, string arg = "")
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"powershell.exe";
            startInfo.Arguments = $@"& '{Path.Combine(Environment.CurrentDirectory, fileName)}' '{arg}'";
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            Process process = new Process
            {
                StartInfo = startInfo
            };
            process.Start();
        }
    }
}
