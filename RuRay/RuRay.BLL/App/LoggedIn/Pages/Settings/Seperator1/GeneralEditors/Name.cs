using OpenQA.Selenium;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages.Bas
{
    /// <summary>
    /// Defines the <see cref="Name" />.
    /// </summary>
    public class Name : BaseEditor
    {
        /// <summary>
        /// Gets the TextBoxFirstName.
        /// </summary>
        public TextBox TextBoxFirstName => new TextBox(Driver, By.XPath("//input[@id='u_i_2']"));

        /// <summary>
        /// Gets the TextBoxMiddleName.
        /// </summary>
        public TextBox TextBoxMiddleName => new TextBox(Driver, By.XPath("//input[@id='u_i_3']"));

        /// <summary>
        /// Gets the TextBoxLastName.
        /// </summary>
        public TextBox TextBoxLastName => new TextBox(Driver, By.XPath("//input[@id='u_i_4']"));

        //public Hyperlink<About> LinkAddOrChangeOtherNames => new Hyperlink<About>(Driver, Wait, By.XPath($"//a[(text()='{ResMiscellaneous.AddOrChangeOtherNames}')]"));
        /// <summary>
        /// Gets the ButtonReviewChanges.
        /// </summary>
        public Button ButtonReviewChanges => new Button(Driver, By.XPath("//button[@id='u_2_0']"));

        /// <summary>
        /// Gets the ButtonCancel.
        /// </summary>
        public TextBox ButtonCancel => new TextBox(Driver, By.XPath("//button[@class='_42ft _42fu cancel']"));
    }
}
