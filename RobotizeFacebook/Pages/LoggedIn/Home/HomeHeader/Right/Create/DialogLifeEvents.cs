using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Dialogs;

namespace RobotizeFacebook.Pages.LoggedIn.Home.HomeHeader
{
    public class DialogLifeEvents : BaseDialog
    {
        public DialogLifeEvents(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        protected override By ByForDialog => By.XPath("//div[@class='tr9rh885 sjgh65i0']");
    }
}
