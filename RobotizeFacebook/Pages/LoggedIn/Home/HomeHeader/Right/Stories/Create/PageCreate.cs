using OpenQA.Selenium;
using RobotizeLibrary.Controls.TriggerControls;

namespace RobotizeFacebook.Pages.LoggedIn.Stories.Create
{
    public class PageCreate : PageBase
    {
        public override string PageUrl => "/stories/create";

        public EventTriggerDiv<DialogStoryPrivacy> DialogButtonStoryPrivacy => new EventTriggerDiv<DialogStoryPrivacy>(Driver, Wait, By.XPath("//div[@class='j83agx80 pfnyh3mw']"));
    }
}
