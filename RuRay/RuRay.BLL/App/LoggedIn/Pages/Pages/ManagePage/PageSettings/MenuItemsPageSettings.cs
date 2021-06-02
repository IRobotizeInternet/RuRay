using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="MenuItemsPageSettings" />.
    /// </summary>
    public class MenuItemsPageSettings : MenuItems
    {
        /// <summary>
        /// Gets the TextboxPagePageName.
        /// </summary>
        public TextBox TextboxPagePageName =>
            new TextBox(Driver, By.XPath($"//label[contains(@aria-label,{ResLeftNav.PageName}')]"));

        /// <summary>
        /// Gets the TextboxPageCategory.
        /// </summary>
        public TextBox TextboxPageCategory =>
            new TextBox(Driver, By.XPath($"//label[contains(@aria-label, {ResLeftNav.Category}')]"));

        /// <summary>
        /// Gets the TextboxDescription.
        /// </summary>
        public TextBox TextboxDescription =>
            new TextBox(Driver, By.XPath($"//label[contains(@aria-label, {ResLeftNav.Description}')]"));

        /// <summary>
        /// Gets the EventTriggerButtonCreatePage.
        /// </summary>
        public EventTriggerButton<AfterSaveControls> EventTriggerButtonCreatePage =>
            new EventTriggerButton<AfterSaveControls>(Driver, By.XPath($"//span[contains(text(), '{ResLeftNav.CreatePage}')]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
