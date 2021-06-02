using System;
using OpenQA.Selenium.Remote;
using RuRayFacebook.App.LoggedIn;

namespace RuRayToolbox.Controls
{
    /// <summary>
    /// Defines the <see cref="FacebookGrid" />.
    /// </summary>
    public class FacebookGrid
    {
        /// <summary>
        /// Defines the _driver.
        /// </summary>
        private readonly RemoteWebDriver _driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookGrid"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public FacebookGrid(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// The ScrollUntilCategoryFound.
        /// </summary>
        /// <param name="category">The category<see cref="string"/>.</param>
        public void ScrollUntilCategoryFound(string category)
        {
        }

        /// <summary>
        /// The ClickColumnButtonWaitForColumnMenu.
        /// </summary>
        /// <param name="columnName">The columnName<see cref="string"/>.</param>
        public void ClickColumnButtonWaitForColumnMenu(string columnName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The ClickFilterButton.
        /// </summary>
        /// <param name="columnName">The columnName<see cref="string"/>.</param>
        public void ClickFilterButton(string columnName)
        {
        }

        /// <summary>
        /// Expand/Collapse the filter for a given filter type using filter name.
        /// </summary>
        /// <typeparam name="TFilter">.</typeparam>
        /// <param name="columnName">The columnName<see cref="string"/>.</param>
        /// <returns>The <see cref="TFilter"/>.</returns>
        public TFilter ExpandCollapseFilter<TFilter>(string columnName)
            where TFilter : IFilter<IFilterOptions>
        {
            if (!typeof(TFilter).IsInterface)
            {
                throw new ArgumentException("The generic type must be an interface.", nameof(TFilter));
            }

            ClickColumnButtonWaitForColumnMenu(columnName);
            return FilterFactory.GetFilter<TFilter>(_driver);
        }
    }
}
