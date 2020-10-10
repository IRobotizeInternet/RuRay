using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.WebDrivers
{
    public class WebDriver
    {
        public static string BaseURL { get; set; }
        protected static string DriverLocation { get; set; } = ".";
        protected static int WebDriverTimeoutInSeconds { get; set; } = 200;

        public WebDriver(string baseUrl)
        {
            BaseURL = baseUrl;
        }

        public virtual RemoteWebDriver Driver() 
        {
            throw new NotImplementedException("Deriving class not implemeting this function.");
        }
    }
}
