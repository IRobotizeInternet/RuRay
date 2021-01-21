using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.App
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
