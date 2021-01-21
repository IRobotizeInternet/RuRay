using OpenQA.Selenium.Remote;
using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class TVsFilter : BaseFilter, ITVsFilter, ITVsFilterOptions
    {
        public TVsFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public ITVsFilterOptions FilterBy => throw new NotImplementedException();

        public IApplyFilter Brand(BrandTVs bodyStyle)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter DisplayTechnology(DisplayTechnology displayTechnology)
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

        public IApplyFilter ScreenSize(ScreenSize screenSize)
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
