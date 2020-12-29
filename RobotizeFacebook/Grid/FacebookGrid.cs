using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Grid;
using System;

namespace RobotizeToolbox.Controls
{
    public class FacebookGrid
    {
        private readonly RemoteWebDriver _driver;
        private readonly WebDriverWait _wait;

        public FacebookGrid(RemoteWebDriver driver, WebDriverWait wait) 
        {
            _driver = driver;
            _wait = wait;
        }

        public void ScrollUntilCategoryFound(string category)
        {

        }

        public void ClickColumnButtonWaitForColumnMenu(string columnName)
        {
            throw new NotImplementedException();
            //ClickFilterButton(columnName);
            //var element = _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(string.Empty)));
        }

        public void ClickFilterButton(string columnName)
        {
            //var xpathForColumnButton = string.Format(KendoGridColumnLocators.ColumnButtonXpath, columnName);
            //var columnButton = new Button(_driver, ByFullXPath(xpathForColumnButton));
            //Acts.WaitForObjectToLoadForTimeSpan(_driver);
            //columnButton.ScrollToElement();
            //columnButton.Click();
        }

        /// <summary>
        /// Expand/Collapse the filter for a given filter type using filter name.
        /// </summary>
        public TFilter ExpandCollapseFilter<TFilter>(string columnName)
            where TFilter : IFilter<IFilterOptions>
        {
            if (!typeof(TFilter).IsInterface)
            {
                throw new ArgumentException("The generic type must be an interface.", nameof(TFilter));
            }

            ClickColumnButtonWaitForColumnMenu(columnName);
            return FilterFactory.GetFilter<TFilter>(_driver, _wait);
        }
    }
}
