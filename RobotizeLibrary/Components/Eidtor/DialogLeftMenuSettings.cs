using OpenQA.Selenium.Remote;
using RobotizeToolbox.Dialogs;

namespace RobotizeLibrary.Controls
{
    public abstract class DialogLeftMenuSettings : BaseDialog
    {
        protected DialogLeftMenuSettings(RemoteWebDriver driver) : base(driver)
        {
        }
    }
}
