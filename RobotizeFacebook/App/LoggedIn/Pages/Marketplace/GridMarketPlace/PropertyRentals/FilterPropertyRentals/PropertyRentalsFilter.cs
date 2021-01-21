using OpenQA.Selenium.Remote;
using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class PropertyRentalsFilter : BaseFilter, IPropertyRentalsFilter, IPropertyRentalsFilterOptions
    {
        public PropertyRentalsFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public IPropertyRentalsFilterOptions FilterBy => throw new NotImplementedException();

        public IApplyFilter Bedrooms(BathroomCount numberOfBedrooms)
        {
            throw new NotImplementedException();
        }

        public void ListingsFromIndividualsOnly(bool listingsFromIndividualsOnly)
        {

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
