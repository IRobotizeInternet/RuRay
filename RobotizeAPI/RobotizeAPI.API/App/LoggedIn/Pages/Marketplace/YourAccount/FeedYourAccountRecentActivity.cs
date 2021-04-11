using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedYourAccountRecentActivity : Feed
    {
        public override string FeedUrl => "/marketplace/you";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
