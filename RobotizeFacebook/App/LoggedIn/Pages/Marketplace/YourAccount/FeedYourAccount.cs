using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedYourAccount : FeedComponent
    {
        public override string FeedUrl => "/marketplace/you/selling";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
