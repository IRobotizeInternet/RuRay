using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogGiveFeedbackOrReportThisComment : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//span[text()='{ResHomePage.ReportCommentToAdmins}']");
        public DialogGiveFeedbackOrReportThisComment()
        {
        }

        public Button ButtonNudity => new Button(Driver, By.XPath($"{ResHomePage.Nudity}"));
        public Button ButtonVoilence => new Button(Driver, By.XPath($"{ResHomePage.Voilence}"));
        public Button ButtonHarassment => new Button(Driver, By.XPath($"{ResHomePage.Harassment}"));
        public Button ButtonSuicideOrSelfInjury => new Button(Driver, By.XPath($"{ResHomePage.SuicideOrSelfInjury}"));
        public Button ButtonFalseInformation => new Button(Driver, By.XPath($"{ResHomePage.FalseInformation}"));
        public Button ButtonSpam => new Button(Driver, By.XPath($"{ResHomePage.Spam}"));
        public Button ButtonUnauthorizedSales => new Button(Driver, By.XPath($"{ResHomePage.UnauthorizedSales}"));
        public Button ButtonHateSpeech => new Button(Driver, By.XPath($"{ResHomePage.HateSpeech}"));
        public Button ButtonTerrorism => new Button(Driver, By.XPath($"{ResHomePage.Terrorism}"));
        public EventTriggerButton<DialogSearhSomethingElse> EventTriggerButtonSomethingElse => 
            new EventTriggerButton<DialogSearhSomethingElse>(Driver, By.XPath($"{ResHomePage.SomethingElse}"));
        public EventTriggerButton<PageHome> EventTriggerButtonNext =>
            new EventTriggerButton<PageHome>(Driver, By.XPath($"{ResHomePage.Next}"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}