using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;

namespace RuRayFacebook.App.LoggedIn
{
    public class ReptileSuppliesFilter : BaseFilter, IReptileSuppliesFilter, IReptileSuppliesFilterOptions
    {
        public ReptileSuppliesFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public IReptileSuppliesFilterOptions FilterBy => throw new NotImplementedException();

        public void Category(ReptileSuppliesCategory category)
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
