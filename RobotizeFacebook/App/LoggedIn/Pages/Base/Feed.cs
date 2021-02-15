using RobotizeFacebook.App.LoggedIn.Pages;

namespace RobotizeFacebook.App.LoggedIn
{
    public abstract class Feed : BaseDriver
    {
        // public 
        public abstract string FeedUrl { get; }
        public string BaseXPath = "//div[@role='main']";

        protected Feed()
        {
        }

        public void GoToPage()
        {
            Driver.Navigate().GoToUrl($"{BaseURL}{FeedUrl}");
        }
    }
}