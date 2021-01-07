using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using Polly;
using RobotizeFacebook.Services;
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
            if (useExistingBrowser) new ServiceBrowser().OpenBrowser();

            if (string.IsNullOrEmpty(BaseURL))
            {
                throw new Exception($"{nameof(BaseURL)} is not set.");
            }

            var options = new ChromeOptions
            {
                DebuggerAddress = $"{AppSettings.DebuggerBrowserUrl}:{ AppSettings.DebuggerBrowserPort}"
            };

            options.AddArgument("no-sandbox");
            if (!useExistingBrowser)
            {
                options.AddUserProfilePreference("credentials_enable_service", false);
                options.AddUserProfilePreference("password_manager_enabled", false);
                options.AddUserProfilePreference("allow-running-insecure-content", true);
            }

            //options.AddArguments(@"user-data-dir=C:\Users\amhus\AppData\Local\Google\Chrome\User Data\Default" /*Profile Path*/);
            //options.BinaryLocation = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";

            ChromeDriver driver = null;

            // Using Polly library: https://github.com/App-vNext/Polly
            var policy = Policy
              .Handle<InvalidOperationException>()
              .WaitAndRetry(10, t => TimeSpan.FromSeconds(10));

            policy.Execute(() =>
            {
                driver = new ChromeDriver(DriverLocation, options, TimeSpan.FromSeconds(WebDriverTimeoutInSeconds));
            });

            // If using existing window then you may not need to maximize it here.
            //driver.Manage().Window.Maximize();

            // set default culture 
            ServiceCulture.SetDefaultCulture(AppSettings.DefaultCulture);

            return driver;
        }

        public RemoteWebDriver GetRemoteWebDriver()
        {
            var options = new ChromeOptions();
            //Environment.SetEnvironmentVariable("prefs", DriverLocation);

            options.AddArguments(@"user-data-dir=C:\Users\amhus\AppData\Local\Google\Chrome\User Data\Default" /*Profile Path*/);
            options.BinaryLocation = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
            ChromeDriver driver = null;

            // Using Polly library: https://github.com/App-vNext/Polly
            var policy = Policy
              .Handle<InvalidOperationException>()
              .WaitAndRetry(10, t => TimeSpan.FromSeconds(10));

            policy.Execute(() =>
            {
                driver = new ChromeDriver(DriverLocation, options, TimeSpan.FromSeconds(WebDriverTimeoutInSeconds));
            });

            driver.Manage().Window.Maximize();

            // set default culture 
            ServiceCulture.SetDefaultCulture(AppSettings.DefaultCulture);

            return driver;
        }
    }
}
