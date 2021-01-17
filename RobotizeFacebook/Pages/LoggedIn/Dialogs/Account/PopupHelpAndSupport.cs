using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.Dialogs;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PopupHelpAndSupport : BasePopup
    {
        public PopupHelpAndSupport(RemoteWebDriver driver) : base(driver)
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
    }
}
