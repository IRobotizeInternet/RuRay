using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemSendToGroup : BaseDiv, IListItem
    {
        public Label LabelFriendName(int index) =>
            new Label(Driver, By.XPath(string.Format(BaseXPath, index)));

        public int XIndex { get; set; }
        public int YIndex { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public ListItemSendToGroup(string baseXPath, int index = 1)
        {
            XIndex = index;
            BaseXPath = baseXPath ?? $"//div[*/h2/span/span[text()='{ResHomePage.SendToGroup}']]//" + "ul[{0}]";
        }
    }
}
