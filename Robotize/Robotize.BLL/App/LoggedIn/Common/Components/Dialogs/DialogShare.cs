using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogShare : BaseDialog
    {
        public DialogShare()
        {
            BaseXPath = "";
        }

        protected override By ByForDialog => By.XPath($"//span[contains(text(),'{ResHomePage.ShareNow}')]");

        public Button ButtonShareNowPublic =>
           new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ShareNowPublic}']"));
        public EventTriggerButton<CreatePost> ButtonShareToNewsFeed =>
            new EventTriggerButton<CreatePost>(Driver, By.XPath($"//span[text()='{ResHomePage.ShareToNewsFeed}']"));
        public Button EventTriggerButtonShareToYourStory =>
           new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ShareToYourStory}']"));
        public EventTriggerButton<DialogSendInMessenger> EventTriggerButtonSendInMessenger =>
            new EventTriggerButton<DialogSendInMessenger>(Driver, By.XPath($"//span[text()='{ResHomePage.SendInMessenger}']"));
        public Button EventTriggerButtonPeopleShareInWhatsApp =>
            new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ShareInWhatsApp}']"));
        public Button EventTriggerButtonShareToAgroup =>
          new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ShareToAgroup}']"));
        public Button EventTriggerButtonShareToAPage =>
            new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ShareToAPage}']"));
        public Button EventTriggerButtonShareToYourStoryFriends =>
            new Button(Driver, By.XPath($"//span[contains(text(),\"{ResHomePage.ShareToYourStory}\"])"));
        public Button EventTriggerButtonSendInTwitter =>
          new Button(Driver, By.XPath($"//span[text()='{ResHomePage.SendInTwitter}']"));
        public Button EventTriggerButtonCopyLink =>
            new Button(Driver, By.XPath($"//span[text()='{ResHomePage.CopyLink}']"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}