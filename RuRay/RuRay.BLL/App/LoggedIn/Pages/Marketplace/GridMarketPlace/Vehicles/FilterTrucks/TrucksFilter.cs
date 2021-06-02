using System;
using System.Collections.Generic;
using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="TrucksFilter" />.
    /// </summary>
    public class TrucksFilter : BaseFilter, ITrucksFilter, ITrucksFilterOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrucksFilter"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public TrucksFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Gets the FilterBy.
        /// </summary>
        public ITrucksFilterOptions FilterBy => throw new NotImplementedException();

        /// <summary>
        /// The BodyStyle.
        /// </summary>
        /// <param name="bodyStyle">The bodyStyle<see cref="VehicleBodyStyle"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        public IApplyFilter BodyStyle(VehicleBodyStyle bodyStyle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The Category.
        /// </summary>
        /// <param name="categoryType">The categoryType<see cref="TruckCategory"/>.</param>
        public void Category(TruckCategory categoryType)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The ExteriorColor.
        /// </summary>
        /// <param name="exteriorColor">The exteriorColor<see cref="ColorVehicleInteriorExterior"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        public IApplyFilter ExteriorColor(ColorVehicleInteriorExterior exteriorColor)
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
        /// The Make.
        /// </summary>
        /// <param name="criteria">The criteria<see cref="VehicleMake"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        public IApplyFilter Make(VehicleMake criteria)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The Milage.
        /// </summary>
        /// <param name="min">The min<see cref="double?"/>.</param>
        /// <param name="max">The max<see cref="double?"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        public IApplyFilter Milage(double? min = null, double? max = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The Model.
        /// </summary>
        /// <param name="model">The model<see cref="VehicleModel"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        public IApplyFilter Model(VehicleModel model)
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
        /// The SortBy.
        /// </summary>
        /// <param name="criteria">The criteria<see cref="VehicleSortOption"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        public IApplyFilter SortBy(VehicleSortOption criteria)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The VehicleType.
        /// </summary>
        /// <param name="vehicleType">The vehicleType<see cref="VehicleType"/>.</param>
        /// <returns>The <see cref="IFilterOptions"/>.</returns>
        public IFilterOptions VehicleType(VehicleType vehicleType)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The VehicleType.
        /// </summary>
        /// <param name="vehicleType">The vehicleType<see cref="VehicleTransmissionType"/>.</param>
        /// <returns>The <see cref="IFilterOptions"/>.</returns>
        public IFilterOptions VehicleType(VehicleTransmissionType vehicleType)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The Year.
        /// </summary>
        /// <param name="min">The min<see cref="int?"/>.</param>
        /// <param name="max">The max<see cref="int?"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        public IApplyFilter Year(int? min, int? max)
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
