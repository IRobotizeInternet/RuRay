using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedWatch : Feed
    {
        public override string FeedUrl => "/watch";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
