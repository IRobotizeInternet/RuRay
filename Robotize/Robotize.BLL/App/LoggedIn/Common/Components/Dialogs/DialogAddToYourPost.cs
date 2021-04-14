using OpenQA.Selenium;
using RobotizeFacebook.App.LoggedIn.Pages;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Components
{
    public class DialogAddToYourPost : BaseDialog
    {
        public DialogAddToYourPost() : base()
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

        public EventTriggerButton<DialogChooseAGIF> ButtonGIF =>
            new EventTriggerButton<DialogChooseAGIF>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.GIF}')]"));

        public Button ButtonLiveVideo =>
            new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.LiveVideo}')]"));

        public EventTriggerButton<DialogAddVideos> ButtonWatchParty =>
            new EventTriggerButton<DialogAddVideos>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.WatchParty}')]"));
        public EventTriggerButton<DialogSelectNonprofit> ButtonRaiseMoney =>
            new EventTriggerButton<DialogSelectNonprofit>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.RaiseMoney}')]"));
        
        public Button ButtonBack =>
            new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.RaiseMoney}')]"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
