using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeLibrary.Dialogs
{
    public class DialogBase
    {
        public RemoteWebDriver Driver;
        public WebDriverWait Wait;
        public DialogBase(RemoteWebDriver remoteWebDriver, WebDriverWait webDriverWait)
        {
            Driver = remoteWebDriver;
            Wait = webDriverWait;
        }
    }
}
