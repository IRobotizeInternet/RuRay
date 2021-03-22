using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Dialogs;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedUpcomingLiveVideosAndEvents : FeedComponent
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
        protected string BaseXPath = string.Empty;
        public UpcomingLiveVideosAndEvent(RemoteWebDriver driver, string baseXPath) : base(driver)
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
    }
}
