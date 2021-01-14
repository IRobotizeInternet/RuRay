using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages
{
    public class DivArchive : PageBase
    {
        public override string PageUrl => "/allactivity/?category_key=ARCHIVED";

        public DivArchive(RemoteWebDriver driver, WebDriverWait wait)
        {

        }
    }
}
