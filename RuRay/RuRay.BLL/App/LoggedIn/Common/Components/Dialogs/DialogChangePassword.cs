using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogChangePassword" />.
    /// </summary>
    public class DialogChangePassword : BaseEditor
    {
        /// <summary>
        /// Gets the TextBoxCurrent.
        /// </summary>
        public TextBox TextBoxCurrent => new TextBox(Driver, By.XPath("//input[@id='password_old']"));

        /// <summary>
        /// Gets the TextBoxNew.
        /// </summary>
        public TextBox TextBoxNew => new TextBox(Driver, By.XPath("//input[@id='password_new']"));

        /// <summary>
        /// Gets the TextBoxReTypeNew.
        /// </summary>
        public TextBox TextBoxReTypeNew => new TextBox(Driver, By.XPath("//input[@id='password_confirm']"));

        //public Hyperlink<> LinkForgotYourPassword => new Hyperlink<EventResult>(Driver, Wait, By.XPath($"//a[text()='{ResMiscellaneous.ForgotYourPassword}']"));
        /// <summary>
        /// Gets the ButtonSaveChanges.
        /// </summary>
        public Button ButtonSaveChanges => new Button(Driver, By.XPath($"//div[@id='password']//input[@value={ResMiscellaneous.SaveChanges}]"));

        /// <summary>
        /// Gets the ButtonClose.
        /// </summary>
        public Button ButtonClose => new Button(Driver, By.XPath($"//button[text()={ResMiscellaneous.Close}]"));
    }
}
