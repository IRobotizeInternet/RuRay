using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages.LoggedIn.Home.MainSection.SubSections
{
    public class Feed
    {
        private RemoteWebDriver _driver;
        private WebDriverWait _wait;

        public Feed(RemoteWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }
    }
}
