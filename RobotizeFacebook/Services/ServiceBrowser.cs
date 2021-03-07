﻿using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using RobotizeFacebook.Utilities;

namespace RobotizeFacebook.Services
{
    public class ServiceBrowser : IDisposable
    {
        private static Process _process;
        public static void OpenBrowser()
        {
            _process = new Process();

            // The shortcut path is taken from ChangeTarget.ps1 file, if you wish to 
            // change the path you must do it in the script first.
            string shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\chrome.exe - Shortcut.lnk";

            // If shortcut does not exist call script ChangeTarget.ps1 to generate icon
            if (!File.Exists(shortcutAddress))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = @"powershell.exe";
                startInfo.Arguments = $@"& '{Path.Combine(Environment.CurrentDirectory, "ChangeTarget.ps1")}'";
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
            // Below code is being duplicated using powershell script ChangeTarget.ps1
            // proc.StartInfo.UseShellExecute = false;
            // proc.StartInfo.Arguments = $"{AppSettings.BaseURL} --remote-debugging-port={AppSettings.DebuggerBrowserPort} --user-data-dir=C:\\Temp";

            _process.StartInfo.FileName = shortcutAddress;
            _process.Start();
        }

        // To detect redundant calls
        private bool _disposed = false;

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            // Dispose managed state (managed objects).
            if (disposing) _process?.Dispose();

            _disposed = true;
        }
    }
}
