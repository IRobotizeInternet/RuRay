using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using RobotizeFacebook.App;

namespace RobotizeFacebook.Utilities
{
    public class ScriptUsingFacebook
    {
        public void GenerateFacebookHelpApi()
        {
            var page = new PageHelp();
            page.GoToPage("https://www.facebook.com/help/570785306433644/?helpref=hc_global_nav");
            var classes = new List<string>();

            var classDTO = new ClassDefinationDTO();
            IList<string> headerMenuItems = page.GetMainMenuItems;
            foreach (var headerMenuItem in headerMenuItems)
            {
                classDTO.NameSpace = new Defiantion { Name = headerMenuItem };
                page.GetFirstItem(headerMenuItem).Click();
                IList<string> MenuItemList = page.GetMenuItemsNames;
                foreach (var parent in MenuItemList)
                {
                    var newDefination = new Defiantion();
                    newDefination.Name = parent;
                    page.GetMenuItemHyperlink(parent).Click();
                    var childrens = page.GetSubMenuItemsName(parent);
                    var className = parent.Replace(" ", "");

                    if (!childrens.Any()) continue;
                    foreach (var child in childrens)
                    {
                        page.GetSubMenuItemHyperlink(parent, child).Click();
                        foreach (var funtionDiv in page.GetFunctionNames)
                        {
                            funtionDiv.Click();
                            foreach (var method in page.GetAllActions(funtionDiv.FindElement(By.XPath("//div[@role='main']//h3//span")).Text))
                            {
                                var h3 = page.GetDescriptionHeader(method.Text);
                                var header = h3.Text;
                                foreach (var divText in h3.FindElements(By.XPath("/parent::div//li/div")))
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
            public PageHelp() { 
               // GoToPage(PageUrl); 
            }
            public override string PageUrl => "https://www.facebook.com/help/";

            public override By ByForPage => By.XPath("//div");

            public IWebElement GetMenuItemHyperlink(string name) =>
                Driver.FindElement(By.XPath($"//div[@aria-label='Using Facebook']//span[text()='{name}']/parent::span/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::a"));
            public IWebElement GetSubMenuItemHyperlink(string parent, string child) =>
                Driver.FindElement(By.XPath($"//div[@aria-label='Using Facebook']//div[@aria-label='{parent}']//a//span/div/span['{child}']/parent::div/parent::span/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::a"));
            public IList<string> GetMenuItemsNames =>
                Driver.FindElements(By.XPath("*//div[@aria-label='Using Facebook']/div/div/div[contains(@style,'padding-left')]/a//span/span")).Select(x => x.Text).ToList();
            public IList<string> GetSubMenuItemsName(string name) =>
                Driver.FindElements(By.XPath($"//div[@aria-label='Using Facebook']//div[@aria-label='{name}']//a//span/div/span")).Select(x => x.Text).ToList();

            public IList<IWebElement> GetFunctionNames =>
                Driver.FindElements(By.XPath("//div[@role='main']//h3"));

            public IWebElement GetFirstItem(string name) =>
                Driver.FindElement(By.XPath($"//div[@aria-haspopup='menu']/div[@id='{name}']/span"));

            public IList<string> GetMainMenuItems =>
                Driver.FindElements(By.XPath("//div[@aria-haspopup='menu']/div/span")).Select(x => x.Text).ToList();

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
