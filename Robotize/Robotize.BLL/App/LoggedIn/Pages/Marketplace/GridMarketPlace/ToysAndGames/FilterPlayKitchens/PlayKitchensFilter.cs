using OpenQA.Selenium.Remote;
using System;

namespace RuRayFacebook.App.LoggedIn
{
    public class PlayKitchensFilter : BaseFilter, IPlayKitchensFilter, IPlayKitchensFilterOptions
    {
        public PlayKitchensFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public IPlayKitchensFilterOptions FilterBy => throw new NotImplementedException();

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
