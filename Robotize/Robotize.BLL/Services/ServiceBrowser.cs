using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace RobotizeFacebook.Services
{
    public class ServiceBrowser : IDisposable
    {
        private static Process _process;
        public static void OpenBrowser()
        {
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
            
            // This is a very interesting hack. Read the code carefully to understand it better.
            var envSettings = EnvironmentSettings.SettingsData;
            if (int.TryParse(envSettings.Details?.ProcessId, out var previousSessionId)
                && Process.GetProcessesByName("chrome")
                .Any(x => x.Id == previousSessionId)) return;
            var existingChromePIds = Process.GetProcessesByName("chrome").Select(x => x.Id);
            _process = new Process();
            _process.StartInfo.FileName = shortcutAddress;
            var p = new Process
            {
                StartInfo = new ProcessStartInfo(shortcutAddress)
                {
                    UseShellExecute = true
                }
            };
            p.Start();
            envSettings.Details = new EnvironmentSettingsDTO {
                ProcessId = Process.GetProcessesByName("chrome").Where(x => !existingChromePIds.Contains(x.Id)).First().Id.ToString() 
            };
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
