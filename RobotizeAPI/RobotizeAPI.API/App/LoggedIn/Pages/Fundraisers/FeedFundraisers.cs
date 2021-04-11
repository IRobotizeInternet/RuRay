using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedFundraisers : Feed
    {
        public override string FeedUrl => "/fundraisers";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
