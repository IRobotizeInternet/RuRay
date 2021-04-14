using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.App.LoggedIn.Components;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class MenuItemsLiveProducer : MenuItems
    {
        public MenuItemsLiveProducer()
        {
            BaseXPath = $"//div[@aria-label='{ResLeftNav.GoLiveSettings}']";
            MenuItemsCommon = new MenuItemsCommon(BaseXPath);
        }
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        public MenuItemsCommon MenuItemsCommon;

        public TextBox TextBoxTitleOptional =>
            new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.TitleOptional}']"));

        public TextBox TextBoxSaySomethingAboutThisLiveVideo =>
            new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.SaySomethingAboutThisLiveVideo}']"));

        public EventTriggerButton<DialogTagFriends> EventTriggerButtonTagFriends =>
            new EventTriggerButton<DialogTagFriends>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.TagFriends}']"));

        public EventTriggerButton<DialogCheckin> EventTriggerButtonCheckIn =>
            new EventTriggerButton<DialogCheckin>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.CheckIn}']"));

        public EventTriggerButton<DialogHowAreYouFeeling> EventTriggerButtonFeelingOrActivity =>
            new EventTriggerButton<DialogHowAreYouFeeling>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.FeelingOrActivity}']"));

        public EventTriggerButton<DialogRaiseMoney> EventTriggerButtonRaiseMoney =>
             new EventTriggerButton<DialogRaiseMoney>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.RaiseMoney}']"));

        public EventTriggerButton<DialogChooseAnEmoji> EventTriggerButtonInsertAnEmoji =>
             new EventTriggerButton<DialogChooseAnEmoji>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResLeftNav.InsertAnEmoji}']"));

        public EventTriggerButton<DialogAddATitle> EventTriggerGoLive =>
            new EventTriggerButton<DialogAddATitle>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.GoLive}']"));

        public EventTriggerButton<DialogSelectAudience> EventTriggerOnlyMe =>
            new EventTriggerButton<DialogSelectAudience>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.OnlyMe}']"));

        public EventTriggerButton<PopupTagAGame> EventTriggerGaming =>
            new EventTriggerButton<PopupTagAGame>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Gaming}']"));
    }

    public class PopupTagAGame : BasePopup
    {
        public PopupTagAGame()
        {
        }

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResLeftNav.GoLiveSettings}']//input[@aria-label='{ResLeftNav.TagAGameExFortnite}']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        private class ComboBoxTagAGame : Combobox
        {
            public ComboBoxTagAGame(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
            {
                BaseXPath = $"//div[@aria-label='{ResLeftNav.GoLiveSettings}']";
                SearchBoxXPath = $"{BaseXPath}//input[contains(@aria-label,'{ResLeftNav.TagAGameExFortnite}')][@type='search']";
                SearchItemsXPath = "//div[@role='presentation']";

            }
        }
    }
}
