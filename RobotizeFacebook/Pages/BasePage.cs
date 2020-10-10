using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Utilities;
using RobotizeFacebook.WebDrivers;
using System;

namespace RobotizeFacebook.Pages
{
    public abstract class PageBase
    {
        // Private 
        private string BaseURL { get; }
        private string WebBrowser { get; }
        private const int _defaultTimeoutInSec = 60;
        [ThreadStatic] private static RemoteWebDriver _remoteDriver = null;

        [ThreadStatic] private static WebDriverWait _wait = null;
        protected WebDriverWait Wait => _wait;

        // public 
        public abstract string PageUrl { get; }

        protected PageBase()
        {
            BaseURL = AppSettings.BaseURL;
            WebBrowser = AppSettings.WebBrowser;
            InitializeDriverAndWait();
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

        public void GoToPage()
        {
            Driver.Navigate().GoToUrl($"{BaseURL}{PageUrl}");
        }

        private void InitializeDriverAndWait()
        {
            if (_remoteDriver == null)
            {
                _remoteDriver = Driver;
                _remoteDriver.Manage().Cookies.DeleteAllCookies();
                _wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(_defaultTimeoutInSec));
            }
        }
    }
}
