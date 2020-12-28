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
            BaseXPath = $"//div[@aria-label = '{ResAccount.Account}']";
        }

        protected override By ByForDialog => By.XPath($"{BaseXPath}//span[text()='{ResAccount.DarkMode}']");

        private string RButtonsXPath = "//div[@role='radiogroup' and contains(@aria-label, '{0}')]//span[text()='{1}']";

        public RadioButton RButtonDarkModeOn => new RadioButton(Driver, By.XPath(string.Format(RButtonsXPath, ResAccount.DarkMode, ResAccount.On)));
        public RadioButton RButtonDarkModeOff => new RadioButton(Driver, By.XPath(string.Format(RButtonsXPath, ResAccount.DarkMode, ResAccount.Off)));
        public RadioButton RButtonCompactModeOn => new RadioButton(Driver, By.XPath(string.Format(RButtonsXPath, ResAccount.CompactMode, ResAccount.On)));
        public RadioButton RButtonCompactModeOff => new RadioButton(Driver, By.XPath(string.Format(RButtonsXPath, ResAccount.CompactMode, ResAccount.Off)));
        
        public EventTriggerButton<PopupKeyBoard> ButtonKeyboard =>
            new EventTriggerButton<PopupKeyBoard>(Driver, Wait, By.XPath($"{string.Format(RButtonsXPath, ResAccount.CompactMode, ResAccount.On)}/following::span[text()='{ResAccount.Keyboard}'])"));
    }
}
