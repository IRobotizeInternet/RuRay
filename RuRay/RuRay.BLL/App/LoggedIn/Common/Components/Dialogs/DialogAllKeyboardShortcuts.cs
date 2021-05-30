﻿using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class DialogAllKeyboardShortcuts : BaseDialog
    {
        public DialogAllKeyboardShortcuts()
        {
        }

        private readonly string _baseXPath = $"//span[text()='{ResAccount.AllKeyboardShortcuts}']/../../../../..";
        protected override By ByForDialog => By.XPath(_baseXPath);

        public Checkbox SingleCharacterKeyboardShortCut => new Checkbox(Driver, By.XPath($"{_baseXPath}//input[@type='checkbox']"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
