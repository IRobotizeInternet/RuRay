using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class PatioFurnitureFilter : BaseFilter, IPatioFurnitureFilter, IPatioFurnitureFilterOptions
    {
        public PatioFurnitureFilter(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public IPatioFurnitureFilterOptions FilterBy => throw new NotImplementedException();

        public void Category(PatioFurnitureCategory category)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter DecorStyle(StyleDecorStyle model)
        {
            throw new NotImplementedException();
        }

        public IApplyFilter Finish(Finish model)
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
