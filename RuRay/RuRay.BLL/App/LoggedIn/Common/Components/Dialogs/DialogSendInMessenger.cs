using System;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogSendInMessenger" />.
    /// </summary>
    public class DialogSendInMessenger : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogSendInMessenger"/> class.
        /// </summary>
        public DialogSendInMessenger()
        {
            BaseXPath = $"//div[@aria-label='{ResHomePage.SendInMessenger}']";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePage.SendInMessenger}']");

        /// <summary>
        /// Gets the TextBoxSaySomething.
        /// </summary>
        public TextBox TextBoxSaySomething =>
            new TextBox(Driver, By.XPath($"//div[@aria-label='{ResHomePage.SaySomethingAboutThis}']"));

        /// <summary>
        /// Gets the EventTriggerButtonSendToGroup.
        /// </summary>
        public EventTriggerButton<DialogSendToGroup<DialogSendInMessenger>> EventTriggerButtonSendToGroup =>
            new EventTriggerButton<DialogSendToGroup<DialogSendInMessenger>>(
                Driver,
                By.XPath($"{BaseXPath}//span[text()='{ResHomePage.SendToNewGroup}']"));

        /// <summary>
        /// Gets the ComboboxSearchFriends.
        /// </summary>
        public ComboboxSharingWithYourFriends ComboboxSearchFriends =>
            new ComboboxSharingWithYourFriends(
                Driver,
                BaseXPath,
                searchItemsXPath: $"{BaseXPath}//div[@aria-label='{ResHomePage.Send}' or @aria-label='{ResHomePage.Sent}']");

        /// <summary>
        /// Gets the ScrollSendInMessenger.
        /// </summary>
        public ScrollControl<ListItemSendInMessenger> ScrollSendInMessenger =>
           new ScrollControl<ListItemSendInMessenger>(
               Driver,
               $"//form//div[@aria-label='{ResCreatePost.Friends}']/div",
               scrollXPath: $"{BaseXPath}//div[@data-visualcompletion='ignore-dynamic' and ./descendant-or-self::div//span[text()='{ResHomePage.Send}']]");

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
