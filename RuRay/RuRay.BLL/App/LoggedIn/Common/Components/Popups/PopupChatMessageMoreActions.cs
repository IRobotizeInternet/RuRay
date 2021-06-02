using System;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PopupChatMessageMoreActions" />.
    /// </summary>
    public class PopupChatMessageMoreActions : BasePopup
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@data-pagelet='ChatTab']//div[@aria-label='{ResHomePage.AttachAPhotoOrVideo}'][not(contains(@aria-disabled,'true'))][@tabindex='0']");

        /// <summary>
        /// Initializes a new instance of the <see cref="PopupChatMessageMoreActions"/> class.
        /// </summary>
        public PopupChatMessageMoreActions()
        {
            BaseXPath = string.Empty;
        }

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

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the EventTriggerButtonCloseMoreActions.
        /// </summary>
        public EventTriggerButton<PopupNewMessage> EventTriggerButtonCloseMoreActions =>
           new EventTriggerButton<PopupNewMessage>(Driver, By.XPath($"//div[@aria-label='{ResHomePage.CloseMoreActions}']"));
    }
}
