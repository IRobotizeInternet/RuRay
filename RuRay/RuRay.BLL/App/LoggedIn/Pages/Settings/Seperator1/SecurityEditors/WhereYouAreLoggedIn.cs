﻿
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls.TriggerControls;
using RuRay.BLL.Resources;
using System;

namespace RuRayFacebook.App.LoggedIn.Pages.SecurityEditors
{
    public class WhereYouAreLoggedIn : BaseEditor
    {
        public WhereYouAreLoggedIn(RemoteWebDriver driver) : base()
        {
            
        }

        public Hyperlink<DialogSeeMore> LinkSeeMore => new Hyperlink<DialogSeeMore>(Driver, By.XPath($"//span[text()={ResMiscellaneous.SeeMore}]"));
        public Label LabelLogOutOfAllSessions => new Label(Driver, By.XPath($"//span[text()={ResMiscellaneous.LogOutOfAllSessions}]"));
    }

    public class DialogSeeMore : BaseDialog
    {
        public DialogSeeMore()
        {
        }

        protected override By ByForDialog => throw new NotImplementedException();

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
