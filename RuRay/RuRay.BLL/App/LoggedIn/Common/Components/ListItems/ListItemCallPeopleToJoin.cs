﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class ListItemCallPeopleToJoin : BaseDiv, IListItem
    {
        public int XIndex { get; set; }
        public int YIndex { get; set; }

        public ListItemCallPeopleToJoin(
            string baseXPath, 
            int xIndex = 1, 
            int yIndex = 1)
        {
            XIndex = xIndex;
            YIndex = yIndex;
            BaseXPath = baseXPath ?? $"//div[text()='{ResHomePage.SUGGESTED}']/following-sibling::div";
        }
    }
}
