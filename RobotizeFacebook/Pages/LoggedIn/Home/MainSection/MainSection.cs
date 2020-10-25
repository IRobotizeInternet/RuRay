using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Pages.LoggedIn.Home.MainSection.SubSections;

namespace RobotizeFacebook.Pages 
{
    public class MainSection
    {
        private RemoteWebDriver _driver;
        private WebDriverWait _wait;
        public MainSection(RemoteWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public CreatePost SectionCreatePost => new CreatePost(_driver, _wait);

        public void RunConformance()
        {

        }
    }
}
