﻿using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class BabyClothingFilter : BaseFilter, IBabyClothingFilter, IBabyClothingFilterOptions
    {
        public BabyClothingFilter(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public IBabyClothingFilterOptions FilterBy => throw new System.NotImplementedException();

        public IApplyFilter BabyAndToddlerSize(BabyAndToddlerSize bodyStyle)
        {
            throw new System.NotImplementedException();
        }

        public IFilterOptions ItemCondition(ItemCondition condition)
        {
            throw new System.NotImplementedException();
        }

        public IApplyFilter Price(double? min = null, double? max = null)
        {
            throw new System.NotImplementedException();
        }

        protected override void ClickFilterButton()
        {
            throw new System.NotImplementedException();
        }

        protected override void SetFilterCriteria()
        {
            throw new System.NotImplementedException();
        }
    }
}
