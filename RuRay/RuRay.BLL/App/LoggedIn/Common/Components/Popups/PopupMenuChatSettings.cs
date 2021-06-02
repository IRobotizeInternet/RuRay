using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PopupMenuChatSettings" />.
    /// </summary>
    public class PopupMenuChatSettings : BasePopup
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@role='menu']//span[text()='Delete conversation']");

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            BaseXPath = $"//div[@data-pagelet='ChatTab']/following::div[@role='menu']";
        }

        /// <summary>
        /// Gets the ButtonOpeninMessenger.
        /// </summary>
        public EventTriggerButton<PageMessages> ButtonOpeninMessenger =>
            new EventTriggerButton<PageMessages>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.OpeninMessenger}'"));

        /// <summary>
        /// Gets the ButtonNewMessengerAppforWindows.
        /// </summary>
        public Button ButtonNewMessengerAppforWindows => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.NewMessengerAppforWindows}'"));

        /// <summary>
        /// Gets the ButtonViewProfile.
        /// </summary>
        public EventTriggerButton<PageHome> ButtonViewProfile =>
            new EventTriggerButton<PageHome>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.ViewProfile}'"));

        /// <summary>
        /// Gets the ButtonColor.
        /// </summary>
        public EventTriggerButton<DialogColor> ButtonColor =>
            new EventTriggerButton<DialogColor>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Color}'"));

        /// <summary>
        /// Gets the ButtonEmoji.
        /// </summary>
        public EventTriggerButton<DialogChooseAnEmoji> ButtonEmoji =>
            new EventTriggerButton<DialogChooseAnEmoji>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Emoji}'"));

        /// <summary>
        /// Gets the ButtonNicknames.
        /// </summary>
        public EventTriggerButton<DialogNickNames> ButtonNicknames =>
            new EventTriggerButton<DialogNickNames>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Nicknames}'"));

        /// <summary>
        /// Gets the ButtonCreategroup.
        /// </summary>
        public Button ButtonCreategroup => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Creategroup}'"));

        /// <summary>
        /// Gets the ButtonMuteconversation.
        /// </summary>
        public EventTriggerButton<DialogMuteConversation> ButtonMuteconversation =>
            new EventTriggerButton<DialogMuteConversation>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Muteconversation}'"));

        /// <summary>
        /// Gets the ButtonIgnoremessages.
        /// </summary>
        public EventTriggerButton<DialogIgnoreThisConversation> ButtonIgnoremessages =>
            new EventTriggerButton<DialogIgnoreThisConversation>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Ignoremessages}'"));

        /// <summary>
        /// Gets the ButtonBlock.
        /// </summary>
        public EventTriggerButton<DialogBlockUser> ButtonBlock =>
            new EventTriggerButton<DialogBlockUser>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Block}'"));

        /// <summary>
        /// Gets the ButtonDeleteconversation.
        /// </summary>
        public EventTriggerButton<DialogDeleteConverstion> ButtonDeleteconversation =>
            new EventTriggerButton<DialogDeleteConverstion>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Deleteconversation}'"));

        /// <summary>
        /// Gets the ButtonSomethingSwrong.
        /// </summary>
        public EventTriggerButton<DialogReport> ButtonSomethingSwrong =>
            new EventTriggerButton<DialogReport>(Driver, By.XPath($"{BaseXPath}//span[text()=\"{ResHomePage.SomethingsWrong}\""));

        /// <summary>
        /// Gets the ButtonGivefeedbackandreporttheconversation.
        /// </summary>
        public Button ButtonGivefeedbackandreporttheconversation => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Givefeedbackandreporttheconversation}'"));
    }

    /// <summary>
    /// Defines the <see cref="DialogReport" />.
    /// </summary>
    public class DialogReport : BaseDialog
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"");

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogReport"/> class.
        /// </summary>
        public DialogReport()
        {
            BaseXPath = $"";
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// Defines the <see cref="DialogDeleteConverstion" />.
    /// </summary>
    public class DialogDeleteConverstion : BaseDialog
    {
        // TODO : These kind of dialogs which are basically a confirmation for an action
        // this could be simplimed and similar dialogs can be consolidated.
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[contains(@aria-label,'{ResHomePage.Deleteconversation}')]");

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogDeleteConverstion"/> class.
        /// </summary>
        public DialogDeleteConverstion()
        {
            BaseXPath = $"//div[contains(@aria-label,'{ResHomePage.Deleteconversation}')]";
        }

        /// <summary>
        /// Gets the EventTriggerButtonDeleteConversation.
        /// </summary>
        public EventTriggerButton<PopupMessanger> EventTriggerButtonDeleteConversation =>
            new EventTriggerButton<PopupMessanger>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.DeleteConversation1}'][@tabindex='0']"));

        /// <summary>
        /// Gets the EventTriggerButtonDeleteCancel.
        /// </summary>
        public EventTriggerButton<PopupMessanger> EventTriggerButtonDeleteCancel =>
            new EventTriggerButton<PopupMessanger>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.Cancel}'][@tabindex='0']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
