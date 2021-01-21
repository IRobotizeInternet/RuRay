using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls.TriggerControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class HeaderRightMenu : BaseDriver
    {
        // Items in the right.
        private readonly string BaseRigthXPath = "//div[@role='navigation']";
        public Hyperlink<PageUserHome> HyperLinkUserProfile => new Hyperlink<PageUserHome>(Driver, By.XPath("//a[@href='/me/']/parent::div"));
        
        public Hyperlink<PopupCreate> DialogButtonToCreate =>
            new Hyperlink<PopupCreate>(Driver, By.XPath($"{BaseRigthXPath}//div[@aria-label='{ResHomePageHeader.Create}']"));

        public Hyperlink<PopupMessanger> DialogButtonMessanger =>
            new Hyperlink<PopupMessanger>(Driver, By.XPath($"{BaseRigthXPath}//div[@aria-label='{ResHomePageHeader.Messenger}'][1]"));

        public Hyperlink<PopupNotifications> DialogButtonNotifications =>
            new Hyperlink<PopupNotifications>(Driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label,'{ResHomePageHeader.Notifications})'][1]"));

        public Label LabelMessangerCount =>
            new Label(Driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label,'{ResHomePageHeader.Messenger})'][2]//span//span"));

        public Label LabelNotificationsCount =>
            new Label(Driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label,'{ResHomePageHeader.Notifications})'][2]//span//span"));

        public Hyperlink<PopupAccount> DialogAccount =>
            new Hyperlink<PopupAccount>(Driver, By.XPath($"{BaseRigthXPath}//div[contains(@aria-label,'{ResHomePageHeader.Account})'][1]"));

    }
}
