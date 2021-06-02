using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayFacebook.App.LoggedIn.Components;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogCreatePost" />.
    /// </summary>
    public class DialogCreatePost : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogCreatePost"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public DialogCreatePost(RemoteWebDriver driver) : base()
        {
            BaseXPath = "//form[@method='POST']";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog =>
            By.XPath($"//form[@method='POST']//span[contains(text(),'{ResCreatePost.CreatePost}')]");

        /// <summary>
        /// Gets the ButtonAddToYourPost.
        /// </summary>
        public EventTriggerButton<DialogAddToYourPost> ButtonAddToYourPost =>
            new EventTriggerButton<DialogAddToYourPost>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.AddToYourPost}')]"));

        /// <summary>
        /// Gets the ButtonPhotoOrVideo.
        /// </summary>
        public Button ButtonPhotoOrVideo =>
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.PhotoOrVideo}']"));

        /// <summary>
        /// Gets the ButtonTagFriends.
        /// </summary>
        public Button ButtonTagFriends =>
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.TagFriends}']"));

        /// <summary>
        /// Gets the ButtonFeelingOrActivity.
        /// </summary>
        public Button ButtonFeelingOrActivity =>
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.FeelingOrActivity}']"));

        /// <summary>
        /// Gets the ButtonCheckIn.
        /// </summary>
        public Button ButtonCheckIn =>
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.CheckIn}']"));

        /// <summary>
        /// Gets the ButtonGIF.
        /// </summary>
        public Button ButtonGIF =>
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.GIF}']"));

        /// <summary>
        /// Gets the ButtonDotDotDot.
        /// </summary>
        public EventTriggerButton<DialogAddToYourPost> ButtonDotDotDot =>
           new EventTriggerButton<DialogAddToYourPost>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.More}']"));

        /// <summary>
        /// Gets the ButtonBackGroundOptions.
        /// </summary>
        public EventTriggerButton<DialogShowBackgroundOptions> ButtonBackGroundOptions =>
           new EventTriggerButton<DialogShowBackgroundOptions>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.ShowBackgroundOptions}']"));

        /// <summary>
        /// Gets the PopupEmojiCollection.
        /// </summary>
        public EventTriggerButton<PopupEmoji> PopupEmojiCollection =>
            new EventTriggerButton<PopupEmoji>(Driver, By.XPath($"//div[@aria-label='{ResCreatePost.Emoji}']"));

        /// <summary>
        /// Gets the TextBoxWhatsOnYourMind.
        /// </summary>
        public TextBox TextBoxWhatsOnYourMind =>
            new TextBox(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.WhatsOnYourMind}']"));

        /// <summary>
        /// Gets the ButtonPost.
        /// </summary>
        public Button ButtonPost =>
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.Post}']"));

        /// <summary>
        /// Gets the TriggerEditPrivacyDialog.
        /// </summary>
        public EventTriggerButton<DialogSelectAudience> TriggerEditPrivacyDialog =>
            new EventTriggerButton<DialogSelectAudience>(Driver, By.XPath($"//div[contains(@aria-label,'{ResCreatePost.EditPrivacy}')]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// Defines the <see cref="DialogShowBackgroundOptions" />.
    /// </summary>
    public class DialogShowBackgroundOptions : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogShowBackgroundOptions"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public DialogShowBackgroundOptions(RemoteWebDriver driver) : base()
        {
        }

        /// <summary>
        /// Defines the Basepath.
        /// </summary>
        private readonly string Basepath = string.Empty;

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResCreatePost.Nobackground}']");

        /// <summary>
        /// The GetBackgroundByName.
        /// </summary>
        /// <param name="background">The background<see cref="PostBackgroundcolor"/>.</param>
        /// <returns>The <see cref="Button"/>.</returns>
        public Button GetBackgroundByName(PostBackgroundcolor background) => new Button(Driver, By.XPath($"{Basepath}//div[@aria-label='{background}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets the ButtonMoreBackgroundOptionsDialog.
        /// </summary>
        public EventTriggerButton<DialogMoreBackgroundOptions> ButtonMoreBackgroundOptionsDialog =>
            new EventTriggerButton<DialogMoreBackgroundOptions>(Driver, By.XPath($"//div[@aria-label='{ResCreatePost.BackgroundOptions}']"));
    }
}
