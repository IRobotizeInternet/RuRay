using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Controls;
using RobotizeLibrary.Controls.TriggerControls;
using RobotizeLibrary.Dialogs;
using RobotizeLibrary.Resources;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PopupKeyBoard : BasePopup
    {
        public PopupKeyBoard(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            BaseXPath = $"//span[text()='{ResAccount.SeeAllKeyboardShortcuts}']/../../../../../../../../../../../..";
        }

        protected override By ByForDialog => By.XPath(BaseXPath);

        public EventTriggerButton<DialogAllKeyboardShortcuts> DialogSeeAllKeyboardShortcuts => 
            new EventTriggerButton<DialogAllKeyboardShortcuts>(Driver, Wait, By.XPath($"//span[text()='{ResAccount.SeeAllKeyboardShortcuts}']"));

        public RadioButton RButtonUseSingleCharacterKeyboardShortcutsOn =>
            new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.On}']/../../../../../..//input"));

        public RadioButton RButtonUseSingleCharacterKeyboardShortcutsOff =>
            new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.Off}']/../../../../../..//input"));
    }
}
