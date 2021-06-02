using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="MenuItemsYourAccount" />.
    /// </summary>
    public class MenuItemsYourAccount : MenuItems
    {
        /// <summary>
        /// Gets the TriggerButtonYourListings.
        /// </summary>
        public EventTriggerButton<PageMarketPlaceYourAccount> TriggerButtonYourListings =>
            new EventTriggerButton<PageMarketPlaceYourAccount>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.YourListings}')]"));

        /// <summary>
        /// Gets the TriggerButtonSaved.
        /// </summary>
        public EventTriggerButton<FeedYourAccountSaved> TriggerButtonSaved =>
           new EventTriggerButton<FeedYourAccountSaved>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Saved}')]"));

        /// <summary>
        /// Gets the TriggerButtonFollowing.
        /// </summary>
        public EventTriggerButton<FeedYourAccountFollowing> TriggerButtonFollowing =>
           new EventTriggerButton<FeedYourAccountFollowing>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Following}')]"));

        /// <summary>
        /// Gets the TriggerButtonRecentActivity.
        /// </summary>
        public EventTriggerButton<FeedYourAccountRecentActivity> TriggerButtonRecentActivity =>
           new EventTriggerButton<FeedYourAccountRecentActivity>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.RecentActivity}')]"));

        /// <summary>
        /// Gets the TriggerButtonCommerceProfile.
        /// </summary>
        public EventTriggerButton<DialogCommerceProfile> TriggerButtonCommerceProfile =>
           new EventTriggerButton<DialogCommerceProfile>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.CommerceProfile}')]"));

        /// <summary>
        /// Gets the TriggerButtonCreateNewListings.
        /// </summary>
        public EventTriggerButton<PageCreateNewListing> TriggerButtonCreateNewListings =>
           new EventTriggerButton<PageCreateNewListing>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.CreateNewListing}')]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
