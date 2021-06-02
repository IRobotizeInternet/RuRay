using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.CommonControls;

namespace RuRayToolbox.Controls
{
    public class FileUploader : BaseDOMObject
    {
        public FileUploader(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
        {

        }
    }
}