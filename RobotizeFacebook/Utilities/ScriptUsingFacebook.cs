using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using RobotizeFacebook.App;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.Utilities
{
    public class ScriptUsingFacebook
    {
        public void GenerateFacebookHelpApi()
        {
            var page = new PageHelp();
            
            //page.GoToPage("https://www.facebook.com/help/246750422356731/adding-friends/?helpref=hc_fnav");
            var classes = new List<string>();

            var classDTO = new ClassDefinationDTO();
            IList<string> headerMenuItems = page.GetMainMenuItems;
            foreach (var headerMenuItem in headerMenuItems)
            {
                classDTO.NameSpace = new Defiantion { Name = headerMenuItem };
                var childrenCount = page.GetMenuItemsNames.Count();
                for (var i =1; i<= childrenCount;i++ )
                {
                    page.GetFirstItem(headerMenuItem).Click();
                    var menuItem = page.GetMenuItemsNames.ToList()[i];
                    var className = menuItem.GetAttribute("aria-label");
                    var partUrl = menuItem.GetAttribute("href");
                    page.GoToPage(partUrl);

                    var newDefination = new Defiantion();
                    newDefination.Name = className;
                    
                    var grandChildren = page.GetSubMenuItemsName(className);

                    if (!grandChildren.Any()) continue;
                    for(var j=0; j< grandChildren.Count; j++) // grandChild in grandChildren)
                    {
                        var grandChildEmement = page.GetSubMenuItemHyperlink(className, grandChildren[j])[j];
                        var methodDefinitions = new List<MethodDefination>();
                        page.GoToPage(grandChildEmement.GetAttribute("href"));
                        var functionNames = page.GetFunctionNames;
                        var comments = new List<string>();
                        string funtionNamePart = string.Empty;
                        for (var k =0; k< page.GetFunctionNames.Count;k++)
                        {
                            page.ClickElement(functionNames[k]);
                            funtionNamePart = functionNames[k].Text;

                            IEnumerable<IWebElement> functionSummaryElements = null;
                            try
                            {
                                functionSummaryElements = functionNames[k].FindElements(By.XPath($"//div[@role='main']/div//div[2]//div[@role='button']//span[text()='{funtionNamePart}']/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::h3/following-sibling::div[1]//ol//li"));
                            }catch(Exception ex)
                            {
                                page.ClickElement(functionNames[k]);
                                continue;
                            }
                            
                            foreach (var functionSummaryElement in functionSummaryElements)
                            {
                                //var h3 = page.GetDescriptionHeader(div.Text);
                                var header = funtionNamePart;
                                comments.Add(functionSummaryElement.Text);
                            }
                            page.ClickElement(functionNames[k]);

                            methodDefinitions.Add(new MethodDefination
                            {
                                Name = $"{funtionNamePart}",
                                Comments = comments
                            });
                        }
                        Json.SerializeAsync<IList<MethodDefination>>("classes", methodDefinitions);


                    }
                    
                    CloseClass(className);
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
               //Driver.FindElement(By.XPath("//div[@aria-label='Using Facebook']//span[text()='Friending']/parent::span/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::a/parent::div")).Click(); 
            }

            public void ClickElement(IWebElement webElement)
            {
                Driver.ExecuteScript("arguments[0].click();", webElement);
            }
            public override string PageUrl => "https://www.facebook.com/help/";

            public override By ByForPage => By.XPath("//div");

            public Button GetMenuItemHyperlink(string name) =>
                new Button(Driver,By.XPath($"//div[@aria-label='Using Facebook']//span[text()='{name}']/parent::span/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::a"));
            public IList<IWebElement> GetSubMenuItemHyperlink(string parent, string child) =>
                Driver.FindElements(By.XPath($"//div[@aria-label='Using Facebook']//div[@aria-label='{parent}']//a//span/div/span['{child}']/parent::div/parent::span/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::a"));
            public IEnumerable<IWebElement> GetMenuItemsNames =>
                Driver.FindElements(By.XPath("//a[@aria-labelledby='Using Facebook']"));
            public IList<string> GetSubMenuItemsName(string name) =>
                Driver.FindElements(By.XPath($"//div[@aria-label='Using Facebook']//div[@aria-label='{name}']//a//span/div/span")).Select(x => x.Text).ToList();

            public IList<IWebElement> GetFunctionNames =>
                Driver.FindElements(By.XPath("//div[@role='main']/div//div[2]//div[@role='button']//span"));
            public IWebElement GetFunctionDiv(string functionName) =>
                Driver.FindElement(By.XPath($"//div[@role='main']/div//div[2]//span[text()='{functionName}']"));
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
