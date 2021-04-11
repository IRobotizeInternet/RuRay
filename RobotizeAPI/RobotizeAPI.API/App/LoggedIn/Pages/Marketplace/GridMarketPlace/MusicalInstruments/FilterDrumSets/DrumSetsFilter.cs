using OpenQA.Selenium.Remote;
using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class DrumSetsFilter : BaseFilter, IDrumSetsFilter, IDrumSetsFilterOptions
    {
        public DrumSetsFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public IDrumSetsFilterOptions FilterBy => throw new NotImplementedException();

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
