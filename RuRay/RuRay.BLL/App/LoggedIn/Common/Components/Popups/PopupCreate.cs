using System.Linq;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PopupCreate" />.
    /// </summary>
    public class PopupCreate : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PopupCreate"/> class.
        /// </summary>
        public PopupCreate()
        {
            BaseXPath = $"//span[text()='{ResHomePageHeader.Create}']/ancestor::div[@role='dialog']";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//span[text()='{ResHomePageHeader.Create}']/ancestor::div[@role='dialog']");

        /// <summary>
        /// Gets the TriggerDivCreatePost.
        /// </summary>
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreatePost =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Post}']"));

        /// <summary>
        /// Gets the TriggerDivCreateStory.
        /// </summary>
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateStory =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Story}']"));

        /// <summary>
        /// Gets the TriggerDivCreateRoom.
        /// </summary>
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateRoom =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Room}']"));

        /// <summary>
        /// Gets the TriggerDivCreatePage.
        /// </summary>
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreatePage =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Page}']"));

        /// <summary>
        /// Gets the TriggerDivCreateAd.
        /// </summary>
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateAd =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Ad}']"));

        /// <summary>
        /// Gets the TriggerDivCreateGroup.
        /// </summary>
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateGroup =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Group}']"));

        /// <summary>
        /// Gets the TriggerDivCreateEvent.
        /// </summary>
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateEvent =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Event}']"));

        /// <summary>
        /// Gets the TriggerDivCreateMarketPlaceListing.
        /// </summary>
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateMarketPlaceListing =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.MarketPlaceListing}']"));

        /// <summary>
        /// Gets the TriggerDivCreateFundraiser.
        /// </summary>
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateFundraiser =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Fundraiser}']"));

        /// <summary>
        /// Gets the SearchboxMenu.
        /// </summary>
        public ComboboxMenu SearchboxMenu => new ComboboxMenu(Driver, null);

        // TODO: This xpath '//input[@placeholder='{ResHomePage.SearchMenu}']/../../..//a' is invalid, please fix it.
        /// <summary>
        /// Gets the ScrollControlUsers.
        /// </summary>
        public ScrollControl<ListItemMenuItem> ScrollControlUsers =>
            new ScrollControl<ListItemMenuItem>(Driver, $"//input[@placeholder='{ResHomePage.SearchMenu}']/../../..//a");

        /// <summary>
        /// Gets the PageCampus.
        /// </summary>
        public EventTriggerButton<PageCampus> PageCampus =>
                    new EventTriggerButton<PageCampus>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Campus}']"));

        /// <summary>
        /// Gets the PageEvents.
        /// </summary>
        public EventTriggerButton<PageEvents> PageEvents =>
                    new EventTriggerButton<PageEvents>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Events}']"));

        /// <summary>
        /// Gets the PageFriends.
        /// </summary>
        public EventTriggerButton<PageFriends> PageFriends =>
                    new EventTriggerButton<PageFriends>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Friends}']"));

        /// <summary>
        /// Gets the PageGroups.
        /// </summary>
        public EventTriggerButton<PageGroup> PageGroups =>
                    new EventTriggerButton<PageGroup>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Groups}']"));

        /// <summary>
        /// Gets the PageNewsFeed.
        /// </summary>
        public EventTriggerButton<PageHome> PageNewsFeed =>
                    new EventTriggerButton<PageHome>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.NewsFeed}']"));

        /// <summary>
        /// Gets the PagePages.
        /// </summary>
        public EventTriggerButton<PagePages> PagePages =>
                    new EventTriggerButton<PagePages>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Pages}']"));

        /// <summary>
        /// Gets the PageGames.
        /// </summary>
        public EventTriggerButton<PageGames> PageGames =>
                    new EventTriggerButton<PageGames>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Games}']"));

        /// <summary>
        /// Gets the PageWatch.
        /// </summary>
        public EventTriggerButton<PageWatch> PageWatch =>
                    new EventTriggerButton<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Watch}']"));

        /// <summary>
        /// Gets the PageFacebookPay.
        /// </summary>
        public EventTriggerButton<PageFacebookPay> PageFacebookPay =>
                    new EventTriggerButton<PageFacebookPay>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.FacebookPay}']"));

        /// <summary>
        /// Gets the PageMarketplace.
        /// </summary>
        public EventTriggerButton<PageMarketplace> PageMarketplace =>
                    new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Marketplace}']"));

        /// <summary>
        /// Gets the PageOffers.
        /// </summary>
        public EventTriggerButton<PageOffers> PageOffers =>
                    new EventTriggerButton<PageOffers>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.Offers}']"));

        /// <summary>
        /// Gets the PageMemories.
        /// </summary>
        public EventTriggerButton<PageMemories> PageMemories =>
                    new EventTriggerButton<PageMemories>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Memories}']"));

        /// <summary>
        /// Gets the PageSaved.
        /// </summary>
        public EventTriggerButton<PageSaved> PageSaved =>
                    new EventTriggerButton<PageSaved>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Saved}']"));

        /// <summary>
        /// Gets the PageWeather.
        /// </summary>
        public EventTriggerButton<PageWeather> PageWeather =>
                    new EventTriggerButton<PageWeather>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Weather}']"));

        /// <summary>
        /// Gets the PageAds.
        /// </summary>
        public EventTriggerButton<PageAdCenter> PageAds =>
                    new EventTriggerButton<PageAdCenter>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Ads}']"));

        /// <summary>
        /// Gets the PageJobs.
        /// </summary>
        public EventTriggerButton<PageJobs> PageJobs =>
                    new EventTriggerButton<PageJobs>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Jobs}']"));

        /// <summary>
        /// Gets the PageFundraisers.
        /// </summary>
        public EventTriggerButton<PageFundraisers> PageFundraisers =>
                    new EventTriggerButton<PageFundraisers>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Fundraisers}']"));

        /// <summary>
        /// Gets the PageMessenger.
        /// </summary>
        public EventTriggerButton<PageMessages> PageMessenger =>
                    new EventTriggerButton<PageMessages>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Messenger}']"));

        /// <summary>
        /// Gets the PageMessengerKids.
        /// </summary>
        public EventTriggerButton<PageMessengerKids> PageMessengerKids =>
                    new EventTriggerButton<PageMessengerKids>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.MessengerKids}']"));

        /// <summary>
        /// The RunConformanceButtonFriendsExcept.
        /// </summary>
        public void RunConformanceButtonFriendsExcept()
        {
            var post = TriggerDivCreatePost.Click();
            var privacyDialog = post.TriggerEditPrivacyDialog.Click();
            var exceptFriends = privacyDialog.ButtonFriendsExcept.Click();
            exceptFriends.ComboboxSearchFriends.Select("TestName");
            post = exceptFriends.TriggerSaveChangesButton.Click();
            privacyDialog = post.TriggerEditPrivacyDialog.Click();
            exceptFriends = privacyDialog.ButtonFriendsExcept.Click();
            var itemToRemove = exceptFriends.FriendsWhoWontSeeYourPost.Where(x => x.GetAttribute("aria-label").Contains("Faisal")).FirstOrDefault();
            itemToRemove.Click();
            exceptFriends.TriggerCancelChangesButton.Click();
        }

        /// <summary>
        /// The RunConformanceButtonSpecificFriends.
        /// </summary>
        public void RunConformanceButtonSpecificFriends()
        {
            var post = TriggerDivCreatePost.Click();
            var privacyDialog = post.TriggerEditPrivacyDialog.Click();
            var specificFriends = privacyDialog.ButtonSpecificFriends.Click();
            specificFriends.ComboboxSearchFriends.Select("TestName");
            post = specificFriends.TriggerSaveChangesButton.Click();
            privacyDialog = post.TriggerEditPrivacyDialog.Click();
            specificFriends = privacyDialog.ButtonSpecificFriends.Click();
            var itemToRemove = specificFriends.FriendsWhoWontSeeYourPost.Where(x => x.GetAttribute("aria-label").Contains("Faisal")).FirstOrDefault();
            itemToRemove.Click();
            specificFriends.TriggerCancelChangesButton.Click();
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            RunConformanceButtonSpecificFriends();
            RunConformanceButtonFriendsExcept();
            var post = TriggerDivCreatePost.Click();
            var p = post.ButtonBackGroundOptions.Click();
            var moreBGImages = p.ButtonMoreBackgroundOptionsDialog.Click();
            moreBGImages.GetPopularBackground(PostBackgroundcolor.BlueMountains);
            TriggerDivCreateStory.Click();
            TriggerDivCreateRoom.Click();
            TriggerDivCreatePage.Click();
            TriggerDivCreateAd.Click();
            TriggerDivCreateGroup.Click();
            TriggerDivCreateEvent.Click();
            TriggerDivCreateMarketPlaceListing.Click();
            TriggerDivCreateFundraiser.Click();
        }
    }
}
