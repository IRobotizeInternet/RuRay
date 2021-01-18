using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.Dialogs;
using RobotizeFacebook.Resources;

namespace RobotizeFacebook.App.LoggedIn.Home.HomeHeader
{
    public class PopupNotifications : BaseDialog
    {
        public PopupNotifications(RemoteWebDriver driver) : base(driver)
        {
        }

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePageHeader.Notifications}'][@role='dialog']");
    }
}
