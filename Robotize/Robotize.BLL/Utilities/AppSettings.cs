using System.Configuration;

namespace RuRayFacebook.Utilities
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
        public static string DefaultCulture { get; set; }
        public static string RuRayDataDirectory { get; set; }
        public static string EnvironmentSettingsFile { get; set; }
        public static string PowerShellOutputFile { get; set; }

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
            DefaultCulture = ConfigurationManager.AppSettings[nameof(DefaultCulture)];
            RuRayDataDirectory = ConfigurationManager.AppSettings[nameof(RuRayDataDirectory)];
            EnvironmentSettingsFile = ConfigurationManager.AppSettings[nameof(EnvironmentSettingsFile)];
            PowerShellOutputFile = ConfigurationManager.AppSettings[nameof(PowerShellOutputFile)];
        }
    }
}
