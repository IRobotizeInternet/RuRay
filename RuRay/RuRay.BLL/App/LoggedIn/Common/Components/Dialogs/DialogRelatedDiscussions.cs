using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogRelatedDiscussions" />.
    /// </summary>
    public class DialogRelatedDiscussions : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogRelatedDiscussions"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        public DialogRelatedDiscussions(string baseXPath)
        {
        }

        /// <summary>
        /// Gets the ScrollPeopleWhoSharedThis.
        /// </summary>
        public ScrollControl<ListItemPeopleWhoSharedThis> ScrollPeopleWhoSharedThis =>
           new ScrollControl<ListItemPeopleWhoSharedThis>(
               Driver,
               $"//div[@aria-label='{ResHomePage.PeopleWhoSharedThis}']/div[3]/div/div/div",
               scrollXPath: $"//div[@aria-label='{ResHomePage.PeopleWhoSharedThis}']/div[3]");

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => throw new System.NotImplementedException();

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
