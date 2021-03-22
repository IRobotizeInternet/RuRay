using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedGaming : FeedComponent
    {
        public override string FeedUrl => "/games";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
