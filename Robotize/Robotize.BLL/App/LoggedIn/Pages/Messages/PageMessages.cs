using OpenQA.Selenium;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageMessages : BasePage
    {
        public override string PageUrl => "/messages";

        public override By ByForPage => throw new NotImplementedException();

        public PageMessages()
        {
            
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
