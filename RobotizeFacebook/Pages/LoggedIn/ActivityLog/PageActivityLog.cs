using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls.TriggerControls;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PageActivityLog : PageBase
    {
        public override string PageUrl => "/allactivity/";

        public readonly string BaseXPath = $"//div[@data-pagelet='page']/div/div[@aria-label='{ResMiscellaneous.ListOfActivityLogItems}'][@role='navigation']";
        public PageActivityLog(RemoteWebDriver driver, WebDriverWait wait)
        {
            
        }

        public Hyperlink<DialogActivityLogFilter> LinkActivityLogFilter => 
            new Hyperlink<DialogActivityLogFilter>(Driver, Wait, By.XPath($"{BaseXPath}//div[@role='button']/span[contains(text(),'{ResMiscellaneous.Filter}'])"));

        public EventTriggerDiv<DivArchive> DivArchive => 
            new EventTriggerDiv<DivArchive>(Driver, Wait, By.XPath($"{BaseXPath}//div[@role='button']//span[contains(text(),{ResMiscellaneous.Archive})]"));

        public EventTriggerDiv<DivTrash> DivTrash =>
           new EventTriggerDiv<DivTrash>(Driver, Wait, By.XPath($"{BaseXPath}//div[@role='button']//span[contains(text(),{ResMiscellaneous.Trash})]"));

        public EventTriggerDiv<DivReviewPostsYouAreTaggedIn> DivReviewPostsYouAreTaggedIn =>
           new EventTriggerDiv<DivReviewPostsYouAreTaggedIn>(Driver, Wait, By.XPath($"{BaseXPath}//div[@role='button']//span[contains(text(),{ResMiscellaneous.ReviewPostsYouAreTaggedIn})]"));

        public EventTriggerDiv<DivReviewPhotosYouMightBeIn> DivReviewPhotosYouMightBeIn =>
           new EventTriggerDiv<DivReviewPhotosYouMightBeIn>(Driver, Wait, By.XPath($"{BaseXPath}//div[@role='button']//span[contains(text(),{ResMiscellaneous.ReviewPhotosYouMightBeIn})]"));

        public EventTriggerDiv<DivReviewTagsOnYourPosts> DivReviewTagsOnYourPosts =>
           new EventTriggerDiv<DivReviewTagsOnYourPosts>(Driver, Wait, By.XPath($"{BaseXPath}//div[@role='button']//span[contains(text(),{ResMiscellaneous.ReviewTagsOnYourPosts})]"));
    }
}
