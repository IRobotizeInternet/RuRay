using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogChooseAnEmoji" />.
    /// </summary>
    public class DialogChooseAnEmoji : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogChooseAnEmoji"/> class.
        /// </summary>
        public DialogChooseAnEmoji()
        {
            BaseXPath = "//div[@role='dialog']//ul[@role='tablist']";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResCreatePost.Emoji}'][@role='dialog']");

        /// <summary>
        /// Gets the ScrollControlChooseEmoji.
        /// </summary>
        public ScrollControl<ListItemEmojiImage> ScrollControlChooseEmoji =>
            new ScrollControl<ListItemEmojiImage>(
                Driver,
                $"//div[@role='dialog' and //h3[text()='{ResHomePage.SmileysAndPeople}']]",
                scrollXPath: "//div[@class='uiScrollableAreaWrap scrollable']");

        /// <summary>
        /// Gets the ButtonRecent.
        /// </summary>
        public Button ButtonRecent => new Button(Driver, By.XPath($"{BaseXPath}//a[@aria-label='{ResHomePage.Recent}']"));

        /// <summary>
        /// Gets the ButtonSmileysAndPeople.
        /// </summary>
        public Button ButtonSmileysAndPeople => new Button(Driver, By.XPath($"{BaseXPath}//a[@aria-label='{ResHomePage.SmileysAndPeople}']"));

        /// <summary>
        /// Gets the ButtonAnimalsAndNature.
        /// </summary>
        public Button ButtonAnimalsAndNature => new Button(Driver, By.XPath($"{BaseXPath}//a[@aria-label='{ResHomePage.AnimalsAndNature}']"));

        /// <summary>
        /// Gets the ButtonFoodAndDrink.
        /// </summary>
        public Button ButtonFoodAndDrink => new Button(Driver, By.XPath($"{BaseXPath}//a[@aria-label='{ResHomePage.FoodAndDrink}']"));

        /// <summary>
        /// Gets the ButtonActivities.
        /// </summary>
        public Button ButtonActivities => new Button(Driver, By.XPath($"{BaseXPath}//a[@aria-label='{ResHomePage.Activities}']"));

        /// <summary>
        /// Gets the ButtonTravelAndPlaces.
        /// </summary>
        public Button ButtonTravelAndPlaces => new Button(Driver, By.XPath($"{BaseXPath}//a[@aria-label='{ResHomePage.TravelAndPlaces}']"));

        /// <summary>
        /// Gets the ButtonObjects.
        /// </summary>
        public Button ButtonObjects => new Button(Driver, By.XPath($"{BaseXPath}//a[@aria-label='{ResHomePage.Objects}']"));

        /// <summary>
        /// Gets the ButtonSymbols.
        /// </summary>
        public Button ButtonSymbols => new Button(Driver, By.XPath($"{BaseXPath}//a[@aria-label='{ResHomePage.Symbols}']"));

        /// <summary>
        /// Gets the ButtonFlags.
        /// </summary>
        public Button ButtonFlags => new Button(Driver, By.XPath($"{BaseXPath}//a[@aria-label='{ResHomePage.Flags}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
