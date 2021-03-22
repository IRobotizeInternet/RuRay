using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedJobs : FeedComponent
    {
        public override string FeedUrl => "/jobs/?source=bookmark";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
