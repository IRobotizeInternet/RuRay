using OpenQA.Selenium;
using RuRay.BLL.Resources;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogJoinRoom" />.
    /// </summary>
    public class DialogJoinRoom : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogJoinRoom"/> class.
        /// </summary>
        public DialogJoinRoom()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@role='dialog']//span[text()='{ResMiscellaneous.JoinRoom}']");

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
