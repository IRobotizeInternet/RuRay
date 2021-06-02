using System;

namespace RuRayFacebook.App.LoggedIn.Pages.Marketplace
{
    /// <summary>
    /// Defines the <see cref="FeedMarketplaceNotification" />.
    /// </summary>
    public class FeedMarketplaceNotification : Feed
    {
        /// <summary>
        /// Gets the FeedUrl.
        /// </summary>
        public override string FeedUrl => "marketplace/notifications";

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
