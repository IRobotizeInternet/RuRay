using System;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeToolbox.Extensions
{
    public static class JscriptExecutor
    {
        public static void ScrollInToView(RemoteWebDriver driver, IWebElement element)
        {
            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", element);
        }

        /// <summary>
        /// This extension will help determine if the element is in visible view port of the window.
        /// </summary>
        /// <param name="driver">RemoteWebDriver</param>
        /// <param name="xpath">xpath of an element, ex: //div[contains(@data-pagelet,'Feed')]//div[@aria-posinset='{1}']</param>
        /// <returns>true if element is in viewport, otherwise false</returns>
        public static bool IsElementOutViewport(RemoteWebDriver driver, string xpath)
        {
            var jsString = "function isElementOutViewport() {" +
                    
                // Get element by xPath
                $"var element = document.evaluate(\"{xpath}\", " +
                @"document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;
                    const rect = element.getBoundingClientRect();
                    
                const rect = element.getBoundingClientRect();
                    
                let height = (document.documentElement.clientHeight);
                let width = (document.documentElement.clientWidth);
                    
                // Check if the given element is entirely within the viewport
                var res = (
                    rect.top >= 0 &&
                    rect.left >= 0 &&
                    (rect.bottom) <=  height &&
                    rect.right <= width
                );
                    
                let viewportPercent = 0;
                if(res) return res;

                // Check if the given element streaches top and botton of the viewport
                else if(res == false && (rect.top < 0 && rect.bottom > height)) return true;

                // If the element completely off the viewport just return false.
                else if((rect.top < 0 && rect.bottom < 0) || (rect.top > height && rect.bottom > height)) { console.log('completely outside');return false;}

                // Check if the given element's top portion is beyond viewport
                else if (rect.top < 0) { console.log('top is outside'); viewportPercent = Math.round((rect.bottom / height) * 100); }

                // Check if the given element's bottom portion is beyond viewport
                else if (rect.bottom > height) { console.log('bottom is out'); viewportPercent = Math.round(((height - rect.top) / height) * 100); }

                // We set the current element is in viewport if it is atleast 40%
                // I choose 40% after trying few options, initial thoughts were check if half of the
                // current element is visible.
                console.log('Element percentage in viewport: ' + viewportPercent);
                if (viewportPercent >= 40 == false) return false;
                element.focus();
                return true;}
            return isElementOutViewport();";
            try
            {
                var js = (IJavaScriptExecutor)driver;
                return (bool)js.ExecuteScript(jsString);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool GetElementFromMiddleOfViewPoint(RemoteWebDriver driver)
        {
            var jsString = @"return document.elementFromPoint(window.innerWidth/2, window.innerHeight/2);";

            try
            {
                var js = (IJavaScriptExecutor)driver;
                var ele = (IWebElement)js.ExecuteScript(jsString);
                var elementId = ((RemoteWebElement)js.ExecuteScript(jsString));
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }

        /// <summary>
        /// Get the xpath from an IWebElement.
        /// </summary>
        /// <param name="driver">Driver</param>
        /// <param name="element">element</param>
        /// <returns>xpath</returns>
        public static string GetElementXPath(RemoteWebDriver driver, IWebElement element)
        {
            var javaScript = "function getElementXPath(elt){" +
                                    "var path = \"\";" +
                                    "for (; elt && elt.nodeType == 1; elt = elt.parentNode){" +
                                        "idx = getElementIdx(elt);" +
                                        "xname = elt.tagName;" +
                                        "if (idx > 1){" +
                                            "xname += \"[\" + idx + \"]\";" +
                                        "}" +
                                        "path = \"/\" + xname + path;" +
                                    "}" +
                                    "return path;" +
                                "}" +
                                "function getElementIdx(elt){" +
                                    "var count = 1;" +
                                    "for (var sib = elt.previousSibling; sib ; sib = sib.previousSibling){" +
                                        "if(sib.nodeType == 1 && sib.tagName == elt.tagName){" +
                                            "count++;" +
                                        "}" +
                                    "}" +
                                    "return count;" +
                                "}" +
                                "return getElementXPath(arguments[0]).toLowerCase();";
            return (string)((IJavaScriptExecutor)driver).ExecuteScript(javaScript, element);
        }

        /// <summary>
        /// When scrolling pop/dialog list compare to scrolling window we need to 
        /// pass element xpath inorder to identify the parent containig the scroll bar.
        /// window.scrollBy will on work on the Feed Windows. 
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="elementXPath">When xpath is null the code will try to scroll feed window.</param>
        /// <param name="scrollingLengthXAxis"></param>
        /// <param name="scrollingLengthYAxis"></param>
        public static void ScrollBy(
            RemoteWebDriver driver, 
            string elementXPath, 
            double scrollingLengthXAxis = 10,
            double scrollingLengthYAxis = 0)
        {
            if (elementXPath == null)
            {
                driver.ExecuteScript($"window.scrollBy({scrollingLengthXAxis}, { scrollingLengthYAxis })");
                return;
            }

            // When scrolling popup/dialog list
            var jScript = 
                $"var element = document.evaluate(\"{elementXPath}\", " +
                 $@"document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;
                      element.scrollBy({scrollingLengthXAxis}, { scrollingLengthYAxis })";
            driver.ExecuteScript(jScript);
        }

        public static int GetViewPortHieght(RemoteWebDriver driver)
        {
            var js = (IJavaScriptExecutor)driver;
            return int.Parse(js.ExecuteScript("return window.innerHeight").ToString());
        }

        /// <summary>
        /// please use <see cref="JScrollSmoothDown"/> or <see cref="JScrollSmoothUp"/> 
        /// for smooth scrolling
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="byForElement"></param>
        /// <param name="webElement"></param>
        public static void JScrollToElement(
            RemoteWebDriver driver, 
            By byForElement, 
            IWebElement webElement = null)
        {
            var jScript = "arguments[0].scrollIntoView(true);" +
            "var evObj = document.createEvent('MouseEvents');" +
            "evObj.initMouseEvent(\"mouseover\",true, false, window, 0, 0, 0, 0, 0, false, false, false, false, 0, null);" +
            "arguments[0].dispatchEvent(evObj);";

            webElement = webElement ?? driver.FindElementWithTimeSpan(byForElement);
            driver.ExecuteScript(jScript, webElement);
        }

        public static void ScrollToTheElement(RemoteWebDriver driver, IWebElement element)
        {
            var jScript = "arguments[0].scrollIntoView(false);" +
          "var evObj = document.createEvent('MouseEvents');" +
          "evObj.initMouseEvent(\"mouseover\",true, false, window, 0, 0, 0, 0, 0, false, false, false, false, 0, null);" +
          "arguments[0].dispatchEvent(evObj);";
            driver.ExecuteScript(jScript, element);
        }
    }
}
