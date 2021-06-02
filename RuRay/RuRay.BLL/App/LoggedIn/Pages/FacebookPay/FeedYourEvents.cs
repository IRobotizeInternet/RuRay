using System;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class FeedYourEvents : Feed
    {
        public override string FeedUrl => "/events/calendar/";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
