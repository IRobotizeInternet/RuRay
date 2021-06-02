using System;

namespace RuRayFacebook.App.LoggedIn
{
    public class FeedGaming : Feed
    {
        public override string FeedUrl => "/games";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
