using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="FeedCreateEvent" />.
    /// </summary>
    public class FeedCreateEvent : Feed
    {
        /// <summary>
        /// Gets the FeedUrl.
        /// </summary>
        public override string FeedUrl => "/events/create/";

        /// <summary>
        /// Gets the TriggerButtonCreateOnlineEvent.
        /// </summary>
        public EventTriggerButton<FeedCreateEventDetails> TriggerButtonCreateOnlineEvent =>
            new EventTriggerButton<FeedCreateEventDetails>(Driver, By.XPath($"{BaseXPath}////span[text()='{ResLeftNav.Online}']"));

        /// <summary>
        /// Gets the TriggerButtonCreateInPersonEvent.
        /// </summary>
        public EventTriggerButton<FeedCreateEventDetails> TriggerButtonCreateInPersonEvent =>
            new EventTriggerButton<FeedCreateEventDetails>(Driver, By.XPath($"{BaseXPath}////span[text()='{ResLeftNav.InPerson}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
