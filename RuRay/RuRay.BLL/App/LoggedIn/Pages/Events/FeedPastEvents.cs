using System;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="FeedPastEvents" />.
    /// </summary>
    public class FeedPastEvents : Feed
    {
        /// <summary>
        /// Gets the FeedUrl.
        /// </summary>
        public override string FeedUrl => "/events/past/";

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
