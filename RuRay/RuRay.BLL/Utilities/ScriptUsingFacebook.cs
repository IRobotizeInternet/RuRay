using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using RuRayFacebook.App.LoggedIn.Pages;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.Utilities
{
    /// <summary>
    /// Defines the <see cref="ScriptUsingFacebook" />.
    /// </summary>
    public class ScriptUsingFacebook
    {
        /// <summary>
        /// The GenerateFacebookHelpApi.
        /// </summary>
        public void GenerateFacebookHelpApi()
        {
            var page = new PageHelp();

            //page.GoToPage("https://www.facebook.com/help/246750422356731/adding-friends/?helpref=hc_fnav");
            var classes = new List<ClassDefinationDTO>();
            int attempts = 0;
            while (attempts < 4)
            {
                try
                {
                    var headerMenuItems = page.GetMainMenuItems;
                    for (var h = 1; h < headerMenuItems.Count; h++)
                    {
                        var childrenCount = page.GetMenuItemsNames(headerMenuItems[h]).Count();
                        for (var i = 0; i <= childrenCount; i++)
                        {
                            var classDTO = new ClassDefinationDTO();
                            classes.Add(classDTO);
                            classDTO.NameSpace = new Defiantion { Name = headerMenuItems[h] };

                            page.GetFirstItem(headerMenuItems[h]).Click();
                            var menuItem = page.GetMenuItemsNames(headerMenuItems[h]).ToList()[i];
                            var className = menuItem.GetAttribute("aria-label");
                            var partUrl = menuItem.GetAttribute("href");
                            page.ClickElement(menuItem);

                            var newDefination = new Defiantion
                            {
                                Name = className
                            };
                            classDTO.ClassDefination = newDefination;

                            var grandChildren = page.GetSubMenuItemsName(className);

                            if (!grandChildren.Any())
                            {
                                continue;
                            }

                            var methodDefinitions = new List<MethodDefination>();
                            for (var j = 0; j < grandChildren.Count; j++)
                            {
                                var grandChildEmement = page.GetSubMenuItemHyperlink(className, grandChildren[j])[j];

                                page.GoToPage(grandChildEmement.GetAttribute("href"));

                                string funtionNamePart = string.Empty;
                                for (var k = 0; k < page.GetFunctionNames.Count; k++)
                                {
                                    page.ClickElement(page.GetFunctionNames[k]);
                                    Thread.Sleep(10000);
                                    funtionNamePart = page.GetFunctionNames[k].Text;

                                    IEnumerable<IWebElement> functionSummaryElements = null;
                                    IList<string> functionSummaryHeader = null;
                                    try
                                    {
                                        functionSummaryElements = page.GetFunctionNames[k].FindElements(By.XPath($"//div[@role='main']/div//div[2]//div[@role='button']//span[text()=\"{funtionNamePart}\"]/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::h3/following-sibling::div[1]//ol"));
                                    }
                                    catch (Exception)
                                    {
                                        page.ClickElement(page.GetFunctionNames[k]);
                                        continue;
                                    }

                                    try
                                    {
                                        functionSummaryHeader = page.GetFunctionNames[k].FindElements(By.XPath($"//div[@role='main']/div//div[2]//div[@role='button']//span[text()=\"{funtionNamePart}\"]/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::h3/following-sibling::div[1]//ol/preceding-sibling::h2")).Select(x => x.Text).ToList();
                                    }
                                    catch (Exception) { }
                                    var index = 0;
                                    foreach (var functionSummaryElement in functionSummaryElements)
                                    {
                                        var comments = new List<string>();
                                        if (functionSummaryHeader.Count() - 1 >= index)
                                        {
                                            funtionNamePart = $"{funtionNamePart}{functionSummaryHeader[index++]}";
                                        }

                                        foreach (var functionSummary in functionSummaryElement.FindElements(By.XPath("//li")))
                                        {
                                            var header = funtionNamePart;
                                            comments.Add(functionSummary.Text);
                                        }

                                        methodDefinitions.Add(new MethodDefination
                                        {
                                            Name = $"{funtionNamePart}",
                                            Comments = comments
                                        });
                                    }

                                    Thread.Sleep(10000);
                                    page.ClickElement(page.GetFunctionNames[k]);
                                    Thread.Sleep(34000);
                                }
                            }
                            classDTO.Methods = methodDefinitions;
                            FileOperations.Serialize(@"D:\Dev\RuRay\RuRayFacebook\Services\RuRayAPIs\JsonClasses11", classes);
                        }
                    }
                    break;
                }
                catch (StaleElementReferenceException e)
                {
                    Debug.WriteLine(e.Message);
                }
                attempts++;
                Thread.Sleep(3000);
            }
        }

        /// <summary>
        /// The CloseClass.
        /// </summary>
        /// <param name="className">The className<see cref="string"/>.</param>
        private void CloseClass(string className)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The CreateClass.
        /// </summary>
        /// <param name="v">The v<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        private string CreateClass(string v)
        {
            throw new NotImplementedException();
        }

        // Get Ul and click on it.
        // if there are li iterater over
        // remove spaces
        /// <summary>
        /// Defines the <see cref="PageHelp" />.
        /// </summary>
        internal class PageHelp : BasePage
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="PageHelp"/> class.
            /// </summary>
            public PageHelp()
            {
            }

            /// <summary>
            /// The ClickElement.
            /// </summary>
            /// <param name="webElement">The webElement<see cref="IWebElement"/>.</param>
            public void ClickElement(IWebElement webElement)
            {
                Driver.ExecuteScript("arguments[0].click();", webElement);
            }

            /// <summary>
            /// Gets the PageUrl.
            /// </summary>
            public override string PageUrl => "https://www.facebook.com/help/";

            /// <summary>
            /// Gets the ByForPage.
            /// </summary>
            public override By ByForPage => By.XPath("//div");

            /// <summary>
            /// The GetMenuItemHyperlink.
            /// </summary>
            /// <param name="name">The name<see cref="string"/>.</param>
            /// <returns>The <see cref="Button"/>.</returns>
            public Button GetMenuItemHyperlink(string name) =>
                new Button(Driver, By.XPath($"//div[@aria-label='Using Facebook']//span[text()='{name}']/parent::span/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::a"));

            /// <summary>
            /// The GetSubMenuItemHyperlink.
            /// </summary>
            /// <param name="parent">The parent<see cref="string"/>.</param>
            /// <param name="child">The child<see cref="string"/>.</param>
            /// <returns>The <see cref="IList{IWebElement}"/>.</returns>
            public IList<IWebElement> GetSubMenuItemHyperlink(string parent, string child) =>
                Driver.FindElements(By.XPath($"//div[@aria-label='Using Facebook']//div[@aria-label='{parent}']//a//span/div/span['{child}']/parent::div/parent::span/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::a"));

            /// <summary>
            /// The GetMenuItemsNames.
            /// </summary>
            /// <param name="name">The name<see cref="string"/>.</param>
            /// <returns>The <see cref="IEnumerable{IWebElement}"/>.</returns>
            public IEnumerable<IWebElement> GetMenuItemsNames(string name) =>
                Driver.FindElements(By.XPath($"//a[@aria-labelledby='{name}']"));

            /// <summary>
            /// The GetSubMenuItemsName.
            /// </summary>
            /// <param name="name">The name<see cref="string"/>.</param>
            /// <returns>The <see cref="IList{string}"/>.</returns>
            public IList<string> GetSubMenuItemsName(string name) =>
                Driver.FindElements(By.XPath($"//div[@aria-label='Using Facebook']//div[@aria-label='{name}']//a//span/div/span")).Select(x => x.Text).ToList();

            /// <summary>
            /// Gets the GetFunctionNames.
            /// </summary>
            public IList<IWebElement> GetFunctionNames =>
                Driver.FindElements(By.XPath("//div[@role='main']/div//div[2]//div[@role='button']//span"));

            /// <summary>
            /// The GetFunctionDiv.
            /// </summary>
            /// <param name="functionName">The functionName<see cref="string"/>.</param>
            /// <returns>The <see cref="IWebElement"/>.</returns>
            public IWebElement GetFunctionDiv(string functionName) =>
                Driver.FindElement(By.XPath($"//div[@role='main']/div//div[2]//span[text()='{functionName}']"));

            /// <summary>
            /// The GetFirstItem.
            /// </summary>
            /// <param name="name">The name<see cref="string"/>.</param>
            /// <returns>The <see cref="IWebElement"/>.</returns>
            public IWebElement GetFirstItem(string name) =>
                Driver.FindElement(By.XPath($"//div[@aria-haspopup='menu']/div[@id='{name}']/span"));

            /// <summary>
            /// Gets the GetMainMenuItems.
            /// </summary>
            public IList<string> GetMainMenuItems =>
                Driver.FindElements(By.XPath("//div[@aria-haspopup='menu']/div/span")).Select(x => x.Text).ToList();

            /// <summary>
            /// The RunConformance.
            /// </summary>
            public override void RunConformance()
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// The GetDescriptionHeader.
            /// </summary>
            /// <param name="name">The name<see cref="string"/>.</param>
            /// <returns>The <see cref="IWebElement"/>.</returns>
            public IWebElement GetDescriptionHeader(string name) =>
                Driver.FindElement(By.XPath($"//div[@role='main']//h3//span[text()='{name}/**How do I find and add friends on Facebook?**/']/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::div/parent::h3/parent::div/div[1]//h2[1]"));

            /// <summary>
            /// The GetAllActions.
            /// </summary>
            /// <param name="name">The name<see cref="string"/>.</param>
            /// <returns>The <see cref="IEnumerable{IWebElement}"/>.</returns>
            public IEnumerable<IWebElement> GetAllActions(string name) =>
                Driver.FindElements(By.XPath("//div[@role='main']//div[@role='button']"));
        }
    }
}
