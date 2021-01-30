using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.LoggedIn.Components
{
    public class DialogAddToYourPost : BaseDialog
    {
        public DialogAddToYourPost(RemoteWebDriver driver) : base(driver)
        {
            BaseXPath = "//form[@method='POST']";
        }

        protected override By ByForDialog => By.XPath($"//form[@method='POST']//span[contains(text(),'{ResCreatePost.WatchParty})']");

        public Button ButtonPhotoOrVideo =>
            new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.PhotoOrVideo}')]"));

        public EventTriggerButton<DialogTagFriends> TriggerButtonTagFriends =>
            new EventTriggerButton<DialogTagFriends>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.TagFriends}')]"));

        public EventTriggerButton<DialogHowAreYouFeeling> TriggerButtonFeelingOrActivity =>
            new EventTriggerButton<DialogHowAreYouFeeling>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.FeelingOrActivity}')]"));

        public EventTriggerButton<DialogCheckin> ButtonCheckIn =>
            new EventTriggerButton<DialogCheckin>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.CheckIn}')]"));

        public EventTriggerButton<DialogGIF> ButtonGIF =>
            new EventTriggerButton<DialogGIF>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.GIF}')]"));

        public Button ButtonLiveVideo =>
            new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.LiveVideo}')]"));

        public EventTriggerButton<DialogAddVideos> ButtonWatchParty =>
            new EventTriggerButton<DialogAddVideos>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.WatchParty}')]"));
        public EventTriggerButton<DialogSelectNonprofit> ButtonRaiseMoney =>
            new EventTriggerButton<DialogSelectNonprofit>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.RaiseMoney}')]"));
        
        public Button ButtonBack =>
            new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.RaiseMoney}')]"));
    }
}
