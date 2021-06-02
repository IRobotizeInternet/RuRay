using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="MenuItemsPages" />.
    /// </summary>
    public class MenuItemsPages : MenuItems
    {
        /// <summary>
        /// Gets the EventTriggerButtonYourPages.
        /// </summary>
        public EventTriggerButton<PagePages> EventTriggerButtonYourPages =>
            new EventTriggerButton<PagePages>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.YourPages}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonCreateNewPage.
        /// </summary>
        public EventTriggerButton<PagePages> EventTriggerButtonCreateNewPage =>
            new EventTriggerButton<PagePages>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.CreateNewPage}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonDiscover.
        /// </summary>
        public EventTriggerButton<PagePages> EventTriggerButtonDiscover =>
            new EventTriggerButton<PagePages>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Discover}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonLikedPages.
        /// </summary>
        public EventTriggerButton<PagePages> EventTriggerButtonLikedPages =>
            new EventTriggerButton<PagePages>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.LikedPages}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonInvites.
        /// </summary>
        public EventTriggerButton<PagePages> EventTriggerButtonInvites =>
            new EventTriggerButton<PagePages>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Invites}')]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
