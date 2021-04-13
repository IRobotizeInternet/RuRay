using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedContainerNotifications : Feed
    {
        public override string FeedUrl => "/notifications";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
