using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageHome : BasePage
    {
        public PageHome()
        {
        }

        public PageHome(RemoteWebDriver driver)
        {
        }

        public EventTriggerButton<PageCreateAStory> EventTriggerButtonCreateStory =>
            new EventTriggerButton<PageCreateAStory>(Driver, By.XPath($"//div[@data-pagelet='Stories']//span[text()='{ResHomePage.CreateAStory}']"));

        public EventTriggerButton<PageStories> EventTriggerButtonSeeAllStories =>
            new EventTriggerButton<PageStories>(Driver, By.XPath($"//div[@data-pagelet='Stories']//span[text()='{ResHomePage.SeeAllStories}']"));

        public EventTriggerButton<PageLiveProducer> EventTriggerButtonLiveVideo =>
            new EventTriggerButton<PageLiveProducer>(Driver, By.XPath($"//div[@role='main']//span[text()='{ResCreatePost.LiveVideo}']"));

        public EventTriggerButton<DialogCreatePost> EventTriggerButtonPhotoOrVideo =>
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"//div[@role='main']//span[text()='{ResCreatePost.PhotoOrVideo}']"));

        public EventTriggerButton<DialogCreatePost> EventTriggerButtonFeelingOrActivity =>
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"//div[@role='main']//span[text()='{ResCreatePost.FeelingOrActivity}']"));

        public EventTriggerButton<DialogCreateYourRoom> EventTriggerButtonCreateNewRoom =>
            new EventTriggerButton<DialogCreateYourRoom>(Driver, By.XPath($"//div[@role='main']//span[text()='{ResCreatePost.NewRoom}' or text()='{ResCreatePost.CreateRoom}']"));

        public IEnumerable<ButtonImage> AllOnlineFriends =>
            Driver.FindElements(By.XPath($"//rdiv[@role='main']//div[contains(@aria-label,'{ResCreatePost.FriendRoomTile}')]"))?
            .Select(x => new ButtonImage(Driver, By.XPath(x.Text.Substring(x.Text.IndexOf($"{ResCreatePost.FriendRoomTile}"), ResCreatePost.FriendRoomTile.Length))));

        public Button ButtonUndo => new Button(Driver, By.XPath($"//span[text()='{ResHomePage.Undo}']"));

        public FeedHome _feed;
        public FeedHome Feed
        {
            get
            {
                if (_feed == null) _feed = new FeedHome();
                return _feed;
            }
        }

        public override string PageUrl => "/";

        public override By ByForPage => throw new System.NotImplementedException();

        public override void RunConformance()
        {
            // Verify all the reaction buttons. 
            //Feed.FeedScroll.ScrollingDownWithAGivenInterval(3, scrollFromCurrentLocation: true);
            Feed.FeedScroll.ScrollingUpWithAGivenInterval(1, scrollFromCurrentLocation: true);
            //var likeButton = Feed.FeedScroll.ListITem.ButtonLike;
            //likeButton.Hoverover().ButtonReactionLike.Click();
            //Thread.Sleep(2000);
            //likeButton.Click();
            //Clicking on the comment box to move the fox from button, otherwise it will
            //Feed.FeedScroll.ListITem.EventTriggerButtonComment.Click();
            //likeButton.Hoverover().ButtonReactionWow.Click();
            //Thread.Sleep(2000);
            //likeButton.Click();
            //Feed.FeedScroll.ListITem.EventTriggerButtonComment.Click();
            //likeButton.Hoverover().ButtonReactionSad.Click();
            //Thread.Sleep(2000);
            //likeButton.Click();
            //Feed.FeedScroll.ListITem.EventTriggerButtonComment.Click();
            //likeButton.Hoverover().ButtonReactionHaha.Click();
            //Thread.Sleep(2000);
            //likeButton.Click();
            //Feed.FeedScroll.ListITem.EventTriggerButtonComment.Click();
            //likeButton.Hoverover().ButtonReactionCare.Click();
            //Thread.Sleep(2000);
            //likeButton.Click();
            //Feed.FeedScroll.ListITem.EventTriggerButtonComment.Click();
            //likeButton.Hoverover().ButtonReactionAngry.Click();
            //Thread.Sleep(2000);
            //likeButton.Click();

            //var reactionsWindow = Feed.FeedScroll.ListITem.EventTriggerButtonSeeWhoReactedToThis.Click();
            //reactionsWindow.ScrollReactions.ScrollDownMore();
            //reactionsWindow.ButtonAllReactions.Click();
            //reactionsWindow.ButtonReactionsAtFirstIndex.Click();
            //reactionsWindow.ButtonReactionsAtSecondIndex.Click();
            //reactionsWindow.ButtonReactionsAtThirdIndex.Click();
            //reactionsWindow.ButtonReactionsAtFourthIndex.Click();
            //reactionsWindow.ButtonReactionsAtFifthIndex.Click();
            //reactionsWindow.ButtonReactionsAtSixthIndex.Click();
            //reactionsWindow.ButtonReactionsAtSeventhIndex.Click();
            //reactionsWindow.ButtonAllReactions.Click();
            //reactionsWindow.ScrollReactions.ScrollDownMore();
            //reactionsWindow.ScrollReactions.ScrollUpMore();
            //Thread.Sleep(5000);
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
            peopleWhoSharedDialog.Close();
        }

        //public void GenerateAllElements()
        //{
        //    Driver.FindElementByXPath("//span[text()='Marketplace']").Click();
        //    Thread.Sleep(3000);
        //    Driver.FindElementByXPath("//span[text()='Garden & Outdoor']").Click();
        //    var rootFolderPath = @"D:\Dev\Robotize\RobotizeFacebook\Pages\LoggedIn\Components\Grid\Family\FamilyFilter\";
        //    var fileBaseName = "Family";
        //    var xPath = "//a[@href='/marketplace/111906762160356/toys/']//span[text()='Toys & Games']/../../../../../../../../../..//span[contains(@class,'fjf4s8hc')]";
        //    foreach (var element in Driver.FindElements(By.XPath(xPath)))
        //    {
        //        var destPath = $@"D:\Dev\Robotize\RobotizeFacebook\Pages\LoggedIn\Components\Grid\ToysAndGames\";
        //        var newDirName = element.Text.Replace("&", "And");
        //        newDirName = newDirName.Replace("'", "");
        //        newDirName = newDirName.Replace(" ", "");
        //        var newDir = $"{destPath}{newDirName}";
        //        Directory.CreateDirectory(newDir);
        //        foreach (var file in Directory.GetFiles(rootFolderPath))
        //        {
        //            var fi = Path.GetFileName(file).Replace(fileBaseName, newDirName);
        //            var destFile = Path.Combine(newDir, fi);
        //            File.Copy(file, destFile, true);
        //            var text = File.ReadAllText(destFile);
        //            File.WriteAllText(destFile, text.Replace(fileBaseName, newDirName));
        //        }
        //    }
        //}
    }
}
