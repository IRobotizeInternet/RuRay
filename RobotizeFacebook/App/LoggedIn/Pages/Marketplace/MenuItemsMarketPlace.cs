using OpenQA.Selenium;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn
{
    public class MenuItemsMarketPlace : MenuItems
    {
        public EventTriggerButton<PageMarketplace> TriggerButtonBrowerAll => 
            new EventTriggerButton<PageMarketplace>(Driver, By.XPath(""));
    }
}
