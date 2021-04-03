using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemSendToGroup : BaseDiv, IListItem
    {
        public Label LabelFriendName(int index) =>
            new Label(Driver, By.XPath(string.Format(BaseXPath, index)));

        public int Index { get; set; }
        
        public ListItemSendToGroup(string baseXPath, int index = 1)
        {
            Index = index;
            BaseXPath = baseXPath ?? $"//div[*/h2/span/span[text()='{ResHomePage.SendToGroup}']]//" + "ul[{0}]";
        }
    }
}
