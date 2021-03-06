using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using Polly;
using RobotizeFacebook.Services;
using RobotizeFacebook.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace RobotizeFacebook.WebDrivers
{
    public class Chrome : WebDriver, IDisposable
    {
        public Chrome(string baseUrl):base(baseUrl) { }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public override RemoteWebDriver Driver(bool useExistingBrowser = true)
        {
            // when useExistingBrowser is set open chrome
            //if (useExistingBrowser) new ServiceBrowser().OpenBrowser();

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
                options.AddUserProfilePreference("disable-web-security", true);
                options.AddUserProfilePreference("allow-file-access-from-file", true);
                options.AddUserProfilePreference("force-renderer-accessibility", true);
                options.AddUserProfilePreference("enable-views-textfield", true);
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

            SelectTab(driver);
            
            //var driver2 = new RemoteWebDriver(options);
            //driver2.SessionId = driver.SessionId;
            //AppSettings.AddAppSettings(driver.SessionId.ToString());


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

        public bool SelectTab(RemoteWebDriver driver)
        {
            var baseURLOpened = false;
            foreach(var tab in driver.WindowHandles)
            {
                if (driver.Title.Contains($"{AppSettings.BaseURL}")) break;
                driver.SwitchTo().Window(tab);
            }
         
            return baseURLOpened;
        }
    }
}
