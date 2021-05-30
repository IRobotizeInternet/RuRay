using OpenQA.Selenium;
using System;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class PageFacebookPay : BasePage
    {
        public override string PageUrl => "/facebook_pay/?referrer=bookmark";

        public override By ByForPage => throw new NotImplementedException();

        public PageFacebookPay()
        {
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
