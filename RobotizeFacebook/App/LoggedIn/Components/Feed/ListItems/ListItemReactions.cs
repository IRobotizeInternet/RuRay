using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemSeeWhoReactedToThis : BaseDiv, IListItem
    {
        public Button ButtonUserProfile =>
            new Button(Driver, By.XPath($"{BaseXPath}//a[contains(@href, 'user')]//*[name()='svg']"));

        public Label LabelUserName =>
            new Label(Driver, By.XPath($"{BaseXPath}//a[text()]"));

        public Button ButtonAddFriend =>
            new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResCreatePost.AddFriend}']"));

        public Button ButtonFollow =>
             new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResCreatePost.Follow}']"));

        public ListItemSeeWhoReactedToThis(string baseXPath)
        {
            BaseXPath = baseXPath;
        }
    }
}
