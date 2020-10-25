using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Pages.LoggedIn;

namespace RobotizeFacebook.Pages.LoggedUser
{
    public class PageHome : PageBase
    {
        public PageHome(RemoteWebDriver driver, WebDriverWait wait)
        {
        }

        public PageHome()
        {
        }

        public override string PageUrl => "";
        public HomePageHeaderSection HeaderSection => new HomePageHeaderSection(Driver, Wait);
        public MainSection MainSection => new MainSection(Driver, Wait);
    }
}
