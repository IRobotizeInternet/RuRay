using System;
using System.Diagnostics;
using RobotizeFacebook.Utilities;

namespace RobotizeFacebook.Services
{
    public class ServiceBrowser
    {
        public void OpenBrowser()
        {
            var proc = new Process();
            if (string.IsNullOrEmpty(AppSettings.BrowserProcessId)) goto NotFound;
            if (int.TryParse(AppSettings.BrowserProcessId, out var id))
            {
                try
                {
                    var existingProcess = Process.GetProcessById(id);
                    if (existingProcess != null) return;
                    goto NotFound;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }

        NotFound:
            proc.StartInfo.FileName = AppSettings.ChromeBrowserLocation;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.Arguments = $"{AppSettings.BaseURL} --remote-debugging-port={AppSettings.DebuggerBrowserPort} --user-data-dir=C:\\Temp";
            proc.Start();
            AppSettings.AddAppSettings(proc.Id);
        }
    }
}
