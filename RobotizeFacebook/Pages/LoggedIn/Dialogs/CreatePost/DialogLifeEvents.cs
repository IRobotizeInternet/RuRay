using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Dialogs;
using RobotizeLibrary.Resources;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class DialogLifeEvents : BaseDialog
    {
        public DialogLifeEvents(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            
        }

        protected override By ByForDialog => By.XPath($"//span[text()='{ResHomePage.LifeEvent}']");
    }
}
