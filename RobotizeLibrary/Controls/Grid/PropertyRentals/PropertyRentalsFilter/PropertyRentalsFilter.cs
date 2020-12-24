using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace RobotizeLibrary.Controls.Grid
{
    public class PropertyRentalsFilter : BaseFilter, IPropertyRentalsFilter, IPropertyRentalsFilterOptions
    {
        public PropertyRentalsFilter(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
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
