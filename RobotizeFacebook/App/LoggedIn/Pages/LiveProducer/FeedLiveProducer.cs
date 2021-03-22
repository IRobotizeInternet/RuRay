using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedLiveProducer : FeedComponent
    {
        public override string FeedUrl => "/live/producer/";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
