using OpenQA.Selenium;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PasswordRecoveryPage" />.
    /// </summary>
    public class PasswordRecoveryPage : BasePage
    {
        /// <summary>
        /// Gets the PageUrl.
        /// </summary>
        public override string PageUrl => "login/identify/?ctx=recover&ars=facebook_login";

        /// <summary>
        /// Gets the LabelPasswordRecoveryHeaderTitle.
        /// </summary>
        public Label LabelPasswordRecoveryHeaderTitle =>
            new Label(Driver, By.XPath("//div[contains(@class, 'uiHeader uiHeaderBottomBorder')]//div[@class='rfloat _ohf']//h2"));

        /// <summary>
        /// Gets the LabelDescription.
        /// </summary>
        public Label LabelDescription => new Label(Driver, By.XPath("//div[@class='identify_yourself_block']//div"));

        /// <summary>
        /// Gets the TextBoxIdentifyEmail.
        /// </summary>
        public TextBox TextBoxIdentifyEmail => new TextBox(Driver, By.XPath("//input[@id='identify_email']"));

        /// <summary>
        /// Gets the LabelButtonSubmit.
        /// </summary>
        public Label LabelButtonSubmit => new Label(Driver, By.XPath("//label[@id='did_submit']"));

        /// <summary>
        /// Gets the LinkCancel.
        /// </summary>
        public Hyperlink<PageHome> LinkCancel =>
            new Hyperlink<PageHome>(Driver, By.XPath("//div[@class='rfloat _ohf']//a[@role='button']"));

        /// <summary>
        /// Gets the ByForPage.
        /// </summary>
        public override By ByForPage => throw new System.NotImplementedException();

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
