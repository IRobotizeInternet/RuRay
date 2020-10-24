using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Utilities;

namespace RobotizeFacebook.WebDrivers
{
    public class WebDriver
    {
        public static string BaseURL { get; set; }
        protected static string DriverLocation { get; set; } = ".";
        protected static int WebDriverTimeoutInSeconds { get; set; } = 200;

        public WebDriver(string baseUrl)
        {
            BaseURL = baseUrl;
        }

        public virtual RemoteWebDriver Driver(bool useExistingBrowser = true) 
        {
            throw new NotImplementedException("Deriving class not implemeting this function.");
        }

        public void OpenBrowserAndGetAddress()
        {
            Process proc = new Process();
            if (!string.IsNullOrEmpty(AppSettings.BrowserProcessId))
            {
                if(int.TryParse(AppSettings.BrowserProcessId, out var id)) 
                
                    try
                    {
                        var existingProcess = Process.GetProcessById(id);
                        if (existingProcess != null) return;
                    }catch(Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                    
                }
            proc.StartInfo.FileName = AppSettings.ChromeBrowserLocation;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.Arguments = $"{AppSettings.BaseURL} --new-window --remote-debugging-port={AppSettings.DebuggerBrowserPort} --user-data-dir=C:\\Temp";
            proc.Start();
            AppSettings.AddAppSettings(proc.Id);
        }
    }
}
