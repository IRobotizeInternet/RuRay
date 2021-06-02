using OpenQA.Selenium;
using RuRay.BLL.Resources;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogNewsFeedPreferences" />.
    /// </summary>
    public class DialogNewsFeedPreferences : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogNewsFeedPreferences"/> class.
        /// </summary>
        public DialogNewsFeedPreferences()
        {
        }

        /// <summary>
        /// Defines the _baseXPath.
        /// </summary>
        private readonly string _baseXPath = $"//div[@aria-label='{ResMiscellaneous.NewsFeedPreferences}' and @role='dialog']";

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath(_baseXPath);

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
