using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogSeeWhoReactedToThis : BaseDialog
    {
        public ScrollControl<ListItemSeeWhoReactedToThis> ScrollReactions =>
            new ScrollControl<ListItemSeeWhoReactedToThis>(
                Driver, 
                $"//div[@aria-label='{ResHomePage.Reactions}']/div[3]//div[@data-visualcompletion='ignore-dynamic']",
                scrollXPath: $"//div[@aria-label='{ResHomePage.Reactions}']/div[3]");


        public DialogSeeWhoReactedToThis()
        {
            BaseXPath = "//div[@aria-label='"+ResHomePage.Reactions+"']//div[@role='tab'][@tabindex='0'][{0}]//span";
        }

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePage.Reactions}']");

        public Button ButtonAllReactions =>
            new Button(Driver, By.XPath(string.Format(BaseXPath, 1)));
        public Button ButtonReactionsAtFirstIndex =>
            new Button(Driver, By.XPath(string.Format(BaseXPath, 2)));
        public Button ButtonReactionsAtSecondIndex =>
            new Button(Driver, By.XPath(string.Format(BaseXPath, 3)));
        public Button ButtonReactionsAtThirdIndex =>
            new Button(Driver, By.XPath(string.Format(BaseXPath, 4)));
        public Button ButtonReactionsAtFourthIndex =>
            new Button(Driver, By.XPath(string.Format(BaseXPath, 5)));
        public Button ButtonReactionsAtFifthIndex =>
            new Button(Driver, By.XPath(string.Format(BaseXPath, 6)));
        public Button ButtonReactionsAtSixthIndex =>
            new Button(Driver, By.XPath(string.Format(BaseXPath, 7)));
        public Button ButtonReactionsAtSeventhIndex =>
            new Button(Driver, By.XPath(string.Format(BaseXPath, 8)));

        public Button ButtonMore => new Button(Driver, ByForDialog);
        public Button ButtonMoreReactionsByIndex(int index) =>
            new Button(Driver, By.XPath($"//div[@data-pagelet='root']/div[@role='menu']//div[@role='menuitemradio'][{index}]"));
        public PageHome Close()
        {
            var xPath = $"//div[@aria-label='{ResHomePage.Reactions}']//div[@aria-label='{ResLeftNav.Close}']";
            return new EventTriggerButton<PageHome>(Driver, By.XPath(xPath)).Click();
        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}