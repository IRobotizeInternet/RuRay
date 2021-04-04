using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemSeeWhoReactedToThis : BaseDiv, IListItem
    {
        public Button ButtonUserProfile =>
            new Button(Driver, By.XPath($"{BaseXPath}[{Index}]//img"));

        public Label LabelUserName =>
            new Label(Driver, By.XPath($"{BaseXPath}[{Index}]/div/div/div[2]/div[1]//span]"));

        public Button ButtonAddFriendOrFollow =>
            new Button(Driver, By.XPath($"{BaseXPath}[{Index}]//span[text()='{ResHomePage.AddFriend}' or text()='{ResCreatePost.Follow}']"));

        public int Index { get; set; }

        public ListItemSeeWhoReactedToThis(string baseXPath, int index = 1)
        {
            BaseXPath = baseXPath;
            Index = index;
        }
    }
}
