using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="Contact" />.
    /// </summary>
    public class Contact : BaseEditor
    {
        /// <summary>
        /// Gets the LabelPrimaryEmail.
        /// </summary>
        public Label LabelPrimaryEmail => new Label(Driver, By.XPath("(//div[@class='pbm fbSettingsEditorFields']//div/span)[2]"));

        /// <summary>
        /// Gets the CheckboxAllowFriendsToIncludeMyEmailAddressIn.
        /// </summary>
        public Checkbox CheckboxAllowFriendsToIncludeMyEmailAddressIn => new Checkbox(Driver, By.XPath("//input[@id='js_0']"));

        /// <summary>
        /// Gets the LinkAddAnotherEmailOrMobile.
        /// </summary>
        public Hyperlink<AddAnotherEmailDialog> LinkAddAnotherEmailOrMobile =>
            new Hyperlink<AddAnotherEmailDialog>(Driver, By.XPath($"//a[text()={ResMiscellaneous.AddAnotherEmailOrMobileNumber}]"));
    }
}
