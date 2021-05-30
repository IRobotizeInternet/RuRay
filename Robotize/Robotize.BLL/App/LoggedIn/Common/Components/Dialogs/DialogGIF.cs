﻿using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class DialogGIF : BaseDialog
    {
        public DialogGIF() 
        {
        }

        //public ScrollControl ScrollGIF =>
        //   new ScrollControl(Driver, $"//form[descendant::input[@aria-label='{ResCreatePost.GIFSearch}']]//img[@alt='GIF']");//form[@method='POST']/parent::div[@role='dialog']/form/div/div[2]/div/div[2]/div/div[2]/div/div/div"));

        protected override By ByForDialog => By.XPath($"//form[@method='POST']/parent::div[@role='dialog']//span[text()='{ResCreatePost.ChooseAGIF}']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        public sealed class CheckinCombox : Combobox
        {
            public CheckinCombox(RemoteWebDriver driver, By byForElement) : base(driver, byForElement)
            {
                BaseXPath = $"//form[@method='POST']/parent::div[@role='dialog']";
                SearchBoxXPath = $"{BaseXPath}//input[contains(@aria-label,'{ResCreatePost.GIFSearch}')][@type='text']";
                SearchItemsXPath = $"{BaseXPath}//div[@aria-label='{ResCreatePost.GIF}']";
            }
        }
    }
}