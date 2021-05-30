﻿using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class ListItemNickname : BaseDiv, IListItem
    {
        public int XIndex { get; set; }
        public int YIndex { get; set; }

        public Button ButtonEdit => new Button(Driver, By.XPath($"{BaseXPath}[{XIndex}]"));

        public TextBox TextBoxNewNickNake => new TextBox(Driver, By.XPath($"{BaseXPath}[{XIndex}]//input"));

        public ListItemNickname(string baseXPath)
        {
            BaseXPath = baseXPath ?? $"//div[@aria-label='{ResHomePage.Nicknames}'][@role='dialog']/div[3]/div/div/div/div/div[./div][{XIndex}]";
        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
