using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DivArchive" />.
    /// </summary>
    public class DivArchive : BasePage
    {
        /// <summary>
        /// Gets the PageUrl.
        /// </summary>
        public override string PageUrl => "/allactivity/?category_key=ARCHIVED";

        /// <summary>
        /// Gets the ByForPage.
        /// </summary>
        public override By ByForPage => throw new System.NotImplementedException();

        /// <summary>
        /// Initializes a new instance of the <see cref="DivArchive"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public DivArchive(RemoteWebDriver driver)
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
