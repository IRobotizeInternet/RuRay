using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using Polly;
using RobotizeFacebook.Utilities;
using System;

namespace RobotizeFacebook.WebDrivers
{
    public class Chrome : WebDriver
    {
        public Chrome(string baseUrl):base(baseUrl) { }

        public override RemoteWebDriver Driver(bool useExistingBrowser = true)
        {
            // when useExistingBrowser is set open chrome
            if (useExistingBrowser) OpenBrowserAndGetAddress();

            if (string.IsNullOrEmpty(BaseURL))
            {
                throw new Exception($"{nameof(BaseURL)} is not set.");
            }

            var options = new ChromeOptions();
            options.DebuggerAddress = $"{AppSettings.DebuggerBrowserUrl}:{ AppSettings.DebuggerBrowserPort}";

            if (!useExistingBrowser)
            {
                options.AddUserProfilePreference("credentials_enable_service", false);
                options.AddUserProfilePreference("password_manager_enabled", false);
                options.AddUserProfilePreference("allow-running-insecure-content", true);
            }
            
            ChromeDriver driver = null;

            // Using Polly library: https://github.com/App-vNext/Polly
            var policy = Policy
              .Handle<InvalidOperationException>()
              .WaitAndRetry(10, t => TimeSpan.FromSeconds(1));

            policy.Execute(() =>
            {
                driver = new ChromeDriver(DriverLocation, options, TimeSpan.FromSeconds(WebDriverTimeoutInSeconds));
            });

            driver.Manage().Window.Maximize();

            return driver;
        }
    }
}
