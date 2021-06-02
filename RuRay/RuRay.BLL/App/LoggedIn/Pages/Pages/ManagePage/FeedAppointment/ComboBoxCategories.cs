using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="ComboBoxCategories" />.
    /// </summary>
    public class ComboBoxCategories : Combobox
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComboBoxCategories"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="byForElement">The byForElement<see cref="By"/>.</param>
        public ComboBoxCategories(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
            BaseXPath = $"//div[@role='main']";
            SearchBoxXPath = $"{BaseXPath}//span[text()='{ResLeftNav.Categories}']/parent::div/input";
            SearchItemsXPath = $"//ul[@role='presentation']";
        }
    }
}
