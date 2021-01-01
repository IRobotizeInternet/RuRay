using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class CondosForRentFilter : BaseFilter, ICondosForRentFilter, ICondosForRentFilterOptions
    {
        public CondosForRentFilter(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public ICondosForRentFilterOptions FilterBy => throw new NotImplementedException();

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
