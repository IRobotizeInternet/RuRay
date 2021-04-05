using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PopupMenuChatSettings : BasePopup
    {
        protected override By ByForDialog => By.XPath($"//div[@role='menu']//span[text()='Delete conversation']");

        public override void RunConformance()
        {
            BaseXPath = $"//div[@data-pagelet='ChatTab']/following::div[@role='menu']";
        }

        public EventTriggerButton<PageMessages> ButtonOpeninMessenger => 
            new EventTriggerButton<PageMessages>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.OpeninMessenger}'"));

        public Button ButtonNewMessengerAppforWindows => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.NewMessengerAppforWindows}'"));

        public EventTriggerButton<PageHome> ButtonViewProfile => 
            new EventTriggerButton<PageHome>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.ViewProfile}'"));

        public Button ButtonColor => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Color}'"));
        public Button ButtonEmoji => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Emoji}'"));
        public Button ButtonNicknames => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Nicknames}'"));
        public Button ButtonCreategroup => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Creategroup}'"));
        public Button ButtonMuteconversation => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Muteconversation}'"));
        public Button ButtonIgnoremessages => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Ignoremessages}'"));
        public Button ButtonBlock => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Block}'"));
        public Button ButtonDeleteconversation => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Deleteconversation}'"));
        public Button ButtonSomethingSwrong => new Button(Driver, By.XPath($"{BaseXPath}//span[text()=\"{ResHomePage.SomethingsWrong}\""));
        public Button ButtonGivefeedbackandreporttheconversation => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Givefeedbackandreporttheconversation}'"));
    }
}
