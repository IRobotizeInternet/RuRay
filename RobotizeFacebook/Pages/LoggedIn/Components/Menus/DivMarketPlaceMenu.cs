using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeToolbox.Controls.TriggerControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class DivMarketPlaceMenu
    {
        private RemoteWebDriver _driver;
        private WebDriverWait _wait;
        public DivMarketPlaceMenu(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        public EventTriggerButton<PageMarketplace> TriggerButtonBrowseAllPage =>
            new EventTriggerButton<PageMarketplace>(_driver, _wait, By.XPath("//span[text()='Browse All']"));
        public EventTriggerButton<PageMarketplace> TriggerButtonNotifications =>
            new EventTriggerButton<PageMarketplace>(_driver, _wait, By.XPath("//span[text()='Notifications']"));
        public EventTriggerButton<PageMarketplace> TriggerButtonCart =>
            new EventTriggerButton<PageMarketplace>(_driver, _wait, By.XPath("//span[text()='Cart']"));
        public EventTriggerButton<PageMarketplace> TriggerButonYourAccount =>
            new EventTriggerButton<PageMarketplace>(_driver, _wait, By.XPath("//span[text()='Your Account']"));
    }
}
