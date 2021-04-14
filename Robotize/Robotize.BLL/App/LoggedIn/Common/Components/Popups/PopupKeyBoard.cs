using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PopupKeyBoard : BasePopup
    {
        public PopupKeyBoard()
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

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
