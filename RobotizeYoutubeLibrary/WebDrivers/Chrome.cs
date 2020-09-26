using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
namespace RobotizeYoutubeLibrary.WebDrivers
{
    public class Chrome : WebDriver
    {
        public static RemoteWebDriver Driver()
        {
            if (string.IsNullOrEmpty(BaseURL))
            {
                throw new Exception($"{nameof(BaseURL)} is not set.");
            }

            //set an option to disable 'Save Password' prompt in the browser
            var options = new ChromeOptions();
            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("password_manager_enabled", false);

            var driver = new ChromeDriver(DriverLocation, options, TimeSpan.FromSeconds(WebDriverTimeoutInSeconds))
            {
                Url = BaseURL
            };

            return driver;
        }
    }
}
