using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayFacebook.App.LoggedIn.Enum;
using RuRayLibrary.Extensions;
using RuRayToolbox.Controls;
using RuRayToolbox.Extensions;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogChooseIllustration" />.
    /// </summary>
    public class DialogChooseIllustration : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogChooseIllustration"/> class.
        /// </summary>
        public DialogChooseIllustration()
        {
            BaseXPath = $"//div[@aria-label='{ResLeftNav.ChooseAnIllustration}']";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResLeftNav.ChooseAnIllustration}'][@role='dialog']");

        /// <summary>
        /// Gets the EventTriggerButtonFeaturedIllustration.
        /// </summary>
        public EventTriggerButton<DialogIllustration> EventTriggerButtonFeaturedIllustration =>
            new EventTriggerButton<DialogIllustration>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Featured}']"), $"{BaseXPath}//div[@role='tab'][@aria-selected='true']//span[text()='{ResLeftNav.Featured}']");

        /// <summary>
        /// Gets the EventTriggerButtonPartyIllustration.
        /// </summary>
        public EventTriggerButton<DialogIllustration> EventTriggerButtonPartyIllustration =>
            new EventTriggerButton<DialogIllustration>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Party}']"), $"{BaseXPath}//div[@role='tab'][@aria-selected='true']//span[text()='{ResLeftNav.Party}']");

        /// <summary>
        /// Gets the EventTriggerButtonBirthdayIllustration.
        /// </summary>
        public EventTriggerButton<DialogIllustration> EventTriggerButtonBirthdayIllustration =>
            new EventTriggerButton<DialogIllustration>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Birthday}']"), $"{BaseXPath}//div[@role='tab'][@aria-selected='true']//span[text()='{ResLeftNav.Birthday}']");

        /// <summary>
        /// Gets the EventTriggerButtonFoodAndDrinkIllustration.
        /// </summary>
        public EventTriggerButton<DialogIllustration> EventTriggerButtonFoodAndDrinkIllustration =>
            new EventTriggerButton<DialogIllustration>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.FoodAndDrink}']"), $"{BaseXPath}//div[@role='tab'][@aria-selected='true']//span[text()='{ResLeftNav.FoodAndDrink}']");

        /// <summary>
        /// Gets the EventTriggerButtonFamilyIllustration.
        /// </summary>
        public EventTriggerButton<DialogIllustration> EventTriggerButtonFamilyIllustration =>
            new EventTriggerButton<DialogIllustration>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Family}']"), $"{BaseXPath}//div[@role='tab'][@aria-selected='true']//span[text()='{ResLeftNav.Family}']");

        /// <summary>
        /// Gets the EventTriggerButtonMoreIllustration.
        /// </summary>
        public EventTriggerButton<DropDownMoreIllustration> EventTriggerButtonMoreIllustration =>
            new EventTriggerButton<DropDownMoreIllustration>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.More}']"), $"{BaseXPath}//div[@role='tab'][@aria-selected='true']//span[text()='{ResLeftNav.More}']");

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// Defines the <see cref="DialogIllustration" />.
    /// </summary>
    public class DialogIllustration : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogIllustration"/> class.
        /// </summary>
        /// <param name="tabXPath">The tabXPath<see cref="string"/>.</param>
        public DialogIllustration(string tabXPath)
        {
            WaitForDialogToAppear(By.XPath(tabXPath));
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResLeftNav.ChooseAnIllustration}']");

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// The SelectIllustration.
        /// </summary>
        /// <param name="index">The index<see cref="int"/>.</param>
        public void SelectIllustration(int index)
        {
            var webElementsCoverPhotos = Driver.FindElements(By.XPath($"//div[@aria-label='{ResLeftNav.ChooseAnIllustration}']//div[@aria-label='{ResLeftNav.CoverPhoto}']"));

            if (webElementsCoverPhotos == null || webElementsCoverPhotos.Count < index)
            {
                return;
            }

            var webElementIllustration = webElementsCoverPhotos.ToList()[index];
            JscriptExecutor.ScrollToTheElement(Driver, webElementIllustration);
            webElementIllustration.Click();
        }
    }

    /// <summary>
    /// Defines the <see cref="DropDownMoreIllustration" />.
    /// </summary>
    public class DropDownMoreIllustration : DropdownWithEnum<MoreIllustration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DropDownMoreIllustration"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="byForDropdown">The byForDropdown<see cref="ExtendBy"/>.</param>
        public DropDownMoreIllustration(RemoteWebDriver driver, ExtendBy byForDropdown) : base(driver, byForDropdown)
        {
        }
    }
}
