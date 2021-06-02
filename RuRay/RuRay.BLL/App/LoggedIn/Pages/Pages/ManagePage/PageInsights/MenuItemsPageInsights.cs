using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="MenuItemsPageInsights" />.
    /// </summary>
    public class MenuItemsPageInsights : MenuItems
    {
        /// <summary>
        /// Gets the EventTriggerButtonCreatePage.
        /// </summary>
        public EventTriggerButton<AfterSaveControls> EventTriggerButtonCreatePage =>
            new EventTriggerButton<AfterSaveControls>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Overview}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonFollowers.
        /// </summary>
        public EventTriggerButton<FeedFollowers> EventTriggerButtonFollowers =>
            new EventTriggerButton<FeedFollowers>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Followers}')]"));

        // TODO: Need to add a logic to a page that loads up a feed with a given parameter. 
        //public EventTriggerButton<FeedAdCenter> EventTriggerButtonAds =>
        //    new EventTriggerButton<FeedAdCenter>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Ads}')]"));
        /// <summary>
        /// Gets the EventTriggerButtonLikes.
        /// </summary>
        public EventTriggerButton<FeedLikes> EventTriggerButtonLikes =>
            new EventTriggerButton<FeedLikes>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Likes}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonReach.
        /// </summary>
        public EventTriggerButton<FeedReach> EventTriggerButtonReach =>
            new EventTriggerButton<FeedReach>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Reach}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonPageViews.
        /// </summary>
        public EventTriggerButton<FeedPageViews> EventTriggerButtonPageViews =>
            new EventTriggerButton<FeedPageViews>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.PageViews}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonPagePreviews.
        /// </summary>
        public EventTriggerButton<FeedPagePreviews> EventTriggerButtonPagePreviews =>
            new EventTriggerButton<FeedPagePreviews>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.PagePreviews}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonActionsOnPage.
        /// </summary>
        public EventTriggerButton<FeedActionsOnPage> EventTriggerButtonActionsOnPage =>
            new EventTriggerButton<FeedActionsOnPage>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.ActionsOnPage}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonPosts.
        /// </summary>
        public EventTriggerButton<FeedPosts> EventTriggerButtonPosts =>
            new EventTriggerButton<FeedPosts>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Posts}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonEvents.
        /// </summary>
        public EventTriggerButton<FeedEvents> EventTriggerButtonEvents =>
            new EventTriggerButton<FeedEvents>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Events}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonVideos.
        /// </summary>
        public EventTriggerButton<FeedVideos> EventTriggerButtonVideos =>
            new EventTriggerButton<FeedVideos>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Videos}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonStories.
        /// </summary>
        public EventTriggerButton<FeedStories> EventTriggerButtonStories =>
            new EventTriggerButton<FeedStories>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Stories}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonMessages.
        /// </summary>
        public EventTriggerButton<AfterSaveControls> EventTriggerButtonMessages =>
            new EventTriggerButton<AfterSaveControls>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Messages}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonOrders.
        /// </summary>
        public EventTriggerButton<FeedOrders> EventTriggerButtonOrders =>
            new EventTriggerButton<FeedOrders>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Orders}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonPromote.
        /// </summary>
        public EventTriggerButton<FeedPromote> EventTriggerButtonPromote =>
            new EventTriggerButton<FeedPromote>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.Promote}')]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
