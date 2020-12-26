using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Pages.LoggedIn.Home.HomeHeader;
using RobotizeLibrary.Controls.TriggerControls;
using RobotizeLibrary.Resources;


namespace RobotizeFacebook.Pages.LoggedIn.Home.MainSection.SubSections
{
    public class CreatePost
    {
        public RemoteWebDriver Driver;
        public WebDriverWait Wait;

        public CreatePost(RemoteWebDriver driver, WebDriverWait wait)
        {
            Driver = driver;
            Wait = wait;
        }

        public EventTriggerButton<DialogCreatePost> ButtonCreatePost => 
            new EventTriggerButton<DialogCreatePost>(Driver, Wait, By.XPath($"//span[contains(text(),'{ResCreatePost.WhatsOnYourMind}')]"));

        public EventTriggerButton<PageTimeline> ButtonTimeline =>
           new EventTriggerButton<PageTimeline>(Driver, Wait, By.XPath("//a[contains(@href, 'facebook') and contains(@aria-label,'Timeline')]"));

        public EventTriggerButton<DialogCreatePost> ButtonLiveVideo =>
            new EventTriggerButton<DialogCreatePost>(Driver, Wait, By.XPath($"//span[text()='{ResCreatePost.LiveVideo}']/../../.."));

        public EventTriggerButton<DialogCreatePost> ButtonPhotoOrVideo =>
            new EventTriggerButton<DialogCreatePost>(Driver, Wait, By.XPath($"//span[text()='{ResCreatePost.PhotoOrVideo}']/../../.."));

        public EventTriggerButton<DialogCreatePost> ButtonFeelingOrActivity =>
            new EventTriggerButton<DialogCreatePost>(Driver, Wait, By.XPath($"//span[text()='{ResCreatePost.FeelingOrActivity}']/../../.."));

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
