﻿using System;
using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn
{
    public class UniformsAndWorkClothingFilter : BaseFilter, IUniformsAndWorkClothingFilter, IUniformsAndWorkClothingFilterOptions
    {
        public UniformsAndWorkClothingFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        public IUniformsAndWorkClothingFilterOptions FilterBy => throw new NotImplementedException();

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
