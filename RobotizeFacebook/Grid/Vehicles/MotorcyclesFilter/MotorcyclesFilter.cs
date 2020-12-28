using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace RobotizeFacebook.Grid
{
    public class MotorcyclesFilter : BaseFilter, IMotorcyclesFilter, IMotorcyclesFilterOptions
    {
        public MotorcyclesFilter(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public IMotorcyclesFilterOptions FilterBy => throw new NotImplementedException();

        public IFilterOptions ItemCondition(ItemCondition vehicleType)
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
