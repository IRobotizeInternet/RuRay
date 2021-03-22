using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedBirthdays : FeedComponent
    {
        public override string FeedUrl => "/events/birthdays/";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
