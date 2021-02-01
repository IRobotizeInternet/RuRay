using OpenQA.Selenium;

namespace RobotizeFacebook.App.NotLoggedIn
{
    public class PageTerms : BasePage
    {
        public override string PageUrl => "legal/terms/update";

        public override By ByForPage => throw new System.NotImplementedException();

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
