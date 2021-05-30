using OpenQA.Selenium;
using RuRay.BLL.Resources;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class PopupNotifications : BaseDialog
    {
        public PopupNotifications()
        {
        }

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePageHeader.Notifications}'][@role='dialog']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
