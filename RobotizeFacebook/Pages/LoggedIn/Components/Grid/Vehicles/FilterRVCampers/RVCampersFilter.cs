using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class RVCampersFilter : BaseFilter, IRVCampersFilter, IRVCampersFilterOptions
    {
        public RVCampersFilter(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public IRVCampersFilterOptions FilterBy => throw new NotImplementedException();

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
