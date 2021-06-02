using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="MenuItemsWatch" />.
    /// </summary>
    public class MenuItemsWatch : MenuItems
    {
        /// <summary>
        /// Gets the EventTriggerButtonHome.
        /// </summary>
        public EventTriggerButton<PageWatch> EventTriggerButtonHome =>
            new EventTriggerButton<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Home}]"));

        /// <summary>
        /// Gets the EventTriggerButtonShows.
        /// </summary>
        public EventTriggerButton<PageWatch> EventTriggerButtonShows =>
            new EventTriggerButton<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Shows}]"));

        /// <summary>
        /// Gets the EventTriggerButtonLive.
        /// </summary>
        public EventTriggerButton<PageWatch> EventTriggerButtonLive =>
            new EventTriggerButton<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Live}]"));

        /// <summary>
        /// Gets the EventTriggerButtonSavedVideos.
        /// </summary>
        public EventTriggerButton<PageWatch> EventTriggerButtonSavedVideos =>
            new EventTriggerButton<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.SavedVideos}]"));

        /// <summary>
        /// Gets the HyperlinkButtonManage.
        /// </summary>
        public Hyperlink<PageWatch> HyperlinkButtonManage =>
            new Hyperlink<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Manage}]"));

        /// <summary>
        /// Gets the HyperlinkButtonLatestVideos.
        /// </summary>
        public Hyperlink<PageWatch> HyperlinkButtonLatestVideos =>
            new Hyperlink<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.LatestVideos}]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
