using OpenQA.Selenium.Remote;
using RuRayToolbox.Dialogs;

namespace RuRayLibrary.Controls
{
    public abstract class DialogLeftMenuSettings : BaseDialog
    {
        protected DialogLeftMenuSettings(RemoteWebDriver driver) : base(driver)
        {
        }
    }
}
