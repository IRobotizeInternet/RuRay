using System;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="FeedYourAccountFollowing" />.
    /// </summary>
    public class FeedYourAccountFollowing : Feed
    {
        /// <summary>
        /// Gets the FeedUrl.
        /// </summary>
        public override string FeedUrl => "/marketplace/you/following";

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
