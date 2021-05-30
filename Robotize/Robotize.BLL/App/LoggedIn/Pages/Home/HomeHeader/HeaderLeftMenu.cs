using OpenQA.Selenium;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.LoggedIn.Pages
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
