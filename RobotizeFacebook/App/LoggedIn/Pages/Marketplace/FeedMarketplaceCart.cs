using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
