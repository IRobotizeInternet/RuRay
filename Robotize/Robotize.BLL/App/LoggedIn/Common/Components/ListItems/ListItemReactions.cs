using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemSeeWhoReactedToThis : BaseDiv, IListItem
    {
        public Button ButtonUserProfile =>
            new Button(Driver, By.XPath($"{BaseXPath}[{XIndex}]//img"));

        public Label LabelUserName =>
            new Label(Driver, By.XPath($"{BaseXPath}[{XIndex}]/div/div/div[2]/div[1]//span]"));

        public Button ButtonAddFriendOrFollow =>
            new Button(Driver, By.XPath($"{BaseXPath}[{XIndex}]//span[text()='{ResHomePage.AddFriend}' or text()='{ResCreatePost.Follow}']"));

        public int XIndex { get; set; }
        public int YIndex { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public ListItemSeeWhoReactedToThis(string baseXPath, int index = 1)
        {
            BaseXPath = baseXPath;
            XIndex = index;
        }
    }
}
