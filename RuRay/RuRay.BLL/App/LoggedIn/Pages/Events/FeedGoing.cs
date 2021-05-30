using System;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class FeedGoing : Feed
    {
        public override string FeedUrl => "/events/going/";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
