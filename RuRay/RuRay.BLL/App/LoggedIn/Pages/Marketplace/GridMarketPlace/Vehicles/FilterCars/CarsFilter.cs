﻿using System;
using System.Collections.Generic;
using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn
{
    public class CarsFilter : BaseFilter, ICarsFilter, ICarsFilterOptions
    {
        public CarsFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        ICarsFilterOptions IFilter<ICarsFilterOptions>.FilterBy => throw new NotImplementedException();

        public void Category(CarCategory categoryType)
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
