using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Extensions;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="CheckboxFilter" />.
    /// </summary>
    public class CheckboxFilter : BaseFilter, ICheckboxFilterOptions, ICheckboxFilter
    {
        /// <summary>
        /// Defines the _byFilterButton.
        /// </summary>
        private readonly By _byFilterButton;

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckboxFilter"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="byFilterButton">The byFilterButton<see cref="By"/>.</param>
        public CheckboxFilter(RemoteWebDriver driver, By byFilterButton)
            : base(driver)
        {
            _byFilterButton = byFilterButton;
        }

        /// <summary>
        /// Gets the FilterCriteriaList.
        /// </summary>
        public IEnumerable<string> FilterCriteriaList { get; private set; }

        /// <summary>
        /// Gets the FilterBy.
        /// </summary>
        public ICheckboxFilterOptions FilterBy => throw new NotImplementedException();

        /// <summary>
        /// The FilterItemList.
        /// </summary>
        /// <param name="itemsToFilter">The itemsToFilter<see cref="IEnumerable{string}"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        public IApplyFilter FilterItemList(IEnumerable<string> itemsToFilter)
        {
            FilterCriteriaList = itemsToFilter;
            return this;
        }

        /// <summary>
        /// The ApplyFilter.
        /// </summary>
        public override void ApplyFilter()
        {
            if (FilterCriteriaList.Any())
            {
                SetFilterCriteria();
            }

            base.ApplyFilter();
        }

        /// <summary>
        /// The ClickFilterButton.
        /// </summary>
        protected override void ClickFilterButton()
        {
            var button = new Button(Driver, _byFilterButton);
            button.Click();
        }

        /// <summary>
        /// The SetFilterCriteria.
        /// </summary>
        protected override void SetFilterCriteria()
        {
            UnSelectAll();
            foreach (var criteria in FilterCriteriaList)
            {
                SetFilterElementLabel(criteria);
            }
        }

        /// <summary>
        /// The SetFilterElementLabel.
        /// </summary>
        /// <param name="filterExpression">The filterExpression<see cref="string"/>.</param>
        private void SetFilterElementLabel(string filterExpression)
        {
            const string xpathForLabelsFilterPopup =
                "//form[@class='k-filter-menu']" +
                "//label";
            var labelElementsFilterPopup = Driver.FindVisibleElementsWait(By.XPath(xpathForLabelsFilterPopup));

            var checkboxItemToClick = labelElementsFilterPopup.First(labelElement => labelElement.Text.Trim()
                .Equals(filterExpression));

            if (checkboxItemToClick == null)
            {
                throw new ElementNotVisibleException($"Unable to add filter {filterExpression}. checkbox filter not available");
            }

            checkboxItemToClick.Click();
        }

        /// <summary>
        /// The UnSelectAll.
        /// </summary>
        private void UnSelectAll()
        {
            const string xpathForCheckboxesFilterPopup =
                "//form[@class='k-filter-menu']" +
                "//input[@type='checkbox']";
            var checkboxElementsOnFilterPopup = Driver.FindElements(By.XPath(xpathForCheckboxesFilterPopup));
            var checkedCheckboxes = checkboxElementsOnFilterPopup.Where(checkbox => checkbox.Selected);
            foreach (var checkbox in checkedCheckboxes)
            {
                checkbox.Click();
            }
        }

        /// <summary>
        /// The SelectAll.
        /// </summary>
        private void SelectAll()
        {
        }

        /// <summary>
        /// The InteriorColor.
        /// </summary>
        /// <param name="interiorColor">The interiorColor<see cref="string"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        public IApplyFilter InteriorColor(string interiorColor)
        {
            throw new NotImplementedException();
        }
    }
}
