using OpenQA.Selenium;
using RuRayLibrary.Components.Eidtor;
using RuRayToolbox.Extensions;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="BasePage" />.
    /// </summary>
    public abstract class BasePage : BaseDriver, IPage
    {
        /// <summary>
        /// Gets the PageUrl.
        /// </summary>
        public abstract string PageUrl { get; }

        /// <summary>
        /// Gets the ByForPage.
        /// </summary>
        public abstract By ByForPage { get; }

        /// <summary>
        /// Gets the XPathForBasePopUp
        /// This is the base element for all the popups. 
        /// We can use this to see if there is any popus opened on the page..
        /// </summary>
        public string XPathForBasePopUp => "//div[@data-pagelet='page']/following-sibling::div/div";

        /// <summary>
        /// Gets the XPathForBaseDialogs
        /// This is the base element for all the dialogs. 
        /// We can use this to see if there is any dialog opened on the page..
        /// </summary>
        public string XPathForBaseDialogs => "//div[@data-pagelet='root']/div/div[4]/div//div[@data-pagelet='root']//div[@role='dialog']";

        /// <summary>
        /// Gets the Header.
        /// </summary>
        public virtual Header Header => new Header();

        /// <summary>
        /// Gets the MenuItems.
        /// </summary>
        public LeftMenuItemsHome MenuItems => new LeftMenuItemsHome();

        /// <summary>
        /// Initializes a new instance of the <see cref="BasePage"/> class.
        /// </summary>
        protected BasePage()
        {
        }

        /// <summary>
        /// The GoToPage.
        /// </summary>
        /// <param name="url">The url<see cref="string"/>.</param>
        public void GoToPage(string url = null)
        {
            if (url != null)
            {
                Driver.Navigate().GoToUrl(url);
            }
            else
            {
                Driver.Navigate().GoToUrl($"{BaseURL}{PageUrl}");
            }
        }

        /// <summary>
        /// The WaitForPageToAppear.
        /// </summary>
        protected virtual void WaitForPageToAppear()
        {
            Driver.WaitUntilElementAppears(ByForPage);
        }
    }
}
