using System;
using OpenQA.Selenium;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PageUpcomingEvent" />.
    /// </summary>
    public class PageUpcomingEvent : BasePage
    {
        /// <summary>
        /// Gets the PageUrl.
        /// </summary>
        public override string PageUrl => "{0}/";

        /// <summary>
        /// Gets the ByForPage.
        /// </summary>
        public override By ByForPage => throw new NotImplementedException();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageUpcomingEvent"/> class.
        /// </summary>
        public PageUpcomingEvent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageUpcomingEvent"/> class.
        /// </summary>
        /// <param name="eventUrl">The eventUrl<see cref="string"/>.</param>
        public PageUpcomingEvent(string eventUrl)
        {
            GoToPage(string.Format(PageUrl, eventUrl));
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
