using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogPeopleWhoSharedThis" />.
    /// </summary>
    public class DialogPeopleWhoSharedThis : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogPeopleWhoSharedThis"/> class.
        /// </summary>
        public DialogPeopleWhoSharedThis()
        {
        }

        /// <summary>
        /// Gets the ScrollPeopleWhoSharedThis.
        /// </summary>
        public ScrollControl<ListItemPeopleWhoSharedThis> ScrollPeopleWhoSharedThis =>
           new ScrollControl<ListItemPeopleWhoSharedThis>(
               Driver,
               $"//div[@aria-label='{ResHomePage.PeopleWhoSharedThis}']/div[3]/div/div/div[descendant-or-self::object]",
               scrollXPath: $"//div[@aria-label='{ResHomePage.PeopleWhoSharedThis}']/div[3]/div");

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePage.PeopleWhoSharedThis}']/div[3]");

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
