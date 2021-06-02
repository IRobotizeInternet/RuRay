using System;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogCreateGroup" />.
    /// </summary>
    public class DialogCreateGroup : BaseDialog
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePage.CreateGroup1}'][@role='dialog']");

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogCreateGroup"/> class.
        /// </summary>
        public DialogCreateGroup()
        {
            BaseXPath = $"//div[@aria-label='{ResHomePage.CreateGroup1}'][@role='dialog']";
        }

        /// <summary>
        /// Gets the ComboboxAddMembers.
        /// </summary>
        public ComboboxAddMembers ComboboxAddMembers =>
            new ComboboxAddMembers(Driver, $"//div[@aria-label='{ResCreatePost.CreateGroup}']");

        /// <summary>
        /// Gets the ScrollControlUsers.
        /// </summary>
        public ScrollControl<ListItemButton> ScrollControlUsers =>
            new ScrollControl<ListItemButton>(Driver, $"//div[@aria-label='{ResCreatePost.CreateGroup}']//ul[contains(@role, 'listbox')]/li");

        /// <summary>
        /// Gets the EventTriggerButtonCreateGroup.
        /// </summary>
        public EventTriggerButton<PopupNewMessage> EventTriggerButtonCreateGroup =>
            new EventTriggerButton<PopupNewMessage>(Driver, By.XPath($"//div[@aria-label='{ResCreatePost.CreateGroup}']//div[@aria-label='{ResHomePageHeader.Create}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
