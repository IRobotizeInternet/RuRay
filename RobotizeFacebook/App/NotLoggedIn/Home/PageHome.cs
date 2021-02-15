using OpenQA.Selenium;
using RobotizeFacebook.App.LoggedIn.Pages;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.NotLoggedIn
{
    public class PageHome : BasePage
    {
        public override string PageUrl => "/";

        public Button ButtonCreateVideo => new Button(Driver, By.XPath("//div[@id='end']//div[@id='buttons']//ytd-topbar-menu-button-renderer[1]//button"));

        public Button ButtonYoutubeApps => new Button(Driver, By.XPath("//div[@id='end']//div[@id='buttons']//ytd-topbar-menu-button-renderer[2]//button"));

        public Button ButtonSettings => new Button(Driver, By.XPath("//div[@id='end']//div[@id='buttons']//ytd-topbar-menu-button-renderer[3]//button"));

        public Button ButtonSignIn => new Button(Driver, By.XPath("//div[@id='buttons']//ytd-button-renderer//a"));

        public override By ByForPage => throw new System.NotImplementedException();

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
