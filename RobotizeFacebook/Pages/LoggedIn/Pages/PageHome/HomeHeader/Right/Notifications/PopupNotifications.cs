using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeToolbox.Dialogs;
using RobotizeFacebook.Resources;

namespace RobotizeFacebook.Pages.LoggedIn.Home.HomeHeader
{
    public class PopupNotifications : BaseDialog
    {
        public PopupNotifications(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePageHeader.Notifications}'][@role='dialog']");
    }
}
