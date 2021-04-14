using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.App.LoggedIn.Components;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogCreatePost : BaseDialog
    {
        public DialogCreatePost(RemoteWebDriver driver) : base()
        {
            BaseXPath = "//form[@method='POST']";
        }

        protected override By ByForDialog => 
            By.XPath($"//form[@method='POST']//span[contains(text(),'{ResCreatePost.CreatePost}')]");
        
        public EventTriggerButton<DialogAddToYourPost> ButtonAddToYourPost => 
            new EventTriggerButton<DialogAddToYourPost>(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResCreatePost.AddToYourPost}')]"));
        
        public Button ButtonPhotoOrVideo => 
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.PhotoOrVideo}']"));
        
        public Button ButtonTagFriends => 
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.TagFriends}']"));
        
        public Button ButtonFeelingOrActivity => 
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.FeelingOrActivity}']"));
        
        public Button ButtonCheckIn => 
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.CheckIn}']"));
        
        public Button ButtonGIF => 
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.GIF}']"));
        
        public EventTriggerButton<DialogAddToYourPost> ButtonDotDotDot =>
           new EventTriggerButton<DialogAddToYourPost>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.More}']"));
        
        public EventTriggerButton<DialogShowBackgroundOptions> ButtonBackGroundOptions =>
           new EventTriggerButton<DialogShowBackgroundOptions>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.ShowBackgroundOptions}']"));
        
        public EventTriggerButton<PopupEmoji> PopupEmojiCollection => 
            new EventTriggerButton<PopupEmoji>(Driver, By.XPath($"//div[@aria-label='{ResCreatePost.Emoji}']"));
        
        public TextBox TextBoxWhatsOnYourMind => 
            new TextBox(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.WhatsOnYourMind}']"));
        
        public Button ButtonPost => 
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.Post}']"));
        
        public EventTriggerButton<DialogSelectAudience> TriggerEditPrivacyDialog => 
            new EventTriggerButton<DialogSelectAudience>(Driver, By.XPath($"//div[contains(@aria-label,'{ResCreatePost.EditPrivacy}')]"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }

    public class DialogShowBackgroundOptions : BaseDialog
    {
        public DialogShowBackgroundOptions(RemoteWebDriver driver) : base()
        {
        }

        private readonly string Basepath = string.Empty;
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResCreatePost.Nobackground}']");

        public Button GetBackgroundByName(PostBackgroundcolor background) => new Button(Driver, By.XPath($"{Basepath}//div[@aria-label='{background}']"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        public EventTriggerButton<DialogMoreBackgroundOptions> ButtonMoreBackgroundOptionsDialog =>
            new EventTriggerButton<DialogMoreBackgroundOptions>(Driver, By.XPath($"//div[@aria-label='{ResCreatePost.BackgroundOptions}']"));
    }
}
