using System;
using OpenQA.Selenium;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PageUserTimeline" />.
    /// </summary>
    public class PageUserTimeline : BasePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageUserTimeline"/> class.
        /// </summary>
        public PageUserTimeline()
        {
        }

        /// <summary>
        /// Gets the PageUrl.
        /// </summary>
        public override string PageUrl => @"\";

        /// <summary>
        /// Gets the ByForPage.
        /// </summary>
        public override By ByForPage => throw new NotImplementedException();

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
