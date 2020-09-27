using OpenQA.Selenium;
using RobotizeLibrary.CommonControls;

namespace RobotizeFacebookLibrary.Pages.NoLoginPages
{
    public class HomePage : BasePage
    {
        public override string PageUrl => "/";

        public Button ButtonCreateVideo => new Button(Driver, By.XPath("//div[@id='end']//div[@id='buttons']//ytd-topbar-menu-button-renderer[1]//button"));

        public Button ButtonYoutubeApps => new Button(Driver, By.XPath("//div[@id='end']//div[@id='buttons']//ytd-topbar-menu-button-renderer[2]//button"));

        public Button ButtonSettings => new Button(Driver, By.XPath("//div[@id='end']//div[@id='buttons']//ytd-topbar-menu-button-renderer[3]//button"));

        public Button ButtonSignIn => new Button(Driver, By.XPath("//div[@id='buttons']//ytd-button-renderer//a"));
    }
}
