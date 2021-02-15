using OpenQA.Selenium;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls.TriggerControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PasswordRecoveryPage : BasePage
    {
        public override string PageUrl => "login/identify/?ctx=recover&ars=facebook_login";

        public Label LabelPasswordRecoveryHeaderTitle => 
            new Label(Driver, By.XPath("//div[contains(@class, 'uiHeader uiHeaderBottomBorder')]//div[@class='rfloat _ohf']//h2"));

        public Label LabelDescription => new Label(Driver, By.XPath("//div[@class='identify_yourself_block']//div"));

        public TextBox TextBoxIdentifyEmail => new TextBox(Driver, By.XPath("//input[@id='identify_email']"));

        public Label LabelButtonSubmit => new Label(Driver, By.XPath("//label[@id='did_submit']"));

        public Hyperlink<PageHome> LinkCancel => 
            new Hyperlink<PageHome>(Driver, By.XPath("//div[@class='rfloat _ohf']//a[@role='button']"));

        public override By ByForPage => throw new System.NotImplementedException();

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
