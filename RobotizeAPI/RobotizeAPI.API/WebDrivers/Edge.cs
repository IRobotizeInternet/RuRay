using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using System;

namespace RobotizeFacebook.WebDrivers
{
    public class Edge: WebDriver
    {
        public Edge(string baseUrl) : base(baseUrl) { }
        
        public override RemoteWebDriver Driver(bool useExistingBrowser)
        {
            if (string.IsNullOrEmpty(BaseURL))
            {
                throw new Exception($"{nameof(BaseURL)} is not set.");
            }

            ////set an option to disable 'Save Password' prompt in the browser
            //var options = new EdgeOptions();
            //options.AddAdditionalCapability("credentials_enable_service", false);
            //options.AddAdditionalCapability("password_manager_enabled", false);

            var driver = new EdgeDriver(DriverLocation)
            {
                Url = BaseURL
            };

            return driver;
        }
    }
}
