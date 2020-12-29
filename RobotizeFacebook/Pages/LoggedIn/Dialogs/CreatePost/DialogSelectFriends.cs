using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeToolbox.Dialogs;
using RobotizeFacebook.Resources;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class DialogSelectFriends : BaseSaveCancelDialog
    {
        public DialogSelectFriends(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        private readonly string Basepath = $"//span[text()='{ResSelectPrivacy.FriendsExcept}']/../../../../..";
        protected override By ByForDialog => By.XPath(Basepath);
    }
}
