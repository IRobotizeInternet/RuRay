using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Resources;

namespace RobotizeFacebook.Pages.LoggedIn.Home.MainSection.SubSections
{
    public class CreateRoom
    {
        private RemoteWebDriver _driver;
        private WebDriverWait _wait;

        public CreateRoom(RemoteWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public EventTriggerButton<DialogCreateYourRoom> DialogCreateRoom =>
            new EventTriggerButton<DialogCreateYourRoom>(_driver, _wait, By.XPath($"//div[@data-pagelet='VideoChatHomeUnit']//span[text()='{ResMiscellaneous.CreateRoom}']"));

        public EventTriggerButton<DialogLearnCreateRoom> LinkLearnHowRoomWorks => 
            new EventTriggerButton<DialogLearnCreateRoom>(_driver, _wait, By.XPath("//div[@data-pagelet='VideoChatHomeUnit']//div[@aria-label='Learn More']"));
    }
}
