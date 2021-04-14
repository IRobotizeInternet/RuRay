using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class MenuItemsAppointment : MenuItems
    {
        public MenuItemsAppointment()
        {
            BaseXPath = "//div[@class='fb_content clearfix ']";
        }

        public EventTriggerButton<FeedCalendar> EventTriggerButtonCalendar =>
            new EventTriggerButton<FeedCalendar>(Driver, By.XPath($"//div[text()='{ResLeftNav.Calendar}']"));
        public EventTriggerButton<FeedRequests> EventTriggerButtonRequests =>
            new EventTriggerButton<FeedRequests>(Driver, By.XPath($"//div[text()='{ResLeftNav.Requests}']"));
        public EventTriggerButton<FeedContacts> EventTriggerButtonContacts =>
            new EventTriggerButton<FeedContacts>(Driver, By.XPath($"//div[text()='{ResLeftNav.Contacts}']"));
        public EventTriggerButton<FeedAppointmentSettings> EventTriggerButtonAppointmentSettings =>
            new EventTriggerButton<FeedAppointmentSettings>(Driver, By.XPath($"//div[text()='{ResLeftNav.AppointmentSettings}']"));
        public EventTriggerButton<DialogPromoteBookNowButton> EventTriggerButtonPromoteBookNowButton =>
            new EventTriggerButton<DialogPromoteBookNowButton>(Driver, By.XPath($"//div[text()='{ResLeftNav.PromoteBookNowButton}']"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
