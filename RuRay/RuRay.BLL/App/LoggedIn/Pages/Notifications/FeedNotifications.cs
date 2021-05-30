using System;

namespace RuRayFacebook.App.LoggedIn.Pages
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
