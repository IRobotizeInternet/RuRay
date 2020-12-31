using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls.TriggerControls;
using RobotizeToolbox.Dialogs;
using System.Linq;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PopupCreate : BaseDialog
    {
        public PopupCreate(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            BaseXPath = $"//div[@aria-label='{ResHomePageHeader.Create}' and @role='dialog']";
        }

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePageHeader.Create}' and @role='dialog']");

        public EventTriggerDiv<DialogCreatePost> TriggerDivCreatePost => 
                    new EventTriggerDiv<DialogCreatePost>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Post}']"));
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateStory =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Story}']"));
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateRoom =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Room}']"));
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreatePage =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Page}']"));
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateAd =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Ad}']"));
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateGroup =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Group}']"));
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateEvent =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Event}']"));
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateMarketPlaceListing =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.MarketPlaceListing}']"));
        public EventTriggerDiv<DialogCreatePost> TriggerDivCreateFundraiser =>
                    new EventTriggerDiv<DialogCreatePost>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.Fundraiser}']"));


        public void RunConformanceButtonFriendsExcept()
        {
            var post = TriggerDivCreatePost.Click();
            var privacyDialog = post.TriggerEditPrivacyDialog.Click();
            var exceptFriends = privacyDialog.ButtonFriendsExcept.Click();
            exceptFriends.ComboboxSearchFriends.Select("Faisal");
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
            specificFriends.ComboboxSearchFriends.Select("Faisal");
            post = specificFriends.TriggerSaveChangesButton.Click();
            privacyDialog = post.TriggerEditPrivacyDialog.Click();
            specificFriends = privacyDialog.ButtonFriendsExcept.Click();
            var itemToRemove = specificFriends.FriendsWhoWontSeeYourPost.Where(x => x.GetAttribute("aria-label").Contains("Faisal")).FirstOrDefault();
            itemToRemove.Click();
            specificFriends.TriggerCancelChangesButton.Click();
        }

        public void RunConformance()
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
