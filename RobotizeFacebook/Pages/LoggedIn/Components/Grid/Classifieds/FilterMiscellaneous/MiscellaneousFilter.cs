using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class MiscellaneousFilter : BaseFilter, IMiscellaneousFilter, IMiscellaneousFilterOptions
    {
        public MiscellaneousFilter(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public IMiscellaneousFilterOptions FilterBy => throw new NotImplementedException();

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
