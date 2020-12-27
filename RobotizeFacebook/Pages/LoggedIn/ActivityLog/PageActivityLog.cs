using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PageActivityLog : PageBase
    {
        public override string PageUrl => "/allactivity/";
        
        public PageActivityLog(RemoteWebDriver driver, WebDriverWait wait)
        {

        }
    }
}
