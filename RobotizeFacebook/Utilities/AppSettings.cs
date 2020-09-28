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

        static AppSettings()
        {
            BaseURL = ConfigurationManager.AppSettings[nameof(BaseURL)];
            UserName = ConfigurationManager.AppSettings[nameof(UserName)];
            Password = ConfigurationManager.AppSettings[nameof(Password)];
            CryptoKey = ConfigurationManager.AppSettings[nameof(CryptoKey)];
            WebBrowser = ConfigurationManager.AppSettings[nameof(WebBrowser)];
        }
    }
}
