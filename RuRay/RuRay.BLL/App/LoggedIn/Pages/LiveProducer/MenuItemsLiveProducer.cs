using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayFacebook.App.LoggedIn.Components;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="MenuItemsLiveProducer" />.
    /// </summary>
    public class MenuItemsLiveProducer : MenuItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItemsLiveProducer"/> class.
        /// </summary>
        public MenuItemsLiveProducer()
        {
            BaseXPath = $"//div[@aria-label='{ResLeftNav.GoLiveSettings}']";
            MenuItemsCommon = new MenuItemsCommon(BaseXPath);
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Defines the MenuItemsCommon.
        /// </summary>
        public MenuItemsCommon MenuItemsCommon;

        /// <summary>
        /// Gets the TextBoxTitleOptional.
        /// </summary>
        public TextBox TextBoxTitleOptional =>
            new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.TitleOptional}']"));

        /// <summary>
        /// Gets the TextBoxSaySomethingAboutThisLiveVideo.
        /// </summary>
        public TextBox TextBoxSaySomethingAboutThisLiveVideo =>
            new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.SaySomethingAboutThisLiveVideo}']"));

        /// <summary>
        /// Gets the EventTriggerButtonTagFriends.
        /// </summary>
        public EventTriggerButton<DialogTagFriends> EventTriggerButtonTagFriends =>
            new EventTriggerButton<DialogTagFriends>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.TagFriends}']"));

        /// <summary>
        /// Gets the EventTriggerButtonCheckIn.
        /// </summary>
        public EventTriggerButton<DialogCheckin> EventTriggerButtonCheckIn =>
            new EventTriggerButton<DialogCheckin>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.CheckIn}']"));

        /// <summary>
        /// Gets the EventTriggerButtonFeelingOrActivity.
        /// </summary>
        public EventTriggerButton<DialogHowAreYouFeeling> EventTriggerButtonFeelingOrActivity =>
            new EventTriggerButton<DialogHowAreYouFeeling>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.FeelingOrActivity}']"));

        /// <summary>
        /// Gets the EventTriggerButtonRaiseMoney.
        /// </summary>
        public EventTriggerButton<DialogRaiseMoney> EventTriggerButtonRaiseMoney =>
             new EventTriggerButton<DialogRaiseMoney>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.RaiseMoney}']"));

        /// <summary>
        /// Gets the EventTriggerButtonInsertAnEmoji.
        /// </summary>
        public EventTriggerButton<DialogChooseAnEmoji> EventTriggerButtonInsertAnEmoji =>
             new EventTriggerButton<DialogChooseAnEmoji>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResLeftNav.InsertAnEmoji}']"));

        /// <summary>
        /// Gets the EventTriggerGoLive.
        /// </summary>
        public EventTriggerButton<DialogAddATitle> EventTriggerGoLive =>
            new EventTriggerButton<DialogAddATitle>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.GoLive}']"));

        /// <summary>
        /// Gets the EventTriggerOnlyMe.
        /// </summary>
        public EventTriggerButton<DialogSelectAudience> EventTriggerOnlyMe =>
            new EventTriggerButton<DialogSelectAudience>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.OnlyMe}']"));

        /// <summary>
        /// Gets the EventTriggerGaming.
        /// </summary>
        public EventTriggerButton<PopupTagAGame> EventTriggerGaming =>
            new EventTriggerButton<PopupTagAGame>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Gaming}']"));
    }

    /// <summary>
    /// Defines the <see cref="PopupTagAGame" />.
    /// </summary>
    public class PopupTagAGame : BasePopup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PopupTagAGame"/> class.
        /// </summary>
        public PopupTagAGame()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResLeftNav.GoLiveSettings}']//input[@aria-label='{ResLeftNav.TagAGameExFortnite}']");

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Defines the <see cref="ComboBoxTagAGame" />.
        /// </summary>
        private class ComboBoxTagAGame : Combobox
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="ComboBoxTagAGame"/> class.
            /// </summary>
            /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
            /// <param name="byForElement">The byForElement<see cref="By"/>.</param>
            public ComboBoxTagAGame(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
            {
                BaseXPath = $"//div[@aria-label='{ResLeftNav.GoLiveSettings}']";
                SearchBoxXPath = $"{BaseXPath}//input[contains(@aria-label,'{ResLeftNav.TagAGameExFortnite}')][@type='search']";
                SearchItemsXPath = "//div[@role='presentation']";
            }
        }
    }
}
