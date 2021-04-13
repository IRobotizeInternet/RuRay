using OpenQA.Selenium.Remote;
using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class TownhousesForRentFilter : BaseFilter, ITownhousesForRentFilter, ITownhousesForRentFilterOptions
    {
        public TownhousesForRentFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public ITownhousesForRentFilterOptions FilterBy => throw new NotImplementedException();

        public IApplyFilter Price(double? min = null, double? max = null)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter SortBy(PropertyRentalsSortOption criteria)
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
