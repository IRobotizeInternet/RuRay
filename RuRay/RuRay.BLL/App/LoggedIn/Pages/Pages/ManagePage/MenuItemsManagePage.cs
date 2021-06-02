using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="MenuItemsManagePage" />.
    /// </summary>
    public class MenuItemsManagePage : MenuItems
    {
        /// <summary>
        /// Gets the EventTriggerButtonHome.
        /// </summary>
        public EventTriggerButton<PageManagePage> EventTriggerButtonHome =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Home}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonNewsFeed.
        /// </summary>
        public EventTriggerButton<PageManagePage> EventTriggerButtonNewsFeed =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.NewsFeed}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonInbox.
        /// </summary>
        public EventTriggerButton<PageManagePage> EventTriggerButtonInbox =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Inbox}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonBusinessAppStore.
        /// </summary>
        public EventTriggerButton<PageManagePage> EventTriggerButtonBusinessAppStore =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.BusinessAppStore}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonResourcesAndTools.
        /// </summary>
        public EventTriggerButton<PageManagePage> EventTriggerButtonResourcesAndTools =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.ResourcesAndTools}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonNotifications.
        /// </summary>
        public EventTriggerButton<PageManagePage> EventTriggerButtonNotifications =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Notifications}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonInsights.
        /// </summary>
        public EventTriggerButton<PageManagePage> EventTriggerButtonInsights =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Insights}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonPublishingTools.
        /// </summary>
        public EventTriggerButton<PageManagePage> EventTriggerButtonPublishingTools =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.PublishingTools}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonAdCenter.
        /// </summary>
        public EventTriggerButton<PageManagePage> EventTriggerButtonAdCenter =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.AdCenter}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonPageQuality.
        /// </summary>
        public EventTriggerButton<PageManagePage> EventTriggerButtonPageQuality =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.PageQuality}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonEditPageInfo.
        /// </summary>
        public EventTriggerButton<PageManagePage> EventTriggerButtonEditPageInfo =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.EditPageInfo}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonSettings.
        /// </summary>
        public EventTriggerButton<PageManagePage> EventTriggerButtonSettings =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Settings}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonPromote.
        /// </summary>
        public EventTriggerButton<PageManagePage> EventTriggerButtonPromote =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Promote}')]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
