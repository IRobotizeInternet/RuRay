using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedMarketplaceCart : Feed
    {
        public override string FeedUrl => "marketplace/cart";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
