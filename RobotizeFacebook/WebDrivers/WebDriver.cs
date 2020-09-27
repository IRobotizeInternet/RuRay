using OpenQA.Selenium.Remote;
using System;

namespace RobotizeFacebookLibrary.WebDrivers
{
    public class WebDriver
    {
        public static string BaseURL { get; set; }
        protected static string DriverLocation { get; set; } = @"D:\Dev\RobotizeFacebook\RobotizeFacebookLibrary\bin\Debug";
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
