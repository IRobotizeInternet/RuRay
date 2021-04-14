using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogSelectAudience : BaseDialog
    {
        public DialogSelectAudience()
        {
            BaseXPath = $"//form[@method='POST']//div[./div/div/h2/span/span[text()='{ResSelectPrivacy.SelectAudience}']]";
        }

        protected override By ByForDialog => By.XPath($"//form[@method='POST']//span[text()='{ResSelectPrivacy.SelectAudience}']");

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

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
