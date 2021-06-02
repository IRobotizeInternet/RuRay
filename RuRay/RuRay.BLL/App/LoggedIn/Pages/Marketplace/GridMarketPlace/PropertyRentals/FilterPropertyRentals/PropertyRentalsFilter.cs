using System;
using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="PropertyRentalsFilter" />.
    /// </summary>
    public class PropertyRentalsFilter : BaseFilter, IPropertyRentalsFilter, IPropertyRentalsFilterOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyRentalsFilter"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public PropertyRentalsFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Gets the FilterBy.
        /// </summary>
        public IPropertyRentalsFilterOptions FilterBy => throw new NotImplementedException();

        /// <summary>
        /// The Bedrooms.
        /// </summary>
        /// <param name="numberOfBedrooms">The numberOfBedrooms<see cref="BathroomCount"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        public IApplyFilter Bedrooms(BathroomCount numberOfBedrooms)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The ListingsFromIndividualsOnly.
        /// </summary>
        /// <param name="listingsFromIndividualsOnly">The listingsFromIndividualsOnly<see cref="bool"/>.</param>
        public void ListingsFromIndividualsOnly(bool listingsFromIndividualsOnly)
        {
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
        /// The RentalType.
        /// </summary>
        /// <param name="numberOfBedrooms">The numberOfBedrooms<see cref="RentalType"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        public IApplyFilter RentalType(RentalType numberOfBedrooms)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The SortBy.
        /// </summary>
        /// <param name="criteria">The criteria<see cref="VehicleSortOption"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        public IApplyFilter SortBy(VehicleSortOption criteria)
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
