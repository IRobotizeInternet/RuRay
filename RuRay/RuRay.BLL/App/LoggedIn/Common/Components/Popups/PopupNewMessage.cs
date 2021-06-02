using System;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PopupNewMessage" />.
    /// </summary>
    public class PopupNewMessage : BasePopup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PopupNewMessage"/> class.
        /// </summary>
        public PopupNewMessage()
        {
            BaseXPath = "//div[@data-pagelet='ChatTab']";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@data-pagelet='ChatTab']");

        /// <summary>
        /// Gets the ScrollPeopleWhoSharedThis.
        /// </summary>
        public ScrollControl<ListItemMessangerChat> ScrollPeopleWhoSharedThis =>
            new ScrollControl<ListItemMessangerChat>(
                   Driver,
                   $"//div[@data-pagelet='ChatTab']//div[@aria-label='{ResHomePage.Messages}']",
                   scrollXPath: $"//div[@data-pagelet='ChatTab']//div[@aria-label='{ResHomePage.Messages}']/../..");

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the ComboboxSearchByNameOrGroup.
        /// </summary>
        public ComboboxSharingWithYourFriends ComboboxSearchByNameOrGroup =>
           new ComboboxSharingWithYourFriends(Driver, BaseXPath);

        /// <summary>
        /// Gets the EventTriggerButtonOpenMoreActions.
        /// </summary>
        public EventTriggerButton<PopupChatMessageMoreActions> EventTriggerButtonOpenMoreActions =>
            new EventTriggerButton<PopupChatMessageMoreActions>(Driver, By.XPath($"//div[@aria-label='{ResHomePage.OpenMoreActions}']"));

        /// <summary>
        /// Gets the TextBoxTypeMessageBox.
        /// </summary>
        public TextBox TextBoxTypeMessageBox =>
            new TextBox(Driver, By.XPath($"//div[@data-pagelet='ChatTab']//div[@aria-label='{ResHomePage.Aa}']"));

        /// <summary>
        /// Gets the EventTriggerButtonChooseAnEmoji.
        /// </summary>
        public EventTriggerButton<DialogChooseAnEmoji> EventTriggerButtonChooseAnEmoji =>
            new EventTriggerButton<DialogChooseAnEmoji>(Driver, By.XPath($"//div[@role='dialog' and //h3[text()='{ResHomePage.SmileysAndPeople}']]"));

        /// <summary>
        /// Gets the ButtonSendOrLike.
        /// </summary>
        public Button ButtonSendOrLike => new Button(Driver, By.XPath($"//div[@aria-label='{ResHomePage.SendALike}' or @aria-label='{ResHomePage.PressEnterToSend}']"));

        // TODO: Closing a chat window could open a confirm dialof if there is an unsent message. Please handle it accordingly.
        /// <summary>
        /// Gets the ButtonCloseChat.
        /// </summary>
        public Button ButtonCloseChat => new Button(Driver, By.XPath($"//div[@aria-label='{ResHomePage.CloseChat}']"));

        /// <summary>
        /// Gets the ButtonMinimizeChat.
        /// </summary>
        public Button ButtonMinimizeChat => new Button(Driver, By.XPath($"//div[@aria-label='{ResHomePage.MinimizeChat}']"));

        // TODO: We need to handle this seperately, since this action will open a new window which need to be mamanged and return the control to 
        // its original place as before.
        /// <summary>
        /// Gets the Button.
        /// </summary>
        public Button Button => new Button(Driver, By.XPath($"//div[contains(@aria-label,'{ResHomePage.StartAVoiceCallWith}']"));

        /// <summary>
        /// Gets the EventTriggerButtonChatSettings.
        /// </summary>
        public EventTriggerButton<PopupMenuChatSettings> EventTriggerButtonChatSettings =>
            new EventTriggerButton<PopupMenuChatSettings>(Driver, By.XPath($"//div[@aria-label=['{ResHomePage.ChatSettings}']"));

        /// <summary>
        /// Gets the EventTriggerButtonUserProfile.
        /// </summary>
        public EventTriggerButton<HoverOverUserProfile> EventTriggerButtonUserProfile =>
            new EventTriggerButton<HoverOverUserProfile>(Driver, By.XPath($"//div[@aria-label=['{ResHomePage.ChatSettings}']//img"));

        /// <summary>
        /// Gets the ButtonAttachAPhotoOrVideo.
        /// </summary>
        public Button ButtonAttachAPhotoOrVideo =>
            new Button(Driver, By.XPath($"//div[@data-pagelet='ChatTab']//div[@aria-label='{ResHomePage.AttachAPhotoOrVideo}'][not(contains(@aria-disabled,'true'))][@tabindex='0']"));

        /// <summary>
        /// Gets the EventTriggerButtonChooseASticker.
        /// </summary>
        public EventTriggerButton<DialogChooseASticker> EventTriggerButtonChooseASticker =>
            new EventTriggerButton<DialogChooseASticker>(Driver, By.XPath($"//div[@data-pagelet='ChatTab']//div[@aria-label='{ResHomePage.ChooseASicker}'][not(contains(@aria-disabled,'true'))][@tabindex='0']"));

        /// <summary>
        /// Gets the EventTriggerButtonChooseAGif.
        /// </summary>
        public EventTriggerButton<DialogChooseAGIF> EventTriggerButtonChooseAGif =>
            new EventTriggerButton<DialogChooseAGIF>(Driver, By.XPath($"//div[@data-pagelet='ChatTab']//div[@aria-label='{ResHomePage.ChooseAGif}'][not(contains(@aria-disabled,'true'))][@tabindex='0']"));
    }
}
