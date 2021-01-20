using OpenQA.Selenium;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageCreateEvent : PageBase
    {
        public override string PageUrl => "/events/create/";

        public override By ByForPage => throw new NotImplementedException();

        public PageCreateEvent()
        {
        }
    }
}
