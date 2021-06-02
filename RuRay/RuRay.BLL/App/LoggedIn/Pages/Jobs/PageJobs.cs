using System;
using OpenQA.Selenium;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PageJobs" />.
    /// </summary>
    public class PageJobs : BasePage
    {
        /// <summary>
        /// Gets the PageUrl.
        /// </summary>
        public override string PageUrl => "/jobs/?source=bookmark";

        /// <summary>
        /// Gets the ByForPage.
        /// </summary>
        public override By ByForPage => throw new NotImplementedException();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageJobs"/> class.
        /// </summary>
        public PageJobs()
        {
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
