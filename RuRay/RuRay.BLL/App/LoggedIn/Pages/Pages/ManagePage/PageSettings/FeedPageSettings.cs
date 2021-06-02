﻿using System;
using OpenQA.Selenium;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class FeedPageSettings : Feed
    {
        public override string FeedUrl => throw new NotImplementedException();

        public RadioButton RadioButtonGeneralSettings => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[text()='General Settings']/parent::div/parent::div//div[text()='Off']"));

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
