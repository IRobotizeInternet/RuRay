using System;
using OpenQA.Selenium;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PageCampus" />.
    /// </summary>
    public class PageCampus : BasePage
    {
        /// <summary>
        /// Gets the PageUrl.
        /// </summary>
        public override string PageUrl => "/campus";

        /// <summary>
        /// Gets the ByForPage.
        /// </summary>
        public override By ByForPage => throw new NotImplementedException();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageCampus"/> class.
        /// </summary>
        public PageCampus()
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
