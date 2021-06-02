using System;
using System.Collections.Generic;
using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="AppliancesFilter" />.
    /// </summary>
    public class AppliancesFilter : BaseFilter, IAppliancesFilter, IAppliancesFilterOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppliancesFilter"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public AppliancesFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Gets the FilterBy.
        /// </summary>
        public IAppliancesFilterOptions FilterBy => throw new NotImplementedException();

        /// <summary>
        /// The Category.
        /// </summary>
        /// <param name="category">The category<see cref="AppliancesCategory"/>.</param>
        public void Category(AppliancesCategory category)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The GetAllCategories.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{string}"/>.</returns>
        public IEnumerable<string> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The ItemCondition.
        /// </summary>
        /// <param name="condition">The condition<see cref="ItemCondition"/>.</param>
        /// <returns>The <see cref="IFilterOptions"/>.</returns>
        public IFilterOptions ItemCondition(ItemCondition condition)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The Price.
        /// </summary>
        /// <param name="min">The min<see cref="double?"/>.</param>
        /// <param name="max">The max<see cref="double?"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        public IApplyFilter Price(double? min = null, double? max = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The ClickFilterButton.
        /// </summary>
        protected override void ClickFilterButton()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The SetFilterCriteria.
        /// </summary>
        protected override void SetFilterCriteria()
        {
            throw new NotImplementedException();
        }
    }
}
