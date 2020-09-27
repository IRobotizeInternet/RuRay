using RobotizeFacebookLibrary.Security;
using System.Configuration;

namespace RobotizeFacebookLibrary.Utilities
{
    public static class AppSettings
    {
        public static string BaseURL { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static string CryptoKey { get; set; }
        public static string WebBrowser { get; set; }

        static AppSettings()
        {
            BaseURL = ConfigurationManager.AppSettings[nameof(BaseURL)];
            UserName = ConfigurationManager.AppSettings[nameof(UserName)];
            Password = ConfigurationManager.AppSettings[nameof(Password)];
            CryptoKey = ConfigurationManager.AppSettings[nameof(CryptoKey)];
            WebBrowser = ConfigurationManager.AppSettings[nameof(WebBrowser)];
        }

        /// <summary>
        /// Encrypt user and password name.
        /// </summary>
        private static void EncryptUserAndPassword()
        {
            UserName = ConfigurationManager.AppSettings[nameof(UserName)];
            Password = ConfigurationManager.AppSettings[nameof(Password)];
            var key = CryptoServiceForString.GetAesKey;
            ConfigurationManager.AppSettings.Set(nameof(CryptoKey), key);
            ConfigurationManager.AppSettings.Set(nameof(UserName), key);
            ConfigurationManager.AppSettings.Set(nameof(Password), key);
        }
    }
}
