using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace MIMYoutubeToolbox.CommonControls
{
    public class TextBox : BaseDOMProperty
    {
        public TextBox(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {
        }
    }
}
