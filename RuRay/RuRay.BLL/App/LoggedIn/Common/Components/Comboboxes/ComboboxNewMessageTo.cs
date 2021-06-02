using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Common.Components.Comboboxes
{
    /// <summary>
    /// Defines the <see cref="ComboboxNewMessageTo" />.
    /// </summary>
    public class ComboboxNewMessageTo : Combobox
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComboboxNewMessageTo"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        public ComboboxNewMessageTo(
           RemoteWebDriver driver,
           string baseXPath) : base(driver, By.XPath(baseXPath))
        {
            BaseXPath = baseXPath ?? "//div[@data-pagelet='ChatTab']";
            SearchBoxXPath = $"{BaseXPath}//input[@type='search']";
            SearchItemsXPath = $"{BaseXPath}//ul[@role='listbox']//li[@role='option']";
        }
    }
}
