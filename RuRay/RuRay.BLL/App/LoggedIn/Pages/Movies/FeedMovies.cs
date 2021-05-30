using System;

namespace RuRayFacebook.App.LoggedIn
{
    public class FeedMovies : Feed
    {
        public override string FeedUrl => "/movies";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
