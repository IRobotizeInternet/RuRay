using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class MenuItemsMarketPlace : MenuItems
    {
        public EventTriggerButton<PageMarketplace> TriggerButtonBrowerAll => 
            new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.BrowseAll}')]"));
        public EventTriggerButton<FeedContainerNotifications> TriggerButtonNotification =>
           new EventTriggerButton<FeedContainerNotifications>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Notifications}')]"));
        public EventTriggerButton<FeedMarketplaceCart> TriggerButtonCart =>
           new EventTriggerButton<FeedMarketplaceCart>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Cart}')]"));
        public EventTriggerButton<PageMarketPlaceYourAccount> TriggerButtonYourAccount =>
           new EventTriggerButton<PageMarketPlaceYourAccount>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.YourAccount}')]"));
        public EventTriggerButton<PageCreateNewListing> TriggerButtonCreateNewListings =>
           new EventTriggerButton<PageCreateNewListing>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.CreateNewListing}')]"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
