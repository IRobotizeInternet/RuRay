using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls.TriggerControls;
using RobotizeToolbox.Dialogs;

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

        public void RunConformance()
        {
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
