using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PopupDisplayAndAccessibility : BasePopup
    {
        public PopupDisplayAndAccessibility()
        {
            BaseXPath = $"//div[@aria-label = '{ResAccount.Account}']";
        }

        protected override By ByForDialog => By.XPath($"{BaseXPath}//span[text()='{ResAccount.DarkMode}']");

        private readonly string RButtonsXPath = "//div[@role='radiogroup' and contains(@aria-label, '{0}')]//span[text()='{1}']";

        public RadioButton RButtonDarkModeOn => new RadioButton(Driver, By.XPath(string.Format(RButtonsXPath, ResAccount.DarkMode, ResAccount.On)));
        public RadioButton RButtonDarkModeOff => new RadioButton(Driver, By.XPath(string.Format(RButtonsXPath, ResAccount.DarkMode, ResAccount.Off)));
        public RadioButton RButtonCompactModeOn => new RadioButton(Driver, By.XPath(string.Format(RButtonsXPath, ResAccount.CompactMode, ResAccount.On)));
        public RadioButton RButtonCompactModeOff => new RadioButton(Driver, By.XPath(string.Format(RButtonsXPath, ResAccount.CompactMode, ResAccount.Off)));
        
        public EventTriggerButton<PopupKeyBoard> ButtonKeyboard =>
            new EventTriggerButton<PopupKeyBoard>(Driver, By.XPath($"{string.Format(RButtonsXPath, ResAccount.CompactMode, ResAccount.On)}/following::span[text()='{ResAccount.Keyboard}'])"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
