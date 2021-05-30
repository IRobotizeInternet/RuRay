﻿using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class MenuItemsWatch : MenuItems
    {
        public EventTriggerButton<PageWatch> EventTriggerButtonHome =>
            new EventTriggerButton<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Home}]"));
        public EventTriggerButton<PageWatch> EventTriggerButtonShows =>
            new EventTriggerButton<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Shows}]"));
        public EventTriggerButton<PageWatch> EventTriggerButtonLive =>
            new EventTriggerButton<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Live}]"));
        public EventTriggerButton<PageWatch> EventTriggerButtonSavedVideos =>
            new EventTriggerButton<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.SavedVideos}]"));

        public Hyperlink<PageWatch> HyperlinkButtonManage =>
            new Hyperlink<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Manage}]"));
        public Hyperlink<PageWatch> HyperlinkButtonLatestVideos =>
            new Hyperlink<PageWatch>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.LatestVideos}]"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
