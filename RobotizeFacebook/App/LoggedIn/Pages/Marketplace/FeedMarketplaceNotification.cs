using System;

namespace RobotizeFacebook.App.LoggedIn.Pages.Marketplace
{
    public class FeedMarketplaceNotification : Feed
    {
        public override string FeedUrl => "marketplace/notifications";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
