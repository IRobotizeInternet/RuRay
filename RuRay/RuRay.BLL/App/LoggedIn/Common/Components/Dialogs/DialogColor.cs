using OpenQA.Selenium;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class DialogColor : BaseDialog
    {
        protected override By ByForDialog => By.XPath("//div[@aria-label='Color'][@role='dialog']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
