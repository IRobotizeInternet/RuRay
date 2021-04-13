using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;

namespace RobotizeFacebook.App.LoggedIn
{
    public class VehicleFilter : BaseFilter, IVehicleFilter, IVehicleFilterOptions
    {
        public VehicleFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public IVehicleFilterOptions FilterBy => throw new NotImplementedException();

        public IApplyFilter BodyStyle(VehicleBodyStyle bodyStyle)
        {
            throw new NotImplementedException();
        }

        public void Category(VehicleCategory categoryType)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter ExteriorColor(ColorVehicleInteriorExterior exteriorColor)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public IApplyFilter Make(VehicleMake criteria)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter Milage(double? min = null, double? max = null)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter Model(VehicleModel model)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter Price(double? min = null, double? max = null)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter SortBy(VehicleSortOption criteria)
        {
            throw new NotImplementedException();
        }

        public IFilterOptions VehicleType(VehicleType vehicleType)
        {
            throw new NotImplementedException();
        }

        public IFilterOptions VehicleType(VehicleTransmissionType vehicleType)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter Year(int? min, int? max)
        {
            throw new NotImplementedException();
        }

        protected override void ClickFilterButton()
        {
            throw new NotImplementedException();
        }

        protected override void SetFilterCriteria()
        {
            throw new NotImplementedException();
        }
    }
}
