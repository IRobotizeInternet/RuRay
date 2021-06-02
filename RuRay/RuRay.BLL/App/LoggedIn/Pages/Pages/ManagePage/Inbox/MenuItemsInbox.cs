using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="MenuItemsInbox" />.
    /// </summary>
    public class MenuItemsInbox : MenuItems
    {
        /// <summary>
        /// Gets the EventTriggerButtonAllMessages.
        /// </summary>
        public EventTriggerButton<PageInbox> EventTriggerButtonAllMessages =>
            new EventTriggerButton<PageInbox>(Driver, By.XPath($"//div[contains(text(), '{ResLeftNav.AllMessages}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonMessenger.
        /// </summary>
        public EventTriggerButton<FeedMessages> EventTriggerButtonMessenger =>
            new EventTriggerButton<FeedMessages>(Driver, By.XPath($"//div[contains(text(), '{ResLeftNav.Messenger}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonInstagramDirect.
        /// </summary>
        public EventTriggerButton<FeedInstagramDirect> EventTriggerButtonInstagramDirect =>
            new EventTriggerButton<FeedInstagramDirect>(Driver, By.XPath($"//div[contains(text(), '{ResLeftNav.InstagramDirect}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonFacebook.
        /// </summary>
        public EventTriggerButton<FeedFacebook> EventTriggerButtonFacebook =>
            new EventTriggerButton<FeedFacebook>(Driver, By.XPath($"//div[contains(text(), '{ResLeftNav.Facebook}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonInstagram.
        /// </summary>
        public EventTriggerButton<FeedInstagram> EventTriggerButtonInstagram =>
            new EventTriggerButton<FeedInstagram>(Driver, By.XPath($"//div[contains(text(), '{ResLeftNav.Instagram}')]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
