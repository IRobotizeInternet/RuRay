using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogNickNames" />.
    /// </summary>
    public class DialogNickNames : BaseDialog
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePage.Nicknames}'][@role='dialog']");

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogNickNames"/> class.
        /// </summary>
        public DialogNickNames()
        {
            BaseXPath = $"//div[@aria-label='{ResHomePage.Nicknames}'][@role='dialog']";
        }

        /// <summary>
        /// Gets the ScrollControlNicknames.
        /// </summary>
        public ScrollControl<ListItemNickname> ScrollControlNicknames =>
            new ScrollControl<ListItemNickname>(Driver,
                $"//div[@aria-label='{ResHomePage.Nicknames}'][@role='dialog']/div[3]/div/div/div/div/div[./div]",
                "//div[@aria-label='{ResHomePage.Nicknames}'][@role='dialog']/div[3]/div/div/div/div");

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
