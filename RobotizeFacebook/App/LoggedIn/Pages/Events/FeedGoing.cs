using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedGoing : FeedComponent
    {
        public override string FeedUrl => "/events/going/";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
