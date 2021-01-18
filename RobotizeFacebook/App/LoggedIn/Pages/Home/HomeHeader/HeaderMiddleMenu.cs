using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls.TriggerControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class HeaderMiddleMenu : BaseDriver
    {
        // Items in the middle.
        public Hyperlink<PageHome> HyperLinkHome => new Hyperlink<PageHome>(Driver, By.XPath($"//a[@aria-label='{ResHomePageHeader.Home}']"));
        public Hyperlink<PageFriends> HyperLinkFriends => new Hyperlink<PageFriends>(Driver, By.XPath($"//a[@href='/friends/']"));
        public Hyperlink<PageWatch> HyperLinkWatch => new Hyperlink<PageWatch>(Driver, By.XPath($"//a[@href='/watch/']"));
        public Hyperlink<PageMarketplace> HyperLinkMarketPlace => new Hyperlink<PageMarketplace>(Driver, By.XPath($"//a[@href='/marketplace/?ref=app_tab']"));
        public Hyperlink<PageGroup> HyperLinkGroups => new Hyperlink<PageGroup>(Driver, By.XPath("//a[@href='/groups/']"));
    }
}
