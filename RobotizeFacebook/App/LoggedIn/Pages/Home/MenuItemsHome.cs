using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class MenuItemsHome : MenuItems
    {
        public MenuItemsHome()
        {

        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        public EventTriggerButton<PageUserTimeline> EventTriggerButtonUserHome =>
            new EventTriggerButton<PageUserTimeline>(Driver, By.XPath("//div[@data-pagelet='LeftRail']/div/div/ul"));
        public EventTriggerButton<PageViewPage> EventTriggerButtonCOVID19InformationCenter =>
            new EventTriggerButton<PageViewPage>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.COVID19InformationCenter}']"));
        public EventTriggerButton<PageFriends> EventTriggerButtonFriends =>
            new EventTriggerButton<PageFriends>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.Friends}']"));
        public EventTriggerButton<PagePages> EventTriggerButtonPages =>
           new EventTriggerButton<PagePages>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.Pages}']"));
        public EventTriggerButton<PageEvents> EventTriggerButtonEvents =>
            new EventTriggerButton<PageEvents>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.Events}']"));
        public EventTriggerButton<PageMarketplace> EventTriggerButtonMarketplace =>
            new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.Marketplace}']"));
        public EventTriggerButton<PageWatch> EventTriggerButtonWatch =>
           new EventTriggerButton<PageWatch>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.Watch}']"));
        public EventTriggerButton<PageGroup> EventTriggerButtonGroups =>
            new EventTriggerButton<PageGroup>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.Groups}']"));

        public EventTriggerButton<MoreMenuItems> EventTriggerButtonSeeMore =>
             new EventTriggerButton<MoreMenuItems>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.SeeMore}']"));

    }

    public sealed class MoreMenuItems : MenuItems
    {
        public EventTriggerButton<PageAdCenter> EventTriggerButtonAds =>
            new EventTriggerButton<PageAdCenter>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.Ads}']"));
        public EventTriggerButton<PageCampus> EventTriggerButtonCampus =>
            new EventTriggerButton<PageCampus>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.Campus}']"));
        public EventTriggerButton<PageViewPage> EventTriggerButtonCommunityHelp =>
           new EventTriggerButton<PageViewPage>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.CommunityHelp}']"));
        public EventTriggerButton<PageFacebookPay> EventTriggerButtonFacebookPay =>
            new EventTriggerButton<PageFacebookPay>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.FacebookPay}']"));
        //public EventTriggerButton<PageFavorites> EventTriggerButtonFavorites =>
        //    new EventTriggerButton<PageFavorites>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.Favorites}']"));
        //public EventTriggerButton<PageWatch> EventTriggerButtonFriendLists =>
        //   new EventTriggerButton<PageWatch>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.FriendLists}']"));
        public EventTriggerButton<PageFundraisers> EventTriggerButtonFundraisers =>
            new EventTriggerButton<PageFundraisers>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.Fundraisers}']"));
        public EventTriggerButton<PageGames> EventTriggerButtonGames =>
            new EventTriggerButton<PageGames>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.Games}']"));
        public EventTriggerButton<PageGames> EventTriggerButtonGamingVideo =>
            new EventTriggerButton<PageGames>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.GamingVideo}']"));
        public EventTriggerButton<PageJobs> EventTriggerButtonJobs =>
           new EventTriggerButton<PageJobs>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.Jobs}']"));
        public EventTriggerButton<PageWatch> EventTriggerButtonLiveVideos =>
            new EventTriggerButton<PageWatch>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.LiveVideos}']"));
        public EventTriggerButton<PageMemories> EventTriggerButtonMemories =>
            new EventTriggerButton<PageMemories>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.Memories}']"));
        public EventTriggerButton<PageChats> EventTriggerButtonMessenger =>
           new EventTriggerButton<PageChats>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.Messenger}']"));
        public EventTriggerButton<PageMessengerKids> EventTriggerButtonMessengerKids =>
            new EventTriggerButton<PageMessengerKids>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.MessengerKids}']"));

        //public EventTriggerButton<PageMarketplace> EventTriggerButtonMostRecent =>
        //    new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.MostRecent}']"));
        public EventTriggerButton<PageMovies> EventTriggerButtonMovies =>
           new EventTriggerButton<PageMovies>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.Movies}']"));
        public EventTriggerButton<PageViewPage> EventTriggerButtonOculus =>
            new EventTriggerButton<PageViewPage>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.Oculus}']"));
        public EventTriggerButton<PageOffers> EventTriggerButtonOffer =>
            new EventTriggerButton<PageOffers>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.Offer}']"));
        //public EventTriggerButton<PageA> EventTriggerButtonRecentAdActivity =>
        //    new EventTriggerButton<PageFriends>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.RecentAdActivity}']"));
        public EventTriggerButton<PageSaved> EventTriggerButtonSaved =>
           new EventTriggerButton<PageSaved>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.Saved}']"));
        public EventTriggerButton<PageWeather> EventTriggerButtonWeather =>
            new EventTriggerButton<PageWeather>(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.Weather}']"));
        public Button ButtonSeeLess =>
            new Button(Driver, By.XPath($"//div[@data-pagelet='LeftRail']//span[text()='{ResLeftNav.SeeLess}']"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
