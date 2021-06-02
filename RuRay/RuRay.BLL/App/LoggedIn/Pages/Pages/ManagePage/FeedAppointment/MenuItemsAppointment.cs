using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="MenuItemsAppointment" />.
    /// </summary>
    public class MenuItemsAppointment : MenuItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItemsAppointment"/> class.
        /// </summary>
        public MenuItemsAppointment()
        {
            BaseXPath = "//div[@class='fb_content clearfix ']";
        }

        /// <summary>
        /// Gets the EventTriggerButtonCalendar.
        /// </summary>
        public EventTriggerButton<FeedCalendar> EventTriggerButtonCalendar =>
            new EventTriggerButton<FeedCalendar>(Driver, By.XPath($"//div[text()='{ResLeftNav.Calendar}']"));

        /// <summary>
        /// Gets the EventTriggerButtonRequests.
        /// </summary>
        public EventTriggerButton<FeedRequests> EventTriggerButtonRequests =>
            new EventTriggerButton<FeedRequests>(Driver, By.XPath($"//div[text()='{ResLeftNav.Requests}']"));

        /// <summary>
        /// Gets the EventTriggerButtonContacts.
        /// </summary>
        public EventTriggerButton<FeedContacts> EventTriggerButtonContacts =>
            new EventTriggerButton<FeedContacts>(Driver, By.XPath($"//div[text()='{ResLeftNav.Contacts}']"));

        /// <summary>
        /// Gets the EventTriggerButtonAppointmentSettings.
        /// </summary>
        public EventTriggerButton<FeedAppointmentSettings> EventTriggerButtonAppointmentSettings =>
            new EventTriggerButton<FeedAppointmentSettings>(Driver, By.XPath($"//div[text()='{ResLeftNav.AppointmentSettings}']"));

        /// <summary>
        /// Gets the EventTriggerButtonPromoteBookNowButton.
        /// </summary>
        public EventTriggerButton<DialogPromoteBookNowButton> EventTriggerButtonPromoteBookNowButton =>
            new EventTriggerButton<DialogPromoteBookNowButton>(Driver, By.XPath($"//div[text()='{ResLeftNav.PromoteBookNowButton}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
