using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Controls.TriggerControls;
using RobotizeLibrary.Dialogs;
using RobotizeFacebook.Resources;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PopupHelpAndSupport : BasePopup
    {
        public PopupHelpAndSupport(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            BaseXPath = $"//div[@aria-label='{ResAccount.Account}'][@role='dialog']//span[text()='{ResAccount.HelpCenter}']/../../../../../../../../../../..";
        }

        protected override By ByForDialog => By.XPath(BaseXPath);

        public EventTriggerButton<PageHelp> ButtonHelpCenter =>
           new EventTriggerButton<PageHelp>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResAccount.HelpCenter}']"));
        public EventTriggerButton<PageSupportInbox> ButtonSupportInbox =>
          new EventTriggerButton<PageSupportInbox>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResAccount.SupportInbox}']"));
        public EventTriggerButton<PageSettings> ButtonReportAProblem =>
          new EventTriggerButton<PageSettings>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResAccount.ReportAProblem}']"));
    }
}
