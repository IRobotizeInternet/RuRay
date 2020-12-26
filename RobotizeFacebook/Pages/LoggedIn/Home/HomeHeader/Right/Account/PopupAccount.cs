using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Dialogs;

namespace RobotizeFacebook.Pages.LoggedIn.Home.HomeHeader
{
    public class PopupAccount : BaseDialog
    {
        public PopupAccount(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        protected override By ByForDialog => By.XPath("//div[@aria-label='Account'][@role='dialog']");
    }
}
