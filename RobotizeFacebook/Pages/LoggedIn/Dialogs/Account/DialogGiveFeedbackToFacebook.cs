using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeToolbox.Dialogs;
using RobotizeFacebook.Resources;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class DialogGiveFeedbackToFacebook : BaseDialog
    {
        public DialogGiveFeedbackToFacebook(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        private string _baseXPath => $"//div[@aria-label='{ResMiscellaneous.GiveFeedbackToFacebook}']";
        protected override By ByForDialog => By.XPath(_baseXPath);

        public EventTriggerButton<DialogHelpUsImproveNewFacebook> DialogHelpToImproveTheNewFacebook =>
            new EventTriggerButton<DialogHelpUsImproveNewFacebook>(Driver, Wait, By.XPath($"{_baseXPath}//span[text()='{ResMiscellaneous.HelpUsImproveTheNewFacebook}']"));

        public EventTriggerButton<DialogHelpUsImproveNewFacebook> DialogSomethingWentWrong =>
            new EventTriggerButton<DialogHelpUsImproveNewFacebook>(Driver, Wait, By.XPath($"{_baseXPath}//span[text()='{ResMiscellaneous.SomethingWentWrong}']"));

    }
}
