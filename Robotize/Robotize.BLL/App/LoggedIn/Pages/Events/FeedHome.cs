using System;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class FeedEventHome : Feed
    {
        public override string FeedUrl => "/events/";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
