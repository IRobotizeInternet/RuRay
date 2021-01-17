using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Pages.LoggedIn.Dialogs;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PopupKeyBoard : BasePopup
    {
        public PopupKeyBoard(RemoteWebDriver driver) : base(driver)
        {
            BaseXPath = $"//div[@aria-label='{ResAccount.UseSingleCharacterKeyboardShortcuts}']";
        }

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResAccount.UseSingleCharacterKeyboardShortcuts}']");

        public EventTriggerButton<DialogAllKeyboardShortcuts> DialogSeeAllKeyboardShortcuts => 
            new EventTriggerButton<DialogAllKeyboardShortcuts>(Driver, By.XPath($"//span[text()='{ResAccount.SeeAllKeyboardShortcuts}']"));

        public RadioButton RButtonUseSingleCharacterKeyboardShortcutsOn =>
            new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.On}']"));

        public RadioButton RButtonUseSingleCharacterKeyboardShortcutsOff =>
            new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.Off}']"));
    }
}
