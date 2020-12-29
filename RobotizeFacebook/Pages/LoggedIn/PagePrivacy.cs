using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages
{
    public class PagePrivacy : PageBase
    {
        public override string PageUrl => "/privacy/";

        public PagePrivacy(RemoteWebDriver driver, WebDriverWait wait)
        {

        }
    }
}
