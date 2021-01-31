using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageScheduleLiveVideoEvent : PageBase
    {
        public override string PageUrl => "/live/producer/events/create/";

        public override By ByForPage => throw new NotImplementedException();

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
