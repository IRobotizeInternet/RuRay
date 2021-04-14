using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class MenuItemsPageInsights : MenuItems
    {
        public EventTriggerButton<AfterSaveControls> EventTriggerButtonCreatePage =>
            new EventTriggerButton<AfterSaveControls>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Overview}')]"));
        public EventTriggerButton<FeedFollowers> EventTriggerButtonFollowers =>
            new EventTriggerButton<FeedFollowers>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Followers}')]"));

        // TODO: Need to add a logic to a page that loads up a feed with a given parameter. 
        //public EventTriggerButton<FeedAdCenter> EventTriggerButtonAds =>
        //    new EventTriggerButton<FeedAdCenter>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Ads}')]"));
        public EventTriggerButton<FeedLikes> EventTriggerButtonLikes =>
            new EventTriggerButton<FeedLikes>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Likes}')]"));
        public EventTriggerButton<FeedReach> EventTriggerButtonReach =>
            new EventTriggerButton<FeedReach>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Reach}')]"));
        public EventTriggerButton<FeedPageViews> EventTriggerButtonPageViews =>
            new EventTriggerButton<FeedPageViews>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.PageViews}')]"));
        public EventTriggerButton<FeedPagePreviews> EventTriggerButtonPagePreviews =>
            new EventTriggerButton<FeedPagePreviews>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.PagePreviews}')]"));
        public EventTriggerButton<FeedActionsOnPage> EventTriggerButtonActionsOnPage =>
            new EventTriggerButton<FeedActionsOnPage>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.ActionsOnPage}')]"));
        public EventTriggerButton<FeedPosts> EventTriggerButtonPosts =>
            new EventTriggerButton<FeedPosts>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Posts}')]"));
        public EventTriggerButton<FeedEvents> EventTriggerButtonEvents =>
            new EventTriggerButton<FeedEvents>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Events}')]"));
        public EventTriggerButton<FeedVideos> EventTriggerButtonVideos =>
            new EventTriggerButton<FeedVideos>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Videos}')]"));
        public EventTriggerButton<FeedStories> EventTriggerButtonStories =>
            new EventTriggerButton<FeedStories>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Stories}')]"));
        public EventTriggerButton<AfterSaveControls> EventTriggerButtonMessages =>
            new EventTriggerButton<AfterSaveControls>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Messages}')]"));
        public EventTriggerButton<FeedOrders> EventTriggerButtonOrders =>
            new EventTriggerButton<FeedOrders>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Orders}')]"));
        public EventTriggerButton<FeedPromote> EventTriggerButtonPromote =>
            new EventTriggerButton<FeedPromote>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Promote}')]"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
