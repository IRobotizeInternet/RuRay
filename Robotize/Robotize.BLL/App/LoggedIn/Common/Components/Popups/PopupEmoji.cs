using OpenQA.Selenium;
using Robotize.BLL.Resources;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PopupEmoji : BasePopup
    {
        public PopupEmoji()
        {
            
        }

        protected override By ByForDialog => By.XPath($"//div[@role='dialog']//h3[text()='{ResCreatePost.RecentlyUsed}']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
