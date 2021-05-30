using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RuRayToolbox.Extensions
{
    public class JscriptExecutor
    {
        public RemoteWebDriver _driver;
        public JscriptExecutor(RemoteWebDriver driver) { _driver = driver; }
        
        public void ScrollInToView(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor) _driver;
           js.ExecuteScript("arguments[0].scrollIntoView();", element);
        }
    }
}
