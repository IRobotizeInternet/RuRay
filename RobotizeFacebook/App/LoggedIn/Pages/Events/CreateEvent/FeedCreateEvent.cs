using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedCreateEvent : FeedComponent
    {
        public override string FeedUrl => "/events/create/";

        public EventTriggerButton<FeedCreateEventDetails> TriggerButtonCreateOnlineEvent =>
            new EventTriggerButton<FeedCreateEventDetails>(Driver, By.XPath($"{BaseXPath}////span[text()='{ResLeftNav.Online}']"));
        public EventTriggerButton<FeedCreateEventDetails> TriggerButtonCreateInPersonEvent =>
            new EventTriggerButton<FeedCreateEventDetails>(Driver, By.XPath($"{BaseXPath}////span[text()='{ResLeftNav.InPerson}']"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
