using System;
using System.Collections.Generic;
using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="EntertainmentFilter" />.
    /// </summary>
    public class EntertainmentFilter : BaseFilter, IEntertainmentFilter, IEntertainmentFilterOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntertainmentFilter"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public EntertainmentFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Gets the FilterBy.
        /// </summary>
        public IEntertainmentFilterOptions FilterBy => throw new NotImplementedException();

        /// <summary>
        /// The Category.
        /// </summary>
        /// <param name="category">The category<see cref="EntertainmentCategory"/>.</param>
        public void Category(EntertainmentCategory category)
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
