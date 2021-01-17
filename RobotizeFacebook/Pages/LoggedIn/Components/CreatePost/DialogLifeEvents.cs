using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.Dialogs;
using RobotizeToolbox.Resources;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class DialogLifeEvents : BaseDialog
    {
        public DialogLifeEvents(RemoteWebDriver driver) : base(driver)
        {
            
        }

        protected override By ByForDialog => By.XPath($"//span[text()='{ResHomePage.LifeEvent}']");
    }
}
