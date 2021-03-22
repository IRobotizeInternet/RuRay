using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedPastEvents : FeedComponent
    {
        public override string FeedUrl => "/events/past/";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
