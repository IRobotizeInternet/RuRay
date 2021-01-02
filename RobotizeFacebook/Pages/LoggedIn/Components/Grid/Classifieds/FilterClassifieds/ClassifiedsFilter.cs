﻿using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class ClassifiedsFilter : BaseFilter, IClassifiedsFilter, IClassifiedsFilterOptions
    {
        public ClassifiedsFilter(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public ITownhousesForRentFilterOptions FilterBy => throw new NotImplementedException();

        IClassifiedsFilterOptions IFilter<IClassifiedsFilterOptions>.FilterBy => throw new NotImplementedException();

        public void Category(ClassifiedCategory categoryType)
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
