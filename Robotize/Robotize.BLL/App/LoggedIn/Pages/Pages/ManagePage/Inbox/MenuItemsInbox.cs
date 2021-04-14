using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class MenuItemsInbox : MenuItems
    {
        public EventTriggerButton<PageInbox> EventTriggerButtonAllMessages =>
            new EventTriggerButton<PageInbox>(Driver, By.XPath($"//div[contains(text(), '{ResLeftNav.AllMessages}')]"));
        public EventTriggerButton<FeedMessages> EventTriggerButtonMessenger =>
            new EventTriggerButton<FeedMessages>(Driver, By.XPath($"//div[contains(text(), '{ResLeftNav.Messenger}')]"));
        public EventTriggerButton<FeedInstagramDirect> EventTriggerButtonInstagramDirect =>
            new EventTriggerButton<FeedInstagramDirect>(Driver, By.XPath($"//div[contains(text(), '{ResLeftNav.InstagramDirect}')]"));
        public EventTriggerButton<FeedFacebook> EventTriggerButtonFacebook =>
            new EventTriggerButton<FeedFacebook>(Driver, By.XPath($"//div[contains(text(), '{ResLeftNav.Facebook}')]"));
        public EventTriggerButton<FeedInstagram> EventTriggerButtonInstagram =>
            new EventTriggerButton<FeedInstagram>(Driver, By.XPath($"//div[contains(text(), '{ResLeftNav.Instagram}')]"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
