using OpenQA.Selenium;
using RuRay.BLL.Resources;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogMenu" />.
    /// </summary>
    public class DialogMenu : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogMenu"/> class.
        /// </summary>
        public DialogMenu()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//span[text()='{ResMiscellaneous.Delete}']");

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
