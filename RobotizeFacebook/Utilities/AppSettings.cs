using System.Configuration;

namespace RobotizeFacebook.Utilities
{
    public static class AppSettings
    {
        public static string BaseURL { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static string CryptoKey { get; set; }
        public static string WebBrowser { get; set; }
        public static string ChromeBrowserLocation { get; set; }
        public static string DebuggerBrowserUrl { get; set; }
        public static string DebuggerBrowserPort { get; set; }
        public static string BrowserProcessId { get; set; }
        public static string DefaultCulture { get; set; }

        static AppSettings()
        {
            BaseURL = ConfigurationManager.AppSettings[nameof(BaseURL)];
            UserName = ConfigurationManager.AppSettings[nameof(UserName)];
            Password = ConfigurationManager.AppSettings[nameof(Password)];
            CryptoKey = ConfigurationManager.AppSettings[nameof(CryptoKey)];
            WebBrowser = ConfigurationManager.AppSettings[nameof(WebBrowser)];
            ChromeBrowserLocation = ConfigurationManager.AppSettings[nameof(ChromeBrowserLocation)];
            DebuggerBrowserUrl = ConfigurationManager.AppSettings[nameof(DebuggerBrowserUrl)];
            DebuggerBrowserPort = ConfigurationManager.AppSettings[nameof(DebuggerBrowserPort)];
            BrowserProcessId = ConfigurationManager.AppSettings[nameof(BrowserProcessId)];
            DefaultCulture = ConfigurationManager.AppSettings[nameof(DefaultCulture)];
        }

        public static void AddAppSettings(int processId)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None); // Add an Application Setting.
            config.AppSettings.Settings.Remove(nameof(BrowserProcessId));
            config.AppSettings.Settings.Add(nameof(BrowserProcessId), processId.ToString());

            // Save the changes in App.config file.
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
