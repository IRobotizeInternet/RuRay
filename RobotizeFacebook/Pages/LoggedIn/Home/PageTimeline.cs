using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages.LoggedIn.Home
{
    public class PageTimeline : PageBase
    {
        public override string PageUrl => "{0}";

        public PageTimeline(RemoteWebDriver driver, WebDriverWait wait)
        {

        }
    }
}
