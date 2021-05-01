using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Controls.TriggerControls;
using System.Linq;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PopupCreate : BaseDialog
    {
        public PopupCreate()
        {
            BaseXPath = $"//span[text()='{ResHomePageHeader.Create}']/ancestor::div[@role='dialog']";
        }

        protected override By ByForDialog => By.XPath($"//span[text()='{ResHomePageHeader.Create}']/ancestor::div[@role='dialog']");

        public EventTriggerDiv<DialogCreatePost> TriggerDivCreatePost => 
                    new EventTriggerDiv<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Post}']"));
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateStory =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Story}']"));
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateRoom =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Room}']"));
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreatePage =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Page}']"));
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateAd =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Ad}']"));
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateGroup =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Group}']"));
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateEvent =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Event}']"));
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateMarketPlaceListing =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.MarketPlaceListing}']"));
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateFundraiser =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Fundraiser}']"));

        public EventTriggerButton<PageCampus> PageCampus => 
                    new EventTriggerButton<PageCampus>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Campus}']"));
        public EventTriggerButton<PageEvents> PageEvents => 
                    new EventTriggerButton<PageEvents>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Events}']"));
        public EventTriggerButton<PageFriends> PageFriends => 
                    new EventTriggerButton<PageFriends>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Friends}']"));
        public EventTriggerButton<PageGroup> PageGroups => 
                    new EventTriggerButton<PageGroup>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Groups}']"));
        public EventTriggerButton<PageHome> PageNewsFeed => 
                    new EventTriggerButton<PageHome>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.NewsFeed}']"));
        public EventTriggerButton<PagePages> PagePages => 
                    new EventTriggerButton<PagePages>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Pages}']"));
        public EventTriggerButton<PageGames> PageGames => 
                    new EventTriggerButton<PageGames>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Games}']"));
        public EventTriggerButton<PageWatch> PageWatch => 
                    new EventTriggerButton<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Watch}']"));
        public EventTriggerButton<PageFacebookPay> PageFacebookPay => 
                    new EventTriggerButton<PageFacebookPay>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.FacebookPay}']"));
        public EventTriggerButton<PageMarketplace> PageMarketplace => 
                    new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Marketplace}']"));
        public EventTriggerButton<PageOffers> PageOffers => 
                    new EventTriggerButton<PageOffers>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.Offers}']"));
        public EventTriggerButton<PageMemories> PageMemories => 
                    new EventTriggerButton<PageMemories>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Memories}']"));
        public EventTriggerButton<PageSaved> PageSaved => 
                    new EventTriggerButton<PageSaved>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Saved}']"));
        public EventTriggerButton<PageWeather> PageWeather => 
                    new EventTriggerButton<PageWeather>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Weather}']"));
        public EventTriggerButton<PageAdCenter> PageAds => 
                    new EventTriggerButton<PageAdCenter>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Ads}']"));
        public EventTriggerButton<PageJobs> PageJobs => 
                    new EventTriggerButton<PageJobs>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Jobs}']"));
        public EventTriggerButton<PageFundraisers> PageFundraisers => 
                    new EventTriggerButton<PageFundraisers>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Fundraisers}']"));
        public EventTriggerButton<PageMessages> PageMessenger => 
                    new EventTriggerButton<PageMessages>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Messenger}']"));
        public EventTriggerButton<PageMessengerKids> PageMessengerKids => 
                    new EventTriggerButton<PageMessengerKids>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.MessengerKids}']"));
        
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
