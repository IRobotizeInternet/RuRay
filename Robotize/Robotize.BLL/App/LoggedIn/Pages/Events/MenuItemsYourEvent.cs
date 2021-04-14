using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class MenuItemsYourEvent : MenuItems
    {
        public EventTriggerButton<FeedGoing> TriggerButtonGoing =>
        new EventTriggerButton<FeedGoing>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Going}')]"));
        public EventTriggerButton<FeedInvites> TriggerButtonYourInvites =>
            new EventTriggerButton<FeedInvites>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Invites}')]"));
        public EventTriggerButton<FeedInterested> TriggerButtonInterested =>
            new EventTriggerButton<FeedInterested>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Interested}')]"));
        public EventTriggerButton<FeedHosting> TriggerButtonHosting =>
            new EventTriggerButton<FeedHosting>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Hosting}')]"));
        public EventTriggerButton<FeedPastEvents> TriggerButtonPastEvents =>
            new EventTriggerButton<FeedPastEvents>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.PastEvents}')]"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}