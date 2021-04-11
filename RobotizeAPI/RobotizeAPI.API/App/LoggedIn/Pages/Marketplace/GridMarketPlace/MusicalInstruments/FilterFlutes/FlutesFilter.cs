using OpenQA.Selenium.Remote;
using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class FlutesFilter : BaseFilter, IFlutesFilter, IFlutesFilterOptions
    {
        public FlutesFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public IFlutesFilterOptions FilterBy => throw new NotImplementedException();

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
