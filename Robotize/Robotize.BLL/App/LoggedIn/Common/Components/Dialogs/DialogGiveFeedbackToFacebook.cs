using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogGiveFeedbackToFacebook : BaseDialog
    {
        public DialogGiveFeedbackToFacebook()
        {
        }

        private string _baseXPath => $"//div[@aria-label='{ResMiscellaneous.GiveFeedbackToFacebook}']";
        protected override By ByForDialog => By.XPath(_baseXPath);

        public EventTriggerButton<DialogHelpUsImproveNewFacebook> DialogHelpToImproveTheNewFacebook =>
            new EventTriggerButton<DialogHelpUsImproveNewFacebook>(Driver, By.XPath($"{_baseXPath}//span[text()='{ResMiscellaneous.HelpUsImproveTheNewFacebook}']"));

        public EventTriggerButton<DialogHelpUsImproveNewFacebook> DialogSomethingWentWrong =>
            new EventTriggerButton<DialogHelpUsImproveNewFacebook>(Driver, By.XPath($"{_baseXPath}//span[text()='{ResMiscellaneous.SomethingWentWrong}']"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
