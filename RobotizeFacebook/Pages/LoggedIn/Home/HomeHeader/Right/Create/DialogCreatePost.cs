using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Dialogs;

namespace RobotizeFacebook.Pages.LoggedIn.Home.HomeHeader
{
    public class DialogCreatePost : DialogBase
    {
        public DialogCreatePost(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        protected override By ByForDialog => By.XPath("//div[@class='dbpd2lw6 l9j0dhe7 stjgntxs ni8dbmo4 lzcic4wl idiwt2bm']");
    }
}
