using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls.TriggerControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class HeaderLeftMenu : BaseDriver
    {
        private readonly RemoteWebDriver _driver;

        // Items on left.
        public Hyperlink<PageUserTimeline> HyperLinkFacebookTitleIcon => 
            new Hyperlink<PageUserTimeline>(_driver, By.XPath("//a[@aria-label='Facebook']"));

        public SearchboxSearchFacebook SearchboxFacebook => 
            new SearchboxSearchFacebook(_driver, By.XPath($"//input[@placeholder='{ResHomePageHeader.SearchFacebook}']"));
        
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
