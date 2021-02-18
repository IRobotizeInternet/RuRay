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
        public string BaseXPath = "//div[@role='Feed']";
        public string FeedUnitIndexPath = $"//div[@role='feed']//div[@aria-posinset={0}]";
        public FeedUnit FeedUnit;

        protected Feed(int feedUnitIndex)
        {
            FeedUnit = new FeedUnit(Driver, By.XPath(BaseXPath), BaseXPath);
            FeedUnitIndexPath = string.Format(FeedUnitIndexPath, feedUnitIndex);
        }

        public Button ButtonLike(string feedUnitIndex) => new Button(Driver, By.XPath($"{FeedUnitIndexPath}//"));

        public void GoToPage()
        {
            Driver.Navigate().GoToUrl($"{BaseURL}{FeedUrl}");
        }
    }
}