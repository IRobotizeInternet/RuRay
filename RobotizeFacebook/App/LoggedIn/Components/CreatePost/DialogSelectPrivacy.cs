using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.LoggedIn
{
    public class DialogSelectPrivacy : BaseDialog
    {
        public DialogSelectPrivacy(RemoteWebDriver driver) : base(driver)
        {
            BaseXPath = "//form[@method='POST']";
        }

        protected override By ByForDialog => By.XPath($"//form[@method='POST']//span[text()='{ResSelectPrivacy.SelectPrivacy}']");

        public RadioButton RButtonAddToYourPost => new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.Public}']"));
        public RadioButton RButtonFriends => new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.Friends}']"));
        
        public EventTriggerButton<DialogFriendsExcepts> ButtonFriendsExcept => 
            new EventTriggerButton<DialogFriendsExcepts>(
                Driver,
                By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.FriendsExcept}']/following::span[contains(text(), '{ResSelectPrivacy.Friends_}')]"));
        
        public EventTriggerButton<DialogSpecificFriends> ButtonSpecificFriends => 
            new EventTriggerButton<DialogSpecificFriends>(Driver, By.XPath($"{BaseXPath}//span[@dir='auto' and text()='{ResSelectPrivacy.SpecificFriends}']"));
        
        public RadioButton RButtonOnlyMe => new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.OnlyMe}']"));
        
        public EventTriggerButton<DialogCustomPrivacy> ButtonCustom => 
            new EventTriggerButton<DialogCustomPrivacy>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.Custom}']"));
        
        public RadioButton RButtonCloseFriends => new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.CloseFriends}']"));
        public RadioButton RButtonCanada => new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.Canada}']"));
    }
}
