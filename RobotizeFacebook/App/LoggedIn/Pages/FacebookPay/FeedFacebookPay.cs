using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedFacebookPay : FeedComponent
    {
        public override string FeedUrl => "/facebook_pay/?referrer=bookmark";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
