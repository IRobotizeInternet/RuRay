using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;

namespace RuRayFacebook.App.LoggedIn
{
    public class PoolsAndSpasFilter : BaseFilter, IPoolsAndSpasFilter, IPoolsAndSpasFilterOptions
    {
        public PoolsAndSpasFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public IPoolsAndSpasFilterOptions FilterBy => throw new NotImplementedException();

        public void Category(PoolsAndSpasCategory category)
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
