using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls.TriggerControls;

namespace RobotizeFacebook.App.LoggedIn.LeftMenu
{
    public class MenuItemsActivityLog : MenuItems
    {

        public readonly string BaseXPath = $"//div[@data-pagelet='page']/div/div[@aria-label='{ResMiscellaneous.ListOfActivityLogItems}'][@role='navigation']";
        public MenuItemsActivityLog()
        {
        }

        public Hyperlink<DialogActivityLogFilter> LinkActivityLogFilter =>
            new Hyperlink<DialogActivityLogFilter>(Driver, By.XPath($"{BaseXPath}//div[@role='button']/span[contains(text(),'{ResMiscellaneous.Filter}'])"));

        public EventTriggerDiv<DivArchive> DivArchive =>
            new EventTriggerDiv<DivArchive>(Driver, By.XPath($"{BaseXPath}//div[@role='button']//span[contains(text(),{ResMiscellaneous.Archive})]"));

        public EventTriggerDiv<PageTrash> DivTrash =>
           new EventTriggerDiv<PageTrash>(Driver, By.XPath($"{BaseXPath}//div[@role='button']//span[contains(text(),{ResMiscellaneous.Trash})]"));

        //public EventTriggerDiv<FeedContainerReviewPostsYouAreTaggedIn> DivReviewPostsYouAreTaggedIn =>
        //   new EventTriggerDiv<FeedContainerReviewPostsYouAreTaggedIn>(Driver, By.XPath($"{BaseXPath}//div[@role='button']//span[contains(text(),{ResMiscellaneous.ReviewPostsYouAreTaggedIn})]"));

        //public EventTriggerDiv<FeedContainerReviewTagsOnYourPosts> DivReviewTagsOnYourPosts =>
        //   new EventTriggerDiv<FeedContainerReviewTagsOnYourPosts>(Driver, By.XPath($"{BaseXPath}//div[@role='button']//span[contains(text(),{ResMiscellaneous.ReviewTagsOnYourPosts})]"));
    }
}
