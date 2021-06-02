using System;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayLibrary.Extensions;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="MenuItemsCommon" />.
    /// </summary>
    public class MenuItemsCommon : MenuItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItemsCommon"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        public MenuItemsCommon(string baseXPath)
        {
            BaseXPath = baseXPath;
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the EventTriggerButtonGoLiveNow.
        /// </summary>
        public EventTriggerButton<PageLiveProducer> EventTriggerButtonGoLiveNow =>
            new EventTriggerButton<PageLiveProducer>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.GoLiveNow}']"));

        /// <summary>
        /// Gets the EventTriggerButtonGoLiveWithOthers.
        /// </summary>
        public EventTriggerButton<FeedGoLiveWithOthers> EventTriggerButtonGoLiveWithOthers =>
            new EventTriggerButton<FeedGoLiveWithOthers>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.GoLiveWithOthers}']"));

        /// <summary>
        /// Gets the EventTriggerButtonScheduleLiveVideoEvent.
        /// </summary>
        public EventTriggerButton<FeedScheduleLiveVideoEvent> EventTriggerButtonScheduleLiveVideoEvent =>
            new EventTriggerButton<FeedScheduleLiveVideoEvent>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.ScheduleLiveVideoEvent}']"));

        /// <summary>
        /// Gets the EventTriggerButtonUpcomingLiveVideosAndEvents.
        /// </summary>
        public EventTriggerButton<FeedUpcomingLiveVideosAndEvents> EventTriggerButtonUpcomingLiveVideosAndEvents =>
            new EventTriggerButton<FeedUpcomingLiveVideosAndEvents>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.UpcomingLiveVideosAndEvents}']"));

        /// <summary>
        /// Gets the DropdownWhereToPost.
        /// </summary>
        public DropdownWhereToPost DropdownWhereToPost =>
            new DropdownWhereToPost(Driver, new ExtendBy($"{BaseXPath}//div[@role='combobox']"));
    }
}
