using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RobotizeToolbox.Extensions
{
    public static class JscriptExecutor
    {
        public static void ScrollInToView(RemoteWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", element);

        }

        public static void ScrollToTheElement(RemoteWebDriver driver, IWebElement element)
        {
            var jScript = "arguments[0].scrollIntoView(false);" +
          "var evObj = document.createEvent('MouseEvents');" +
          "evObj.initMouseEvent(\"mouseover\",true, false, window, 0, 0, 0, 0, 0, false, false, false, false, 0, null);" +
          "arguments[0].dispatchEvent(evObj);";
            driver.ExecuteScript(jScript, element);
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
                    $"var el = document.evaluate(\"{xpath}\", " +
                    @"document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;
                    var top = el.offsetTop;
                    var left = el.offsetLeft;
                    var width = el.offsetWidth;
                    var height = el.offsetHeight;

                    while (el.offsetParent)
                    {
                        el = el.offsetParent;
                        top += el.offsetTop;
                        left += el.offsetLeft;
                    }

                    return (
                      top < (window.pageYOffset + window.innerHeight) &&
                      left < (window.pageXOffset + window.innerWidth) &&
                      (top + height) > window.pageYOffset &&
                      (left + width) > window.pageXOffset
                    );
                }
                return this.isElementOutViewport();";
            
            try
            {
                var js = (IJavaScriptExecutor)driver;
                return (bool)js.ExecuteScript(jsString);
            }
            catch {
                return false;
            }
        }

        public static bool IsElementOutViewport_1(RemoteWebDriver driver, string xpath)
        {
            var jsString = "function isElementOutViewport() {" +
                    $"var element = document.evaluate(\"{xpath}\", " +
                    @"document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;
                       const rect = element.getBoundingClientRect();
                    console.log(rect.top);
                    console.log(rect.bottom)
                    console.log((document.documentElement.clientHeight));
                    let hight = (window.innerHeight || document.documentElement.clientHeight);
                    let width = (window.innerWidth || document.documentElement.clientWidth);
                    var res = (
                        rect.top >= 0 &&
                        rect.left >= 0 &&
                        (rect.bottom) <=  hight &&
                        rect.right <= width
                    );
                    
                    let diff = 0;
                    if(res) return res;
                    else if(res == false && (rect.top < 0 && rect.bottom > hight)) return true;
                    else if(rect.top < 0) diff = rect.bottom + rect.top;
                    else if(rect.bottom > hight) diff = hight - rect.top;
                    return diff >= hight/2.5;
                }
            return isElementOutViewport();";
            try
            {
                var js = (IJavaScriptExecutor)driver;
                return (bool)js.ExecuteScript(jsString);
            }
            catch(Exception ex)
            {
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
    }

    public class ChildRemoteWebElement : RemoteWebElement
    {
        public ChildRemoteWebElement(RemoteWebDriver parentDriver, string id) : base(parentDriver, id)
        {
        }
    }
}
