using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayFacebook.App.LoggedIn.Pages;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Components
{
    /// <summary>
    /// Defines the <see cref="DialogAddToYourPost" />.
    /// </summary>
    public class DialogAddToYourPost : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogAddToYourPost"/> class.
        /// </summary>
        public DialogAddToYourPost() : base()
        {
            BaseXPath = "//form[@method='POST']";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//form[@method='POST']//span[contains(text(),'{ResCreatePost.WatchParty})']");

        /// <summary>
        /// Gets the ButtonPhotoOrVideo.
        /// </summary>
        public Button ButtonPhotoOrVideo =>
            new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.PhotoOrVideo}')]"));

        /// <summary>
        /// Gets the TriggerButtonTagFriends.
        /// </summary>
        public EventTriggerButton<DialogTagFriends> TriggerButtonTagFriends =>
            new EventTriggerButton<DialogTagFriends>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.TagFriends}')]"));

        /// <summary>
        /// Gets the TriggerButtonFeelingOrActivity.
        /// </summary>
        public EventTriggerButton<DialogHowAreYouFeeling> TriggerButtonFeelingOrActivity =>
            new EventTriggerButton<DialogHowAreYouFeeling>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.FeelingOrActivity}')]"));

        /// <summary>
        /// Gets the ButtonCheckIn.
        /// </summary>
        public EventTriggerButton<DialogCheckin> ButtonCheckIn =>
            new EventTriggerButton<DialogCheckin>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.CheckIn}')]"));

        /// <summary>
        /// Gets the ButtonGIF.
        /// </summary>
        public EventTriggerButton<DialogChooseAGIF> ButtonGIF =>
            new EventTriggerButton<DialogChooseAGIF>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.GIF}')]"));

        /// <summary>
        /// Gets the ButtonLiveVideo.
        /// </summary>
        public Button ButtonLiveVideo =>
            new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.LiveVideo}')]"));

        /// <summary>
        /// Gets the ButtonWatchParty.
        /// </summary>
        public EventTriggerButton<DialogAddVideos> ButtonWatchParty =>
            new EventTriggerButton<DialogAddVideos>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.WatchParty}')]"));

        /// <summary>
        /// Gets the ButtonRaiseMoney.
        /// </summary>
        public EventTriggerButton<DialogSelectNonprofit> ButtonRaiseMoney =>
            new EventTriggerButton<DialogSelectNonprofit>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.RaiseMoney}')]"));

        /// <summary>
        /// Gets the ButtonBack.
        /// </summary>
        public Button ButtonBack =>
            new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.RaiseMoney}')]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
