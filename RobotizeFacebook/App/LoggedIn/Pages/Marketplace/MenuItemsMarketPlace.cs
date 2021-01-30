using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class MenuItemsMarketPlace : MenuItems
    {
        public EventTriggerButton<PageMarketplace> TriggerButtonBrowerAll => 
            new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.BrowseAll}')]"));
        public EventTriggerButton<FeedNotifications> TriggerButtonNotification =>
           new EventTriggerButton<FeedNotifications>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Notifications}')]"));
        public EventTriggerButton<FeedMarketplaceCart> TriggerButtonCart =>
           new EventTriggerButton<FeedMarketplaceCart>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Cart}')]"));
        public EventTriggerButton<PageMarketplaceYourAccount> TriggerButtonYourAccount =>
           new EventTriggerButton<PageMarketplaceYourAccount>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.YourAccount}')]"));
        public EventTriggerButton<PageCreateNewListing> TriggerButtonCreateNewListings =>
           new EventTriggerButton<PageCreateNewListing>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.CreateNewListing}')]"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
