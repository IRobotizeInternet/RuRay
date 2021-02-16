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
        public FeedUnit FeedUnit;

        protected Feed()
        {
            FeedUnit = new FeedUnit(Driver, By.XPath(BaseXPath), BaseXPath);
        }

        public void GoToPage()
        {
            Driver.Navigate().GoToUrl($"{BaseURL}{FeedUrl}");
        }
    }
}