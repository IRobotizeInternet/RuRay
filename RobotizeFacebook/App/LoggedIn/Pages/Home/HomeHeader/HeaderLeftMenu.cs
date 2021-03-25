using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls.TriggerControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class HeaderLeftMenu : BaseDriver
    {
        // Items on left.
        public Hyperlink<PageUserTimeline> HyperLinkFacebookTitleIcon =>
            new Hyperlink<PageUserTimeline>(Driver, By.XPath("//a[@aria-label='Facebook']"));

        public SearchboxSearchFacebook SearchboxFacebook => 
            new SearchboxSearchFacebook(Driver, By.XPath($"//input[@placeholder='{ResHomePageHeader.SearchFacebook}']"));
        
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
