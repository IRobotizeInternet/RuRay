using OpenQA.Selenium;
using RobotizeToolbox.Controls.TriggerControls;

namespace RobotizeFacebook.App.LoggedIn.Stories.Create
{
    public class DialogCreateAStory : PageBase
    {
        public override string PageUrl => "/stories/create";

        public EventTriggerDiv<DialogStoryPrivacy> DialogButtonStoryPrivacy => new EventTriggerDiv<DialogStoryPrivacy>(Driver, By.XPath("//div[@class='j83agx80 pfnyh3mw']"));

        public override By ByForPage => throw new System.NotImplementedException();
    }
}
