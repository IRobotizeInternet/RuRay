using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Resources;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Controls.TriggerControls;
using RobotizeLibrary.Dialogs;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class DialogCreatePost : BaseDialog
    {
        public DialogCreatePost(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            BaseXPath = "//form[@method='POST']";
        }

        protected override By ByForDialog => By.XPath("//form[@method='POST']//span[text()='Create Post']");
        public EventTriggerButton<DialogAddToYourPost> ButtonAddToYourPost => 
            new EventTriggerButton<DialogAddToYourPost>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResCreatePost.AddToYourPost}']"));
        public Button ButtonPhotoOrVideo => new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.PhotoOrVideo}']"));
        public Button ButtonTagFriends => new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.TagFriends}']"));
        public Button ButtonFeelingOrActivity => new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.FeelingOrActivity}']"));
        public Button ButtonCheckIn => new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.CheckIn}']"));
        public Button ButtonGIF => new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.GIF}']"));
        
        public EventTriggerButton<DialogAddToYourPost> ButtonDotDotDot =>
           new EventTriggerButton<DialogAddToYourPost>(Driver, Wait, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.More}']"));
        
        public EventTriggerButton<DialogShowBackgroundOptions> ButtonBackGroundOptions =>
           new EventTriggerButton<DialogShowBackgroundOptions>(Driver, Wait, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.ShowBackgroundOptions}']"));
        public EventTriggerButton<PopupEmoji> PopupEmojiCollection => 
            new EventTriggerButton<PopupEmoji>(Driver, Wait, By.XPath($"//div[@aria-label='{ResCreatePost.Emoji}']"));
        public TextBox TextBoxWhatsOnYourMind => new TextBox(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.WhatsOnYourMind}']"));
        public Button ButtonPost => new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.Post}']"));
        
        public EventTriggerButton<DialogSelectPrivacy> TriggerEditPrivacyDialog => 
            new EventTriggerButton<DialogSelectPrivacy>(Driver, Wait, By.XPath($"//div[contains(@aria-label,'{ResCreatePost.EditPrivacy}')]"));
    }

    public class DialogShowBackgroundOptions : BaseDialog
    {
        public DialogShowBackgroundOptions(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        private readonly string Basepath = string.Empty;
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResCreatePost.Nobackground}']");

        public Button GetBackgroundByName(PostBackgroundcolor background) => new Button(Driver, By.XPath($"{Basepath}//div[@aria-label='{background}']"));
        
        public EventTriggerButton<DialogMoreBackgroundOptions> ButtonMoreBackgroundOptionsDialog =>
            new EventTriggerButton<DialogMoreBackgroundOptions>(Driver, Wait, By.XPath($"//div[@aria-label='{ResCreatePost.BackgroundOptions}']"));
    }
}
