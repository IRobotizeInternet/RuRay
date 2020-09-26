using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotizeYoutubeLibrary.CommonControls
{
    public class Button : BaseDOMProperty
    {
        public Button(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
        }
    }
}
