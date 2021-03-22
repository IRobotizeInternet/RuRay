using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedYourEvents : FeedComponent
    {
        public override string FeedUrl => "/events/calendar/";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
