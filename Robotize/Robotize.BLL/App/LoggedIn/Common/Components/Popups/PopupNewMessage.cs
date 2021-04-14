using System;
using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PopupNewMessage : BasePopup
    {
        public PopupNewMessage()
        {
            BaseXPath = "//div[@data-pagelet='ChatTab']";
        }
        protected override By ByForDialog => By.XPath($"//div[@data-pagelet='ChatTab']");

        public ScrollControl<ListItemMessangerChat> ScrollPeopleWhoSharedThis =>
            new ScrollControl<ListItemMessangerChat>(
                   Driver, 
                   $"//div[@data-pagelet='ChatTab']//div[@aria-label='{ResHomePage.Messages}']",
                   scrollXPath: $"//div[@data-pagelet='ChatTab']//div[@aria-label='{ResHomePage.Messages}']/../..");

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }

        public ComboboxSharingWithYourFriends ComboboxSearchByNameOrGroup =>
           new ComboboxSharingWithYourFriends(Driver, BaseXPath);

        public EventTriggerButton<PopupChatMessageMoreActions> EventTriggerButtonOpenMoreActions =>
            new EventTriggerButton<PopupChatMessageMoreActions>(Driver, By.XPath($"//div[@aria-label='{ResHomePage.OpenMoreActions}']"));

        public TextBox TextBoxTypeMessageBox =>
            new TextBox(Driver, By.XPath($"//div[@data-pagelet='ChatTab']//div[@aria-label='{ResHomePage.Aa}']"));

        public EventTriggerButton<DialogChooseAnEmoji> EventTriggerButtonChooseAnEmoji =>
            new EventTriggerButton<DialogChooseAnEmoji>(Driver, By.XPath($"//div[@role='dialog' and //h3[text()='{ResHomePage.SmileysAndPeople}']]"));

        public Button ButtonSendOrLike => new Button(Driver, By.XPath($"//div[@aria-label='{ResHomePage.SendALike}' or @aria-label='{ResHomePage.PressEnterToSend}']"));

        // TODO: Closing a chat window could open a confirm dialof if there is an unsent message. Please handle it accordingly.
        public Button ButtonCloseChat => new Button(Driver, By.XPath($"//div[@aria-label='{ResHomePage.CloseChat}']"));

        public Button ButtonMinimizeChat => new Button(Driver, By.XPath($"//div[@aria-label='{ResHomePage.MinimizeChat}']"));

        // TODO: We need to handle this seperately, since this action will open a new window which need to be mamanged and return the control to 
        // its original place as before.
        public Button Button => new Button(Driver, By.XPath($"//div[contains(@aria-label,'{ResHomePage.StartAVoiceCallWith}']"));

        public EventTriggerButton<PopupMenuChatSettings> EventTriggerButtonChatSettings =>
            new EventTriggerButton<PopupMenuChatSettings>(Driver, By.XPath($"//div[@aria-label=['{ResHomePage.ChatSettings}']"));

        public EventTriggerButton<HoverOverUserProfile> EventTriggerButtonUserProfile =>
            new EventTriggerButton<HoverOverUserProfile>(Driver, By.XPath($"//div[@aria-label=['{ResHomePage.ChatSettings}']//img"));

        public Button ButtonAttachAPhotoOrVideo =>
            new Button(Driver, By.XPath($"//div[@data-pagelet='ChatTab']//div[@aria-label='{ResHomePage.AttachAPhotoOrVideo}'][not(contains(@aria-disabled,'true'))][@tabindex='0']"));

        public EventTriggerButton<DialogChooseASticker> EventTriggerButtonChooseASticker =>
            new EventTriggerButton<DialogChooseASticker>(Driver, By.XPath($"//div[@data-pagelet='ChatTab']//div[@aria-label='{ResHomePage.ChooseASicker}'][not(contains(@aria-disabled,'true'))][@tabindex='0']"));

        public EventTriggerButton<DialogChooseAGIF> EventTriggerButtonChooseAGif =>
            new EventTriggerButton<DialogChooseAGIF>(Driver, By.XPath($"//div[@data-pagelet='ChatTab']//div[@aria-label='{ResHomePage.ChooseAGif}'][not(contains(@aria-disabled,'true'))][@tabindex='0']"));
    }
}
