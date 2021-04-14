using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogBlockUser : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//div[contains(@aria-label,'{ResHomePage.Block}')]");

        public DialogBlockUser()
        {
            BaseXPath = $"//div[contains(@aria-label,'{ResHomePage.Block}')]";
        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        public EventTriggerButton<PopupNewMessage> EventTriggerButtonBlockMessagesAndCalls =>
            new EventTriggerButton<PopupNewMessage>(Driver, By.XPath($"{BaseXPath}//div[text()='{ResHomePage.BlockMessagesAndCalls1}']"));

        public EventTriggerButton<PopupNewMessage> EventTriggerButtonBlockOnFacebook =>
            new EventTriggerButton<PopupNewMessage>(Driver, By.XPath($"{BaseXPath}//div[text()='{ResHomePage.BlockOnFacebook}']"));

        internal class DialogConformation : BaseDialog
        {
            protected override By ByForDialog => By.XPath($"//div[contains(@aria-label,'{ResHomePage.BlockMessagesAndCalls1}')]");

            public override void RunConformance()
            {
                throw new System.NotImplementedException();
            }

            public EventTriggerButton<PopupNewMessage> EventTriggerButtonBlock =>
                new EventTriggerButton<PopupNewMessage>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Block}']"));

            public EventTriggerButton<DialogBlockUser> EventTriggerButtonCancel =>
                new EventTriggerButton<DialogBlockUser>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePage.Cancel}']"));
        }

    }
}
