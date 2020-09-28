using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeLibrary.Dialogs
{
    public class DialogBase
    {
        public RemoteWebDriver Driver;
        public WebDriverWait Wait;
        public DialogBase(RemoteWebDriver driver, WebDriverWait wait)
        {
            Driver = driver;
            Wait = wait;
        }
    }
}
