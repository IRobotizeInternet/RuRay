using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedMessengerKids : Feed
    {
        public override string FeedUrl => "/messenger_kids";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
