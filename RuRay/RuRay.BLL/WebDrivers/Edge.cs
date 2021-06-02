using System;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;

namespace RuRayFacebook.WebDrivers
{
    /// <summary>
    /// Defines the <see cref="Edge" />.
    /// </summary>
    public class Edge : WebDriver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Edge"/> class.
        /// </summary>
        /// <param name="baseUrl">The baseUrl<see cref="string"/>.</param>
        public Edge(string baseUrl) : base(baseUrl)
        {
        }

        /// <summary>
        /// The Driver.
        /// </summary>
        /// <param name="useExistingBrowser">The useExistingBrowser<see cref="bool"/>.</param>
        /// <returns>The <see cref="RemoteWebDriver"/>.</returns>
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
