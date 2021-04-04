using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DivArchive : BasePage
    {
        public override string PageUrl => "/allactivity/?category_key=ARCHIVED";

        public override By ByForPage => throw new System.NotImplementedException();

        public DivArchive(RemoteWebDriver driver)
        {

        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
