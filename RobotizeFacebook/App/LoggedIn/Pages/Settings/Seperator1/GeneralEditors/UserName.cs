using OpenQA.Selenium;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class UserName: BaseEditor
    {
        public Label LabelUserName => new Label(Driver, By.XPath("//div[@class='fcb']//span"));
        public TextBox TextBoxUserName => new TextBox(Driver, By.XPath("@//input[@aria-describedby='u_3_1']"));
        public Label LabelUserNameIsAvailable => new Label(Driver, By.XPath("//span[@class='fbSettingsUsernameStatus']//i"));
        public Button ButtonSaveChanges => new Button(Driver, By.XPath("//input[@id='u_3_2']"));
        public Button ButtonCancel => new Button(Driver, By.XPath("//input[@id='u_3_3']"));
    }
}
