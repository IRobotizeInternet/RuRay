using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages.LoggedIn.UserHomePage
{
    public class PageUserHome : PageBase
    {
        public PageUserHome(RemoteWebDriver driver, WebDriverWait wait)
        {
        }

        public override string PageUrl => "{0}";
    }
}
