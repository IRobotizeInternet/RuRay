using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls.TriggerControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class HeaderRightMenu : BaseDriver
    {
        // Items in the right.
        private readonly string BaseRigthXPath = "//div[@role='navigation']";
        public Hyperlink<PageUserTimeline> HyperLinkUserProfile => 
            new Hyperlink<PageUserTimeline>(Driver, By.XPath("//a[@href='/me/']/parent::div"));
        
        public Hyperlink<PopupCreate> DialogButtonToCreate =>
            new Hyperlink<PopupCreate>(Driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label, '{ResHomePageHeader.Create}'  or contains(@aria-label, '{ResCreatePost.Menu}'))]"));

        public Hyperlink<PopupMessanger> DialogButtonMessanger =>
            new Hyperlink<PopupMessanger>(Driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label, '{ResHomePageHeader.Messenger}')][1]"));

        public Hyperlink<PopupNotifications> DialogButtonNotifications =>
            new Hyperlink<PopupNotifications>(Driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label, '{ResHomePageHeader.Notifications}')][1]"));

        public Label LabelMessangerCount =>
            new Label(Driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label,'{ResHomePageHeader.Messenger}')][2]//span//span"));

        public Label LabelNotificationsCount =>
            new Label(Driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label,'{ResHomePageHeader.Notifications}')][2]//span//span"));

        public Hyperlink<PopupAccount> EventTriggerButtonAccount =>
            new Hyperlink<PopupAccount>(Driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label,'{ResHomePageHeader.Account}')][1]"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
