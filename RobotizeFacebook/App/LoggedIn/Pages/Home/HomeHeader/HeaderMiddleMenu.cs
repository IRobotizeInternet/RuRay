using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls.TriggerControls;
using System.Text.RegularExpressions;

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

        public Label LabelNotificationOfHome =>
            new Label(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Home}'][2]//span//span"));

        public Label LabelNotificationOfFriend =>
            new Label(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Friends}'][2]//span//span"));

        public Label LabelNotificationOfWatch =>
            new Label(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Watch}']//span//span"));

        public Label LabelNotificationsOfMarketplace =>
            new Label(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Marketplace}']//span//span"));

        public Label LabelNotificationOfGroups =>
            new Label(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Groups}']//span//span"));

        public override void RunConformance()
        {
            HyperLinkFriends.Click();
            HyperLinkGroups.Click();
            HyperLinkMarketPlace.Click();
        }

        public int GetNotificationOfGroups()
        {
            var notification = LabelNotificationOfGroups.GetAttribute("aria-label");
            var count = Regex.Match(notification, @"\d+").Value;
            return int.TryParse(count, out var res) ? res : 0;
        }
    }
}
