using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;

namespace RobotizeFacebook.WebDrivers
{
    public class InternetExplorer : WebDriver
    {
        public InternetExplorer(string baseUrl) : base(baseUrl) { }

        public override RemoteWebDriver Driver(bool useExistingBrowser= true)
        {
            if (string.IsNullOrEmpty(BaseURL))
            {
                throw new Exception($"{nameof(BaseURL)} is not set.");
            }

            //set an option to disable 'Save Password' prompt in the browser
            var options = new InternetExplorerOptions();
            options.AcceptInsecureCertificates = true;
            var driver = new InternetExplorerDriver(DriverLocation, options, TimeSpan.FromSeconds(WebDriverTimeoutInSeconds))
            {
                Url = BaseURL
            };

            return driver;
        }
    }
}
