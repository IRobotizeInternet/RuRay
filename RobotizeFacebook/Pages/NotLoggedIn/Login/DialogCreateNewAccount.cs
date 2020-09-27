using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebookLibrary.WebDrivers;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Pages.NotLoggedIn
{
    public class DialogCreateNewAccount : DialogBase
    {
        public DialogCreateNewAccount(RemoteWebDriver driver, WebDriverWait wait):base(driver, wait) { }

        public TextBox TextBoxFirstName => new TextBox(Driver, By.XPath("//input[@name='firstname']"));
        public TextBox TextBoxLastName => new TextBox(Driver, By.XPath("//input[@name='firstname']"));
        public TextBox TextBoxMobileNumberOrEmail => new TextBox(Driver, By.XPath("//input[@name='firstname']"));
        public TextBox TextBoxNewPassword => new TextBox(Driver, By.XPath("//input[@name='firstname']"));
        public Dropdown DropdownMonth => new Dropdown(Driver, By.XPath("//input[@name='birthday_month']"));
        public Dropdown DropdownDate => new Dropdown(Driver, By.XPath("//input[@name='day']"));
        public Dropdown DropdownYear => new Dropdown(Driver, By.XPath("//input[@name='year']"));
    }
}
