using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class BagsAndLuggageFilter : BaseFilter, IBagsAndLuggageFilter, IBagsAndLuggageFilterOptions
    {
        public BagsAndLuggageFilter(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        IBagsAndLuggageFilterOptions IFilter<IBagsAndLuggageFilterOptions>.FilterBy => throw new NotImplementedException();

        public IApplyFilter Brand(BrandBagsAndLuggage bodyStyle)
        {
            throw new NotImplementedException();
        }

        public void Category(BagsAndLuggageCategory categoryType)
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
