using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedJobs : Feed
    {
        public override string FeedUrl => "/jobs/?source=bookmark";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
