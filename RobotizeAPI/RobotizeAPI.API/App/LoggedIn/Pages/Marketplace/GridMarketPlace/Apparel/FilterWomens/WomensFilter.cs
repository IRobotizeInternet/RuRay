using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;

namespace RobotizeFacebook.App.LoggedIn
{
    public class WomensFilter : BaseFilter, IWomensFilter, IWomensFilterOptions
    {
        public WomensFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public IWomensFilterOptions FilterBy => throw new NotImplementedException();

        public void Category(WomensCategory categoryType)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter ExteriorColor(ColorWomenApparel exteriorColor)
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
