using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.LoggedIn.Pages.Base
{
    public class DialogShare : BaseDialog
    {
        public DialogShare(RemoteWebDriver driver) : base(driver)
        {
        }

        protected override By ByForDialog => "//span[text()='']";
    }
}