using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;

namespace RuRayFacebook.App.LoggedIn
{
    public class GuitarsAndBassesFilter : BaseFilter, IGuitarsAndBassesFilter, IGuitarsAndBassesFilterOptions
    {
        public GuitarsAndBassesFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public IGuitarsAndBassesFilterOptions FilterBy => throw new NotImplementedException();

        public void Category(GuitarsAndBassesCategory category)
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
