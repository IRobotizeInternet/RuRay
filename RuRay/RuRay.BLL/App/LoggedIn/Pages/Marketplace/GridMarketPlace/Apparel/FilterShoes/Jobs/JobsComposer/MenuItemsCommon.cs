﻿using System;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayLibrary.Extensions;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class MenuItemsCommon : MenuItems
    {
        public MenuItemsCommon(string baseXPath)
        {
            BaseXPath = baseXPath;
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }

        public EventTriggerButton<PageLiveProducer> EventTriggerButtonGoLiveNow =>
            new EventTriggerButton<PageLiveProducer>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.GoLiveNow}']"));
        public EventTriggerButton<FeedGoLiveWithOthers> EventTriggerButtonGoLiveWithOthers =>
            new EventTriggerButton<FeedGoLiveWithOthers>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.GoLiveWithOthers}']"));
        public EventTriggerButton<FeedScheduleLiveVideoEvent> EventTriggerButtonScheduleLiveVideoEvent =>
            new EventTriggerButton<FeedScheduleLiveVideoEvent>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.ScheduleLiveVideoEvent}']"));
        public EventTriggerButton<FeedUpcomingLiveVideosAndEvents> EventTriggerButtonUpcomingLiveVideosAndEvents =>
            new EventTriggerButton<FeedUpcomingLiveVideosAndEvents>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.UpcomingLiveVideosAndEvents}']"));

        public DropdownWhereToPost DropdownWhereToPost =>
            new DropdownWhereToPost(Driver, new ExtendBy($"{BaseXPath}//div[@role='combobox']"));

    }
}
