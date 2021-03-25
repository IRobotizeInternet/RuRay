using OpenQA.Selenium;
using RobotizeFacebook.App.LoggedIn.Pages;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.LoggedIn
{
    public abstract class FeedComponent : BaseDriver
    {
        public abstract string FeedUrl { get; }
        public virtual string BaseXPath { get; set; }
        public virtual string PositionXPath { get; set; }
        public virtual int? StartIndex { get; set; }
        public ScrollControl<ListItemFeedUnit> FeedScroll => 
            new ScrollControl<ListItemFeedUnit>(Driver, BaseXPath, PositionXPath);
        public ListItemFeedUnit GetFeedUnit(int? index) => new ListItemFeedUnit(BaseXPath, index ?? StartIndex ?? 1);

        protected FeedComponent(string baseXPath = null,
            string positionXPath = null)
        {
            PositionXPath = positionXPath;
            BaseXPath = baseXPath;
        }

        public void GoToPage()
        {
            Driver.Navigate().GoToUrl($"{BaseURL}{FeedUrl}");
        }
    }
}