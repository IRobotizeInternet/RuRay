using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls.TriggerControls;
using System.Linq;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PopupCreate : BaseDialog
    {
        public PopupCreate()
        {
            BaseXPath = $"//div[@aria-label='{ResHomePageHeader.Create}' and @role='dialog']";
        }

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePageHeader.Create}' and @role='dialog']");

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
