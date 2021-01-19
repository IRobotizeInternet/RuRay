namespace RobotizeFacebook.App.LoggedIn
{
    public abstract class Feed : BaseDriver
    {
        // public 
        public abstract string FeedUrl { get; }

        protected Feed()
        {
        }

        public void GoToPage()
        {
            Driver.Navigate().GoToUrl($"{BaseURL}{FeedUrl}");
        }
    }
}