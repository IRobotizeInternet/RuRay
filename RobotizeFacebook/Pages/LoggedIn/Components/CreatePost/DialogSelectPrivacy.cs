using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Controls.TriggerControls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class DialogSelectPrivacy : BaseDialog
    {
        public DialogSelectPrivacy(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            BaseXPath = "//form[@method='POST']";
        }

        protected override By ByForDialog => By.XPath($"//form[@method='POST']//span[text()='{ResSelectPrivacy.SelectPrivacy}']");

        public RadioButton RButtonAddToYourPost => new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.Public}']"));
        public RadioButton RButtonFriends => new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.Friends}']"));
        
        public EventTriggerButton<DialogFriendsExcepts> ButtonFriendsExcept => 
            new EventTriggerButton<DialogFriendsExcepts>(
                Driver, 
                Wait, 
                By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.FriendsExcept}']/following::span[contains(text(), '{ResSelectPrivacy.Friends_}')]"));
        
        public EventTriggerButton<DialogSpecificFriends> ButtonSpecificFriends => 
            new EventTriggerButton<DialogSpecificFriends>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.SpecificFriends}']"));
        
        public RadioButton RButtonOnlyMe => new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.OnlyMe}']"));
        
        public EventTriggerButton<DialogCustomPrivacy> ButtonCustom => 
            new EventTriggerButton<DialogCustomPrivacy>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.Custom}']"));
        
        public RadioButton RButtonCloseFriends => new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.CloseFriends}']"));
        public RadioButton RButtonCanada => new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.Canada}']"));
    }
}
