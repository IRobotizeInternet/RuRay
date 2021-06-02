using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="ComboboxNavigation" />.
    /// </summary>
    public abstract class ComboboxNavigation : Combobox
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComboboxNavigation"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        public ComboboxNavigation(RemoteWebDriver driver, string baseXPath) : base(driver, By.XPath(baseXPath))
        {
            BaseXPath = baseXPath ?? $"//div[@data-pagelet='LeftNavSearchContainer']";
            SearchBoxXPath = $"{BaseXPath}//input[contains(@aria-label,'{ResMiscellaneous.Search}')][@role='combobox']";
            SearchItemsXPath = $"//div[@role='listbox'][@data-pagelet='root']";
        }
    }
}
