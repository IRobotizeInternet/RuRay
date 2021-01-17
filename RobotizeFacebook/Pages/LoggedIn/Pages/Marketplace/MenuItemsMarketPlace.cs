using OpenQA.Selenium;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class MenuItemsMarketPlace : MenuItems
    {
        public EventTriggerButton<PageMarketplace> TriggerButtonBrowerAll => 
            new EventTriggerButton<PageMarketplace>(Driver, By.XPath(""));
    }
}
