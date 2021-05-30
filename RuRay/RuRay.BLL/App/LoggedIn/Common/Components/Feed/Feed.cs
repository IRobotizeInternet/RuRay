using RuRayFacebook.App.LoggedIn.Pages;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn
{
    public abstract class Feed : BaseDriver
    {
        public abstract string FeedUrl { get; }
        public virtual string BaseXPath { get; set; }
        public virtual string PositionXPath { get; set; }
        public virtual int? StartIndex { get; set; }
        public ScrollControl<ListItemFeedUnit> FeedScroll;
        //public ListItemFeedUnit GetFeedUnit(int? index) => new ListItemFeedUnit(BaseXPath, index ?? StartIndex ?? 1);
        public int CurrentFeedIndex = 1;
        protected Feed(string baseXPath = null,
            string positionXPath = null)
        {
            PositionXPath = positionXPath;
            BaseXPath = baseXPath ?? BaseXPath;
            FeedScroll = new ScrollControl<ListItemFeedUnit>(Driver, BaseXPath, PositionXPath);
        }

        public void GoToPage()
        {
            Driver.Navigate().GoToUrl($"{BaseURL}{FeedUrl}");
        }
    }
}