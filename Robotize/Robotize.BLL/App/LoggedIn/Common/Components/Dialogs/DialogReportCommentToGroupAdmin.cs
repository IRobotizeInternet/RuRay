using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogReportCommentToGroupAdmin : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//span[text()='{ResHomePage.ReportCommentToAdmins}']");
        public DialogReportCommentToGroupAdmin()
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

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}