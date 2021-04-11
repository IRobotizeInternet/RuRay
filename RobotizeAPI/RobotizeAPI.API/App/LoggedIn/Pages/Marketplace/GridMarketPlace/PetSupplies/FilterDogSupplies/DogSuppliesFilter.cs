using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;

namespace RobotizeFacebook.App.LoggedIn
{
    public class DogSuppliesFilter : BaseFilter, IDogSuppliesFilter, IDogSuppliesFilterOptions
    {
        public DogSuppliesFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public IDogSuppliesFilterOptions FilterBy => throw new NotImplementedException();

        public void Category(DogSuppliesCategory category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public IFilterOptions ItemCondition(ItemCondition condition)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter Price(double? min = null, double? max = null)
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
