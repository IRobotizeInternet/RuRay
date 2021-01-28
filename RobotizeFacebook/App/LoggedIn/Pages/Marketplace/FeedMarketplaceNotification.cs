using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
