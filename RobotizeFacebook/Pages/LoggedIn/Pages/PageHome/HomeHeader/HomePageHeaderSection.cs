using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Pages.LoggedIn.Home.HomeHeader;
using RobotizeFacebook.Pages.LoggedUser;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls.TriggerControls;

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
        public Hyperlink<PageHome> HyperLinkFacebookTitleIcon => new Hyperlink<PageHome>(_driver, By.XPath("//a[@aria-label='Facebook']"));
        public TextBox TextBoxSearchFacebook => new TextBox(_driver, By.XPath($"//input[@placeholder='{ResHomePageHeader.SearchFacebook}']"));

        // Items in the middle.
        public Hyperlink<PageHome> HyperLinkHome => new Hyperlink<PageHome>(_driver, By.XPath($"//a[@aria-label='{ResHomePageHeader.Home}']"));
        public Hyperlink<PageFriends> HyperLinkFriends => new Hyperlink<PageFriends>(_driver, By.XPath($"//a[@href='/friends/']"));
        public Hyperlink<PageHome> HyperLinkWatch => new Hyperlink<PageHome>(_driver, By.XPath($"//a[@href='/watch/']"));
        public Hyperlink<PageHome> HyperLinkMarketPlace => new Hyperlink<PageHome>(_driver, By.XPath($"//a[@href='/marketplace/?ref=app_tab']"));
        public Hyperlink<PageHome> HyperLinkGroups => new Hyperlink<PageHome>(_driver, By.XPath("//a[@href='/groups/']"));

        // Items in the right.
        private readonly string BaseRigthXPath = "//div[@role='navigation']";
        public Hyperlink<PageUserHome> HyperLinkUserProfile => new Hyperlink<PageUserHome>(_driver, By.XPath("//a[@href='/me/']/parent::div"));
        public Hyperlink<PopupCreate> DialogButtonToCreate => 
            new Hyperlink<PopupCreate>(_driver, By.XPath($"{BaseRigthXPath}//div[@aria-label='{ResHomePageHeader.Create}']"));
        
        public Hyperlink<PopupMessanger> DialogButtonMessanger => 
            new Hyperlink<PopupMessanger>(_driver, By.XPath($"{BaseRigthXPath}//div[@aria-label='{ResHomePageHeader.Messenger}'][1]"));

        public Hyperlink<PopupMessanger> DialogButtonNotifications => 
            new Hyperlink<PopupMessanger>(_driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label,'{ResHomePageHeader.Notifications})'][1]"));

        public Label LabelMessangerCount => 
            new Label(_driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label,'{ResHomePageHeader.Messenger})'][2]//span//span"));

        public Label LabelNotificationsCount => 
            new Label(_driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label,'{ResHomePageHeader.Notifications})'][2]//span//span"));
        
        public Hyperlink<PopupAccount> DialogAccount => 
            new Hyperlink<PopupAccount>(_driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label,'{ResHomePageHeader.Account})'][1]"));
        
        public void RunConformance()
        {
            //RunConformanceLeftHeader();
            //RunConformanceMiddleHeader();
            //TextBoxSearchFacebook.Click();
            //TextBoxSearchFacebook.SetData("Ali");
            //HyperLinkFacebookTitleIcon.Click();
            //RunConformanceAccountPopUp();
            var a = DialogButtonToCreate.Click();
            a.RunConformance();
        }

        public void RunConformanceMiddleHeader()
        {
            HyperLinkWatch.Click();
            HyperLinkGroups.Click();
            HyperLinkMarketPlace.Click();
            HyperLinkFriends.Click();
            HyperLinkHome.Click();
        }

        public void RunConformanceLeftHeader()
        {
            HyperLinkUserProfile.Click();
            DialogButtonToCreate.Click();
            DialogButtonMessanger.Click();
            DialogButtonNotifications.Click();
            DialogAccount.Click();
        }

        public void RunConformanceAccountPopUp()
        {
            var accountPopUp = DialogAccount.Click();
            var displayAndAccessibilityDialog = accountPopUp.TriggerDisplayAndAccessibilityDialog.Click();
            displayAndAccessibilityDialog.RButtonDarkModeOn.Click();
            displayAndAccessibilityDialog.RButtonDarkModeOff.Click();
            displayAndAccessibilityDialog.RButtonCompactModeOn.Click();
            displayAndAccessibilityDialog.RButtonCompactModeOff.Click();

        }
    }
}
