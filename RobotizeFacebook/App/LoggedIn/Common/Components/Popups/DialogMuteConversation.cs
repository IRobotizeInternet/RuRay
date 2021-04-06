using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
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

        public EventTriggerButton<PopupMessanger> ButtonClose => new EventTriggerButton<PopupMessanger>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePageHeader.Close}']"));
        public EventTriggerButton<PopupMessanger> ButtonCancel => new EventTriggerButton<PopupMessanger>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.Cancel}'][@tabindex='0']"));
        public EventTriggerButton<PopupMessanger> ButtonMute => new EventTriggerButton<PopupMessanger>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.Mute}'][@tabindex='0']"));
    }
}
