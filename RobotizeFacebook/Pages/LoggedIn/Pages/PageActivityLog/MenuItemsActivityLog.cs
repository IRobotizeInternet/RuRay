using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls.TriggerControls;

namespace RobotizeFacebook.Pages.LoggedIn.LeftMenu
{
    public class MenuItemsActivityLog : MenuItems
    {

        public readonly string BaseXPath = $"//div[@data-pagelet='page']/div/div[@aria-label='{ResMiscellaneous.ListOfActivityLogItems}'][@role='navigation']";
        public MenuItemsActivityLog()
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
