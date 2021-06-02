using RuRayFacebook.App.LoggedIn.Pages;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="Feed" />.
    /// </summary>
    public abstract class Feed : BaseDriver
    {
        /// <summary>
        /// Gets the FeedUrl.
        /// </summary>
        public abstract string FeedUrl { get; }

        /// <summary>
        /// Gets or sets the BaseXPath.
        /// </summary>
        public virtual string BaseXPath { get; set; }

        /// <summary>
        /// Gets or sets the PositionXPath.
        /// </summary>
        public virtual string PositionXPath { get; set; }

        /// <summary>
        /// Gets or sets the StartIndex.
        /// </summary>
        public virtual int? StartIndex { get; set; }

        /// <summary>
        /// Defines the FeedScroll.
        /// </summary>
        public ScrollControl<ListItemFeedUnit> FeedScroll;

        //public ListItemFeedUnit GetFeedUnit(int? index) => new ListItemFeedUnit(BaseXPath, index ?? StartIndex ?? 1);
        /// <summary>
        /// Defines the CurrentFeedIndex.
        /// </summary>
        public int CurrentFeedIndex = 1;

        /// <summary>
        /// Initializes a new instance of the <see cref="Feed"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="positionXPath">The positionXPath<see cref="string"/>.</param>
        protected Feed(string baseXPath = null,
            string positionXPath = null)
        {
            PositionXPath = positionXPath;
            BaseXPath = baseXPath ?? BaseXPath;
            FeedScroll = new ScrollControl<ListItemFeedUnit>(Driver, BaseXPath, PositionXPath);
        }

        /// <summary>
        /// The GoToPage.
        /// </summary>
        public void GoToPage()
        {
            Driver.Navigate().GoToUrl($"{BaseURL}{FeedUrl}");
        }
    }
}
