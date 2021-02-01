using OpenQA.Selenium;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageCreateEvent : BasePage
    {
        public override string PageUrl => "/events/create/";

        public override By ByForPage => throw new NotImplementedException();

        public PageCreateEvent()
        {
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
