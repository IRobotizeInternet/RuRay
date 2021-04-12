using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Robotize.BLL.Contracts;
using RobotizeFacebook.App.LoggedIn.Pages;

namespace Robotize.BLL
{
    public class ServiceHomeHeader : IServiceHomeHeader
    {
        public Task<bool> FacebookSwitchMode(Switch mode)
        {
            var pageHome = new PageHome();
            var dialog = pageHome.Header.RightMenu.EventTriggerButtonAccount.Click();
            var accessibilityDialog = dialog.TriggerDisplayAndAccessibilityDialog.Click();
            if (mode == Switch.OFF) return accessibilityDialog.RButtonCompactModeOff.Click();
            return accessibilityDialog.RButtonCompactModeOn.Click();
            
        }
    }
}
