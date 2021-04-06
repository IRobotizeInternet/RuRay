using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;
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
        public Button ButtonIgnoremessages => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Ignoremessages}'"));
        public Button ButtonBlock => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Block}'"));
        public Button ButtonDeleteconversation => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Deleteconversation}'"));
        public Button ButtonSomethingSwrong => new Button(Driver, By.XPath($"{BaseXPath}//span[text()=\"{ResHomePage.SomethingsWrong}\""));
        public Button ButtonGivefeedbackandreporttheconversation => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Givefeedbackandreporttheconversation}'"));
    }

    public class DialogMuteConversation : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePage.Muteconversation}']");

        public DialogMuteConversation()
        {
            BaseXPath = $"//div[@aria-label='{ResHomePage.Muteconversation}']";
        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        public EventTriggerButton<PopupMessanger> ButtonClose => new EventTriggerButton<PopupMessanger>(Driver, By.XPath(""));
    }

    public class DialogNickNames : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePage.Nicknames}'][@role='dialog']");

        public DialogNickNames()
        {
            BaseXPath = $"//div[@aria-label='{ResHomePage.Nicknames}'][@role='dialog']";
        }

        public ScrollControl<ListItemNickname> ScrollControlNicknames =>
            new ScrollControl<ListItemNickname>(Driver,
                $"//div[@aria-label='{ResHomePage.Nicknames}'][@role='dialog']/div[3]/div/div/div/div/div[./div]",
                "//div[@aria-label='{ResHomePage.Nicknames}'][@role='dialog']/div[3]/div/div/div/div");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }

    public class ListItemNickname : BaseDiv, IListItem
    {
        public int XIndex { get; set; }
        public int YIndex { get; set; }

        public Button ButtonEdit => new Button(Driver, By.XPath($"{BaseXPath}[{XIndex}]"));

        public TextBox TextBoxNewNickNake => new TextBox(Driver, By.XPath($"{BaseXPath}[{XIndex}]//input"));

        public ListItemNickname(string baseXPath)
        {
            BaseXPath = baseXPath ?? $"//div[@aria-label='{ResHomePage.Nicknames}'][@role='dialog']/div[3]/div/div/div/div/div[./div][{XIndex}]";
        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }

    public class DialogColor : BaseDialog
    {
        protected override By ByForDialog => By.XPath("//div[@aria-label='Color'][@role='dialog']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
