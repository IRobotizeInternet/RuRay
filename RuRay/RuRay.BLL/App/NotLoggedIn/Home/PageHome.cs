using OpenQA.Selenium;
using RuRayFacebook.App.LoggedIn.Pages;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.NotLoggedIn
{
    /// <summary>
    /// Defines the <see cref="PageHome" />.
    /// </summary>
    public class PageHome : BasePage
    {
        /// <summary>
        /// Gets the PageUrl.
        /// </summary>
        public override string PageUrl => "/";

        /// <summary>
        /// Gets the ButtonCreateVideo.
        /// </summary>
        public Button ButtonCreateVideo => new Button(Driver, By.XPath("//div[@id='end']//div[@id='buttons']//ytd-topbar-menu-button-renderer[1]//button"));

        /// <summary>
        /// Gets the ButtonYoutubeApps.
        /// </summary>
        public Button ButtonYoutubeApps => new Button(Driver, By.XPath("//div[@id='end']//div[@id='buttons']//ytd-topbar-menu-button-renderer[2]//button"));

        /// <summary>
        /// Gets the ButtonSettings.
        /// </summary>
        public Button ButtonSettings => new Button(Driver, By.XPath("//div[@id='end']//div[@id='buttons']//ytd-topbar-menu-button-renderer[3]//button"));

        /// <summary>
        /// Gets the ButtonSignIn.
        /// </summary>
        public Button ButtonSignIn => new Button(Driver, By.XPath("//div[@id='buttons']//ytd-button-renderer//a"));

        /// <summary>
        /// Gets the ByForPage.
        /// </summary>
        public override By ByForPage => throw new System.NotImplementedException();

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
