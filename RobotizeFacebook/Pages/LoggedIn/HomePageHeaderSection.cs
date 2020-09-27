using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Pages.LoggedUser;
using RobotizeLibrary.CommonControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class HomePageHeaderSection
    {
        private RemoteWebDriver _remoteWebDriver;
        private WebDriverWait _webDriverWait;

        public HomePageHeaderSection(RemoteWebDriver remoteWebDriver, WebDriverWait webDriverWait)
        {
            _remoteWebDriver = remoteWebDriver;
            _webDriverWait = webDriverWait;
        }

        public EventTriggerHyperlink<HomePage> LinkFacebookTitleIcon => new EventTriggerHyperlink<HomePage>(_remoteWebDriver, _webDriverWait, By.XPath("//div[@class='bp9cbjyn rq0escxv j83agx80 buofh1pr byvelhso dhix69tm poy2od1o j9ispegn kr520xx4 ehxjyohh']//a"));

        public TextBox TextBoxSearchFacebook => new TextBox(_remoteWebDriver, By.XPath("//label[@class='rq0escxv a8c37x1j a5nuqjux l9j0dhe7 k4urcfbm']//input"));

        public EventTriggerHyperlink<HomePage> LinkHome => new EventTriggerHyperlink<HomePage>(_remoteWebDriver, _webDriverWait, By.XPath("//a[@aria-label='Home']"));
        public EventTriggerHyperlink<HomePage> LinkFriends => new EventTriggerHyperlink<HomePage>(_remoteWebDriver, _webDriverWait, By.XPath("//a[@aria-label='Friends']"));
        public EventTriggerHyperlink<HomePage> LinkWatch => new EventTriggerHyperlink<HomePage>(_remoteWebDriver, _webDriverWait, By.XPath("//a[@aria-label='Watch']"));
        public EventTriggerHyperlink<HomePage> LinkMarketPlace => new EventTriggerHyperlink<HomePage>(_remoteWebDriver, _webDriverWait, By.XPath("//a[@aria-label='Marketplace']"));
        public EventTriggerHyperlink<HomePage> LinkGroups => new EventTriggerHyperlink<HomePage>(_remoteWebDriver, _webDriverWait, By.XPath("//a[@aria-label='Groups']"));
    }
}
