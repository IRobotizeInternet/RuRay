using System;
using OpenQA.Selenium;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PageMessengerKids" />.
    /// </summary>
    public class PageMessengerKids : BasePage
    {
        /// <summary>
        /// Gets the PageUrl.
        /// </summary>
        public override string PageUrl => "/messenger_kids";

        /// <summary>
        /// Gets the ByForPage.
        /// </summary>
        public override By ByForPage => throw new NotImplementedException();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageMessengerKids"/> class.
        /// </summary>
        public PageMessengerKids()
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
