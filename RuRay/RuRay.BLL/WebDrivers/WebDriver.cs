using System;
using OpenQA.Selenium.Remote;

namespace RuRayFacebook.WebDrivers
{
    /// <summary>
    /// Defines the <see cref="WebDriver" />.
    /// </summary>
    public class WebDriver
    {
        /// <summary>
        /// Gets or sets the BaseURL.
        /// </summary>
        public static string BaseURL { get; set; }

        /// <summary>
        /// Gets or sets the DriverLocation.
        /// </summary>
        protected static string DriverLocation { get; set; } = ".";

        /// <summary>
        /// Gets or sets the WebDriverTimeoutInSeconds.
        /// </summary>
        protected static int WebDriverTimeoutInSeconds { get; set; } = 20;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebDriver"/> class.
        /// </summary>
        /// <param name="baseUrl">The baseUrl<see cref="string"/>.</param>
        public WebDriver(string baseUrl)
        {
            BaseURL = baseUrl;
        }

        /// <summary>
        /// The Driver.
        /// </summary>
        /// <param name="useExistingBrowser">The useExistingBrowser<see cref="bool"/>.</param>
        /// <returns>The <see cref="RemoteWebDriver"/>.</returns>
        public virtual RemoteWebDriver Driver(bool useExistingBrowser = true)
        {
            throw new NotImplementedException("Driving class has not implemeted this function.");
        }
    }
}
