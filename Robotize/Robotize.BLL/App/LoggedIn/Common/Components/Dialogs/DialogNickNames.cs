﻿using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class DialogNickNames : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePage.Nicknames}'][@role='dialog']");

        public DialogNickNames()
        {
            BaseXPath = $"//div[@aria-label='{ResHomePage.Nicknames}'][@role='dialog']";
        }

        public ScrollControl<ListItemNickname> ScrollControlNicknames =>
            new ScrollControl<ListItemNickname>(Driver,
                $"//div[@aria-label='{ResHomePage.Nicknames}'][@role='dialog']/div[3]/div/div/div/div/div[./div]",
                "//div[@aria-label='{ResHomePage.Nicknames}'][@role='dialog']/div[3]/div/div/div/div");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
