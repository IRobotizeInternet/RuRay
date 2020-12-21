using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Pages.LoggedIn.Settings.Tabs.Seperator1;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Controls.TriggerControls;
using RobotizeLibrary.Dialogs;
using RobotizeLibrary.Resources;

namespace RobotizeFacebook.Pages.LoggedIn.Settings.Tabs
{
    public class SecurityLogin : BaseEditor
    {
        public SecurityLogin(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public Button ButtonClose => new Button(Driver, By.XPath($"//div[@id='device_based_login']/../../..//button[text()={ResMiscellaneous.Close}]"));
        public Button ButtonChangePasswordEdit => new Button(Driver, By.XPath($"//span[text()='{ResMiscellaneous.ChangePassword}']/.."));
        public Button ButtonSaveYourLoginInfoEdit => new Button(Driver, By.XPath($"//span[text()={ResMiscellaneous.SaveYourLoginInfo}]/../.."));
        public Label LabelSaveYourLoginInfo => new Label(Driver, By.XPath($"//div[@id='device_based_login']//div[text()={ResMiscellaneous.SaveYourLoginInfo}]/.."));
        public Label LabelRemoveAccount => new Label(Driver, By.XPath($"//div[@id='device_based_login']//div[text()={ResMiscellaneous.RemoveAccount}]/.."));
    }
}
