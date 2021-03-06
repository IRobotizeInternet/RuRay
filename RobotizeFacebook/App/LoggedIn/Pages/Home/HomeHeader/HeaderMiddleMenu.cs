using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using System.Text.RegularExpressions;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class HeaderMiddleMenu : BaseDriver
    {
        // Items in the middle.
        public EventTriggerButton<PageHome> EventTriggerButtonHome => 
            new EventTriggerButton<PageHome>(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Home}')]"));
        public EventTriggerButton<PageFriends> EventTriggerButtonFriends => 
            new EventTriggerButton<PageFriends>(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Friends}')][2]"));
        public EventTriggerButton<PageWatch> EventTriggerButtonWatch => 
            new EventTriggerButton<PageWatch>(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Watch}')]"));
        public EventTriggerButton<PageMarketplace> EventTriggerButtonMarketPlace => 
            new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Marketplace}')]"));
        public EventTriggerButton<PageGroup> EventTriggerButtonGroups => 
            new EventTriggerButton<PageGroup>(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Groups}')]"));

        public override void RunConformance()
        {
            EventTriggerButtonFriends.Click();
            EventTriggerButtonGroups.Click();
            EventTriggerButtonMarketPlace.Click();
        }

        public int GetNotificationOfGroups()
        {
            var btn = new Button(Driver, By.XPath("//a[contains(@aria-label, 'Groups')]"));
            var t = EventTriggerButtonHome.GetAttribute("aria-label");
            var notification = btn.GetAttribute("aria-label");
            var count = Regex.Match(notification, @"\d+").Value;
            return int.TryParse(count, out var res) ? res : 0;
        }
    }
}
