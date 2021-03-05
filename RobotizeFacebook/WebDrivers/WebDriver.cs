using System;
using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.WebDrivers
{
    public class WebDriver
    {
        public static string BaseURL { get; set; }
        protected static string DriverLocation { get; set; } = ".";
        protected static int WebDriverTimeoutInSeconds { get; set; } = 20;

        public WebDriver(string baseUrl)
        {
            BaseURL = baseUrl;
        }

        public virtual RemoteWebDriver Driver(bool useExistingBrowser = true) 
        {
            throw new NotImplementedException("Driving class has not implemeted this function.");
        }
    }
}
