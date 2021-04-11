using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;

namespace RobotizeFacebook.App.LoggedIn
{
    public class BoatsFilter : BaseFilter, IBoatFilter, IBoatsFilterOptions
    {
        public BoatsFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public IBoatsFilterOptions FilterBy => throw new NotImplementedException();

        public void Category(BoatCategory categoryType)
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

        public IApplyFilter Price(double? min = null, double? max = null)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter SortBy(VehicleSortOption criteria)
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
