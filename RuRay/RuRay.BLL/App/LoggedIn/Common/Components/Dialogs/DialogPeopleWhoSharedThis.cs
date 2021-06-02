﻿using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class DialogPeopleWhoSharedThis : BaseDialog
    {
        public DialogPeopleWhoSharedThis()
        {

        }

        public ScrollControl<ListItemPeopleWhoSharedThis> ScrollPeopleWhoSharedThis =>
           new ScrollControl<ListItemPeopleWhoSharedThis>(
               Driver,
               $"//div[@aria-label='{ResHomePage.PeopleWhoSharedThis}']/div[3]/div/div/div[descendant-or-self::object]",
               scrollXPath: $"//div[@aria-label='{ResHomePage.PeopleWhoSharedThis}']/div[3]/div");

        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePage.PeopleWhoSharedThis}']/div[3]");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}