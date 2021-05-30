using OpenQA.Selenium;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class ListItemContact : BaseDiv, IListItem
    {
        public int XIndex { get; set; }
        public int YIndex { get; set; }

        public Label LabelUserName => new Label(Driver, By.XPath($"{BaseXPath}/li[{XIndex}]//span[text()]"));

        public Button ButtonHoverOver => new Button(Driver, By.XPath($"{BaseXPath}/li[{XIndex}]//*[name()='svg']"));

        public ListItemContact(string baseXPath, int xIndex = 1, int yIndex = 1)
        {
            BaseXPath = baseXPath ?? "//div[@data-pagelet='RightRail']/div[2]//ul/div/li";
            XIndex = xIndex;
            YIndex = yIndex;
        }
    }
}
