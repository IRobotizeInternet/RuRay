using System;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class FeedHosting : Feed
    {
        public override string FeedUrl => "/events/hosting/";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
