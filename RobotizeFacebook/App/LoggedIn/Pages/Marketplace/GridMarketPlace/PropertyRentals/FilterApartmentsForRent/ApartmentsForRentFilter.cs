using OpenQA.Selenium.Remote;
using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class ApartmentsForRentFilter : BaseFilter, IApartmentsForRentFilter, IApartmentsForRentFilterOptions
    {
        public ApartmentsForRentFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public IApartmentsForRentFilterOptions FilterBy => throw new NotImplementedException();

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
