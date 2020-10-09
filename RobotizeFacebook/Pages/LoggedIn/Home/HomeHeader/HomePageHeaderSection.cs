using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Pages.LoggedIn.Friends;
using RobotizeFacebook.Pages.LoggedIn.HomeHeader;
using RobotizeFacebook.Pages.LoggedIn.UserHomePage;
using RobotizeFacebook.Pages.LoggedUser;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Controls.TriggerControls;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class HomePageHeaderSection
    {
        private readonly RemoteWebDriver _driver;
        private readonly WebDriverWait _wait;

        public HomePageHeaderSection(RemoteWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        // Items on left.
        public EventTriggerHyperlink<PageHome> HyperLinkFacebookTitleIcon => new EventTriggerHyperlink<PageHome>(_driver, _wait, By.XPath("//div[@class='bp9cbjyn rq0escxv j83agx80 buofh1pr byvelhso dhix69tm poy2od1o j9ispegn kr520xx4 ehxjyohh']//a"));
        public TextBox TextBoxSearchFacebook => new TextBox(_driver, By.XPath("//label[@class='rq0escxv a8c37x1j a5nuqjux l9j0dhe7 k4urcfbm']//input"));

        // Items in the middle.
        public EventTriggerHyperlink<PageHome> HyperLinkHome => new EventTriggerHyperlink<PageHome>(_driver, _wait, By.XPath("//a[@aria-label='Home']"));
        public EventTriggerHyperlink<PageFriends> HyperLinkFriends => new EventTriggerHyperlink<PageFriends>(_driver, _wait, By.XPath("//a[@aria-label='Friends']"));
        public EventTriggerHyperlink<PageHome> HyperLinkWatch => new EventTriggerHyperlink<PageHome>(_driver, _wait, By.XPath("//a[@aria-label='Watch']"));
        public EventTriggerHyperlink<PageHome> HyperLinkMarketPlace => new EventTriggerHyperlink<PageHome>(_driver, _wait, By.XPath("//a[@aria-label='Marketplace']"));
        public EventTriggerHyperlink<PageHome> HyperLinkGroups => new EventTriggerHyperlink<PageHome>(_driver, _wait, By.XPath("//a[@aria-label='Groups']"));

        // Items in the right.
        public EventTriggerHyperlink<PageUserHome> HyperLinkUserProfile => new EventTriggerHyperlink<PageUserHome>(_driver, _wait, By.XPath("//div[@class='bp9cbjyn j83agx80 datstx6m taijpn5t oi9244e8 d74ut37n']"));
        public EventTriggerHyperlink<DialogPopUpCreate> DialogButtonToCreate => new EventTriggerHyperlink<DialogPopUpCreate>(_driver, _wait, By.XPath("//div[@class='bp9cbjyn j83agx80 datstx6m taijpn5t oi9244e8 d74ut37n']"));
    }
}
