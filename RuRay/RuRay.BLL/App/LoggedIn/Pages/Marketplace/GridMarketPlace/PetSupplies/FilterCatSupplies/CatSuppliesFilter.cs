using System;
using System.Collections.Generic;
using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn
{
    public class CatSuppliesFilter : BaseFilter, ICatSuppliesFilter, ICatSuppliesFilterOptions
    {
        public CatSuppliesFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public ICatSuppliesFilterOptions FilterBy => throw new NotImplementedException();

        public void Category(CatSuppliesCategory category)
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
