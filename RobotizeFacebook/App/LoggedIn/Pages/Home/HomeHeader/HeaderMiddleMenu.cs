using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls.TriggerControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class HeaderMiddleMenu : BaseDriver
    {
        // Items in the middle.
        public Hyperlink<PageHome> HyperLinkHome => 
            new Hyperlink<PageHome>(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Home}']"));
        public Hyperlink<PageFriends> HyperLinkFriends => 
            new Hyperlink<PageFriends>(Driver, By.XPath($"//a[@href='/friends/']"));
        public Hyperlink<PageWatch> HyperLinkWatch => 
            new Hyperlink<PageWatch>(Driver, By.XPath($"//a[@href='/watch/']"));
        public Hyperlink<PageMarketplace> HyperLinkMarketPlace => 
            new Hyperlink<PageMarketplace>(Driver, By.XPath($"//a[@href='/marketplace/']"));
        public Hyperlink<PageGroup> HyperLinkGroups => 
            new Hyperlink<PageGroup>(Driver, By.XPath("//a[@href='/groups/']"));

        public Label LabelNotificationHomeCount =>
            new Label(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Home}'][2]//span//span"));

        public Label LabelNotificationFriendsCount =>
            new Label(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Friends}'][2]//span//span"));

        public Label LabelNotificationWatchCount =>
            new Label(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Watch}'][2]//span//span"));

        public Label LabelNotificationMarketplaceCount =>
            new Label(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Marketplace}'][2]//span//span"));

        public Label LabelNotificationGroupsCount =>
            new Label(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Groups}'][2]//span//span"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
