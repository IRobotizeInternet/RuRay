using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogReportCommentToGroupAdmin" />.
    /// </summary>
    public class DialogReportCommentToGroupAdmin : BaseDialog
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//span[text()='{ResHomePage.ReportCommentToAdmins}']");

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogReportCommentToGroupAdmin"/> class.
        /// </summary>
        public DialogReportCommentToGroupAdmin()
        {
        }

        /// <summary>
        /// Gets the ButtonBreaksGroupRule.
        /// </summary>
        public Button ButtonBreaksGroupRule => new Button(Driver, By.XPath($"{ResHomePage.BreaksGroupRule}"));

        /// <summary>
        /// Gets the ButtonSpam.
        /// </summary>
        public Button ButtonSpam => new Button(Driver, By.XPath($"{ResHomePage.Spam}"));

        /// <summary>
        /// Gets the ButtonMemberConflict.
        /// </summary>
        public Button ButtonMemberConflict => new Button(Driver, By.XPath($"{ResHomePage.MemberConflict}"));

        /// <summary>
        /// Gets the ButtonHarassment.
        /// </summary>
        public Button ButtonHarassment => new Button(Driver, By.XPath($"{ResHomePage.Harassment}"));

        /// <summary>
        /// Gets the ButtonHateSpeech.
        /// </summary>
        public Button ButtonHateSpeech => new Button(Driver, By.XPath($"{ResHomePage.HateSpeech}"));

        /// <summary>
        /// Gets the ButtonNudityOrSexualActivity.
        /// </summary>
        public Button ButtonNudityOrSexualActivity => new Button(Driver, By.XPath($"{ResHomePage.NudityOrSexualActivity}"));

        /// <summary>
        /// Gets the ButtonVoilence.
        /// </summary>
        public Button ButtonVoilence => new Button(Driver, By.XPath($"{ResHomePage.Voilence}"));

        /// <summary>
        /// Gets the ButtonOther.
        /// </summary>
        public Button ButtonOther => new Button(Driver, By.XPath($"{ResHomePage.Other}"));

        /// <summary>
        /// Gets the EventTriggerButtonSendToAdmin.
        /// </summary>
        public EventTriggerButton<PageHome> EventTriggerButtonSendToAdmin =>
            new EventTriggerButton<PageHome>(Driver, By.XPath($"{ResHomePage.SendToAdmins}"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
