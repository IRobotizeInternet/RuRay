using System;
using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedUpcomingLiveVideosAndEvents : Feed
    {
        public override string FeedUrl => "/live/producer/upcoming/";
        private string PostXPath = string.Empty;

        private EventTriggerButton<UpcomingLiveVideosAndEvent> EventTriggerButtonViewPost
        {
            get
            {
                return new EventTriggerButton<UpcomingLiveVideosAndEvent>(Driver, By.XPath($"//div[@role='main']//span[text()='{ResLeftNav.ViewPost}']"), 
                    $"//div[@role='main']//div[contains(@style,'border-radius')  and //div[@role='main']//span[contains(text(), '{PostXPath}')]]");
            }
        }
           
        public UpcomingLiveVideosAndEvent ViewMyPost(string postName)
        {
            PostXPath = postName;
            return EventTriggerButtonViewPost.Click();
        }


        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }

    public class UpcomingLiveVideosAndEvent : BaseDialog
    {
        public UpcomingLiveVideosAndEvent(string baseXPath)
        {
            BaseXPath = baseXPath;
        }

        protected override By ByForDialog => throw new NotImplementedException();

        public EventTriggerButton<PageScheduleLiveVideoEvent> EventTriggerButtonEditPost =>
              new EventTriggerButton<PageScheduleLiveVideoEvent>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResLeftNav.Edit}']"));


        public EventTriggerButton<PageUpcomingEvent> EventTriggerButtonViewPost =>
            new EventTriggerButton<PageUpcomingEvent>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResLeftNav.ViewPost}']"));

        public EventTriggerButton<PageLiveProducer> EventTriggerButtonSetUpLiveVideo =>
            new EventTriggerButton<PageLiveProducer>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResLeftNav.SetUpLiveVideo}']"));

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
