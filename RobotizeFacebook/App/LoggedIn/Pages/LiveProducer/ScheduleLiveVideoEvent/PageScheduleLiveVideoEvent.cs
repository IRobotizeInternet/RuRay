using OpenQA.Selenium;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageScheduleLiveVideoEvent : BasePage
    {
        public override string PageUrl => "/live/producer/events/create/";

        public override By ByForPage => throw new NotImplementedException();

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
