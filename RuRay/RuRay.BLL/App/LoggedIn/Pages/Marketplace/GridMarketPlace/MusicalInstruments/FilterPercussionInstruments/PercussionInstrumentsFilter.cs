using System;
using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn
{
    public class PercussionInstrumentsFilter : BaseFilter, IPercussionInstrumentsFilter, IPercussionInstrumentsFilterOptions
    {
        public PercussionInstrumentsFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public IPercussionInstrumentsFilterOptions FilterBy => throw new NotImplementedException();

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
