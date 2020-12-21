using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace RobotizeLibrary.Controls.Grid
{
    public class Vehicle : BaseFilter, IVehicleFilter, IVehicleFilterOptions
    {
        public Vehicle(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public IVehicleFilterOptions FilterBy => throw new NotImplementedException();

        public IApplyFilter BodyStyle(VehicleBodyStyle bodyStyle)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter ExteriorColor(VehicleInteriorExteriorColor exteriorColor)
        {
            throw new NotImplementedException();
        }

        public IFilterOptions InteriorColor(VehicleInteriorExteriorColor interiorColor)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter Maker(VehicleMake criteria)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter Milage(double milage)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter Model(VehicleModel model)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter Price(double price)
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

        public IApplyFilter Year(string year)
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
