using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedYourAccount : Feed
    {
        public override string FeedUrl => "/marketplace/you/selling";
    }
}
