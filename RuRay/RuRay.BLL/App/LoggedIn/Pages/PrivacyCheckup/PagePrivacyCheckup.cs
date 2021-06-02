using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PagePrivacyCheckup" />.
    /// </summary>
    public class PagePrivacyCheckup : BasePage
    {
        /// <summary>
        /// Gets the PageUrl.
        /// </summary>
        public override string PageUrl => "/privacy/checkup/";

        /// <summary>
        /// Gets the ByForPage.
        /// </summary>
        public override By ByForPage => throw new System.NotImplementedException();

        /// <summary>
        /// Initializes a new instance of the <see cref="PagePrivacyCheckup"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public PagePrivacyCheckup(RemoteWebDriver driver)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagePrivacyCheckup"/> class.
        /// </summary>
        public PagePrivacyCheckup()
        {
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
