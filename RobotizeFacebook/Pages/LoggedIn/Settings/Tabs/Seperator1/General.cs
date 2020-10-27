using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Pages.LoggedIn.Settings.Tabs.Seperator1;
using RobotizeFacebook.Pages.LoggedIn.Settings.Tabs.Seperator1.Bas;
using RobotizeLibrary.Controls.TriggerControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Pages.LoggedIn.Settings.Tabs
{
    public class General : BaseSettings
    {

        public General(RemoteWebDriver driver, WebDriverWait wait)
        {

        }

        public Hyperlink<Name> LinkName => new Hyperlink<Name>(Driver, Wait, By.XPath("//li[@data-testid='settings_section_name']"));
        public Hyperlink<UserName> LinkUserName => new Hyperlink<UserName>(Driver, Wait, By.XPath("//li[@data-testid='settings_section_username']"));
        public Hyperlink<Contact> LinkContactEmail => new Hyperlink<Contact>(Driver, Wait, By.XPath("//li[@data-testid='settings_section_email']"));
        public Hyperlink<AdAccount> LinkAdAccountContact => new Hyperlink<AdAccount>(Driver, Wait, By.XPath("//li[@data-testid='settings_section_advertising_email']"));
        public Hyperlink<Memorialization> LinkMemorializationSettings => new Hyperlink<Memorialization>(Driver, Wait, By.XPath("//li[@data-testid='settings_section_account_management']"));
   }
}
