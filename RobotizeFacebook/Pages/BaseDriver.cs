using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Utilities;
using RobotizeFacebook.WebDrivers;
using System;

namespace RobotizeFacebook.Pages
{
    public abstract class BaseDriver
    {
        // Private 
        protected string BaseURL { get; }
        private string WebBrowser { get; }

        [ThreadStatic]
        private static RemoteWebDriver _remoteDriver = null;

        [ThreadStatic]
        private static WebDriverWait _wait = null;

        private const int _defaultTimeoutInSec = 60;
        protected WebDriverWait Wait => _wait;

        protected BaseDriver()
        {
            BaseURL = AppSettings.BaseURL;
            WebBrowser = AppSettings.WebBrowser;
            InitializeDriverAndWait();
        }

        private void InitializeDriverAndWait()
        {
            if (_remoteDriver == null)
            {
                _remoteDriver = Driver;

                // Enable this if you wish to delete the cookies 
                // _remoteDriver.Manage().Cookies.DeleteAllCookies();
                _wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(_defaultTimeoutInSec));
            }
        }

        private static RemoteWebDriver _driver;
        public RemoteWebDriver Driver
        {
            get
            {
                if (_driver != null) return _driver;
                var webDriver = (WebDriver)Activator.CreateInstance(Type.GetType(WebBrowser), BaseURL);
                return _driver = webDriver.Driver();
            }
        }
    }
}