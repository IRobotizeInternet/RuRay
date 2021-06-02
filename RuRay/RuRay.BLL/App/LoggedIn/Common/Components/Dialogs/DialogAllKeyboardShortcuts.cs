using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogAllKeyboardShortcuts" />.
    /// </summary>
    public class DialogAllKeyboardShortcuts : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogAllKeyboardShortcuts"/> class.
        /// </summary>
        public DialogAllKeyboardShortcuts()
        {
        }

        /// <summary>
        /// Defines the _baseXPath.
        /// </summary>
        private readonly string _baseXPath = $"//span[text()='{ResAccount.AllKeyboardShortcuts}']/../../../../..";

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath(_baseXPath);

        /// <summary>
        /// Gets the SingleCharacterKeyboardShortCut.
        /// </summary>
        public Checkbox SingleCharacterKeyboardShortCut => new Checkbox(Driver, By.XPath($"{_baseXPath}//input[@type='checkbox']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
