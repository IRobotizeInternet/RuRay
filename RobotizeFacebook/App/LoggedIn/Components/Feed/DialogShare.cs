using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.LoggedIn.Pages.Base
{
    public class DialogShare : BaseDialog
    {
        public DialogShare()
        {
            BaseXPath = "";
        }

        protected override By ByForDialog => By.XPath($"//span[text()='{ResHomePage.ShareNowPublic}']");

        public Button ButtonShareNowPublic =>
           new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ShareNowPublic}']"));
        public Button ButtonShareToNewsFeed =>
            new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ShareToNewsFeed}']"));
        public Button EventTriggerButtonShowHideComments =>
           new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ShareToYourStoryFriends}']"));
        public Button EventTriggerButtonSendInMessenger =>
            new Button(Driver, By.XPath($"//span[text()='{ResHomePage.SendInMessenger}']"));
        public Button EventTriggerButtonPeopleShareInWhatsApp =>
            new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ShareInWhatsApp}']"));
        public Button EventTriggerButtonShareToAgroup =>
          new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ShareToAgroup}']"));
        public Button EventTriggerButtonShareToAPage =>
            new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ShareToAPage}']"));
        public Button EventTriggerButtonShareToYourStoryFriends =>
            new Button(Driver, By.XPath($"//span[text()=\"{ResHomePage.ShareToYourStoryFriends}\"]"));
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