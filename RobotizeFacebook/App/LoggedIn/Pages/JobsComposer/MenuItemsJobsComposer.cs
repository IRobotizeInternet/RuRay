using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.App.LoggedIn.Components;
using RobotizeFacebook.App.LoggedIn.Enum;
using RobotizeFacebook.Resources;
using RobotizeLibrary.Extensions;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class MenuItemsJobsComposer : MenuItems
    {
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
            BaseXPath = $"//div[@aria-label='{ResLeftNav.GoLiveSettings}']";
        }

        public EventTriggerButton<PageLiveProducer> EventTriggerButtonGoLiveNow =>
            new EventTriggerButton<PageLiveProducer>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.GoLiveNow}']"));
        public EventTriggerButton<FeedGoLiveWithOthers> EventTriggerButtonGoLiveWithOthers =>
            new EventTriggerButton<FeedGoLiveWithOthers>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.GoLiveWithOthers}']"));
        public EventTriggerButton<FeedScheduleLiveVideoEvent> EventTriggerButtonScheduleLiveVideoEvent =>
            new EventTriggerButton<FeedScheduleLiveVideoEvent>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.ScheduleLiveVideoEvent}']"));
        public EventTriggerButton<FeedUpcomingLiveVideosAndEvents> EventTriggerButtonUpcomingLiveVideosAndEvents =>
            new EventTriggerButton<FeedUpcomingLiveVideosAndEvents>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.UpcomingLiveVideosAndEvents}']"));

        public DropdownWhereToPost DropdownWhereToPost =>
            new DropdownWhereToPost(Driver, new ExtendBy($"{BaseXPath}//div[@role='combobox']"));

        public TextBox TextBoxTitleOptional =>
            new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.TitleOptional}']"));

        public TextBox TextBoxSaySomethingAboutThisLiveVideo =>
            new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.SaySomethingAboutThisLiveVideo}']"));

        public EventTriggerButton<DialogTagFriends> EventTriggerButtonTagFriends =>
            new EventTriggerButton<DialogTagFriends>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.TagFriends}']"));

        public EventTriggerButton<DialogCheckin> EventTriggerButtonCheckIn =>
            new EventTriggerButton<DialogCheckin>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.CheckIn}']"));

        public EventTriggerButton<DialogHowAreYouFeeling> EventTriggerButtonFeelingOrActivity =>
            new EventTriggerButton<DialogHowAreYouFeeling>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.FeelingOrActivity}']"));

        public EventTriggerButton<DialogRaiseMoney> EventTriggerButtonRaiseMoney =>
             new EventTriggerButton<DialogRaiseMoney>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.RaiseMoney}']"));

        public EventTriggerButton<DialogEmojis> EventTriggerButtonInsertAnEmoji =>
             new EventTriggerButton<DialogEmojis>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResLeftNav.InsertAnEmoji}']"));

        public EventTriggerButton<DialogAddATitle> EventTriggerGoLive =>
            new EventTriggerButton<DialogAddATitle>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.GoLive}']"));

        public EventTriggerButton<DialogSelectAudience> EventTriggerOnlyMe =>
            new EventTriggerButton<DialogSelectAudience>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.OnlyMe}']"));

        public EventTriggerButton<PopupTagAGame> EventTriggerGaming =>
            new EventTriggerButton<PopupTagAGame>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Gaming}']"));
    }

    public class PopupTagAGame : BasePopup
    {
        public PopupTagAGame(RemoteWebDriver driver) : base(driver)
        {
        }

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResLeftNav.GoLiveSettings}']//input[@aria-label='{ResLeftNav.TagAGameExFortnite}']");

        private class ComboBoxTagAGame : Combobox
        {
            public ComboBoxTagAGame(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
            {
                BaseXPath = $"//div[@aria-label='{ResLeftNav.GoLiveSettings}']";
                SearchBoxXPath = $"{BaseXPath}//input[contains(@aria-label,'{ResLeftNav.TagAGameExFortnite}')][@type='search']";
                SearchItemsXPath = "//div[@role='presentation']";

            }
        }
    }
}
