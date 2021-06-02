using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogCustomPrivacy" />.
    /// </summary>
    public class DialogCustomPrivacy : BaseSaveCancelDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogCustomPrivacy"/> class.
        /// </summary>
        public DialogCustomPrivacy()
        {
            BaseXPath = $"//span[text()='{ResSelectPrivacy.CustomPrivacy}']/../../../../..";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//span[text()='{ResSelectPrivacy.CustomPrivacy}']/../../../../..");

        /// <summary>
        /// Gets the CheckboxFriendsOfTagged.
        /// </summary>
        public Checkbox CheckboxFriendsOfTagged => new Checkbox(Driver, By.XPath($"{BaseXPath}//input[@type='checkbox']"));

        /// <summary>
        /// Gets the ComboboxDontShareWith.
        /// </summary>
        public ComboboxSharingWithYourFriends ComboboxDontShareWith =>
            new ComboboxSharingWithYourFriends(Driver, BaseXPath);
    }
}
