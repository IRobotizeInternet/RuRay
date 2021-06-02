using System;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace RuRayFacebook.WebDrivers
{
    /// <summary>
    /// Defines the <see cref="InternetExplorer" />.
    /// </summary>
    public class InternetExplorer : WebDriver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternetExplorer"/> class.
        /// </summary>
        /// <param name="baseUrl">The baseUrl<see cref="string"/>.</param>
        public InternetExplorer(string baseUrl) : base(baseUrl)
        {
        }

        /// <summary>
        /// The Driver.
        /// </summary>
        /// <param name="useExistingBrowser">The useExistingBrowser<see cref="bool"/>.</param>
        /// <returns>The <see cref="RemoteWebDriver"/>.</returns>
        public override RemoteWebDriver Driver(bool useExistingBrowser = true)
        {
            if (string.IsNullOrEmpty(BaseURL))
            {
                throw new Exception($"{nameof(BaseURL)} is not set.");
            }

            //set an option to disable 'Save Password' prompt in the browser
            var options = new InternetExplorerOptions
            {
                AcceptInsecureCertificates = true
            };
            var driver = new InternetExplorerDriver(DriverLocation, options, TimeSpan.FromSeconds(WebDriverTimeoutInSeconds))
            {
                Url = BaseURL
            };

            return driver;
        }
    }
}
