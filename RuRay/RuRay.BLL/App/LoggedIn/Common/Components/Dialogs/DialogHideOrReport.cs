using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogHideOrReport" />.
    /// </summary>
    public class DialogHideOrReport : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogHideOrReport"/> class.
        /// </summary>
        public DialogHideOrReport()
        {
        }

        /// <summary>
        /// Gets the ButtonHideComment.
        /// </summary>
        public Button ButtonHideComment => new Button(Driver, By.XPath($"//span[text()='{ResHomePage.HideComment}'])"));

        /// <summary>
        /// Gets the ButtonReportCommentToGroupAdmins.
        /// </summary>
        public Button ButtonReportCommentToGroupAdmins => new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ReportCommentToGroupAdmins}'])"));

        /// <summary>
        /// Gets the ButtonGiveFeedbackOrReportThisComment.
        /// </summary>
        public Button ButtonGiveFeedbackOrReportThisComment => new Button(Driver, By.XPath($"//span[text()='{ResHomePage.GiveFeedbackOrReportThisComment}'])"));

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => throw new System.NotImplementedException();

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
