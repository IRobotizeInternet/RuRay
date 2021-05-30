using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class DialogHideOrReport : BaseDialog
    {
        public DialogHideOrReport()
        {
        }

        public Button ButtonHideComment => new Button(Driver, By.XPath($"//span[text()='{ResHomePage.HideComment}'])"));
        public Button ButtonReportCommentToGroupAdmins => new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ReportCommentToGroupAdmins}'])"));
        public Button ButtonGiveFeedbackOrReportThisComment => new Button(Driver, By.XPath($"//span[text()='{ResHomePage.GiveFeedbackOrReportThisComment}'])"));
        protected override By ByForDialog => throw new System.NotImplementedException();

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}