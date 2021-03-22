using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedJobsComposer : FeedComponent
    {
        public override string FeedUrl => "/jobs_composer/?job_opening_create_surface=JOBS&source=job_browser";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
