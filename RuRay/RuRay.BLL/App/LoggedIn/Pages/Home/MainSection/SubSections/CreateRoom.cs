using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="CreateRoom" />.
    /// </summary>
    public class CreateRoom
    {
        /// <summary>
        /// Defines the _driver.
        /// </summary>
        private readonly RemoteWebDriver _driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRoom"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public CreateRoom(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// Gets the DialogCreateRoom.
        /// </summary>
        public EventTriggerButton<DialogCreateYourRoom> DialogCreateRoom =>
            new EventTriggerButton<DialogCreateYourRoom>(_driver, By.XPath($"//div[@data-pagelet='VideoChatHomeUnit']//span[text()='{ResMiscellaneous.CreateRoom}']"));

        /// <summary>
        /// Gets the LinkLearnHowRoomWorks.
        /// </summary>
        public EventTriggerButton<DialogLearnCreateRoom> LinkLearnHowRoomWorks =>
            new EventTriggerButton<DialogLearnCreateRoom>(_driver, By.XPath($"//div[@data-pagelet='VideoChatHomeUnit']//div[@aria-label='{ResMiscellaneous.LearnMore}']"));
    }
}
