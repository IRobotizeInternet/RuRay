using OpenQA.Selenium;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PageCreateAStory" />.
    /// </summary>
    public class PageCreateAStory : BasePage
    {
        /// <summary>
        /// Gets the PageUrl.
        /// </summary>
        public override string PageUrl => "/stories/create";

        /// <summary>
        /// Gets the DialogButtonStoryPrivacy.
        /// </summary>
        public EventTriggerDiv<DialogStoryPrivacy> DialogButtonStoryPrivacy => new EventTriggerDiv<DialogStoryPrivacy>(Driver, By.XPath("//div[@class='j83agx80 pfnyh3mw']"));

        /// <summary>
        /// Gets the ByForPage.
        /// </summary>
        public override By ByForPage => throw new System.NotImplementedException();

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
