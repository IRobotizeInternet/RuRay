using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogSeeWhoReactedToThis" />.
    /// </summary>
    public class DialogSeeWhoReactedToThis : BaseDialog
    {
        /// <summary>
        /// Gets the ScrollReactions.
        /// </summary>
        public ScrollControl<ListItemSeeWhoReactedToThis> ScrollReactions =>
            new ScrollControl<ListItemSeeWhoReactedToThis>(
                Driver,
                $"//div[@aria-label='{ResHomePage.Reactions}']/div[3]//div[@data-visualcompletion='ignore-dynamic']",
                scrollXPath: $"//div[@aria-label='{ResHomePage.Reactions}']/div[3]");

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogSeeWhoReactedToThis"/> class.
        /// </summary>
        public DialogSeeWhoReactedToThis()
        {
            BaseXPath = "//div[@aria-label='" + ResHomePage.Reactions + "']//div[@role='tab'][@tabindex='0'][{0}]//span";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePage.Reactions}']");

        /// <summary>
        /// Gets the ButtonAllReactions.
        /// </summary>
        public Button ButtonAllReactions =>
            new Button(Driver, By.XPath(string.Format(BaseXPath, 1)));

        /// <summary>
        /// Gets the ButtonReactionsAtFirstIndex.
        /// </summary>
        public Button ButtonReactionsAtFirstIndex =>
            new Button(Driver, By.XPath(string.Format(BaseXPath, 2)));

        /// <summary>
        /// Gets the ButtonReactionsAtSecondIndex.
        /// </summary>
        public Button ButtonReactionsAtSecondIndex =>
            new Button(Driver, By.XPath(string.Format(BaseXPath, 3)));

        /// <summary>
        /// Gets the ButtonReactionsAtThirdIndex.
        /// </summary>
        public Button ButtonReactionsAtThirdIndex =>
            new Button(Driver, By.XPath(string.Format(BaseXPath, 4)));

        /// <summary>
        /// Gets the ButtonReactionsAtFourthIndex.
        /// </summary>
        public Button ButtonReactionsAtFourthIndex =>
            new Button(Driver, By.XPath(string.Format(BaseXPath, 5)));

        /// <summary>
        /// Gets the ButtonReactionsAtFifthIndex.
        /// </summary>
        public Button ButtonReactionsAtFifthIndex =>
            new Button(Driver, By.XPath(string.Format(BaseXPath, 6)));

        /// <summary>
        /// Gets the ButtonReactionsAtSixthIndex.
        /// </summary>
        public Button ButtonReactionsAtSixthIndex =>
            new Button(Driver, By.XPath(string.Format(BaseXPath, 7)));

        /// <summary>
        /// Gets the ButtonReactionsAtSeventhIndex.
        /// </summary>
        public Button ButtonReactionsAtSeventhIndex =>
            new Button(Driver, By.XPath(string.Format(BaseXPath, 8)));

        /// <summary>
        /// Gets the ButtonMore.
        /// </summary>
        public Button ButtonMore => new Button(Driver, ByForDialog);

        /// <summary>
        /// The ButtonMoreReactionsByIndex.
        /// </summary>
        /// <param name="index">The index<see cref="int"/>.</param>
        /// <returns>The <see cref="Button"/>.</returns>
        public Button ButtonMoreReactionsByIndex(int index) =>
            new Button(Driver, By.XPath($"//div[@data-pagelet='root']/div[@role='menu']//div[@role='menuitemradio'][{index}]"));

        /// <summary>
        /// The Close.
        /// </summary>
        /// <returns>The <see cref="PageHome"/>.</returns>
        public PageHome Close()
        {
            var xPath = $"//div[@aria-label='{ResHomePage.Reactions}']//div[@aria-label='{ResLeftNav.Close}']";
            return new EventTriggerButton<PageHome>(Driver, By.XPath(xPath)).Click();
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
