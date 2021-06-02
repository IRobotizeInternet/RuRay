using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PageHome" />.
    /// </summary>
    public class PageHome : BasePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageHome"/> class.
        /// </summary>
        public PageHome()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageHome"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public PageHome(RemoteWebDriver driver)
        {
            _editorHome = new EditorHome(driver);
        }

        // This is work in progress, which requires more work. Read the code carefully before making use of these generics.
        /// <summary>
        /// Defines the _editorHome.
        /// </summary>
        private readonly EditorHome _editorHome;

        /// <summary>
        /// Gets the SectionHeader.
        /// </summary>
        public Header SectionHeader => _editorHome.PageHeader;

        /// <summary>
        /// Gets the SectionLeftMenuItems.
        /// </summary>
        public LeftMenuItemsHome SectionLeftMenuItems => _editorHome.LeftMenu;

        /// <summary>
        /// Gets the SectionFeedHome.
        /// </summary>
        public FeedHome SectionFeedHome => _editorHome.FeedContainer;

        /// <summary>
        /// Gets the EventTriggerButtonCreateStory.
        /// </summary>
        public EventTriggerButton<PageCreateAStory> EventTriggerButtonCreateStory =>
            new EventTriggerButton<PageCreateAStory>(Driver, By.XPath($"//div[@data-pagelet='Stories']//span[text()='{ResHomePage.CreateAStory}']"));

        /// <summary>
        /// Gets the EventTriggerButtonSeeAllStories.
        /// </summary>
        public EventTriggerButton<PageStories> EventTriggerButtonSeeAllStories =>
            new EventTriggerButton<PageStories>(Driver, By.XPath($"//div[@data-pagelet='Stories']//span[text()='{ResHomePage.SeeAllStories}']"));

        /// <summary>
        /// Gets the EventTriggerButtonLiveVideo.
        /// </summary>
        public EventTriggerButton<PageLiveProducer> EventTriggerButtonLiveVideo =>
            new EventTriggerButton<PageLiveProducer>(Driver, By.XPath($"//div[@role='main']//span[text()='{ResCreatePost.LiveVideo}']"));

        /// <summary>
        /// Gets the EventTriggerButtonPhotoOrVideo.
        /// </summary>
        public EventTriggerButton<DialogCreatePost> EventTriggerButtonPhotoOrVideo =>
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"//div[@role='main']//span[text()='{ResCreatePost.PhotoOrVideo}']"));

        /// <summary>
        /// Gets the EventTriggerButtonFeelingOrActivity.
        /// </summary>
        public EventTriggerButton<DialogCreatePost> EventTriggerButtonFeelingOrActivity =>
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"//div[@role='main']//span[text()='{ResCreatePost.FeelingOrActivity}']"));

        /// <summary>
        /// Gets the EventTriggerButtonCreateNewRoom.
        /// </summary>
        public EventTriggerButton<DialogCreateYourRoom> EventTriggerButtonCreateNewRoom =>
            new EventTriggerButton<DialogCreateYourRoom>(Driver, By.XPath($"//div[@role='main']//span[text()='{ResCreatePost.NewRoom}' or text()='{ResCreatePost.CreateRoom}']"));

        /// <summary>
        /// Gets the AllOnlineFriends.
        /// </summary>
        public IEnumerable<ButtonImage> AllOnlineFriends =>
            Driver.FindElements(By.XPath($"//div[@role='main']//div[contains(@aria-label,'{ResCreatePost.FriendRoomTile}')]"))?
            .Select(x => new ButtonImage(Driver, By.XPath(x.Text.Substring(x.Text.IndexOf($"{ResCreatePost.FriendRoomTile}"), ResCreatePost.FriendRoomTile.Length))));

        /// <summary>
        /// Gets the ButtonUndo.
        /// </summary>
        public Button ButtonUndo => new Button(Driver, By.XPath($"//span[text()='{ResHomePage.Undo}']"));

        /// <summary>
        /// Gets the EventTriggerButtonNewMessage.
        /// </summary>
        public EventTriggerButton<PopupNewMessage> EventTriggerButtonNewMessage =>
            new EventTriggerButton<PopupNewMessage>(Driver, By.XPath($"//div[@aria-label='{ResCreatePost.NewMessage}']"));

        /// <summary>
        /// Defines the _feed.
        /// </summary>
        public FeedHome _feed;

        /// <summary>
        /// Gets the Feed.
        /// </summary>
        public FeedHome Feed
        {
            get
            {
                if (_feed == null)
                {
                    _feed = new FeedHome();
                }

                return _feed;
            }
        }

        /// <summary>
        /// Gets the PageUrl.
        /// </summary>
        public override string PageUrl => "/";

        /// <summary>
        /// Gets the ByForPage.
        /// </summary>
        public override By ByForPage => throw new System.NotImplementedException();

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            RunConformanceReactions();
            RunConformanceReactionsWindow();
            RunConformanceShareWindow();
        }

        /// <summary>
        /// The RunConformanceReactions.
        /// </summary>
        public void RunConformanceReactions()
        {
            // Verify all the reaction buttons.
            Feed.FeedScroll.ScrollingDownWithAGivenInterval(3, scrollFromCurrentLocation: true);
            var likeButton = Feed.FeedScroll.ListITem.ButtonLike;
            likeButton.Hoverover().ButtonReactionLike.Click();
            Thread.Sleep(2000);
            likeButton.Click();

            // Clicking on the comment box to move the fox from button, otherwise it will
            Feed.FeedScroll.ListITem.EventTriggerButtonComment.Click();
            likeButton.Hoverover().ButtonReactionWow.Click();
            Thread.Sleep(2000);
            likeButton.Click();
            Feed.FeedScroll.ListITem.EventTriggerButtonComment.Click();
            likeButton.Hoverover().ButtonReactionSad.Click();
            Thread.Sleep(2000);
            likeButton.Click();
            Feed.FeedScroll.ListITem.EventTriggerButtonComment.Click();
            likeButton.Hoverover().ButtonReactionHaha.Click();
            Thread.Sleep(2000);
            likeButton.Click();
            Feed.FeedScroll.ListITem.EventTriggerButtonComment.Click();
            likeButton.Hoverover().ButtonReactionCare.Click();
            Thread.Sleep(2000);
            likeButton.Click();
            Feed.FeedScroll.ListITem.EventTriggerButtonComment.Click();
            likeButton.Hoverover().ButtonReactionAngry.Click();
            Thread.Sleep(2000);
            likeButton.Click();
        }

        /// <summary>
        /// The RunConformanceReactionsWindow.
        /// </summary>
        public void RunConformanceReactionsWindow()
        {
            Feed.FeedScroll.ScrollingUpWithAGivenInterval(1, scrollFromCurrentLocation: true);
            var reactionsWindow = Feed.FeedScroll.ListITem.EventTriggerButtonSeeWhoReactedToThis.Click();
            reactionsWindow.ScrollReactions.ScrollDownMore();
            reactionsWindow.ButtonAllReactions.Click();
            reactionsWindow.ButtonReactionsAtFirstIndex.Click();
            reactionsWindow.ButtonReactionsAtSecondIndex.Click();
            reactionsWindow.ButtonReactionsAtThirdIndex.Click();
            reactionsWindow.ButtonReactionsAtFourthIndex.Click();
            reactionsWindow.ButtonReactionsAtFifthIndex.Click();
            reactionsWindow.ButtonReactionsAtSixthIndex.Click();
            reactionsWindow.ButtonReactionsAtSeventhIndex.Click();
            reactionsWindow.ButtonAllReactions.Click();
            reactionsWindow.ScrollReactions.ScrollDownMore();
            reactionsWindow.ScrollReactions.ScrollUpMore();
            Thread.Sleep(5000);
        }

        /// <summary>
        /// The RunConformanceShareWindow.
        /// </summary>
        public void RunConformanceShareWindow()
        {
            Feed.FeedScroll.ScrollingUpWithAGivenInterval(1, scrollFromCurrentLocation: true);
            var item = Feed.FeedScroll.ListITem;
            item.EventTriggerButtonComment.Click();
            var peopleWhoSharedDialog = item.EventTriggerButtonPeopleWhoSharedThis.Click();
            //peopleWhoSharedDialog.ScrollPeopleWhoSharedThis.ScrollDownMore();
            var listItemScroll = peopleWhoSharedDialog.ScrollPeopleWhoSharedThis;
            listItemScroll.ScrollDownMore();
            listItemScroll.ScrollUpMore();
            listItemScroll.ScrollingDownWithAGivenInterval();
            var reactions = listItemScroll.ListITem.ButtonLike.Click();
            reactions.ButtonReactionLike.Click();
            //listItemScroll.ListITem.ButtonShowAttachment
            var dialogShare = listItemScroll.ListITem.EventTriggerButtonShare.Click();
            var text = dialogShare.ButtonShareNowPublic.GetText();
            text = dialogShare.ButtonShareToNewsFeed.GetText();

            text = dialogShare.EventTriggerButtonShareToYourStoryFriends.GetText();

            var dialogSendInMessanger = dialogShare.EventTriggerButtonSendInMessenger.Click();
            dialogSendInMessanger.ScrollSendInMessenger.ScrollingUpWithAGivenInterval(6);
            dialogSendInMessanger.ComboboxSearchFriends.Select("Wei");
            dialogSendInMessanger.ScrollSendInMessenger.ListITem.ButtonSend.Click();
        }
    }
}
