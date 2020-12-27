using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Controls;
using RobotizeLibrary.Controls.TriggerControls;
using RobotizeLibrary.Dialogs;
using RobotizeLibrary.Resources;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PopupDisplayAndAccessibility : BasePopup
    {
        public PopupDisplayAndAccessibility(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            BaseXPath = $"//span[text()='{ResAccount.DarkMode}']/../../../../../../../.."; ;
        }

        protected override By ByForDialog => By.XPath(BaseXPath);

        public RadioButton RButtonDarkModeOn => 
            new RadioButton(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResAccount.DarkMode}']//span[text()='{ResAccount.On}']/../../../../.././..//input"));
        public RadioButton RButtonDarkModeOff =>
            new RadioButton(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResAccount.DarkMode}']//span[text()='{ResAccount.Off}']/../../../../.././..//input"));
        public RadioButton RButtonCompactModeOn =>
            new RadioButton(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResAccount.CompactMode}']//span[text()='{ResAccount.On}']/../../../../.././..//input"));
        public RadioButton RButtonCompactModeOff =>
            new RadioButton(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResAccount.CompactMode}']//span[text()='{ResAccount.Off}']/../../../../.././..//input"));

        public EventTriggerButton<PopupKeyBoard> ButtonKeyboard =>
            new EventTriggerButton<PopupKeyBoard>(Driver, Wait, By.XPath($"{BaseXPath}//span[text()='{ResAccount.Keyboard}']"));
    }
}
