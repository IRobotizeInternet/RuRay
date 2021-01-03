using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PianosAndKeyboardsFilter : BaseFilter, IPianosAndKeyboardsFilter, IPianosAndKeyboardsFilterOptions
    {
        public PianosAndKeyboardsFilter(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public IPianosAndKeyboardsFilterOptions FilterBy => throw new NotImplementedException();

        public void Category(PianosAndKeyboardsCategory category)
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
