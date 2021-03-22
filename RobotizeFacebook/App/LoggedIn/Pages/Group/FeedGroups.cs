using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedGroups : FeedComponent
    {
        public override string FeedUrl => "/groups/feed/";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
