using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.LoggedIn.Pages.Base
{
    public class DialogHideOrReport : BaseDialog
    {
        public DialogHideOrReport(RemoteWebDriver driver) : base(driver)
        {
        }

        public Button ButtonHideComment => new Button(Driver, By.XPath($"//span[text()='{ResHomePage.HideComment}'])"));
        public Button ButtonReportCommentToGroupAdmins => new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ReportCommentToGroupAdmins}'])"));
        public Button ButtonGiveFeedbackOrReportThisComment => new Button(Driver, By.XPath($"//span[text()='{ResHomePage.GiveFeedbackOrReportThisComment}'])"));
        protected override By ByForDialog => throw new System.NotImplementedException();
    }

    public class DialogReportCommentToGroupAdmin : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//span[text()='{ResHomePage.ReportCommentToAdmins}']");
        public DialogReportCommentToGroupAdmin(RemoteWebDriver driver) : base(driver)
        {
        }

        public Button ButtonBreaksGroupRule => new Button(Driver, By.XPath($"{ResHomePage.BreaksGroupRule}"));
        public Button ButtonSpam => new Button(Driver, By.XPath($"{ResHomePage.Spam}"));
        public Button ButtonMemberConflict => new Button(Driver, By.XPath($"{ResHomePage.MemberConflict}"));
        public Button ButtonHarassment => new Button(Driver, By.XPath($"{ResHomePage.Harassment}"));
        public Button ButtonHateSpeech => new Button(Driver, By.XPath($"{ResHomePage.HateSpeech}"));
        public Button ButtonNudityOrSexualActivity => new Button(Driver, By.XPath($"{ResHomePage.NudityOrSexualActivity}"));
        public Button ButtonVoilence => new Button(Driver, By.XPath($"{ResHomePage.Voilence}"));
        public Button ButtonOther => new Button(Driver, By.XPath($"{ResHomePage.Other}"));
        public EventTriggerButton<PageHome> EventTriggerButtonSendToAdmin =>
            new EventTriggerButton<PageHome>(Driver, By.XPath($"{ResHomePage.SendToAdmins}"));
    }

    public class DialogGiveFeedbackOrReportThisComment : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//span[text()='{ResHomePage.ReportCommentToAdmins}']");
        public DialogGiveFeedbackOrReportThisComment(RemoteWebDriver driver) : base(driver)
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
    }

    public class DialogSearhSomethingElse
    {
    }
}