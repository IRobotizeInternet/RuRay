using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PopupKeyBoard" />.
    /// </summary>
    public class PopupKeyBoard : BasePopup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PopupKeyBoard"/> class.
        /// </summary>
        public PopupKeyBoard()
        {
            BaseXPath = $"//div[@aria-label='{ResAccount.UseSingleCharacterKeyboardShortcuts}']";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResAccount.UseSingleCharacterKeyboardShortcuts}']");

        /// <summary>
        /// Gets the DialogSeeAllKeyboardShortcuts.
        /// </summary>
        public EventTriggerButton<DialogAllKeyboardShortcuts> DialogSeeAllKeyboardShortcuts =>
            new EventTriggerButton<DialogAllKeyboardShortcuts>(Driver, By.XPath($"//span[text()='{ResAccount.SeeAllKeyboardShortcuts}']"));

        /// <summary>
        /// Gets the RButtonUseSingleCharacterKeyboardShortcutsOn.
        /// </summary>
        public RadioButton RButtonUseSingleCharacterKeyboardShortcutsOn =>
            new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.On}']"));

        /// <summary>
        /// Gets the RButtonUseSingleCharacterKeyboardShortcutsOff.
        /// </summary>
        public RadioButton RButtonUseSingleCharacterKeyboardShortcutsOff =>
            new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.Off}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
