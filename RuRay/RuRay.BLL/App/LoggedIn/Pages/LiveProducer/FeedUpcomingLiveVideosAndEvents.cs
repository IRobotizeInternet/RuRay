using System;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="FeedUpcomingLiveVideosAndEvents" />.
    /// </summary>
    public class FeedUpcomingLiveVideosAndEvents : Feed
    {
        /// <summary>
        /// Gets the FeedUrl.
        /// </summary>
        public override string FeedUrl => "/live/producer/upcoming/";

        /// <summary>
        /// Defines the PostXPath.
        /// </summary>
        private readonly string PostXPath = string.Empty;

        /// <summary>
        /// Gets the EventTriggerButtonViewPost.
        /// </summary>
        private EventTriggerButton<UpcomingLiveVideosAndEvent> EventTriggerButtonViewPost
        {
            get
            {
                return new EventTriggerButton<UpcomingLiveVideosAndEvent>(Driver, By.XPath($"//div[@role='main']//span[text()='{ResLeftNav.ViewPost}']"),
                    $"//div[@role='main']//div[contains(@style,'border-radius')  and //div[@role='main']//span[contains(text(), '{PostXPath}')]]");
            }
        }

        /// <summary>
        /// The ViewMyPost.
        /// </summary>
        /// <param name="postName">The postName<see cref="string"/>.</param>
        /// <returns>The <see cref="UpcomingLiveVideosAndEvent"/>.</returns>
        public UpcomingLiveVideosAndEvent ViewMyPost(string postName)
        {
            PostXPath = postName;
            return EventTriggerButtonViewPost.Click();
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Defines the <see cref="UpcomingLiveVideosAndEvent" />.
    /// </summary>
    public class UpcomingLiveVideosAndEvent : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpcomingLiveVideosAndEvent"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        public UpcomingLiveVideosAndEvent(string baseXPath)
        {
            BaseXPath = baseXPath;
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => throw new NotImplementedException();

        /// <summary>
        /// Gets the EventTriggerButtonEditPost.
        /// </summary>
        public EventTriggerButton<PageScheduleLiveVideoEvent> EventTriggerButtonEditPost =>
              new EventTriggerButton<PageScheduleLiveVideoEvent>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResLeftNav.Edit}']"));

        /// <summary>
        /// Gets the EventTriggerButtonViewPost.
        /// </summary>
        public EventTriggerButton<PageUpcomingEvent> EventTriggerButtonViewPost =>
            new EventTriggerButton<PageUpcomingEvent>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResLeftNav.ViewPost}']"));

        /// <summary>
        /// Gets the EventTriggerButtonSetUpLiveVideo.
        /// </summary>
        public EventTriggerButton<PageLiveProducer> EventTriggerButtonSetUpLiveVideo =>
            new EventTriggerButton<PageLiveProducer>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResLeftNav.SetUpLiveVideo}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
