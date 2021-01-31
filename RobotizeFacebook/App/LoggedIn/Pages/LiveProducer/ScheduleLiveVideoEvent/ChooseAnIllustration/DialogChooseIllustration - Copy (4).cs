using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogChooseIllustration : BaseDialog
    {
        public DialogChooseIllustration(RemoteWebDriver driver) : base(driver)
        {
        }

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResLeftNav.ChooseIllustration}']");
    }
}