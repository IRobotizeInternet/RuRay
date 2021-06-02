using System.Configuration;

namespace RuRayFacebook.Utilities
{
    /// <summary>
    /// Defines the <see cref="AppSettings" />.
    /// </summary>
    public static class AppSettings
    {
        /// <summary>
        /// Gets or sets the BaseURL.
        /// </summary>
        public static string BaseURL { get; set; }

        /// <summary>
        /// Gets or sets the UserName.
        /// </summary>
        public static string UserName { get; set; }

        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        public static string Password { get; set; }

        /// <summary>
        /// Gets or sets the CryptoKey.
        /// </summary>
        public static string CryptoKey { get; set; }

        /// <summary>
        /// Gets or sets the WebBrowser.
        /// </summary>
        public static string WebBrowser { get; set; }

        /// <summary>
        /// Gets or sets the ChromeBrowserLocation.
        /// </summary>
        public static string ChromeBrowserLocation { get; set; }

        /// <summary>
        /// Gets or sets the DebuggerBrowserUrl.
        /// </summary>
        public static string DebuggerBrowserUrl { get; set; }

        /// <summary>
        /// Gets or sets the DebuggerBrowserPort.
        /// </summary>
        public static string DebuggerBrowserPort { get; set; }

        /// <summary>
        /// Gets or sets the DefaultCulture.
        /// </summary>
        public static string DefaultCulture { get; set; }

        /// <summary>
        /// Gets or sets the RuRayDataDirectory.
        /// </summary>
        public static string RuRayDataDirectory { get; set; }

        /// <summary>
        /// Gets or sets the EnvironmentSettingsFile.
        /// </summary>
        public static string EnvironmentSettingsFile { get; set; }

        /// <summary>
        /// Gets or sets the PowerShellOutputFile.
        /// </summary>
        public static string PowerShellOutputFile { get; set; }

        /// <summary>
        /// Initializes static members of the <see cref="AppSettings"/> class.
        /// </summary>
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
