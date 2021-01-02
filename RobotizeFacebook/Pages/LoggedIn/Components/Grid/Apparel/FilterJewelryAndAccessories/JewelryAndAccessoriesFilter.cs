using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class JewelryAndAccessoriesFilter : BaseFilter, IJewelryAndAccessoriesFilter, IJewelryAndAccessoriesFilterOptions
    {
        public JewelryAndAccessoriesFilter(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public IJewelryAndAccessoriesFilterOptions FilterBy => throw new NotImplementedException();

        public IApplyFilter Brand(BrandJewelryAndAccessories bodyStyle)
        {
            throw new NotImplementedException();
        }

        public void Category(JewelryAndAccessoriesCategory categoryType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public IFilterOptions ItemCondition(ItemCondition vehicleType)
        {
            throw new NotImplementedException();
        }

        public IFilterOptions Material(Material material)
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
