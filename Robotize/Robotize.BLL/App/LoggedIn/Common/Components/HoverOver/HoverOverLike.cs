using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class HoverOverLike : BaseHoverOver
    {
        public HoverOverLike()
        {
        }
        public string BaseXPath = "//div[@data-pagelet='page']/following-sibling::div/div//div";
        public Button ButtonReactionLike => new Button(Driver, By.XPath($"{BaseXPath}[contains(@aria-label,'{ResHomePage.Like}')]"));
        public Button ButtonReactionLove => new Button(Driver, By.XPath($"{BaseXPath}[contains(@aria-label,'{ResHomePage.Love}')]"));
        public Button ButtonReactionCare => new Button(Driver, By.XPath($"{BaseXPath}[contains(@aria-label,'{ResHomePage.Care}')]"));
        public Button ButtonReactionHaha => new Button(Driver, By.XPath($"{BaseXPath}[contains(@aria-label,'{ResHomePage.Haha}')]"));
        public Button ButtonReactionWow => new Button(Driver, By.XPath($"{BaseXPath}[contains(@aria-label,'{ResHomePage.Wow}')]"));
        public Button ButtonReactionSad => new Button(Driver, By.XPath($"{BaseXPath}[contains(@aria-label,'{ResHomePage.Sad}')]"));
        public Button ButtonReactionAngry => new Button(Driver, By.XPath($"{BaseXPath}[contains(@aria-label,'{ResHomePage.Angry}')]"));
    }
}
