using OpenQA.Selenium;
using Robotize.BLL.Resources;
using System.Collections.Generic;
using System.Linq;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogChooseHowToInteract : BaseDialog
    {
        public DialogChooseHowToInteract()
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

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}