using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.Pages
{
    public class PageTimeline : PageBase
    {
        public override string PageUrl => "{0}";

        public override By ByForPage => throw new System.NotImplementedException();

        public PageTimeline(RemoteWebDriver driver)
        {

        }
    }
}
