﻿using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Dialogs;
using RobotizeLibrary.Resources;

namespace RobotizeFacebook.Pages.LoggedIn.Home.MainSection.SubSections
{
    public class DialogCreateYourRoom : DialogBase
    {
        // This is the ugliest way to making the xpath, feel free to chage to for better.
        protected override By ByForDialog => By.XPath($"*//span[text()='{ResMiscellaneous.CreateYourRoom}']//..//..//..//..//..//..//..//..//parent::div[@role='dialog']");

        public DialogCreateYourRoom(RemoteWebDriver driver, WebDriverWait wait)
            :base(driver, wait)
        {
            
        }

    }
}