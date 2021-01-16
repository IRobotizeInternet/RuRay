namespace RobotizeFacebook.Pages.LoggedIn
{
    public abstract class FeedContainer : BaseDriver
    {
        // public 
        public abstract string FeedUrl { get; }

        protected FeedContainer()
        {
        }

        public void GoToPage()
        {
            Driver.Navigate().GoToUrl($"{BaseURL}{FeedUrl}");
        }
    }
}