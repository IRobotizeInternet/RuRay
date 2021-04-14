using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Extensions;

namespace RobotizeFacebook.App.LoggedIn.Pages.JobsComposer.ScheduleLiveVideoEvent
{
    public class DialogEventSettings : BaseDialog
    {
        public DialogEventSettings()
        {
        }

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResLeftNav.ScheduleLiveSettings}']//span[text()='{ResLeftNav.ShowGuestList}']");

        public CoHostCombobox ComboboxCoHostCombobox =>
            new CoHostCombobox(Driver, By.XPath($"//div[@aria-label='{ResLeftNav.ScheduleLiveSettings}']//input[@role='combobox']"));

        public Checkbox CheckboxShowGuestList =>
            new Checkbox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.ShowGuestList}']"));

        public EventTriggerButton<DialogScheduleNext> EventTriggerButtonCancal =>
             new EventTriggerButton<DialogScheduleNext>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Cancel}']"));

        public EventTriggerButton<DialogEventSettings> EventTriggerButtonSave =>
            new EventTriggerButton<DialogEventSettings>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Save}']"));

        public void RemoveCoHost(string coHostName)
        {
            Driver.TryFindElement(By.XPath($"//div[@aria-label='{ResLeftNav.ScheduleLiveSettings}']//div[@aria-label='{ResLeftNav.RemoveCoHost}' and //div[@aria-label='{ResLeftNav.ScheduleLiveSettings}']//span[text()='{coHostName}']]"), out var webElementCoHost);
            webElementCoHost.Click();
        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        public class CoHostCombobox : Combobox
        {
            public CoHostCombobox(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
            {
                BaseXPath = $"//div[@aria-label='{ResLeftNav.ScheduleLiveSettings}']//input[@role='combobox']";
                SearchBoxXPath = $"{BaseXPath}//input[@type='search']";
                SearchItemsXPath = "//ul[@role='presentation']";
            }
        }

    }
}
