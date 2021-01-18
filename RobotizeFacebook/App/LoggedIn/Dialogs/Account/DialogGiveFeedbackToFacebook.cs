using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.Dialogs;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn
{
    public class DialogGiveFeedbackToFacebook : BaseDialog
    {
        public DialogGiveFeedbackToFacebook(RemoteWebDriver driver) : base(driver)
        {
        }

        private string _baseXPath => $"//div[@aria-label='{ResMiscellaneous.GiveFeedbackToFacebook}']";
        protected override By ByForDialog => By.XPath(_baseXPath);

        public EventTriggerButton<DialogHelpUsImproveNewFacebook> DialogHelpToImproveTheNewFacebook =>
            new EventTriggerButton<DialogHelpUsImproveNewFacebook>(Driver, By.XPath($"{_baseXPath}//span[text()='{ResMiscellaneous.HelpUsImproveTheNewFacebook}']"));

        public EventTriggerButton<DialogHelpUsImproveNewFacebook> DialogSomethingWentWrong =>
            new EventTriggerButton<DialogHelpUsImproveNewFacebook>(Driver, By.XPath($"{_baseXPath}//span[text()='{ResMiscellaneous.SomethingWentWrong}']"));

    }
}
