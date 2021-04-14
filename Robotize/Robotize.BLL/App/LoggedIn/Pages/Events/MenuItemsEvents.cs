using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class MenuItemsEvents : MenuItems
    {
        public EventTriggerButton<FeedEventHome> TriggerButtonHome =>
            new EventTriggerButton<FeedEventHome>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Home}')]"));
        public EventTriggerButton<FeedYourEvents> TriggerButtonYourEvents =>
            new EventTriggerButton<FeedYourEvents>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.YourEvents}')]"));
        public EventTriggerButton<FeedBirthdays> TriggerButtonBirthdays =>
            new EventTriggerButton<FeedBirthdays>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Birthdays}')]"));
        public EventTriggerButton<FeedDiscoverEvents> TriggerButtonDiscoverEvents =>
            new EventTriggerButton<FeedDiscoverEvents>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.DiscoverEvents}')]"));
        public EventTriggerButton<PageMarketplace> TriggerButtonCreateNewEvent =>
            new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.CreateNewEvent}')]"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
