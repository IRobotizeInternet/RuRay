using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;

namespace RobotizeFacebook.App.LoggedIn
{
    public class CellPhonesFilter : BaseFilter, ICellPhonesFilter, ICellPhonesFilterOptions
    {
        public CellPhonesFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public ICellPhonesFilterOptions FilterBy => throw new NotImplementedException();

        public IApplyFilter Brand(BrandCamera bodyStyle)
        {
            throw new NotImplementedException();
        }

        public void Category(CellPhonesCategory category)
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

        public IApplyFilter Network(Network network)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter Price(double? min = null, double? max = null)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter ProductLine(ProductLine productLine)
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
