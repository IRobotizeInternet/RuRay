using OpenQA.Selenium;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class ListItemContactGroupConversation : BaseDiv, IListItem
    {
        public int XIndex { get; set; }
        public int YIndex { get; set; }

        public Label LabelGroupName => new Label(Driver, By.XPath($"{BaseXPath}/li[{XIndex}]//span[text()]"));

        public ListItemContactGroupConversation(string baseXPath, int xIndex = 1, int yIndex = 1)
        {
            BaseXPath = baseXPath ?? "//div[@data-pagelet='RightRail']/div[3]//ul/li";
            XIndex = xIndex;
            YIndex = yIndex;
        }
    }
}
