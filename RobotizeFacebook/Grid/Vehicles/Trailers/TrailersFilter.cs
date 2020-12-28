using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace RobotizeFacebook.Grid
{
    public class TrailersFilter : BaseFilter, ITrailersFilter, ITrailersFilterOptions
    {
        public TrailersFilter(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public ITrailersFilterOptions FilterBy => throw new NotImplementedException();

        public IApplyFilter ExteriorColor(VehicleInteriorExteriorColor exteriorColor)
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
