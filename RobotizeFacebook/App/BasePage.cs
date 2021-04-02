using OpenQA.Selenium;
using RobotizeLibrary.Components.Eidtor;
using RobotizeToolbox.Extensions;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public abstract class BasePage : BaseDriver, IPage
    {
        public abstract string PageUrl { get; }
        public abstract By ByForPage { get; }

        /// <summary>
        /// This is the base element for all the popups. 
        /// We can use this to see if there are any popus is opened on the page.
        /// </summary>
        public string XPathForBasePopUp => "//div[@data-pagelet='page']/following-sibling::div/div";

        /// <summary>
        /// This is the base element for all the dialogs. 
        /// We can use this to see if there are any dialog is opened on the page.
        /// </summary>
        public string XPathForBaseDialogs => "//div[@data-pagelet='root']/div/div[4]/div//div[@data-pagelet='root']//div[@role='dialog']";
        public virtual Header Header => new Header();
        public MenuItemsHome MenuItems => new MenuItemsHome();

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
