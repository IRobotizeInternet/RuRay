using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Pages.LoggedIn.Home.HomeHeader;
using RobotizeFacebook.Pages.LoggedIn.UserHomePage;
using RobotizeFacebook.Pages.LoggedUser;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Controls.TriggerControls;
using RobotizeLibrary.Resources;
using System;
using System.Linq;
using System.Threading;

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
        public Hyperlink<PageHome> HyperLinkFacebookTitleIcon => new Hyperlink<PageHome>(_driver, _wait, By.XPath("//a[@aria-label='Facebook']"));
        public TextBox TextBoxSearchFacebook => new TextBox(_driver, By.XPath("//div[@data-testid='Keycommand_wrapper']//input"));

        // Items in the middle.
        public Hyperlink<PageHome> HyperLinkHome => new Hyperlink<PageHome>(_driver, _wait, By.XPath($"//a[@aria-label='{ResHomePageHeader.Home}']"));
        public Hyperlink<PageFriends> HyperLinkFriends => new Hyperlink<PageFriends>(_driver, _wait, By.XPath($"//a[@href='/friends/']"));
        public Hyperlink<PageHome> HyperLinkWatch => new Hyperlink<PageHome>(_driver, _wait, By.XPath($"//a[@href='/watch/']"));
        public Hyperlink<PageHome> HyperLinkMarketPlace => new Hyperlink<PageHome>(_driver, _wait, By.XPath($"//a[@href='/marketplace/?ref=app_tab']"));
        public Hyperlink<PageHome> HyperLinkGroups => new Hyperlink<PageHome>(_driver, _wait, By.XPath("//a[@href='/groups/']"));

        // Items in the right.
        public Hyperlink<PageUserHome> HyperLinkUserProfile => new Hyperlink<PageUserHome>(_driver, _wait, By.XPath("//a[@href='/me/']/parent::div"));
        public Hyperlink<PopupCreate> DialogButtonToCreate => new Hyperlink<PopupCreate>(_driver, _wait, By.XPath($"//div[@aria-label='{ResHomePageHeader.Create}']"));
        public Hyperlink<PopupMessanger> DialogButtonMessanger => new Hyperlink<PopupMessanger>(_driver, _wait, By.XPath($"//div[@aria-label='{ResHomePageHeader.Messenger}'][@tabindex='0']"));
        public Hyperlink<PopupAccount> DialogButtonNotifications => new Hyperlink<PopupAccount>(_driver, _wait, By.XPath($"//div[@aria-label='{ResHomePageHeader.Account}']"));

        public void RunConformance()
        {
            HyperLinkWatch.Click();
            HyperLinkGroups.Click();
            HyperLinkWatch.Click();
            HyperLinkMarketPlace.Click();
            HyperLinkGroups.Click();
            HyperLinkFacebookTitleIcon.Click();
            HyperLinkUserProfile.Click();
            DialogButtonToCreate.Click();
            DialogButtonMessanger.Click();
            DialogButtonNotifications.Click();
            HyperLinkFriends.Click();
        }

    }
}
