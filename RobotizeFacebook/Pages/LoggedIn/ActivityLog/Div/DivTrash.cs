using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages
{
    public class DivTrash : PageBase
    {
        public override string PageUrl => "/allactivity/?category_key=TRASH";

        public DivTrash(RemoteWebDriver driver, WebDriverWait wait)
        {

        }
    }
}
