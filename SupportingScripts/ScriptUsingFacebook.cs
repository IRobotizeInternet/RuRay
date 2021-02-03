using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using RobotizeFacebook.App;
using System.Reflection.Emit;

namespace SupportingScripts
{
    public class ScriptUsingFacebook
    {
        public void GenerateFacebookHelpApi()
        {
            var page = new PageHelp();
            var classes = new List<string>();
            foreach(var parent in page.GetMenuItemsNames)
            {

                page.GetMenuItemHyperlink(parent).Click();
                var childrens = page.GetSubMenuItemsName(parent);
                var className = CreateClass(parent.Replace(" ", ""));

                if (!childrens.Any()) continue;
                foreach(var child in childrens)
                {
                    page.GetSubMenuItemHyperlink(parent, child).Click();
                    foreach(var funtionDiv in page.GetFunctionNames)
                    {
                        funtionDiv.Click();
                        foreach (var method in page.GetAllActions(funtionDiv.FindElement(By.XPath("//div[@role='main']//h3//span")).Text))
                        {
                            var h3 = page.GetDescriptionHeader(method.Text);
                            var header = h3.Text;
                            foreach(var divText in h3.FindElements(By.XPath("/parent::div//li/div")))
                            {
                                var r = divText.Text;
                            }
                        }
                    }
                }

                CloseClass(className);
                classes.Add(parent.Replace(" ", ""));
            }
        }

        private void CloseClass(string className)
        {
            throw new NotImplementedException();
        }

        private string CreateClass(string v)
        {
            throw new NotImplementedException();
        }

        // Get Ul and click on it.
        // if there are li iterater over
        // remove spaces 
        class PageHelp : BasePage
        {
            public override string PageUrl => "https://www.facebook.com/help/570785306433644/?helpref=hc_fnav";

            public override By ByForPage => By.XPath("//div");

            public IWebElement GetMenuItemHyperlink(string name) =>
                Driver.FindElement(By.XPath($"//div[@aria-label='Using Facebook']//span[text()='{name}']/parent::span/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::a"));
            public IWebElement GetSubMenuItemHyperlink(string parent, string child) =>
                Driver.FindElement(By.XPath($"//div[@aria-label='Using Facebook']//div[@aria-label='{parent}']//a//span/div/span['{child}']/parent::div/parent::span/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::a"));
            public IEnumerable<string> GetMenuItemsNames =>
                Driver.FindElements(By.XPath("*//div[@aria-label='Using Facebook']/div/div/div[contains(@style,'padding-left')]/a//span/span")).Select(x => x.Text);
            public IEnumerable<string> GetSubMenuItemsName(string name) =>
                Driver.FindElements(By.XPath($"//div[@aria-label='Using Facebook']//div[@aria-label='{name}']//a//span/div/span")).Select(x => x.Text);

            public IEnumerable<IWebElement> GetFunctionNames =>
                Driver.FindElements(By.XPath("//div[@role='main']//h3"));
            public override void RunConformance()
            {
                throw new NotImplementedException();
            }

            public IWebElement GetDescriptionHeader(string name) =>
                Driver.FindElement(By.XPath($"//div[@role='main']//h3//span[text()='{name}/**How do I find and add friends on Facebook?**/']/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::h3/parent::div/div[1]//h2[1]"));

            public IEnumerable<IWebElement> GetAllActions(string name) =>
                Driver.FindElements(By.XPath("//div[@role='main']//div[@role='button']"));
        }
    }
}
