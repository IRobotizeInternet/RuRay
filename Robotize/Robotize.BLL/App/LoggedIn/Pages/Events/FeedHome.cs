using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedEventHome : Feed
    {
        public override string FeedUrl => "/events/";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
