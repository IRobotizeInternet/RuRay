using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PopupDisplayAndAccessibility" />.
    /// </summary>
    public class PopupDisplayAndAccessibility : BasePopup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PopupDisplayAndAccessibility"/> class.
        /// </summary>
        public PopupDisplayAndAccessibility()
        {
            BaseXPath = $"//div[@aria-label = '{ResAccount.Account}']";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"{BaseXPath}//span[text()='{ResAccount.DarkMode}']");

        /// <summary>
        /// Defines the RButtonsXPath.
        /// </summary>
        private readonly string RButtonsXPath = "//div[@role='radiogroup' and contains(@aria-label, '{0}')]//span[text()='{1}']";

        /// <summary>
        /// Gets the RButtonDarkModeOn.
        /// </summary>
        public RadioButton RButtonDarkModeOn => new RadioButton(Driver, By.XPath(string.Format(RButtonsXPath, ResAccount.DarkMode, ResAccount.On)));

        /// <summary>
        /// Gets the RButtonDarkModeOff.
        /// </summary>
        public RadioButton RButtonDarkModeOff => new RadioButton(Driver, By.XPath(string.Format(RButtonsXPath, ResAccount.DarkMode, ResAccount.Off)));

        /// <summary>
        /// Gets the RButtonCompactModeOn.
        /// </summary>
        public RadioButton RButtonCompactModeOn => new RadioButton(Driver, By.XPath(string.Format(RButtonsXPath, ResAccount.CompactMode, ResAccount.On)));

        /// <summary>
        /// Gets the RButtonCompactModeOff.
        /// </summary>
        public RadioButton RButtonCompactModeOff => new RadioButton(Driver, By.XPath(string.Format(RButtonsXPath, ResAccount.CompactMode, ResAccount.Off)));

        /// <summary>
        /// Gets the ButtonKeyboard.
        /// </summary>
        public EventTriggerButton<PopupKeyBoard> ButtonKeyboard =>
            new EventTriggerButton<PopupKeyBoard>(Driver, By.XPath($"{string.Format(RButtonsXPath, ResAccount.CompactMode, ResAccount.On)}/following::span[text()='{ResAccount.Keyboard}'])"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
