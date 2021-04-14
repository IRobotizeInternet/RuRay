using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls.TriggerControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class HeaderLeftMenu : BaseDriver
    {
        // Items on left.
        public Hyperlink<PageUserTimeline> HyperLinkFacebookTitleIcon =>
            new Hyperlink<PageUserTimeline>(Driver, By.XPath("//a[@aria-label='Facebook']"));

        public ComboboxSearchFacebook SearchboxFacebook => 
            new ComboboxSearchFacebook(Driver, null);
        
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
