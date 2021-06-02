using System;
using OpenQA.Selenium;
using RuRay.BLL.Resources;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PageFriends" />.
    /// </summary>
    public class PageFriends : BasePage
    {
        /// <summary>
        /// Gets the PageUrl.
        /// </summary>
        public override string PageUrl => "/friends";

        /// <summary>
        /// Gets the ByForPage.
        /// </summary>
        public override By ByForPage => By.XPath($"//h1[text()='{ResCreatePost.Friends}']");

        /// <summary>
        /// Initializes a new instance of the <see cref="PageFriends"/> class.
        /// </summary>
        public PageFriends()
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
