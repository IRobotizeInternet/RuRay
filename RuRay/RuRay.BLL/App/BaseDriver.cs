using System;
using OpenQA.Selenium.Remote;
using RuRayFacebook.Utilities;
using RuRayFacebook.WebDrivers;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="BaseDriver" />.
    /// </summary>
    public abstract class BaseDriver
    {
        /// <summary>
        /// The RunConformance.
        /// </summary>
        public abstract void RunConformance();

        // Private
        /// <summary>
        /// Gets the BaseURL.
        /// </summary>
        protected string BaseURL { get; }

        /// <summary>
        /// Gets the WebBrowser.
        /// </summary>
        private string WebBrowser { get; }

        /// <summary>
        /// Defines the _remoteDriver.
        /// </summary>
        [ThreadStatic]
        private static RemoteWebDriver _remoteDriver = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDriver"/> class.
        /// </summary>
        protected BaseDriver()
        {
            BaseURL = AppSettings.BaseURL;
            WebBrowser = AppSettings.WebBrowser;
            InitializeDriverAndWait();
        }

        /// <summary>
        /// The InitializeDriverAndWait.
        /// </summary>
        private void InitializeDriverAndWait()
        {
            if (_remoteDriver != null)
            {
                return;
            }

            _remoteDriver = Driver;
        }

        /// <summary>
        /// Defines the _driver.
        /// </summary>
        private static RemoteWebDriver _driver;

        /// <summary>
        /// Gets the Driver.
        /// </summary>
        public RemoteWebDriver Driver
        {
            get
            {
                if (_driver != null)
                {
                    return _driver;
                }

                var webDriver = (WebDriver)Activator.CreateInstance(Type.GetType(WebBrowser), BaseURL);
                return _driver = webDriver.Driver();
            }
        }
    }
}
