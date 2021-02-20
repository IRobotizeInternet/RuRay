using OpenQA.Selenium;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Extensions;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public abstract class BasePage : BaseDriver
    {
        public abstract string PageUrl { get; }
        public abstract By ByForPage { get; }

        public virtual Header Header => new Header();
        public MenuItemsHome MenuItems => new MenuItemsHome();
        public FeedControl Feed { get; set; }

        protected BasePage(string baseXPath = null)
        {
            Feed = new FeedControl(Driver, By.XPath(baseXPath), baseXPath);
        }

        public void GoToPage(string url = null)
        {
            if (url != null) Driver.Navigate().GoToUrl(url);
            else Driver.Navigate().GoToUrl($"{BaseURL}{PageUrl}");
        }

        protected virtual void WaitForPageToAppear()
        {
            Driver.WaitUntilElementAppears(ByForPage);
        }
    }
}
