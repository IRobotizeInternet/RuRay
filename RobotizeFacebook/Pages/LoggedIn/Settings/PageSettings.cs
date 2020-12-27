using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages
{
    public class PageSettings : PageBase
    {
        public override string PageUrl => "/settings/";

        public PageSettings(RemoteWebDriver driver, WebDriverWait wait)
        {
        }
    }
}
