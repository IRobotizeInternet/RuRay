using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedJobsComposer : Feed
    {
        public override string FeedUrl => "/live/producer/";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
