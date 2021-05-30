using System;

namespace RuRayFacebook.App.LoggedIn
{
    public class FeedFriends : Feed
    {
        public override string FeedUrl => "/friends";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
