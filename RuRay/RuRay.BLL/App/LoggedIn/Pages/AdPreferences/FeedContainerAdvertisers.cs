namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="FeedAdvertisers" />.
    /// </summary>
    public class FeedAdvertisers : Feed
    {
        /// <summary>
        /// Gets the FeedUrl.
        /// </summary>
        public override string FeedUrl => "/adpreferences/advertisers/?entry_product=account_settings_menu";

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
