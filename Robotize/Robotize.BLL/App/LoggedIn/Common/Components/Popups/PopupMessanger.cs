using OpenQA.Selenium;
using Robotize.BLL.Resources;

namespace RobotizeFacebook.App.LoggedIn.Pages
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
