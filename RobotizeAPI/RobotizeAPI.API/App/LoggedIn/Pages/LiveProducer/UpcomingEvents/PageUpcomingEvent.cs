using OpenQA.Selenium;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageUpcomingEvent : BasePage
    {
        public override string PageUrl => "{0}/";

        public override By ByForPage => throw new NotImplementedException();

        public PageUpcomingEvent() { }

        public PageUpcomingEvent(string eventUrl) {
            GoToPage(string.Format(PageUrl, eventUrl));
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
