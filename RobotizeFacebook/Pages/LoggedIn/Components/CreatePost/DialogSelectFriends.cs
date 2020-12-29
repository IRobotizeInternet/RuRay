using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeToolbox.Dialogs;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls.TriggerControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class DialogSelectFriends : BaseSaveCancelDialog
    {
        public DialogSelectFriends(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            BaseXPath = "//form[@method='POST']";
        }
        
        protected override By ByForDialog => By.XPath($"//form[@method='POST']//span[text()='{ResCreatePost.FriendsExcept}']");

        public Combobox ComboboxSearchFriends => new Combobox(Driver, ByForDialog);

        public EventTriggerButton<DialogCreatePost> TriggerSaveChangesButton => 
            new EventTriggerButton<DialogCreatePost>(Driver, Wait, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.SaveChanges}']"));

        public EventTriggerButton<DialogCreatePost> TriggerCancelChangesButton =>
            new EventTriggerButton<DialogCreatePost>(Driver, Wait, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.Cancel}']"));
    }

}
