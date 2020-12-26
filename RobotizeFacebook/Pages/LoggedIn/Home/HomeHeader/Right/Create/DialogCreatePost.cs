using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Controls;
using RobotizeLibrary.Controls.TriggerControls;
using RobotizeLibrary.Dialogs;
using RobotizeLibrary.Resources;

namespace RobotizeFacebook.Pages.LoggedIn.Home.HomeHeader
{
    public class DialogCreatePost : BaseDialog
    {
        public DialogCreatePost(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        private readonly string Basepath = $"//span[text()='{ResCreatePost.CreatePost}']/../../../../../../..";

        protected override By ByForDialog => By.XPath(Basepath);
        public EventTriggerButton<DialogAddToYourPost> ButtonAddToYourPost => 
            new EventTriggerButton<DialogAddToYourPost>(Driver, Wait, By.XPath($"{Basepath}//span[text()='{ResCreatePost.AddToYourPost}']/../../.."));
        public Button ButtonPhotoOrVideo => new Button(Driver, By.XPath($"{Basepath}//div[@aria-label='{ResCreatePost.PhotoOrVideo}']"));
        public Button ButtonTagFriends => new Button(Driver, By.XPath($"{Basepath}//div[@aria-label='{ResCreatePost.TagFriends}']"));
        public Button ButtonFeelingOrActivity => new Button(Driver, By.XPath($"{Basepath}//div[@aria-label='{ResCreatePost.FeelingOrActivity}']"));
        public Button ButtonCheckIn => new Button(Driver, By.XPath($"{Basepath}//div[@aria-label='{ResCreatePost.CheckIn}']"));
        public Button ButtonGIF => new Button(Driver, By.XPath($"{Basepath}//div[@aria-label='{ResCreatePost.GIF}']"));
        
        public EventTriggerButton<DialogAddToYourPost> ButtonDotDotDot =>
           new EventTriggerButton<DialogAddToYourPost>(Driver, Wait, By.XPath($"{Basepath}//span[text()='{ResCreatePost.More}']/../../.."));
        
        public EventTriggerButton<DialogShowBackgroundOptions> ButtonBackGroungOptions =>
           new EventTriggerButton<DialogShowBackgroundOptions>(Driver, Wait, By.XPath($"{Basepath}//div[@aria-label='Show Background Options']"));
        public TextBox TextBoxWhatsOnYourMind => new TextBox(Driver, By.XPath($"{Basepath}//div[@aria-label='{ResCreatePost.WhatsOnYourMind}']"));
        //public EventTriggerButton<SelectPrivacyDialog>
        public Button ButtonPost => new Button(Driver, By.XPath($"{Basepath}//div[@aria-label='{ResCreatePost.Post}']"));
    }

    public class DialogShowBackgroundOptions : BaseDialog
    {
        public DialogShowBackgroundOptions(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        private readonly string Basepath = $"//span[text()='{ResCreatePost.CreatePost}']/../../../../../../..//div[@aria-label='No background']";
        protected override By ByForDialog => By.XPath(Basepath);

        public Button GetBackgroundByName(PostBackgroundcolor background) => new Button(Driver, By.XPath($"{Basepath}//div[@aria-label='{background}']"));
        public EventTriggerButton<DialogMoreBackgroundOptions> ButtonMoreBackgroundOptionsDialog =>
            new EventTriggerButton<DialogMoreBackgroundOptions>(Driver, Wait, By.XPath($"//span[text()='{ResCreatePost.CreatePost}']/../../../../../..//div[@aria-label='Background Options']"));
    }

    public class DialogMoreBackgroundOptions : BaseDialog
    {
        public DialogMoreBackgroundOptions(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        private readonly string Basepath = 
            $"//span[text()='{ResCreatePost.CreatePost}']/../../../../../../../../..//span[text()='{ResPostBackGroundColor.ChooseBackground}']/../../../../..";
        protected override By ByForDialog => By.XPath(Basepath);


        // TODO: Add Popular, New and More background colors to the enums.
        public Button GetPopularBackground(PostBackgroundcolor background) => new Button(Driver, By.XPath($"{Basepath}//div[@aria-label='{background}']"));
        public Button GetNewBackground(PostBackgroundcolor background) => new Button(Driver, By.XPath($"{Basepath}//div[@aria-label='{background}']"));
        public Button GetMoreBackground(PostBackgroundcolor background) => new Button(Driver, By.XPath($"{Basepath}//div[@aria-label='{background}']"));
    }

    public class DialogAddToYourPost : BaseDialog
    {
        public DialogAddToYourPost(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        private readonly string Basepath = $"//span[text()='{ResCreatePost.RaiseMoney}']/../../../../../../../../../..";
        protected override By ByForDialog => By.XPath(Basepath);

        public Button ButtonAddToYourPost => new Button(Driver, By.XPath($"{Basepath}//span[text()='{ResCreatePost.PhotoOrVideo}']/../../.."));
        public Button ButtonTagFriends => new Button(Driver, By.XPath($"{Basepath}//span[text()='{ResCreatePost.TagFriends}']/../../.."));
        public Button ButtonFeelingOrActivity => new Button(Driver, By.XPath($"{Basepath}//span[text()='{ResCreatePost.FeelingOrActivity}']/../../.."));
        public Button ButtonCheckIn => new Button(Driver, By.XPath($"{Basepath}//span[text()='{ResCreatePost.CheckIn}']/../../.."));
        public Button ButtonGIF => new Button(Driver, By.XPath($"{Basepath}//span[text()='{ResCreatePost.GIF}']/../../.."));
        public Button ButtonLiveVideo => new Button(Driver, By.XPath($"{Basepath}//span[text()='{ResCreatePost.LiveVideo}']/../../.."));
        public Button ButtonWatchParty => new Button(Driver, By.XPath($"{Basepath}//span[text()='{ResCreatePost.WatchParty}']/../../.."));
        public Button ButtonRaiseMoney => new Button(Driver, By.XPath($"{Basepath}//span[text()='{ResCreatePost.RaiseMoney}']/../../.."));

        public Button ButtonBack => new Button(Driver, By.XPath($"{Basepath}//span[text()='{ResCreatePost.RaiseMoney}']/../../.."));
    }

    public class SelectPrivacyDialog : BaseDialog
    {
        public SelectPrivacyDialog(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        private readonly string Basepath = $"//span[text()='{ResSelectPrivacy.SelectPrivacy}']/../../../../..";
        protected override By ByForDialog => By.XPath(Basepath);

        public RadioButton RButtonAddToYourPost => new RadioButton(Driver, By.XPath($"{Basepath}//span[text()='{ResSelectPrivacy.Public}']/../.."));
        public RadioButton RButtonFriends => new RadioButton(Driver, By.XPath($"{Basepath}//span[text()='{ResSelectPrivacy.Friends}']/../.."));
        
        public EventTriggerButton<DialogSelectFriends> ButtonFriendsExcept => 
            new EventTriggerButton<DialogSelectFriends>(Driver, Wait, By.XPath($"{Basepath}//span[text()='{ResSelectPrivacy.FriendsExcept}']/../.."));
        
        public EventTriggerButton<DialogSelectFriends> ButtonSpecificFriends => 
            new EventTriggerButton<DialogSelectFriends>(Driver, Wait, By.XPath($"{Basepath}//span[text()='{ResSelectPrivacy.SpecificFriends}']/../.."));
        public RadioButton RButtonOnlyMe => new RadioButton(Driver, By.XPath($"{Basepath}//span[text()='{ResSelectPrivacy.OnlyMe}']/../.."));
        
        public EventTriggerButton<DialogCustomPrivacy> ButtonCustom => 
            new EventTriggerButton<DialogCustomPrivacy>(Driver, Wait, By.XPath($"{Basepath}//span[text()='{ResSelectPrivacy.Custom}']/../.."));
        
        public RadioButton RButtonCloseFriends => new RadioButton(Driver, By.XPath($"{Basepath}//span[text()='{ResSelectPrivacy.CloseFriends}']/../.."));
        public RadioButton RButtonCanada => new RadioButton(Driver, By.XPath($"{Basepath}//span[text()='{ResSelectPrivacy.Canada}']/../.."));
    }

    public class DialogSelectFriends : BaseSaveCancelDialog
    {
        public DialogSelectFriends(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        private readonly string Basepath = $"//span[text()='{ResSelectPrivacy.FriendsExcept}']/../../../../..";
        protected override By ByForDialog => By.XPath(Basepath);
    }

    public class DialogCustomPrivacy : BaseSaveCancelDialog
    {
        public DialogCustomPrivacy(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        private readonly string Basepath = $"//span[text()='{ResSelectPrivacy.CustomPrivacy}']/../../../../..";
        protected override By ByForDialog => By.XPath(Basepath);

        public Checkbox CheckboxFriendsOfTagged => new Checkbox(Driver, By.XPath($"{Basepath}//input[@type='checkbox']"));
        public Combobox ComboboxDontShareWith => new Combobox(Driver, By.XPath($"{Basepath}//input[@type='checkbox']"));
    }
}
