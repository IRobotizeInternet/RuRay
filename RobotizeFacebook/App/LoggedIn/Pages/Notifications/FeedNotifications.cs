using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedNotifications : Feed
    {
        public override string FeedUrl => "/notifications";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
