using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedMemories : Feed
    {
        public override string FeedUrl => "/memories";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
