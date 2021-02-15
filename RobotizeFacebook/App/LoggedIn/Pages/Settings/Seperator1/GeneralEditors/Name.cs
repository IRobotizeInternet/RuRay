using OpenQA.Selenium;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.LoggedIn.Pages.Bas
{
    public class Name : BaseEditor
    {
        public TextBox TextBoxFirstName => new TextBox(Driver, By.XPath("//input[@id='u_i_2']"));
        public TextBox TextBoxMiddleName => new TextBox(Driver, By.XPath("//input[@id='u_i_3']"));
        public TextBox TextBoxLastName => new TextBox(Driver, By.XPath("//input[@id='u_i_4']"));
        //public Hyperlink<About> LinkAddOrChangeOtherNames => new Hyperlink<About>(Driver, Wait, By.XPath($"//a[(text()='{ResMiscellaneous.AddOrChangeOtherNames}')]"));
        public Button ButtonReviewChanges => new Button(Driver, By.XPath("//button[@id='u_2_0']"));
        public TextBox ButtonCancel => new TextBox(Driver, By.XPath("//button[@class='_42ft _42fu cancel']"));
    }
}
