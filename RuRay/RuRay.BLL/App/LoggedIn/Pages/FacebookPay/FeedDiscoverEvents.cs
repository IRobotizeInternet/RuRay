using System;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class FeedDiscoverEvents : Feed
    {
        public override string FeedUrl => "/events/discovery/";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
