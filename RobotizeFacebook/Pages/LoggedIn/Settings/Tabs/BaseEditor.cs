using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages.LoggedIn.Settings.Tabs.Seperator1
{
    public class BaseEditor
    {
        internal RemoteWebDriver Driver;
        internal WebDriverWait Wait;
        protected BaseEditor()
        {

        }

        public BaseEditor(RemoteWebDriver driver, WebDriverWait wait)
        {
            Driver = driver;
            Wait = wait;
        }
    }
}
