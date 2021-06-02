using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayFacebook.App.LoggedIn.Pages;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Settings.Tabs
{
    /// <summary>
    /// Defines the <see cref="SecurityLogin" />.
    /// </summary>
    public class SecurityLogin : BaseEditor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityLogin"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public SecurityLogin(RemoteWebDriver driver) : base()
        {
        }

        /// <summary>
        /// Gets the ButtonClose.
        /// </summary>
        public Button ButtonClose => new Button(Driver, By.XPath($"//div[@id='device_based_login']/../../..//button[text()={ResMiscellaneous.Close}]"));

        /// <summary>
        /// Gets the ButtonChangePasswordEdit.
        /// </summary>
        public Button ButtonChangePasswordEdit => new Button(Driver, By.XPath($"//span[text()='{ResMiscellaneous.ChangePassword}']/.."));

        /// <summary>
        /// Gets the ButtonSaveYourLoginInfoEdit.
        /// </summary>
        public Button ButtonSaveYourLoginInfoEdit => new Button(Driver, By.XPath($"//span[text()={ResMiscellaneous.SaveYourLoginInfo}]/../.."));

        /// <summary>
        /// Gets the LabelSaveYourLoginInfo.
        /// </summary>
        public Label LabelSaveYourLoginInfo => new Label(Driver, By.XPath($"//div[@id='device_based_login']//div[text()={ResMiscellaneous.SaveYourLoginInfo}]/.."));

        /// <summary>
        /// Gets the LabelRemoveAccount.
        /// </summary>
        public Label LabelRemoveAccount => new Label(Driver, By.XPath($"//div[@id='device_based_login']//div[text()={ResMiscellaneous.RemoveAccount}]/.."));
    }
}
