using System;
using OpenQA.Selenium;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PageEvents" />.
    /// </summary>
    public class PageEvents : BasePage
    {
        /// <summary>
        /// Gets the PageUrl.
        /// </summary>
        public override string PageUrl => "/events";

        /// <summary>
        /// Gets the ByForPage.
        /// </summary>
        public override By ByForPage => throw new NotImplementedException();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageEvents"/> class.
        /// </summary>
        public PageEvents()
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
