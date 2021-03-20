using OpenQA.Selenium;
using RobotizeFacebook.App.LoggedIn.Pages;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.LoggedIn
{
    public abstract class Feed : BaseDriver
    {
        public abstract string FeedUrl { get; }
        public virtual string BaseXPath { get; set; }
        public ScrollControl FeedScroll => new ScrollControl(Driver, By.XPath(BaseXPath), BaseXPath);
        public FeedUnit GetFeedUnit(int index = 1)=> new FeedUnit(index, BaseXPath);

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