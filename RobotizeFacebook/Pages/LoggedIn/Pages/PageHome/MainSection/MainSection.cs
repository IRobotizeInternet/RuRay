using OpenQA.Selenium.Remote;
using RobotizeFacebook.Pages.LoggedIn.Home.MainSection.SubSections;

namespace RobotizeFacebook.Pages
{
    public class MainSection
    {
        private readonly RemoteWebDriver _driver;
        public MainSection(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        public CreatePost SectionCreatePost => new CreatePost(_driver);

        public void RunConformance()
        {
        }
    }
}
