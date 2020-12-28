using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Pages.LoggedIn.Dialogs;
using RobotizeFacebook.Resources;
using RobotizeLibrary.Controls;
using RobotizeLibrary.Controls.TriggerControls;
using RobotizeLibrary.Dialogs;
using RobotizeFacebook.Resources;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PopupKeyBoard : BasePopup
    {
        public PopupKeyBoard(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            BaseXPath = $"//div[@aria-label='{ResAccount.UseSingleCharacterKeyboardShortcuts}']";
        }

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResAccount.UseSingleCharacterKeyboardShortcuts}']");

        public EventTriggerButton<DialogAllKeyboardShortcuts> DialogSeeAllKeyboardShortcuts => 
            new EventTriggerButton<DialogAllKeyboardShortcuts>(Driver, Wait, By.XPath($"//span[text()='{ResAccount.SeeAllKeyboardShortcuts}']"));

        public RadioButton RButtonUseSingleCharacterKeyboardShortcutsOn =>
            new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.On}']"));

        public RadioButton RButtonUseSingleCharacterKeyboardShortcutsOff =>
            new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.Off}']"));
    }
}
