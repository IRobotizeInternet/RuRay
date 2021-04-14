using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class MenuItemsHome : MenuItems
    {
        public MenuItemsHome()
        {
            BaseXPath = "{BaseXPath}";
        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        public EventTriggerButton<PageUserTimeline> EventTriggerButtonUserHome =>
            new EventTriggerButton<PageUserTimeline>(Driver, By.XPath($"{BaseXPath}/div/div/ul"));
        public EventTriggerButton<PageViewPage> EventTriggerButtonCOVID19InformationCenter =>
            new EventTriggerButton<PageViewPage>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.COVID19InformationCenter}']"));
        public EventTriggerButton<PageFriends> EventTriggerButtonFriends =>
            new EventTriggerButton<PageFriends>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Friends}']"));
        public EventTriggerButton<PagePages> EventTriggerButtonPages =>
           new EventTriggerButton<PagePages>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Pages}']"));
        public EventTriggerButton<PageEvents> EventTriggerButtonEvents =>
            new EventTriggerButton<PageEvents>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Events}']"));
        public EventTriggerButton<PageMarketplace> EventTriggerButtonMarketplace =>
            new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Marketplace}']"));
        public EventTriggerButton<PageWatch> EventTriggerButtonWatch =>
           new EventTriggerButton<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Watch}']"));
        public EventTriggerButton<PageGroup> EventTriggerButtonGroups =>
            new EventTriggerButton<PageGroup>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Groups}']"));

        public EventTriggerButton<MoreMenuItems> EventTriggerButtonSeeMore =>
             new EventTriggerButton<MoreMenuItems>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.SeeMore}']"));

    }

    public sealed class MoreMenuItems : MenuItems
    {
        public EventTriggerButton<PageAdCenter> EventTriggerButtonAds =>
            new EventTriggerButton<PageAdCenter>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Ads}']"));
        public EventTriggerButton<PageCampus> EventTriggerButtonCampus =>
            new EventTriggerButton<PageCampus>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Campus}']"));
        public EventTriggerButton<PageViewPage> EventTriggerButtonCommunityHelp =>
           new EventTriggerButton<PageViewPage>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.CommunityHelp}']"));
        public EventTriggerButton<PageFacebookPay> EventTriggerButtonFacebookPay =>
            new EventTriggerButton<PageFacebookPay>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.FacebookPay}']"));
        //public EventTriggerButton<PageFavorites> EventTriggerButtonFavorites =>
        //    new EventTriggerButton<PageFavorites>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Favorites}']"));
        //public EventTriggerButton<PageWatch> EventTriggerButtonFriendLists =>
        //   new EventTriggerButton<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.FriendLists}']"));
        public EventTriggerButton<PageFundraisers> EventTriggerButtonFundraisers =>
            new EventTriggerButton<PageFundraisers>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Fundraisers}']"));
        public EventTriggerButton<PageGames> EventTriggerButtonGames =>
            new EventTriggerButton<PageGames>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Games}']"));
        public EventTriggerButton<PageGames> EventTriggerButtonGamingVideo =>
            new EventTriggerButton<PageGames>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.GamingVideo}']"));
        public EventTriggerButton<PageJobs> EventTriggerButtonJobs =>
           new EventTriggerButton<PageJobs>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Jobs}']"));
        public EventTriggerButton<PageWatch> EventTriggerButtonLiveVideos =>
            new EventTriggerButton<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.LiveVideos}']"));
        public EventTriggerButton<PageMemories> EventTriggerButtonMemories =>
            new EventTriggerButton<PageMemories>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Memories}']"));
        public EventTriggerButton<PageChats> EventTriggerButtonMessenger =>
           new EventTriggerButton<PageChats>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Messenger}']"));
        public EventTriggerButton<PageMessengerKids> EventTriggerButtonMessengerKids =>
            new EventTriggerButton<PageMessengerKids>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.MessengerKids}']"));

        //public EventTriggerButton<PageMarketplace> EventTriggerButtonMostRecent =>
        //    new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.MostRecent}']"));
        public EventTriggerButton<PageMovies> EventTriggerButtonMovies =>
           new EventTriggerButton<PageMovies>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Movies}']"));
        public EventTriggerButton<PageViewPage> EventTriggerButtonOculus =>
            new EventTriggerButton<PageViewPage>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Oculus}']"));
        public EventTriggerButton<PageOffers> EventTriggerButtonOffer =>
            new EventTriggerButton<PageOffers>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Offer}']"));
        //public EventTriggerButton<PageA> EventTriggerButtonRecentAdActivity =>
        //    new EventTriggerButton<PageFriends>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.RecentAdActivity}']"));
        public EventTriggerButton<PageSaved> EventTriggerButtonSaved =>
           new EventTriggerButton<PageSaved>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Saved}']"));
        public EventTriggerButton<PageWeather> EventTriggerButtonWeather =>
            new EventTriggerButton<PageWeather>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Weather}']"));
        public Button ButtonSeeLess =>
            new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.SeeLess}']"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
