using OpenQA.Selenium;
using RuRay.BLL.Resources;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogLearnCreateRoom" />.
    /// </summary>
    public class DialogLearnCreateRoom : BaseDialog
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResMiscellaneous.LearnHowRoomsWork}']");

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogLearnCreateRoom"/> class.
        /// </summary>
        public DialogLearnCreateRoom()
        {
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
