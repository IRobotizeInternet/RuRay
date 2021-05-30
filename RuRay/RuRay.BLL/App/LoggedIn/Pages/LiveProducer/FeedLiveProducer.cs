using System;

namespace RuRayFacebook.App.LoggedIn
{
    public class FeedLiveProducer : Feed
    {
        public override string FeedUrl => "/live/producer/";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
