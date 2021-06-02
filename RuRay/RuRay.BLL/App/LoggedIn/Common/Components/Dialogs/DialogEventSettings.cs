using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;
using RuRayToolbox.Extensions;

namespace RuRayFacebook.App.LoggedIn.Pages.JobsComposer.ScheduleLiveVideoEvent
{
    /// <summary>
    /// Defines the <see cref="DialogEventSettings" />.
    /// </summary>
    public class DialogEventSettings : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogEventSettings"/> class.
        /// </summary>
        public DialogEventSettings()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResLeftNav.ScheduleLiveSettings}']//span[text()='{ResLeftNav.ShowGuestList}']");

        /// <summary>
        /// Gets the ComboboxCoHostCombobox.
        /// </summary>
        public CoHostCombobox ComboboxCoHostCombobox =>
            new CoHostCombobox(Driver, By.XPath($"//div[@aria-label='{ResLeftNav.ScheduleLiveSettings}']//input[@role='combobox']"));

        /// <summary>
        /// Gets the CheckboxShowGuestList.
        /// </summary>
        public Checkbox CheckboxShowGuestList =>
            new Checkbox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.ShowGuestList}']"));

        /// <summary>
        /// Gets the EventTriggerButtonCancal.
        /// </summary>
        public EventTriggerButton<DialogScheduleNext> EventTriggerButtonCancal =>
             new EventTriggerButton<DialogScheduleNext>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Cancel}']"));

        /// <summary>
        /// Gets the EventTriggerButtonSave.
        /// </summary>
        public EventTriggerButton<DialogEventSettings> EventTriggerButtonSave =>
            new EventTriggerButton<DialogEventSettings>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Save}']"));

        /// <summary>
        /// The RemoveCoHost.
        /// </summary>
        /// <param name="coHostName">The coHostName<see cref="string"/>.</param>
        public void RemoveCoHost(string coHostName)
        {
            Driver.TryFindElement(By.XPath($"//div[@aria-label='{ResLeftNav.ScheduleLiveSettings}']//div[@aria-label='{ResLeftNav.RemoveCoHost}' and //div[@aria-label='{ResLeftNav.ScheduleLiveSettings}']//span[text()='{coHostName}']]"), out var webElementCoHost);
            webElementCoHost.Click();
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Defines the <see cref="CoHostCombobox" />.
        /// </summary>
        public class CoHostCombobox : Combobox
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="CoHostCombobox"/> class.
            /// </summary>
            /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
            /// <param name="byForElement">The byForElement<see cref="By"/>.</param>
            public CoHostCombobox(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
            {
                BaseXPath = $"//div[@aria-label='{ResLeftNav.ScheduleLiveSettings}']//input[@role='combobox']";
                SearchBoxXPath = $"{BaseXPath}//input[@type='search']";
                SearchItemsXPath = "//ul[@role='presentation']";
            }
        }
    }
}
