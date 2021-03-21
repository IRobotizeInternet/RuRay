using OpenQA.Selenium;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageMemories : BasePage
    {
        public override string PageUrl => "/memories";

        public override By ByForPage => throw new NotImplementedException();

        public PageMemories()
        {
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
