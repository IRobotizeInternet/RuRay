using OpenQA.Selenium;
using RobotizeFacebook.App.LoggedIn.Pages;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.LoggedIn
{
    public abstract class Feed : BaseDriver
    {
        public abstract string FeedUrl { get; }
        public virtual string BaseXPath { get; set; }
        public ScrollControl<ListItenFeedUnit> FeedScroll => new ScrollControl<ListItenFeedUnit>(Driver, BaseXPath);
        public ListItenFeedUnit GetFeedUnit(int index = 1) => new ListItenFeedUnit(BaseXPath, index);

        protected Feed()
        {
            BaseXPath = "//div[@role='feed']";
        }

        public void GoToPage()
        {
            Driver.Navigate().GoToUrl($"{BaseURL}{FeedUrl}");
        }
    }
}