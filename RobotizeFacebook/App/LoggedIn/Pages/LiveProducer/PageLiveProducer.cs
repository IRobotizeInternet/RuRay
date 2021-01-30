using OpenQA.Selenium;
using System;

namespace RobotizeFacebook.App
{
    public class PageLiveProducer : PageBase
    {
        public override string PageUrl => throw new NotImplementedException();

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
