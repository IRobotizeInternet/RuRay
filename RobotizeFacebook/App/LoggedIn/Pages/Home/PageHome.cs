using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageHome : BasePage
    {
        public PageHome()
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
            Driver.FindElements(By.XPath($"//div[@role='main']//div[contains(@aria-label,'{ResCreatePost.FriendRoomTile}')]"))?
            .Select(x => new ButtonImage(Driver, By.XPath(x.Text.Substring(x.Text.IndexOf($"{ResCreatePost.FriendRoomTile}"), ResCreatePost.FriendRoomTile.Length))));

        public FeedHome Feeds => new FeedHome();

        public override string PageUrl => "/";

        public override By ByForPage => throw new System.NotImplementedException();

        public override void RunConformance()
        {
            //Feeds.FeedScroll.ScrollingDownWithAGivenInterval();
            Feeds.FeedScroll.ScrollingUpWithAGivenInterval();
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
