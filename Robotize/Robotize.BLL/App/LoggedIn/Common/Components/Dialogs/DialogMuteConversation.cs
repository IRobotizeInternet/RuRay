using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
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

        public Button ButtonFor30minutes => new Button(Driver, By.XPath($"//div[@data-pagelet='ChatTab']/following::div[@role='menu']//span[text()='{ResHomePage.For30minutes}'"));
        public Button ButtonFor1Hour => new Button(Driver, By.XPath($"//div[@data-pagelet='ChatTab']/following::div[@role='menu']//span[text()='{ResHomePage.For1Hour}'"));
        public Button ButtonFor8Hours => new Button(Driver, By.XPath($"//div[@data-pagelet='ChatTab']/following::div[@role='menu']//span[text()='{ResHomePage.For8Hours}'"));
        public Button ButtonFor24Hours => new Button(Driver, By.XPath($"//div[@data-pagelet='ChatTab']/following::div[@role='menu']//span[text()='{ResHomePage.For24Hours}'"));
        public Button ButtonUntilIturnitbackon => new Button(Driver, By.XPath($"//div[@data-pagelet='ChatTab']/following::div[@role='menu']//span[text()='{ResHomePage.UntilIturnitbackon}'"));

        public EventTriggerButton<PopupMessanger> ButtonClose => new EventTriggerButton<PopupMessanger>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePageHeader.Close}']"));
        public EventTriggerButton<PopupMessanger> ButtonCancel => new EventTriggerButton<PopupMessanger>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.Cancel}'][@tabindex='0']"));
        public EventTriggerButton<PopupMessanger> ButtonMute => new EventTriggerButton<PopupMessanger>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.Mute}'][@tabindex='0']"));
    }
}
