﻿using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class CreateRoom
    {
        private readonly RemoteWebDriver _driver;
        

        public CreateRoom(RemoteWebDriver driver)
        {
            _driver = driver;

        }

        public EventTriggerButton<DialogCreateYourRoom> DialogCreateRoom =>
            new EventTriggerButton<DialogCreateYourRoom>(_driver, By.XPath($"//div[@data-pagelet='VideoChatHomeUnit']//span[text()='{ResMiscellaneous.CreateRoom}']"));

        public EventTriggerButton<DialogLearnCreateRoom> LinkLearnHowRoomWorks => 
            new EventTriggerButton<DialogLearnCreateRoom>(_driver, By.XPath($"//div[@data-pagelet='VideoChatHomeUnit']//div[@aria-label='{ResMiscellaneous.LearnMore}']"));
    }
}
