using OpenQA.Selenium;
using RobotizeToolbox.Extensions;

namespace RobotizeFacebook.App
{
    public abstract class BasePage : BaseDriver
    {
        public abstract string PageUrl { get; }
        public abstract By ByForPage { get; }

        protected BasePage()
        {
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
