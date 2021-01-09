using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeToolbox.Dialogs;

namespace RobotizeLibrary.Controls
{
    public abstract class DialogLeftMenuSettings : BaseDialog
    {
        protected DialogLeftMenuSettings(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }
    }
}
