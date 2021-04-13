using OpenQA.Selenium;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageMessengerKids : BasePage
    {
        public override string PageUrl => "/messenger_kids";

        public override By ByForPage => throw new NotImplementedException();

        public PageMessengerKids()
        {
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
