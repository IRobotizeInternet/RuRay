using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayLibrary.Components.Eidtor;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="LeftMenuItemsHome" />.
    /// </summary>
    public class LeftMenuItemsHome : MenuItems, ILeftNavigation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeftMenuItemsHome"/> class.
        /// </summary>
        public LeftMenuItemsHome()
        {
            BaseXPath = "{BaseXPath}";
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets the EventTriggerButtonUserHome.
        /// </summary>
        public EventTriggerButton<PageUserTimeline> EventTriggerButtonUserHome =>
            new EventTriggerButton<PageUserTimeline>(Driver, By.XPath($"{BaseXPath}/div/div/ul"));

        /// <summary>
        /// Gets the EventTriggerButtonCOVID19InformationCenter.
        /// </summary>
        public EventTriggerButton<PageViewPage> EventTriggerButtonCOVID19InformationCenter =>
            new EventTriggerButton<PageViewPage>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.COVID19InformationCenter}']"));

        /// <summary>
        /// Gets the EventTriggerButtonFriends.
        /// </summary>
        public EventTriggerButton<PageFriends> EventTriggerButtonFriends =>
            new EventTriggerButton<PageFriends>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Friends}']"));

        /// <summary>
        /// Gets the EventTriggerButtonPages.
        /// </summary>
        public EventTriggerButton<PagePages> EventTriggerButtonPages =>
           new EventTriggerButton<PagePages>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Pages}']"));

        /// <summary>
        /// Gets the EventTriggerButtonEvents.
        /// </summary>
        public EventTriggerButton<PageEvents> EventTriggerButtonEvents =>
            new EventTriggerButton<PageEvents>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Events}']"));

        /// <summary>
        /// Gets the EventTriggerButtonMarketplace.
        /// </summary>
        public EventTriggerButton<PageMarketplace> EventTriggerButtonMarketplace =>
            new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Marketplace}']"));

        /// <summary>
        /// Gets the EventTriggerButtonWatch.
        /// </summary>
        public EventTriggerButton<PageWatch> EventTriggerButtonWatch =>
           new EventTriggerButton<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Watch}']"));

        /// <summary>
        /// Gets the EventTriggerButtonGroups.
        /// </summary>
        public EventTriggerButton<PageGroup> EventTriggerButtonGroups =>
            new EventTriggerButton<PageGroup>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Groups}']"));

        /// <summary>
        /// Gets the EventTriggerButtonSeeMore.
        /// </summary>
        public EventTriggerButton<MoreMenuItems> EventTriggerButtonSeeMore =>
             new EventTriggerButton<MoreMenuItems>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.SeeMore}']"));
    }

    /// <summary>
    /// Defines the <see cref="MoreMenuItems" />.
    /// </summary>
    public sealed class MoreMenuItems : MenuItems
    {
        /// <summary>
        /// Gets the EventTriggerButtonAds.
        /// </summary>
        public EventTriggerButton<PageAdCenter> EventTriggerButtonAds =>
            new EventTriggerButton<PageAdCenter>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Ads}']"));

        /// <summary>
        /// Gets the EventTriggerButtonCampus.
        /// </summary>
        public EventTriggerButton<PageCampus> EventTriggerButtonCampus =>
            new EventTriggerButton<PageCampus>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Campus}']"));

        /// <summary>
        /// Gets the EventTriggerButtonCommunityHelp.
        /// </summary>
        public EventTriggerButton<PageViewPage> EventTriggerButtonCommunityHelp =>
           new EventTriggerButton<PageViewPage>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.CommunityHelp}']"));

        /// <summary>
        /// Gets the EventTriggerButtonFacebookPay.
        /// </summary>
        public EventTriggerButton<PageFacebookPay> EventTriggerButtonFacebookPay =>
            new EventTriggerButton<PageFacebookPay>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.FacebookPay}']"));

        //public EventTriggerButton<PageFavorites> EventTriggerButtonFavorites =>
        //    new EventTriggerButton<PageFavorites>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Favorites}']"));
        //public EventTriggerButton<PageWatch> EventTriggerButtonFriendLists =>
        //   new EventTriggerButton<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.FriendLists}']"));
        /// <summary>
        /// Gets the EventTriggerButtonFundraisers.
        /// </summary>
        public EventTriggerButton<PageFundraisers> EventTriggerButtonFundraisers =>
            new EventTriggerButton<PageFundraisers>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Fundraisers}']"));

        /// <summary>
        /// Gets the EventTriggerButtonGames.
        /// </summary>
        public EventTriggerButton<PageGames> EventTriggerButtonGames =>
            new EventTriggerButton<PageGames>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Games}']"));

        /// <summary>
        /// Gets the EventTriggerButtonGamingVideo.
        /// </summary>
        public EventTriggerButton<PageGames> EventTriggerButtonGamingVideo =>
            new EventTriggerButton<PageGames>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.GamingVideo}']"));

        /// <summary>
        /// Gets the EventTriggerButtonJobs.
        /// </summary>
        public EventTriggerButton<PageJobs> EventTriggerButtonJobs =>
           new EventTriggerButton<PageJobs>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Jobs}']"));

        /// <summary>
        /// Gets the EventTriggerButtonLiveVideos.
        /// </summary>
        public EventTriggerButton<PageWatch> EventTriggerButtonLiveVideos =>
            new EventTriggerButton<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.LiveVideos}']"));

        /// <summary>
        /// Gets the EventTriggerButtonMemories.
        /// </summary>
        public EventTriggerButton<PageMemories> EventTriggerButtonMemories =>
            new EventTriggerButton<PageMemories>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Memories}']"));

        /// <summary>
        /// Gets the EventTriggerButtonMessenger.
        /// </summary>
        public EventTriggerButton<PageChats> EventTriggerButtonMessenger =>
           new EventTriggerButton<PageChats>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Messenger}']"));

        /// <summary>
        /// Gets the EventTriggerButtonMessengerKids.
        /// </summary>
        public EventTriggerButton<PageMessengerKids> EventTriggerButtonMessengerKids =>
            new EventTriggerButton<PageMessengerKids>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.MessengerKids}']"));

        //public EventTriggerButton<PageMarketplace> EventTriggerButtonMostRecent =>
        //    new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.MostRecent}']"));
        /// <summary>
        /// Gets the EventTriggerButtonMovies.
        /// </summary>
        public EventTriggerButton<PageMovies> EventTriggerButtonMovies =>
           new EventTriggerButton<PageMovies>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Movies}']"));

        /// <summary>
        /// Gets the EventTriggerButtonOculus.
        /// </summary>
        public EventTriggerButton<PageViewPage> EventTriggerButtonOculus =>
            new EventTriggerButton<PageViewPage>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Oculus}']"));

        /// <summary>
        /// Gets the EventTriggerButtonOffer.
        /// </summary>
        public EventTriggerButton<PageOffers> EventTriggerButtonOffer =>
            new EventTriggerButton<PageOffers>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Offer}']"));

        //public EventTriggerButton<PageA> EventTriggerButtonRecentAdActivity =>
        //    new EventTriggerButton<PageFriends>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.RecentAdActivity}']"));
        /// <summary>
        /// Gets the EventTriggerButtonSaved.
        /// </summary>
        public EventTriggerButton<PageSaved> EventTriggerButtonSaved =>
           new EventTriggerButton<PageSaved>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Saved}']"));

        /// <summary>
        /// Gets the EventTriggerButtonWeather.
        /// </summary>
        public EventTriggerButton<PageWeather> EventTriggerButtonWeather =>
            new EventTriggerButton<PageWeather>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Weather}']"));

        /// <summary>
        /// Gets the ButtonSeeLess.
        /// </summary>
        public Button ButtonSeeLess =>
            new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.SeeLess}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
