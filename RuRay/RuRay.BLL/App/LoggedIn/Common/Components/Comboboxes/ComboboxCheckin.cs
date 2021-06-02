using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogAddVideos" />.
    /// </summary>
    public partial class DialogAddVideos
    {
        /// <summary>
        /// Defines the <see cref="ComboboxCheckin" />.
        /// </summary>
        public class ComboboxCheckin : Combobox
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="ComboboxCheckin"/> class.
            /// </summary>
            /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
            /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
            public ComboboxCheckin(RemoteWebDriver driver, string baseXPath) : base(driver, By.XPath(baseXPath))
            {
                BaseXPath = $"//form[@method='POST']/parent::div[@role='dialog']";
                SearchBoxXPath = $"{BaseXPath}//input[contains(@aria-label,'{ResCreatePost.SearchForVideos}')][@type='text']";
                SearchItemsXPath = $"{BaseXPath}//input[@aria-label='{ResCreatePost.SearchForVideos}']/parent::label/parent::div/parent::div//div[@aria-label='{ResCreatePost.SelectThisCheckbox}']']";
            }
        }
    }
}
