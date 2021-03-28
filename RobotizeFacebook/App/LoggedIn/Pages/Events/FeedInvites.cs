using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedInvites : Feed
    {
        public override string FeedUrl => "/events/invites/";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
