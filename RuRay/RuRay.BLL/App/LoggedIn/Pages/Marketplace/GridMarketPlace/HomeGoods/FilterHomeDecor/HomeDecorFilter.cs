using System;
using System.Collections.Generic;
using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn
{
    public class HomeDecorFilter : BaseFilter, IHomeDecorFilter, IHomeDecorFilterOptions
    {
        public HomeDecorFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public IHomeDecorFilterOptions FilterBy => throw new NotImplementedException();

        public void Category(HomeDecorCategory category)
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
