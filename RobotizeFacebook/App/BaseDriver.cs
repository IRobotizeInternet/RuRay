using OpenQA.Selenium.Remote;
using RobotizeFacebook.Utilities;
using RobotizeFacebook.WebDrivers;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public abstract class BaseDriver
    {
        public abstract void RunConformance();
        // Private 
        protected string BaseURL { get; }
        private string WebBrowser { get; }

        [ThreadStatic]
        private static RemoteWebDriver _remoteDriver = null;

        protected BaseDriver()
        {
            BaseURL = AppSettings.BaseURL;
            WebBrowser = AppSettings.WebBrowser;
            InitializeDriverAndWait();
        }

        private void InitializeDriverAndWait()
        {
            if (_remoteDriver != null) return;
         
            _remoteDriver = Driver;
            
            // Enable this if you wish to delete the cookies each time you start new session.
            // _remoteDriver.Manage().Cookies.DeleteAllCookies();
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