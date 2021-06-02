using OpenQA.Selenium;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="HeaderLeftMenu" />.
    /// </summary>
    public class HeaderLeftMenu : BaseDriver
    {
        // Items on left.
        /// <summary>
        /// Gets the HyperLinkFacebookTitleIcon.
        /// </summary>
        public Hyperlink<PageUserTimeline> HyperLinkFacebookTitleIcon =>
            new Hyperlink<PageUserTimeline>(Driver, By.XPath("//a[@aria-label='Facebook']"));

        /// <summary>
        /// Gets the SearchboxFacebook.
        /// </summary>
        public ComboboxSearchFacebook SearchboxFacebook =>
            new ComboboxSearchFacebook(Driver, null);

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
