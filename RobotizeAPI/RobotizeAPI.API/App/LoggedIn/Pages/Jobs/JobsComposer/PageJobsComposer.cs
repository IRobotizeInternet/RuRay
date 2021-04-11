using OpenQA.Selenium;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageJobsComposer : BasePage
    {
        public override string PageUrl => "/jobs_composer/?job_opening_create_surface=JOBS&source=job_browser";

        public override By ByForPage => throw new NotImplementedException();

        public PageJobsComposer()
        {
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
