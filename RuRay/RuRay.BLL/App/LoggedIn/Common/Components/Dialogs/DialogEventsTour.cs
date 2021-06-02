using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages.Pages.ManagePage
{
    /// <summary>
    /// Defines the <see cref="DialogEventsTour" />.
    /// </summary>
    public class DialogEventsTour : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogEventsTour"/> class.
        /// </summary>
        public DialogEventsTour()
        {
            BaseXPath = $"//div[@aria-label='{ResMiscellaneous.welcomeToEventsAdminTool}'][@role='dialog']";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath(BaseXPath);

        /// <summary>
        /// Gets the ButtonTakeTour.
        /// </summary>
        public Button ButtonTakeTour => new Button(Driver, By.XPath($"//div[@data-hover='tooltip'][text()='{ResMiscellaneous.TakeTour}']"));

        /// <summary>
        /// Gets the ButtonCloseDialog.
        /// </summary>
        public Button ButtonCloseDialog => new Button(Driver, By.XPath($"{BaseXPath}/div/div/div/div/div[2]//i"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
