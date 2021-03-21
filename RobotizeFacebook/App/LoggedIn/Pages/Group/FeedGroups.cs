using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedGroups : Feed
    {
        public override string FeedUrl => "/groups/feed/";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
