﻿using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Pages.LoggedUser;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Controls;
using RobotizeLibrary.Controls.TriggerControls;
using RobotizeLibrary.Dialogs;

namespace RobotizeFacebook.Pages.NotLoggedIn
{
    public class DialogCreateNewAccount : DialogBase
    {
        protected override By ByForDialog => throw new System.NotImplementedException();

        public DialogCreateNewAccount(RemoteWebDriver driver, WebDriverWait wait):base(driver, wait) { }

        public TextBox TextBoxFirstName => new TextBox(Driver, By.XPath("//input[@name='firstname']"));
        public TextBox TextBoxLastName => new TextBox(Driver, By.XPath("//input[@name='lastname']"));
        
        public TextBox TextBoxMobileNumberOrEmail => new TextBox(Driver, By.XPath("//input[@name='reg_email__']"));
        public TextBox TextBoxReMobileNumberOrEmail => new TextBox(Driver, By.XPath("//input[@name='reg_email_confirmation__']"));
        public TextBox TextBoxNewPassword => new TextBox(Driver, By.XPath("//input[@name='reg_passwd__']"));
        
        public Dropdown DropdownMonth => new Dropdown(Driver, By.XPath("//select[@name='birthday_month']"));
        public Dropdown DropdownDate => new Dropdown(Driver, By.XPath("//select[@name='birthday_day']"));
        public Dropdown DropdownYear => new Dropdown(Driver, By.XPath("//select[@name='birthday_year']"));

        public RadioButton RadioButtonFemale => new RadioButton(Driver, By.XPath("//input[@name='sex' and @value='1']"));
        public RadioButton RadioButtonMale => new RadioButton(Driver, By.XPath("//input[@name='sex' and @value='2']"));
        
        public RadioButton RadioButtonCustom => new RadioButton(Driver, By.XPath("//input[@name='sex' and @value='3']"));
        public Dropdown DropdownSelectYourPronoun => new Dropdown(Driver, By.XPath("//select[name='preferred_pronoun']"));
        public TextBox TextBoxGenderOptional => new TextBox(Driver, By.XPath("//input[@name='custom_gender']"));

        public Hyperlink<PageTerms> HyperlinkTerms => new Hyperlink<PageTerms>(Driver, Wait, By.XPath("//a[@id='terms-link']"));
        public Hyperlink<PagePrivacy> HyperlinkDataPolicy => new Hyperlink<PagePrivacy>(Driver, Wait, By.XPath("//a[@id='privacy-link']"));
        public Hyperlink<PageCookies> HyperlinkCookiePolicy => new Hyperlink<PageCookies>(Driver, Wait, By.XPath("//a[@id='cookie-use-link']"));

        public EventTriggerButton<PageHome> ButtonSignUp => new EventTriggerButton<PageHome>(Driver, Wait, By.XPath("//button[@name='websubmit')]"));

    }
}
