using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn
{
    public class MenuItemsMarketPlace : MenuItems
    {
        public EventTriggerButton<PageMarketplace> TriggerButtonBrowerAll => 
            new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.BrowseAll}')]"));
        public EventTriggerButton<FeedNo> TriggerButtonNotification =>
           new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Notifications}')]"));
        public EventTriggerButton<PageMarketplace> TriggerButtonCart =>
           new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Cart}')]"));
        public EventTriggerButton<PageMarketplace> TriggerButtonYourAccount =>
           new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.YourAccount}')]"));
        public EventTriggerButton<PageMarketplace> TriggerButtonCreateNewListings =>
           new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.CreateNewListing}')]"));
    }
}
