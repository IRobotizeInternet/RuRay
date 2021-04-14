using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class MenuItemsManagePage : MenuItems
    {
        public EventTriggerButton<PageManagePage> EventTriggerButtonHome =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Home}')]"));
        public EventTriggerButton<PageManagePage> EventTriggerButtonNewsFeed =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.NewsFeed}')]"));
        public EventTriggerButton<PageManagePage> EventTriggerButtonInbox =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Inbox}')]"));
        public EventTriggerButton<PageManagePage> EventTriggerButtonBusinessAppStore =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.BusinessAppStore}')]"));
        public EventTriggerButton<PageManagePage> EventTriggerButtonResourcesAndTools =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.ResourcesAndTools}')]"));
        public EventTriggerButton<PageManagePage> EventTriggerButtonNotifications =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Notifications}')]"));
        public EventTriggerButton<PageManagePage> EventTriggerButtonInsights =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Insights}')]"));
        public EventTriggerButton<PageManagePage> EventTriggerButtonPublishingTools =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.PublishingTools}')]"));
        public EventTriggerButton<PageManagePage> EventTriggerButtonAdCenter =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.AdCenter}')]"));
        public EventTriggerButton<PageManagePage> EventTriggerButtonPageQuality =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.PageQuality}')]"));
        public EventTriggerButton<PageManagePage> EventTriggerButtonEditPageInfo =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.EditPageInfo}')]"));
        public EventTriggerButton<PageManagePage> EventTriggerButtonSettings =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Settings}')]"));
        public EventTriggerButton<PageManagePage> EventTriggerButtonPromote =>
            new EventTriggerButton<PageManagePage>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Promote}')]"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
