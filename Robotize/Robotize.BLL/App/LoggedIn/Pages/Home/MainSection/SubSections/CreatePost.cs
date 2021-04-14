using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class CreatePost : BaseDriver
    {
        public EventTriggerButton<DialogCreatePost> ButtonCreatePost => 
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"//span[contains(text(),'{ResCreatePost.WhatsOnYourMind}')]"));

        public EventTriggerButton<PageUserTimeline> ButtonTimeline =>
           new EventTriggerButton<PageUserTimeline>(Driver, By.XPath("//a[contains(@href, 'facebook') and contains(@aria-label,'Timeline')]"));

        public EventTriggerButton<PageLiveProducer> ButtonLiveVideo =>
            new EventTriggerButton<PageLiveProducer>(Driver, By.XPath($"//span[text()='{ResCreatePost.LiveVideo}']"));

        public EventTriggerButton<DialogCreatePost> ButtonPhotoOrVideo =>
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"//span[text()='{ResCreatePost.PhotoOrVideo}']"));

        public EventTriggerButton<DialogCreatePost> ButtonFeelingOrActivity =>
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"//span[text()='{ResCreatePost.FeelingOrActivity}']"));

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
