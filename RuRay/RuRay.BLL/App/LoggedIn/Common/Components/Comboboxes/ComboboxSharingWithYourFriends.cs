using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.Controls;
using RuRayToolbox.Extensions;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="ComboboxSharingWithYourFriends" />.
    /// </summary>
    public class ComboboxSharingWithYourFriends : Combobox
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComboboxSharingWithYourFriends"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="searchBoxXPath">The searchBoxXPath<see cref="string"/>.</param>
        /// <param name="searchItemsXPath">The searchItemsXPath<see cref="string"/>.</param>
        public ComboboxSharingWithYourFriends(
            RemoteWebDriver driver,
            string baseXPath,
            string searchBoxXPath = null,
            string searchItemsXPath = null) : base(driver, By.XPath(baseXPath))
        {
            BaseXPath = baseXPath;
            SearchBoxXPath = searchBoxXPath ?? $"{BaseXPath}//input[@type='search' and contains(@role, 'textbox')]";
            SearchItemsXPath = searchItemsXPath ?? $"{BaseXPath}//div[contains(@role, 'grid')]//div[@role='row']//div[@role='button']";
        }

        /// <summary>
        /// The Select.
        /// </summary>
        /// <param name="itemToSearch">The itemToSearch<see cref="string"/>.</param>
        public override void Select(string itemToSearch)
        {
            SearchItem(itemToSearch);
            WaitUntilSearchedItemsRetrieved();
            var targetItem = SelectItem(itemToSearch);
            targetItem?.Click();
        }

        /// <summary>
        /// The WaitUntilSearchedItemsRetrieved.
        /// </summary>
        private void WaitUntilSearchedItemsRetrieved()
        {
            var byForLoadingSvg = $"//*[name()='svg']//*[name()='circle'][@stroke='var(--progress-ring-disabled-foreground)']";
            Driver.WaitUntilElementDisappears(By.XPath(byForLoadingSvg));
            Thread.Sleep(TimeSpan.FromMilliseconds(500));
        }
    }
}
