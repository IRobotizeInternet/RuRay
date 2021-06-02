using OpenQA.Selenium;
using RuRay.BLL.Resources;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogLifeEvents" />.
    /// </summary>
    public class DialogLifeEvents : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogLifeEvents"/> class.
        /// </summary>
        public DialogLifeEvents()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//span[text()='{ResHomePage.LifeEvent}']");

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
