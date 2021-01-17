using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.Dialogs;
using RobotizeFacebook.Resources;

namespace RobotizeFacebook.Pages.LoggedIn.Home.HomeHeader
{
    public class PopupMessanger : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePageHeader.Messenger}'][@role='dialog']");

        public PopupMessanger(RemoteWebDriver driver) : base(driver)
        {
        }
    }
}
