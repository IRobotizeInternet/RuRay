using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.LoggedIn
{
    public class DialogLifeEvents : BaseDialog
    {
        public DialogLifeEvents(RemoteWebDriver driver) : base(driver)
        {
            
        }

        protected override By ByForDialog => By.XPath($"//span[text()='{ResHomePage.LifeEvent}']");
    }
}
