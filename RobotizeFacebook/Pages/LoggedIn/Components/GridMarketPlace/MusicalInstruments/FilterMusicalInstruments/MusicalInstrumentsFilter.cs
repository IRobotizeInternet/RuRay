using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class MusicalInstrumentsFilter : BaseFilter, IMusicalInstrumentsFilter, IMusicalInstrumentsFilterOptions
    {
        public MusicalInstrumentsFilter(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public IGuitarsAndBassesFilterOptions FilterBy => throw new NotImplementedException();

        IMusicalInstrumentsFilterOptions IFilter<IMusicalInstrumentsFilterOptions>.FilterBy => throw new NotImplementedException();

        public void Category(GuitarsAndBassesCategory category)
        {
            throw new NotImplementedException();
        }

        public void Category(MusicalInstrumentsCategory category)
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
