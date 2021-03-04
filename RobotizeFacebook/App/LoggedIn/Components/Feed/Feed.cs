using OpenQA.Selenium;
using RobotizeFacebook.App.LoggedIn.Pages;
using RobotizeToolbox.CommonControls;
using System.Threading;

namespace RobotizeFacebook.App.LoggedIn
{
    public abstract class Feed : BaseDriver
    {
        // public 
        public abstract string FeedUrl { get; }
        public virtual string BaseXPath { get; set; }
        public ScrollControl FeedScroll {
            get {
                if (FeedScroll != null) return FeedScroll;
                return FeedScroll = new ScrollControl(Driver, By.XPath(BaseXPath), BaseXPath);
            }
            set { FeedScroll = value; }
        }

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