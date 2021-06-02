using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayFacebook.App.LoggedIn.Enum;
using RuRayLibrary.Extensions;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogActivityLogFilter" />.
    /// </summary>
    public class DialogActivityLogFilter : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogActivityLogFilter"/> class.
        /// </summary>
        public DialogActivityLogFilter()
        {
            BaseXPath = $"//div[@role='dialog'][@aria-label='{ResMiscellaneous.Filter}']";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath(BaseXPath);

        /// <summary>
        /// Gets the DropdownForYear.
        /// </summary>
        public DropdownYear DropdownForYear =>
            new DropdownYear(Driver, new ExtendBy("//div[@aria-haspopup='listbox'][@role='combobox']"));

        /// <summary>
        /// The GetFilterCategoryButton.
        /// </summary>
        /// <param name="category">The category<see cref="FilterCategory"/>.</param>
        /// <returns>The <see cref="RadioButton"/>.</returns>
        public RadioButton GetFilterCategoryButton(FilterCategory category)
        {
            var rButton = new RadioButton(Driver, By.XPath($"{BaseXPath}//span[contains(text(), {category})]"));
            // TODO: Fix the below function.
            //rButton.ScrollToElement();
            return rButton;
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets the ButtonActivityLog.
        /// </summary>
        public EventTriggerButton<PageActivityLog> ButtonActivityLog =>
            new EventTriggerButton<PageActivityLog>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResMiscellaneous.ClearAll}')]"));
    }
}
