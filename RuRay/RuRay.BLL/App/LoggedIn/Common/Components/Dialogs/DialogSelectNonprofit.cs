﻿using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class DialogSelectNonprofit : BaseDialog
    {
        public DialogSelectNonprofit()
        {
        }

        protected override By ByForDialog => By.XPath($"//form[@method='POST']/parent::div[@role='dialog']//span[text()='{ResCreatePost.SelectNonprofit}']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        public sealed class CheckinCombox : Combobox
        {
            public CheckinCombox(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
            {
                BaseXPath = $"//form[@method='POST']/parent::div[@role='dialog']";
                SearchBoxXPath = $"{BaseXPath}//input[contains(@aria-label,'{ResCreatePost.SearchForANonprofitToSupport}')][@type='text']";
                SearchItemsXPath = $"{BaseXPath}//ul//li";
            }
        }
    }
}