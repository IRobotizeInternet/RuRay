using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class PageSupportInbox : BasePage
    {
        public override string PageUrl => throw new NotImplementedException();

        public override By ByForPage => throw new NotImplementedException();

        public PageSupportInbox(RemoteWebDriver driver)
        {

        }

        public PageSupportInbox()
        {

        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
