using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PageHelp : PageBase
    {
        public override string PageUrl => "/help/";

        public PageHelp(RemoteWebDriver driver, WebDriverWait wait)
        {

        }
    }
}
