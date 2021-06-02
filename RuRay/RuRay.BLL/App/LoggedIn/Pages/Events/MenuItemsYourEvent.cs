using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="MenuItemsYourEvent" />.
    /// </summary>
    public class MenuItemsYourEvent : MenuItems
    {
        /// <summary>
        /// Gets the TriggerButtonGoing.
        /// </summary>
        public EventTriggerButton<FeedGoing> TriggerButtonGoing =>
        new EventTriggerButton<FeedGoing>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Going}')]"));

        /// <summary>
        /// Gets the TriggerButtonYourInvites.
        /// </summary>
        public EventTriggerButton<FeedInvites> TriggerButtonYourInvites =>
            new EventTriggerButton<FeedInvites>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Invites}')]"));

        /// <summary>
        /// Gets the TriggerButtonInterested.
        /// </summary>
        public EventTriggerButton<FeedInterested> TriggerButtonInterested =>
            new EventTriggerButton<FeedInterested>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Interested}')]"));

        /// <summary>
        /// Gets the TriggerButtonHosting.
        /// </summary>
        public EventTriggerButton<FeedHosting> TriggerButtonHosting =>
            new EventTriggerButton<FeedHosting>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Hosting}')]"));

        /// <summary>
        /// Gets the TriggerButtonPastEvents.
        /// </summary>
        public EventTriggerButton<FeedPastEvents> TriggerButtonPastEvents =>
            new EventTriggerButton<FeedPastEvents>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.PastEvents}')]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
