using OpenQA.Selenium;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageLiveProducer : BasePage
    {
        public override string PageUrl => "/live/producer/";

        public override By ByForPage => throw new NotImplementedException();

        public PageLiveProducer()
        {
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
