using OpenQA.Selenium.Remote;
using System;

namespace RuRayFacebook.App.LoggedIn
{
    public class KitchenCabinetsFilter : BaseFilter, IKitchenCabinetsFilter, IKitchenCabinetsFilterOptions
    {
        public KitchenCabinetsFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public IKitchenCabinetsFilterOptions FilterBy => throw new NotImplementedException();

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
