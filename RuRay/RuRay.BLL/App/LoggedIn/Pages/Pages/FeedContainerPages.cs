using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="FeedContainerPages" />.
    /// </summary>
    public class FeedContainerPages : Feed
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeedContainerPages"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="positionXPath">The positionXPath<see cref="string"/>.</param>
        public FeedContainerPages(string baseXPath = null, string positionXPath = null) : base(baseXPath, positionXPath)
        {
        }

        /// <summary>
        /// Gets the FeedUrl.
        /// </summary>
        public override string FeedUrl => throw new NotImplementedException();

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
