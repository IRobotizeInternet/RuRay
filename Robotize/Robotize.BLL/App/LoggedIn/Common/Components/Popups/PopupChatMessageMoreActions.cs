using System;
using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PopupChatMessageMoreActions : BasePopup
    {
        protected override By ByForDialog => By.XPath($"//div[@data-pagelet='ChatTab']//div[@aria-label='{ResHomePage.AttachAPhotoOrVideo}'][not(contains(@aria-disabled,'true'))][@tabindex='0']");

        public PopupChatMessageMoreActions()
        {
            BaseXPath = string.Empty;
        }

        public Button ButtonAttachAPhotoOrVideo =>
            new Button(Driver, By.XPath($"//div[@data-pagelet='ChatTab']//div[@aria-label='{ResHomePage.AttachAPhotoOrVideo}'][not(contains(@aria-disabled,'true'))][@tabindex='0']"));

        public EventTriggerButton<DialogChooseASticker> EventTriggerButtonChooseASticker =>
            new EventTriggerButton<DialogChooseASticker>(Driver, By.XPath($"//div[@data-pagelet='ChatTab']//div[@aria-label='{ResHomePage.ChooseASicker}'][not(contains(@aria-disabled,'true'))][@tabindex='0']"));

        public EventTriggerButton<DialogChooseAGIF> EventTriggerButtonChooseAGif =>
            new EventTriggerButton<DialogChooseAGIF>(Driver, By.XPath($"//div[@data-pagelet='ChatTab']//div[@aria-label='{ResHomePage.ChooseAGif}'][not(contains(@aria-disabled,'true'))][@tabindex='0']"));

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }

        public EventTriggerButton<PopupNewMessage> EventTriggerButtonCloseMoreActions =>
           new EventTriggerButton<PopupNewMessage>(Driver, By.XPath($"//div[@aria-label='{ResHomePage.CloseMoreActions}']"));
    }
}
