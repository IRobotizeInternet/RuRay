using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class PopupHelpAndSupport : BasePopup
    {
        public PopupHelpAndSupport()
        {
            BaseXPath = $"//div[@aria-label='{ResAccount.Account}'][@role='dialog']//span[text()='{ResAccount.HelpCenter}']/../../../../../../../../../../..";
        }

        protected override By ByForDialog => By.XPath(BaseXPath);

        public EventTriggerButton<PageHelp> ButtonHelpCenter =>
           new EventTriggerButton<PageHelp>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.HelpCenter}']"));
        public EventTriggerButton<PageSupportInbox> ButtonSupportInbox =>
          new EventTriggerButton<PageSupportInbox>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.SupportInbox}']"));
        public EventTriggerButton<PageSettings> ButtonReportAProblem =>
          new EventTriggerButton<PageSettings>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.ReportAProblem}']"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
