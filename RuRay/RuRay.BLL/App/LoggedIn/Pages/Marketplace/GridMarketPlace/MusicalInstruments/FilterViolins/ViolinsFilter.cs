using System;
using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn
{
    public class ViolinsFilter : BaseFilter, IViolinsFilter, IViolinsFilterOptions
    {
        public ViolinsFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public IViolinsFilterOptions FilterBy => throw new NotImplementedException();

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
