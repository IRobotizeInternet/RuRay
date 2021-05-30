﻿using OpenQA.Selenium;
using RuRay.BLL.Resources;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class DialogMenu : BaseDialog
    {
        public DialogMenu()
        {
        }

        protected override By ByForDialog => By.XPath($"//span[text()='{ResMiscellaneous.Delete}']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
