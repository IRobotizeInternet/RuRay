﻿using System;
using OpenQA.Selenium;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class PageAdPreferences : BasePage
    {
        public override string PageUrl => "/adpreferences/advertisers/?entry_product=account_settings_menu";

        public override By ByForPage => throw new NotImplementedException();

        public PageAdPreferences()
        {
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
