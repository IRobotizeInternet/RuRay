using OpenQA.Selenium;
using RobotizeToolbox.Extensions;

namespace RobotizeFacebook.Pages
{
    public abstract class PageBase : BaseDriver
    {
        public abstract string PageUrl { get; }
        public abstract By ByForPage { get; }

        protected PageBase()
        {
        }

        public void GoToPage()
        {
            Driver.Navigate().GoToUrl($"{BaseURL}{PageUrl}");
        }

        protected virtual void WaitForPageToAppear()
        {
            Driver.WaitUntilElementAppears(ByForPage);
        }
    }
}
