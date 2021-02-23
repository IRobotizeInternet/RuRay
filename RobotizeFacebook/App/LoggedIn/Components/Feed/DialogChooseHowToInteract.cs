using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Dialogs;
using System.Collections.Generic;
using System.Linq;

namespace RobotizeFacebook.App.LoggedIn.Pages.Base
{
    public class DialogChooseHowToInteract : BaseDialog
    {
        public DialogChooseHowToInteract(RemoteWebDriver driver) : base(driver)
        {
        }

        protected override By ByForDialog => By.XPath($"//div[@role='menuitem']//strong[text()='{ResHomePage.ChooseHowToInteract}']");

        public List<IWebElement> AllAvailableOptiosOfHowToInteract => Driver.FindElements(By.XPath($"//div[@role='menuitem']//strong[text()='{ResHomePage.ChooseHowToInteract}']/parent::span/parent::div/parent::div/parent::div/parent::div/div[3]//span")).ToList();

        public void SetHowToInteract(int index)
        {
            var options = AllAvailableOptiosOfHowToInteract;
            if (index > options.Count) return;
            AllAvailableOptiosOfHowToInteract[index].Click();
        }
    }
}