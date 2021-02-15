using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.Dialogs;
using RobotizeFacebook.Resources;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogCreateYourRoom : BaseDialog
    {
        // This is the ugliest way to making the xpath, feel free to chage to for better.
        protected override By ByForDialog => By.XPath($"*//span[text()='{ResMiscellaneous.CreateYourRoom}']//..//..//..//..//..//..//..//..//parent::div[@role='dialog']");

        public DialogCreateYourRoom(RemoteWebDriver driver)
            :base(driver)
        {
            
        }

    }
}
