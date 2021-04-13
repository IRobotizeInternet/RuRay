using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedMessages : Feed
    {
        public override string FeedUrl => "/messages";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
