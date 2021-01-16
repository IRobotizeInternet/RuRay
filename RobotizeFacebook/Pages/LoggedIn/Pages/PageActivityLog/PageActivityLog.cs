using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Resources;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PageActivityLog : PageBase
    {
        public override string PageUrl => "/allactivity/";

        public readonly string BaseXPath = $"//div[@data-pagelet='page']/div/div[@aria-label='{ResMiscellaneous.ListOfActivityLogItems}'][@role='navigation']";
        public PageActivityLog(RemoteWebDriver driver, WebDriverWait wait)
        {
        }
    }
}
