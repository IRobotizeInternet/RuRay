using OpenQA.Selenium.Remote;
using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class HousesForRentFilter : BaseFilter, IHousesForRentFilter, IHousesForRentFilterOptions
    {
        public HousesForRentFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public IHousesForRentFilterOptions FilterBy => throw new NotImplementedException();

        public IApplyFilter Bedrooms(BathroomCount numberOfBedrooms)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter Price(double? min = null, double? max = null)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter RentalType(RentalType numberOfBedrooms)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter SortBy(VehicleSortOption criteria)
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
