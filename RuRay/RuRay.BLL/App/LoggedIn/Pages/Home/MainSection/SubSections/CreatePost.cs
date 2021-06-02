using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="CreatePost" />.
    /// </summary>
    public class CreatePost : BaseDriver
    {
        /// <summary>
        /// Gets the ButtonCreatePost.
        /// </summary>
        public EventTriggerButton<DialogCreatePost> ButtonCreatePost =>
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"//span[contains(text(),'{ResCreatePost.WhatsOnYourMind}')]"));

        /// <summary>
        /// Gets the ButtonTimeline.
        /// </summary>
        public EventTriggerButton<PageUserTimeline> ButtonTimeline =>
           new EventTriggerButton<PageUserTimeline>(Driver, By.XPath("//a[contains(@href, 'facebook') and contains(@aria-label,'Timeline')]"));

        /// <summary>
        /// Gets the ButtonLiveVideo.
        /// </summary>
        public EventTriggerButton<PageLiveProducer> ButtonLiveVideo =>
            new EventTriggerButton<PageLiveProducer>(Driver, By.XPath($"//span[text()='{ResCreatePost.LiveVideo}']"));

        /// <summary>
        /// Gets the ButtonPhotoOrVideo.
        /// </summary>
        public EventTriggerButton<DialogCreatePost> ButtonPhotoOrVideo =>
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"//span[text()='{ResCreatePost.PhotoOrVideo}']"));

        /// <summary>
        /// Gets the ButtonFeelingOrActivity.
        /// </summary>
        public EventTriggerButton<DialogCreatePost> ButtonFeelingOrActivity =>
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"//span[text()='{ResCreatePost.FeelingOrActivity}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            var dialog = ButtonCreatePost.Click();
            ButtonLiveVideo.Click();
            ButtonPhotoOrVideo.Click();
            ButtonFeelingOrActivity.Click();
            ButtonTimeline.Click();
        }
    }
}
