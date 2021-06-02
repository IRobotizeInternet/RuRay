using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using Polly;
using Polly.Retry;
using RuRayFacebook.Services;
using RuRayFacebook.Utilities;

namespace RuRayFacebook.WebDrivers
{
    /// <summary>
    /// Defines the <see cref="Chrome" />.
    /// </summary>
    public class Chrome : WebDriver//, IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Chrome"/> class.
        /// </summary>
        /// <param name="baseUrl">The baseUrl<see cref="string"/>.</param>
        public Chrome(string baseUrl) : base(baseUrl)
        {
        }

        /// <summary>
        /// The Dispose.
        /// </summary>
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The Driver.
        /// </summary>
        /// <param name="useExistingBrowser">The useExistingBrowser<see cref="bool"/>.</param>
        /// <returns>The <see cref="RemoteWebDriver"/>.</returns>
        public override RemoteWebDriver Driver(bool useExistingBrowser = true)
        {
            // when useExistingBrowser is set open chrome
            if (useExistingBrowser)
            {
                ServiceBrowser.OpenBrowser();
            }

            if (string.IsNullOrEmpty(BaseURL))
            {
                throw new Exception($"{nameof(BaseURL)} is not set.");
            }

            // NOTE: This will cause problem when we run this code 
            // in multi threaded program. Remove this code, to avoid 
            // running into problems when experimenting with parallel runs.
            ServiceTask.CloseTask(nameof(ChromeDriver));
            var options = new ChromeOptions
            {
                DebuggerAddress = $"{AppSettings.DebuggerBrowserUrl}:{ AppSettings.DebuggerBrowserPort}"
            };

            options.AddArgument("no-sandbox");

            //options.AddArguments(@"user-data-dir=C:\Users\amhus\AppData\Local\Google\Chrome\User Data\Default" /*Profile Path*/);
            //options.BinaryLocation = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";

            ChromeDriver driver = null;

            RetryPolicy().Execute(() =>
            {
                driver = new ChromeDriver(options);
            });


            // Temp disabling this
            // SelectTab(driver);

            // If using existing window then you may not need to maximize it here.
            //driver.Manage().Window.Maximize();

            // set default culture 
            ServiceCulture.SetDefaultCulture(AppSettings.DefaultCulture);

            return driver;
        }

        /// <summary>
        /// The GetRemoteWebDriver.
        /// </summary>
        /// <returns>The <see cref="RemoteWebDriver"/>.</returns>
        private RemoteWebDriver GetRemoteWebDriver()
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

        /// <summary>
        /// The SelectTab.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public void SelectTab(RemoteWebDriver driver)
        {
            foreach (var tab in driver.WindowHandles)
            {
                // TODO: This code is being hit twice when it ran first time, find the cuase and fix it.
                // This should only be called one or being called explicitly. 
                if (driver.Url.Contains($"{AppSettings.BaseURL}"))
                {
                    return;
                }

                driver.SwitchTo().Window(tab);
            }

            RetryPolicy().Execute(() =>
            {
                driver.Navigate().GoToUrl(BaseURL);
            });
        }

        /// <summary>
        /// The RetryPolicy.
        /// </summary>
        /// <param name="retryCount">The retryCount<see cref="int"/>.</param>
        /// <returns>The <see cref="RetryPolicy"/>.</returns>
        private RetryPolicy RetryPolicy(int retryCount = 10)
        {
            return Policy
              .Handle<InvalidOperationException>()
              .WaitAndRetry(retryCount, t => TimeSpan.FromSeconds(10));
        }

        /// <summary>
        /// The CommandLineTextFromChrome.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        private void CommandLineTextFromChrome(RemoteWebDriver driver)
        {
            // Below code is used to verify the remote debugging and the port used.
            driver.Navigate().GoToUrl("chrome://version/");
            driver.FindElementById("command_line").Text.Contains("--remote-debugging-port=9222");
        }
    }
}
