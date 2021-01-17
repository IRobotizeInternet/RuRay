using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.Pages
{
    public class CreatePost
    {
        public RemoteWebDriver Driver;

        public CreatePost(RemoteWebDriver driver)
        {
            Driver = driver;
        }

        public EventTriggerButton<DialogCreatePost> ButtonCreatePost => 
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"//span[contains(text(),'{ResCreatePost.WhatsOnYourMind}')]"));

        public EventTriggerButton<PageTimeline> ButtonTimeline =>
           new EventTriggerButton<PageTimeline>(Driver, By.XPath("//a[contains(@href, 'facebook') and contains(@aria-label,'Timeline')]"));

        public EventTriggerButton<DialogCreatePost> ButtonLiveVideo =>
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"//span[text()='{ResCreatePost.LiveVideo}']/../../.."));

        public EventTriggerButton<DialogCreatePost> ButtonPhotoOrVideo =>
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"//span[text()='{ResCreatePost.PhotoOrVideo}']/../../.."));

        public EventTriggerButton<DialogCreatePost> ButtonFeelingOrActivity =>
            new EventTriggerButton<DialogCreatePost>(Driver, By.XPath($"//span[text()='{ResCreatePost.FeelingOrActivity}']/../../.."));

        public void RunConformance()
        {
            var dialog = ButtonCreatePost.Click();
            ButtonLiveVideo.Click();
            ButtonPhotoOrVideo.Click();
            ButtonFeelingOrActivity.Click();
            ButtonTimeline.Click();
        }
    }
}
