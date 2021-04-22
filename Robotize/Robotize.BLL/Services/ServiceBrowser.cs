using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace RobotizeFacebook.Services
{
    public class ServiceBrowser
    {
        public static void OpenBrowser()
        {
            // The shortcut path is taken from ChangeTarget.ps1 file, if you wish to 
            // change the path you must do it in the script first.
            string shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\chrome.exe - Shortcut.lnk";

            // If shortcut does not exist call script ChangeTarget.ps1 to generate icon
            if (!File.Exists(shortcutAddress)) ServiceTask.RunScript("ChangeTarget.ps1");

            // This is a very interesting hack. Read the code carefully to understand it better.
            var envSettings = EnvironmentSettings.SettingsData();
            if (int.TryParse(envSettings.Details?.ProcessId, out var previousSessionId)
                && Process.GetProcessesByName("chrome")
                .Any(x => x.Id == previousSessionId)) return;
            var existingChromePIds = Process.GetProcessesByName("chrome").Select(x => x.Id);
            
            ServiceTask.RunScript(shortcutAddress);
            
            envSettings.Details = new EnvironmentSettingsDTO {
                ProcessId = Process.GetProcessesByName("chrome").Where(x => !existingChromePIds.Contains(x.Id)).First().Id.ToString() 
            };
        }
    }
}
