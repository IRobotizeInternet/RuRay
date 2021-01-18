using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls.TriggerControls;

namespace RobotizeFacebook.App.LoggedIn
{
    public class HomePageHeaderSection
    {
        private readonly RemoteWebDriver _driver;

        public HomePageHeaderSection(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        // Items on left.
        public Hyperlink<PageUserHome> HyperLinkFacebookTitleIcon => 
            new Hyperlink<PageUserHome>(_driver, By.XPath("//a[@aria-label='Facebook']"));

        public SearchboxSearchFacebook SearchboxFacebook => 
            new SearchboxSearchFacebook(_driver, By.XPath($"//input[@placeholder='{ResHomePageHeader.SearchFacebook}']"));
        
        public void RunConformance()
        {
            ////RunConformanceLeftHeader();
            ////RunConformanceMiddleHeader();
            ////TextBoxSearchFacebook.Click();
            ////TextBoxSearchFacebook.SetData("Ali");
            ////HyperLinkFacebookTitleIcon.Click();
            ////RunConformanceAccountPopUp();
            //var a = DialogButtonToCreate.Click();
            //a.RunConformance();
        }

        public void RunConformanceMiddleHeader()
        {
            //HyperLinkWatch.Click();
            //HyperLinkGroups.Click();
            //HyperLinkMarketPlace.Click();
            //HyperLinkFriends.Click();
            //HyperLinkHome.Click();
        }

        public void RunConformanceLeftHeader()
        {
            //HyperLinkUserProfile.Click();
            //DialogButtonToCreate.Click();
            //DialogButtonMessanger.Click();
            //DialogButtonNotifications.Click();
            //DialogAccount.Click();
        }

        public void RunConformanceAccountPopUp()
        {
            //var accountPopUp = DialogAccount.Click();
            //var displayAndAccessibilityDialog = accountPopUp.TriggerDisplayAndAccessibilityDialog.Click();
            //displayAndAccessibilityDialog.RButtonDarkModeOn.Click();
            //displayAndAccessibilityDialog.RButtonDarkModeOff.Click();
            //displayAndAccessibilityDialog.RButtonCompactModeOn.Click();
            //displayAndAccessibilityDialog.RButtonCompactModeOff.Click();

        }
    }
}
