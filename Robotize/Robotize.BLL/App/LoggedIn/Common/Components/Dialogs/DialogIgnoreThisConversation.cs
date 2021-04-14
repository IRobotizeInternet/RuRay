using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogIgnoreThisConversation : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePage.IgnoreThisConversation}']");

        public DialogIgnoreThisConversation()
        {
            BaseXPath = $"//div[@aria-label='{ResHomePage.IgnoreThisConversation}']";
        }

        public EventTriggerButton<PopupNewMessage> EventTriggerButtonIgnoremessages =>
            new EventTriggerButton<PopupNewMessage>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.Ignoremessages}'][@tabindex='0']"));

        public EventTriggerButton<PopupNewMessage> EventTriggerButtonCancel =>
            new EventTriggerButton<PopupNewMessage>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.Cancel}'][@tabindex='0']"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
