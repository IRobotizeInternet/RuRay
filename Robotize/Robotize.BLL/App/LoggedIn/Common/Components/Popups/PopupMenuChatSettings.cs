using OpenQA.Selenium;
using Robotize.BLL.Resources;
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

        public EventTriggerButton<DialogColor> ButtonColor => 
            new EventTriggerButton<DialogColor>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Color}'"));

        public EventTriggerButton<DialogChooseAnEmoji> ButtonEmoji => 
            new EventTriggerButton<DialogChooseAnEmoji>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Emoji}'"));

        public EventTriggerButton<DialogNickNames> ButtonNicknames => 
            new EventTriggerButton<DialogNickNames>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Nicknames}'"));

        public Button ButtonCreategroup => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Creategroup}'"));

        public EventTriggerButton<DialogMuteConversation> ButtonMuteconversation => 
            new EventTriggerButton<DialogMuteConversation>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Muteconversation}'"));

        public EventTriggerButton<DialogIgnoreThisConversation> ButtonIgnoremessages => 
            new EventTriggerButton<DialogIgnoreThisConversation>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Ignoremessages}'"));

        public EventTriggerButton<DialogBlockUser> ButtonBlock => 
            new EventTriggerButton<DialogBlockUser>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Block}'"));

        public EventTriggerButton<DialogDeleteConverstion> ButtonDeleteconversation => 
            new EventTriggerButton<DialogDeleteConverstion>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Deleteconversation}'"));

        public EventTriggerButton<DialogReport> ButtonSomethingSwrong => 
            new EventTriggerButton<DialogReport>(Driver, By.XPath($"{BaseXPath}//span[text()=\"{ResHomePage.SomethingsWrong}\""));
        
        public Button ButtonGivefeedbackandreporttheconversation => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Givefeedbackandreporttheconversation}'"));
    }

    public class DialogReport : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"");

        public DialogReport()
        {
            BaseXPath = $"";
        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }

    public class DialogDeleteConverstion : BaseDialog
    {
        // TODO : These kind of dialogs which are basically a confirmation for an action
        // this could be simplimed and similar dialogs can be consolidated.
        protected override By ByForDialog => By.XPath($"//div[contains(@aria-label,'{ResHomePage.Deleteconversation}')]");

        public DialogDeleteConverstion()
        {
            BaseXPath = $"//div[contains(@aria-label,'{ResHomePage.Deleteconversation}')]";
        }

        public EventTriggerButton<PopupMessanger> EventTriggerButtonDeleteConversation =>
            new EventTriggerButton<PopupMessanger>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.DeleteConversation1}'][@tabindex='0']"));

        public EventTriggerButton<PopupMessanger> EventTriggerButtonDeleteCancel =>
            new EventTriggerButton<PopupMessanger>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.Cancel}'][@tabindex='0']"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
