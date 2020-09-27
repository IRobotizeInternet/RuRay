using OpenQA.Selenium;
using RobotizeFacebookLibrary.Pages;
using RobotizeLibrary.CommonControls;

namespace RobotizeFacebook.Pages.PasswordRecovery
{
    public class PasswordRecoveryPage : BasePage
    {
        public override string PageUrl => "login/identify/?ctx=recover&ars=facebook_login";

        public Label LabelPasswordRecoveryHeaderTitle => new Label(Driver, By.XPath("//div[contains(@class, 'uiHeader uiHeaderBottomBorder')]//div[@class='rfloat _ohf']//h2"));

        public Label LabelDescription => new Label(Driver, By.XPath("//div[@class='identify_yourself_block']//div"));

        public TextBox TextBoxIdentifyEmail => new TextBox(Driver, By.XPath("//input[@id='identify_email']"));

        public Label LabelButtonSubmit => new Label(Driver, By.XPath("//label[@id='did_submit']"));

        public EventTriggerHyperlink<HomePage> LinkCancel => new EventTriggerHyperlink<HomePage>(Driver, Wait, By.XPath("//div[@class='rfloat _ohf']//a[@role='button']"));
    }
}
