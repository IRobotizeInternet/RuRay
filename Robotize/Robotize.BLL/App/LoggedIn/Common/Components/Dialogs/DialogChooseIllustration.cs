using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.App.LoggedIn.Enum;
using Robotize.BLL.Resources;
using RobotizeLibrary.Extensions;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Extensions;
using System.Linq;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogChooseIllustration : BaseDialog
    {
        public DialogChooseIllustration()
        {
            BaseXPath = $"//div[@aria-label='{ResLeftNav.ChooseAnIllustration}']";
        }

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResLeftNav.ChooseAnIllustration}'][@role='dialog']");

        public EventTriggerButton<DialogIllustration> EventTriggerButtonFeaturedIllustration =>
            new EventTriggerButton<DialogIllustration>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Featured}']"), $"{BaseXPath}//div[@role='tab'][@aria-selected='true']//span[text()='{ResLeftNav.Featured}']");
        public EventTriggerButton<DialogIllustration> EventTriggerButtonPartyIllustration =>
            new EventTriggerButton<DialogIllustration>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Party}']"), $"{BaseXPath}//div[@role='tab'][@aria-selected='true']//span[text()='{ResLeftNav.Party}']");
        public EventTriggerButton<DialogIllustration> EventTriggerButtonBirthdayIllustration =>
            new EventTriggerButton<DialogIllustration>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Birthday}']"), $"{BaseXPath}//div[@role='tab'][@aria-selected='true']//span[text()='{ResLeftNav.Birthday}']");
        public EventTriggerButton<DialogIllustration> EventTriggerButtonFoodAndDrinkIllustration =>
            new EventTriggerButton<DialogIllustration>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.FoodAndDrink}']"), $"{BaseXPath}//div[@role='tab'][@aria-selected='true']//span[text()='{ResLeftNav.FoodAndDrink}']");
        public EventTriggerButton<DialogIllustration> EventTriggerButtonFamilyIllustration =>
            new EventTriggerButton<DialogIllustration>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Family}']"), $"{BaseXPath}//div[@role='tab'][@aria-selected='true']//span[text()='{ResLeftNav.Family}']");
        public EventTriggerButton<DropDownMoreIllustration> EventTriggerButtonMoreIllustration =>
            new EventTriggerButton<DropDownMoreIllustration>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.More}']"), $"{BaseXPath}//div[@role='tab'][@aria-selected='true']//span[text()='{ResLeftNav.More}']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }

    public class DialogIllustration : BaseDialog
    {
        public DialogIllustration(string tabXPath)
        {
            WaitForDialogToAppear(By.XPath(tabXPath));
        }

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResLeftNav.ChooseAnIllustration}']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        public void SelectIllustration(int index)
        {
            var webElementsCoverPhotos = Driver.FindElements(By.XPath($"//div[@aria-label='{ResLeftNav.ChooseAnIllustration}']//div[@aria-label='{ResLeftNav.CoverPhoto}']"));

            if (webElementsCoverPhotos == null || webElementsCoverPhotos.Count < index) return;
            var webElementIllustration = webElementsCoverPhotos.ToList()[index];
            JscriptExecutor.ScrollToTheElement(Driver, webElementIllustration);
            webElementIllustration.Click();
        }
    }

    public class DropDownMoreIllustration : DropdownWithEnum<MoreIllustration>
    {
        public DropDownMoreIllustration(RemoteWebDriver driver, ExtendBy byForDropdown) : base(driver, byForDropdown)
        {
        }
    }
}