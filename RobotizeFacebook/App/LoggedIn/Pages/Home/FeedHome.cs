using System;
using OpenQA.Selenium;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedHome : FeedComponent
    {
        public CreatePost SectionCreatePost => new CreatePost();

        public override string FeedUrl => "/";

        public FeedHome()
        {
            TryToSetCurrentFeedIndex();
            base.BaseXPath = "//div[contains(@data-pagelet,'Feed')]";
            base.PositionXPath = "//div[@aria-posinset='{0}']";
        }

        public void TryToSetCurrentFeedIndex()
        {

            foreach(var ele in Driver.FindElements(By.XPath("//div[contains(@data-pagelet,'Feed')]")))
            {
               var jsString = "function isElementOutViewport () {"+
                            "let el = document.evaluate(\"//div[contains(@data-pagelet,'Feed')]//div[@aria-posinset='1']\", document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;"+
                            @"var rect = el.getBoundingClientRect();
                            return rect.bottom < 0 || rect.right < 0 || rect.left > window.innerWidth || rect.top > window.innerHeight;
                           }
                        return this.isElementOutViewport();";
                var js = (IJavaScriptExecutor)Driver;
                
                var res = js.ExecuteScript(jsString);

                if (ele.Displayed) Console.WriteLine("");
            }
        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
