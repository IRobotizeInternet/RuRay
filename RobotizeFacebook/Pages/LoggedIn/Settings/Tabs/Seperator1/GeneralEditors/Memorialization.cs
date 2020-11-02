using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Pages.NotLoggedIn.Help;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Controls;
using RobotizeLibrary.Controls.TriggerControls;
using RobotizeLibrary.Dialogs;
using RobotizeLibrary.Resources;

namespace RobotizeFacebook.Pages.LoggedIn.Settings.Tabs.Seperator1
{
    public class Memorialization: BaseEditor
    {
        public Combobox ComboboxChooseAFriend => new Combobox(Driver, By.XPath($"//input[@placeholder={ResMiscellaneous.ChooseAFriend}]"));
        public Button ButtonAdd => new Button(Driver, By.XPath($"//button[text()={ResMiscellaneous.Add}]"));
        public Hyperlink<DialogDeleteYourAccountInFuture> Link =>
            new Hyperlink<DialogDeleteYourAccountInFuture>(Driver, Wait, By.XPath($"//input[@value={ResMiscellaneous.RequestThatYourAccountBeDeletedAfterYouPassAway}]"));
    }

    public class DialogDeleteYourAccountInFuture : DialogBase
    {
        public DialogDeleteYourAccountInFuture(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        protected override By ByForDialog => By.XPath($"//div/h3[text()={ResMiscellaneous.DeleteYourAccountInTheFuture}]");

        public Button ButtonDeleteAfterDeath => new Button(Driver, By.XPath("//button[text()='Delete After Death']"));
        public Button ButtonCancel => new Button(Driver, By.XPath("//a[text()='Cancel']"));
        public Hyperlink<PageHelpChooseALegacyContact> LinkLearnMore => 
            new Hyperlink<PageHelpChooseALegacyContact>(Driver, Wait, By.XPath("//div[@role='dialog']//a[text()='Learn More']"));
    }
}
