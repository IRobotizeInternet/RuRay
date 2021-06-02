using System.Diagnostics;
using System.Text.RegularExpressions;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="HeaderMiddleMenu" />.
    /// </summary>
    public class HeaderMiddleMenu : BaseDriver
    {
        // Items in the middle.
        /// <summary>
        /// Gets the EventTriggerButtonHome.
        /// </summary>
        public EventTriggerButton<PageHome> EventTriggerButtonHome =>
            new EventTriggerButton<PageHome>(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Home}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonFriends.
        /// </summary>
        public EventTriggerButton<PageFriends> EventTriggerButtonFriends =>
            new EventTriggerButton<PageFriends>(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Friends}')][2]"));

        /// <summary>
        /// Gets the EventTriggerButtonWatch.
        /// </summary>
        public EventTriggerButton<PageWatch> EventTriggerButtonWatch =>
            new EventTriggerButton<PageWatch>(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Watch}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonMarketPlace.
        /// </summary>
        public EventTriggerButton<PageMarketplace> EventTriggerButtonMarketPlace =>
            new EventTriggerButton<PageMarketplace>(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Marketplace}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonGroups.
        /// </summary>
        public EventTriggerButton<PageGroup> EventTriggerButtonGroups =>
            new EventTriggerButton<PageGroup>(Driver, By.XPath($"//a[contains(@aria-label, '{ResHomePageHeader.Groups}')]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            EventTriggerButtonFriends.Click();
            EventTriggerButtonGroups.Click();
            EventTriggerButtonMarketPlace.Click();
        }

        /// <summary>
        /// The VerifyNotifications.
        /// </summary>
        public void VerifyNotifications()
        {
            //var btn = new Button(Driver, By.XPath("//a[contains(@aria-label, 'Groups')]"));
            var notification = EventTriggerButtonHome.GetAttribute("aria-label");
            Debug.WriteLine(Regex.Match(notification, @"\d+").Value);
            notification = EventTriggerButtonFriends.GetAttribute("aria-label");
            Debug.WriteLine(Regex.Match(notification, @"\d+").Value);
            notification = EventTriggerButtonWatch.GetAttribute("aria-label");
            Debug.WriteLine(Regex.Match(notification, @"\d+").Value);
            notification = EventTriggerButtonMarketPlace.GetAttribute("aria-label");
            Debug.WriteLine(Regex.Match(notification, @"\d+").Value);
            notification = EventTriggerButtonMarketPlace.GetAttribute("aria-label");
            Debug.WriteLine(Regex.Match(notification, @"\d+").Value);
        }
    }
}
