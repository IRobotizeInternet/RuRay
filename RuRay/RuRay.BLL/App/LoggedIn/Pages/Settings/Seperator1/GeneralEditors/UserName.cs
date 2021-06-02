using OpenQA.Selenium;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="UserName" />.
    /// </summary>
    public class UserName : BaseEditor
    {
        /// <summary>
        /// Gets the LabelUserName.
        /// </summary>
        public Label LabelUserName => new Label(Driver, By.XPath("//div[@class='fcb']//span"));

        /// <summary>
        /// Gets the TextBoxUserName.
        /// </summary>
        public TextBox TextBoxUserName => new TextBox(Driver, By.XPath("@//input[@aria-describedby='u_3_1']"));

        /// <summary>
        /// Gets the LabelUserNameIsAvailable.
        /// </summary>
        public Label LabelUserNameIsAvailable => new Label(Driver, By.XPath("//span[@class='fbSettingsUsernameStatus']//i"));

        /// <summary>
        /// Gets the ButtonSaveChanges.
        /// </summary>
        public Button ButtonSaveChanges => new Button(Driver, By.XPath("//input[@id='u_3_2']"));

        /// <summary>
        /// Gets the ButtonCancel.
        /// </summary>
        public Button ButtonCancel => new Button(Driver, By.XPath("//input[@id='u_3_3']"));
    }
}
