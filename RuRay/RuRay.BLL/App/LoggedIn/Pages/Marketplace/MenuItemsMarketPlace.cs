using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="MenuItemsMarketPlace" />.
    /// </summary>
    public class MenuItemsMarketPlace : MenuItems
    {
        /// <summary>
        /// Gets the TriggerButtonBrowerAll.
        /// </summary>
        public EventTriggerButton<PageMarketplace> TriggerButtonBrowerAll =>
            new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.BrowseAll}')]"));

        /// <summary>
        /// Gets the TriggerButtonNotification.
        /// </summary>
        public EventTriggerButton<FeedContainerNotifications> TriggerButtonNotification =>
           new EventTriggerButton<FeedContainerNotifications>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Notifications}')]"));

        /// <summary>
        /// Gets the TriggerButtonCart.
        /// </summary>
        public EventTriggerButton<FeedMarketplaceCart> TriggerButtonCart =>
           new EventTriggerButton<FeedMarketplaceCart>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Cart}')]"));

        /// <summary>
        /// Gets the TriggerButtonYourAccount.
        /// </summary>
        public EventTriggerButton<PageMarketPlaceYourAccount> TriggerButtonYourAccount =>
           new EventTriggerButton<PageMarketPlaceYourAccount>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.YourAccount}')]"));

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
