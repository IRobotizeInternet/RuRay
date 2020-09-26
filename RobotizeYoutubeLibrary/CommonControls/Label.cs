using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeYoutubeLibrary.CommonControls;
using System;
using System.Collections.Generic;
using System.Text;

namespace MIMYoutubeToolbox.CommonControls
{
    public class Label : BaseDOMProperty
    {
        public Label(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
        }
    }
}
