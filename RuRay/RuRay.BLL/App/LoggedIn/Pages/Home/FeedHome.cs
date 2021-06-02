using RuRayLibrary.Components.Eidtor;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="FeedHome" />.
    /// </summary>
    public class FeedHome : Feed, IFeedContainer
    {
        /// <summary>
        /// Gets the SectionCreatePost.
        /// </summary>
        public CreatePost SectionCreatePost => new CreatePost();

        /// <summary>
        /// Gets the FeedUrl.
        /// </summary>
        public override string FeedUrl => "/";

        /// <summary>
        /// Defines the FeedIndex.
        /// </summary>
        public int FeedIndex = 1;

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedHome"/> class.
        /// </summary>
        public FeedHome() :
            base(baseXPath: "//div[contains(@data-pagelet,'Feed')]", positionXPath: "//div[@aria-posinset='{0}']")
        {
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
