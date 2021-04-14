using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.LoggedIn.Components
{
    public class DivRememberPassword
    {
        private readonly RemoteWebDriver _driver;
        private readonly string _basePath = $"//span[text()='{ResMiscellaneous.DivRememberPassword}']/../../../../../..";
        public DivRememberPassword(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        public Button ButtonOK => new Button(_driver, By.XPath($"{_basePath}//span[text()='{ResMiscellaneous.OK}']"));
        public Button ButtonNotNow => new Button(_driver, By.XPath($"{_basePath}//span[text()='{ResMiscellaneous.NotNow}']"));
    }
}
