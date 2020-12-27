using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PagePrivacyCheckup : PageBase
    {
        public override string PageUrl => "/privacy/checkup/";

        public PagePrivacyCheckup(RemoteWebDriver driver, WebDriverWait wait)
        {

        }
    }
}
