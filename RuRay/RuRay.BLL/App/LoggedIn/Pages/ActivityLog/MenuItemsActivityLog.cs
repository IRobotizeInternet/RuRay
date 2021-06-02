using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="MenuItemsActivityLog" />.
    /// </summary>
    public class MenuItemsActivityLog : MenuItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItemsActivityLog"/> class.
        /// </summary>
        public MenuItemsActivityLog()
        {
            BaseXPath = $"//div[@data-pagelet='page']/div/div[@aria-label='{ResMiscellaneous.ListOfActivityLogItems}'][@role='navigation']";
        }

        /// <summary>
        /// Gets the LinkActivityLogFilter.
        /// </summary>
        public Hyperlink<DialogActivityLogFilter> LinkActivityLogFilter =>
            new Hyperlink<DialogActivityLogFilter>(Driver, By.XPath($"{BaseXPath}//div[@role='button']/span[contains(text(),'{ResMiscellaneous.Filter}'])"));

        /// <summary>
        /// Gets the DivArchive.
        /// </summary>
        public EventTriggerDiv<DivArchive> DivArchive =>
            new EventTriggerDiv<DivArchive>(Driver, By.XPath($"{BaseXPath}//div[@role='button']//span[contains(text(),{ResMiscellaneous.Archive})]"));

        /// <summary>
        /// Gets the DivTrash.
        /// </summary>
        public EventTriggerDiv<PageTrash> DivTrash =>
           new EventTriggerDiv<PageTrash>(Driver, By.XPath($"{BaseXPath}//div[@role='button']//span[contains(text(),{ResMiscellaneous.Trash})]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
