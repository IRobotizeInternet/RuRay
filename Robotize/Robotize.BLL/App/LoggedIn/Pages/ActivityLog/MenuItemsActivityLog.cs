using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls.TriggerControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class MenuItemsActivityLog : MenuItems
    {

        public MenuItemsActivityLog()
        {
            BaseXPath = $"//div[@data-pagelet='page']/div/div[@aria-label='{ResMiscellaneous.ListOfActivityLogItems}'][@role='navigation']";
        }

        public Hyperlink<DialogActivityLogFilter> LinkActivityLogFilter =>
            new Hyperlink<DialogActivityLogFilter>(Driver, By.XPath($"{BaseXPath}//div[@role='button']/span[contains(text(),'{ResMiscellaneous.Filter}'])"));

        public EventTriggerDiv<DivArchive> DivArchive =>
            new EventTriggerDiv<DivArchive>(Driver, By.XPath($"{BaseXPath}//div[@role='button']//span[contains(text(),{ResMiscellaneous.Archive})]"));

        public EventTriggerDiv<PageTrash> DivTrash =>
           new EventTriggerDiv<PageTrash>(Driver, By.XPath($"{BaseXPath}//div[@role='button']//span[contains(text(),{ResMiscellaneous.Trash})]"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        //public EventTriggerDiv<FeedContainerReviewPostsYouAreTaggedIn> DivReviewPostsYouAreTaggedIn =>
        //   new EventTriggerDiv<FeedContainerReviewPostsYouAreTaggedIn>(Driver, By.XPath($"{BaseXPath}//div[@role='button']//span[contains(text(),{ResMiscellaneous.ReviewPostsYouAreTaggedIn})]"));

        //public EventTriggerDiv<FeedContainerReviewTagsOnYourPosts> DivReviewTagsOnYourPosts =>
        //   new EventTriggerDiv<FeedContainerReviewTagsOnYourPosts>(Driver, By.XPath($"{BaseXPath}//div[@role='button']//span[contains(text(),{ResMiscellaneous.ReviewTagsOnYourPosts})]"));
    }
}
