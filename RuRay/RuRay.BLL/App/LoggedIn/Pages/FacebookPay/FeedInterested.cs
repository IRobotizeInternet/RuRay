using System;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class FeedInterested : Feed
    {
        public override string FeedUrl => "/events/interested/";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
