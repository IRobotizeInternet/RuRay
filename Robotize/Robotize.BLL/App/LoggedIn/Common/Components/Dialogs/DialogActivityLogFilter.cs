﻿using OpenQA.Selenium;
using RuRayFacebook.App.LoggedIn.Enum;
using RuRay.BLL.Resources;
using RuRayLibrary.Extensions;
using RuRayToolbox.Controls;
namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class DialogActivityLogFilter : BaseDialog
    {
        public DialogActivityLogFilter()
        {
            BaseXPath = $"//div[@role='dialog'][@aria-label='{ResMiscellaneous.Filter}']";
        }

        protected override By ByForDialog => By.XPath(BaseXPath);

        public DropdownYear DropdownForYear =>
            new DropdownYear(Driver, new ExtendBy("//div[@aria-haspopup='listbox'][@role='combobox']"));

        public RadioButton GetFilterCategoryButton(FilterCategory category)
        {
            var rButton = new RadioButton(Driver, By.XPath($"{BaseXPath}//span[contains(text(), {category})]"));
            // TODO: Fix the below function.
            //rButton.ScrollToElement();
            return rButton;
        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        public EventTriggerButton<PageActivityLog> ButtonActivityLog => 
            new EventTriggerButton<PageActivityLog>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResMiscellaneous.ClearAll}')]"));
    }
}
