namespace RobotizeFacebook.Pages
{
    public abstract class PageBase : BaseDriver
    {
        // public 
        public abstract string PageUrl { get; }

        protected PageBase()
        {
        }

        public void GoToPage()
        {
            Driver.Navigate().GoToUrl($"{BaseURL}{PageUrl}");
        }
    }
}
