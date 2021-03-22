using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedInterested : FeedComponent
    {
        public override string FeedUrl => "/events/interested/";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
