using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogEmojis : BaseDialog
    {
        public DialogEmojis()
        {
            BaseXPath = "//div[@role='dialog']//ul[@role='tablist']";
        }

        protected override By ByForDialog => By.XPath("//div[@role='dialog']//ul[@role='tablist']");

        public Button ButtonRecent => new Button(Driver, By.XPath($"{BaseXPath}//a[@aria-label='{ResHomePage.Recent}']"));
        public Button ButtonSmileysAndPeople => new Button(Driver, By.XPath($"{BaseXPath}//a[@aria-label='{ResHomePage.SmileysAndPeople}']"));
        public Button ButtonAnimalsAndNature => new Button(Driver, By.XPath($"{BaseXPath}//a[@aria-label='{ResHomePage.AnimalsAndNature}']"));
        public Button ButtonFoodAndDrink => new Button(Driver, By.XPath($"{BaseXPath}//a[@aria-label='{ResHomePage.FoodAndDrink}']"));
        public Button ButtonActivities => new Button(Driver, By.XPath($"{BaseXPath}//a[@aria-label='{ResHomePage.Activities}']"));
        public Button ButtonTravelAndPlaces => new Button(Driver, By.XPath($"{BaseXPath}//a[@aria-label='{ResHomePage.TravelAndPlaces}']"));
        public Button ButtonObjects => new Button(Driver, By.XPath($"{BaseXPath}//a[@aria-label='{ResHomePage.Objects}']"));
        public Button ButtonSymbols => new Button(Driver, By.XPath($"{BaseXPath}//a[@aria-label='{ResHomePage.Symbols}']"));
        public Button ButtonFlags => new Button(Driver, By.XPath($"{BaseXPath}//a[@aria-label='{ResHomePage.Flags}']"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}