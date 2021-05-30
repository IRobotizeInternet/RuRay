using OpenQA.Selenium;
using RuRay.BLL.Resources;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class PopupMessanger : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePageHeader.Messenger}'][@role='dialog']");

        public PopupMessanger()
        {
        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
