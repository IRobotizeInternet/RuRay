using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="MenuItemsEvents" />.
    /// </summary>
    public class MenuItemsEvents : MenuItems
    {
        /// <summary>
        /// Gets the TriggerButtonHome.
        /// </summary>
        public EventTriggerButton<FeedEventHome> TriggerButtonHome =>
            new EventTriggerButton<FeedEventHome>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Home}')]"));

        /// <summary>
        /// Gets the TriggerButtonYourEvents.
        /// </summary>
        public EventTriggerButton<FeedYourEvents> TriggerButtonYourEvents =>
            new EventTriggerButton<FeedYourEvents>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.YourEvents}')]"));

        /// <summary>
        /// Gets the TriggerButtonBirthdays.
        /// </summary>
        public EventTriggerButton<FeedBirthdays> TriggerButtonBirthdays =>
            new EventTriggerButton<FeedBirthdays>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Birthdays}')]"));

        /// <summary>
        /// Gets the TriggerButtonDiscoverEvents.
        /// </summary>
        public EventTriggerButton<FeedDiscoverEvents> TriggerButtonDiscoverEvents =>
            new EventTriggerButton<FeedDiscoverEvents>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.DiscoverEvents}')]"));

        /// <summary>
        /// Gets the TriggerButtonCreateNewEvent.
        /// </summary>
        public EventTriggerButton<PageMarketplace> TriggerButtonCreateNewEvent =>
            new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.CreateNewEvent}')]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
