using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class MenuItemsYourAccount : MenuItems
    {
        public EventTriggerButton<PageMarketPlaceYourAccount> TriggerButtonYourListings => 
            new EventTriggerButton<PageMarketPlaceYourAccount>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.YourListings}')]"));
        public EventTriggerButton<FeedYourAccountSaved> TriggerButtonSaved =>
           new EventTriggerButton<FeedYourAccountSaved>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Saved}')]"));
        public EventTriggerButton<FeedYourAccountFollowing> TriggerButtonFollowing =>
           new EventTriggerButton<FeedYourAccountFollowing>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Following}')]"));
        public EventTriggerButton<FeedYourAccountRecentActivity> TriggerButtonRecentActivity =>
           new EventTriggerButton<FeedYourAccountRecentActivity>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.RecentActivity}')]"));
        public EventTriggerButton<DialogCommerceProfile> TriggerButtonCommerceProfile =>
           new EventTriggerButton<DialogCommerceProfile>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.CommerceProfile}')]"));
        public EventTriggerButton<PageCreateNewListing> TriggerButtonCreateNewListings =>
           new EventTriggerButton<PageCreateNewListing>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.CreateNewListing}')]"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
