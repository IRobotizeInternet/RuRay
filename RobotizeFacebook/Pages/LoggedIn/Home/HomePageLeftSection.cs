using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages.LoggedIn.Home
{
    public class HomePageLeftSection
    {
        private readonly RemoteWebDriver _driver;
        private readonly WebDriverWait _wait;

        public HomePageLeftSection(RemoteWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }
    }
}
