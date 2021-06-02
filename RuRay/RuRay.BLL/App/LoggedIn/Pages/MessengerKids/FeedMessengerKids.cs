using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="FeedMessengerKids" />.
    /// </summary>
    public class FeedMessengerKids : Feed
    {
        /// <summary>
        /// Gets the FeedUrl.
        /// </summary>
        public override string FeedUrl => "/messenger_kids";

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
