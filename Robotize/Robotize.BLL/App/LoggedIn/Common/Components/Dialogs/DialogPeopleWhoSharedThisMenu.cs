using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogPeopleWhoSharedThisMenu : BaseDialog
    {
        public DialogPeopleWhoSharedThisMenu()
        {
        }

        public Button ButtonHideAllFrom =>
            new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.HideAllFrom}']"));

        public Button ButtonUnFollow =>
            new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.Unfollow}']"));

        public Button ButtonSavePost =>
            new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.SavePost}'] or contains(text(),'{ResCreatePost.SaveLink}']"));

        public Button ButtonTurnOnNotificationsForThisPost =>
            new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.TurnOnNotificationsForThisPost}']"));

        public Button ButtonEmbed =>
            new Button(Driver, By.XPath($"//div[@role='menuitem']//span[contains(text(),'{ResCreatePost.Embed}']"));

        protected override By ByForDialog => By.XPath($"//div[@role='menuitem']//span[text()='{ResCreatePost.TurnOnNotificationsForThisPost}']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
