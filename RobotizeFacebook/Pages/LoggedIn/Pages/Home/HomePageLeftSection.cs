using OpenQA.Selenium.Remote;


namespace RobotizeFacebook.Pages.LoggedIn.Home
{
    public class HomePageLeftSection
    {
        private readonly RemoteWebDriver _driver;

        public HomePageLeftSection(RemoteWebDriver driver)
        {
            _driver = driver;
        }
    }
}
