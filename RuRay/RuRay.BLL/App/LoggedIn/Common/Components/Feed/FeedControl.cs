using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="FeedControl" />.
    /// </summary>
    public class FeedControl : BaseFeed
    {
        /// <summary>
        /// Gets or sets the BaseXPath.
        /// </summary>
        public string BaseXPath { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedControl"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="byForElement">The byForElement<see cref="By"/>.</param>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        public FeedControl(RemoteWebDriver driver,
            By byForElement,
            string baseXPath) : base()
        {
            BaseXPath = baseXPath;
        }
    }
}
