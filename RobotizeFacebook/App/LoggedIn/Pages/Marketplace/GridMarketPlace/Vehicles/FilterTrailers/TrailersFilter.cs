using OpenQA.Selenium.Remote;
using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class TrailersFilter : BaseFilter, ITrailersFilter, ITrailersFilterOptions
    {
        public TrailersFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public ITrailersFilterOptions FilterBy => throw new NotImplementedException();

        public IApplyFilter ExteriorColor(ColorVehicleInteriorExterior exteriorColor)
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
