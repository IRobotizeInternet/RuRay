using System.Threading.Tasks;
using RuRay.BLL.Contracts;
using RuRayFacebook.App.LoggedIn.Pages;

namespace RuRay.BLL
{
    public class ServiceHomeHeader : IServiceHomeHeader
    {
        public Task<bool> HomePageScrollDown()
        {
            var pageHome = new PageHome();
            //var dialog = pageHome.Header.RightMenu.EventTriggerButtonAccount.Click();
            //var accessibilityDialog = dialog.TriggerDisplayAndAccessibilityDialog.Click();
            //if (mode == Switch.OFF) return accessibilityDialog.RButtonCompactModeOff.Click();
            //return accessibilityDialog.RButtonCompactModeOn.Click();
            pageHome.Feed.FeedScroll.ScrollDownMore();
            return Task.FromResult(true);

        }

        public Task<bool> FacebookChangeVisualMode(Switch mode)
        {
            var pageHome = new PageHome();
            var dialog = pageHome.Header.RightMenu.EventTriggerButtonAccount.Click();
            var accessibilityDialog = dialog.TriggerDisplayAndAccessibilityDialog.Click();
            if (mode == Switch.ON)
            {
                accessibilityDialog.RButtonDarkModeOn.Click();
            }
            else
            {
                accessibilityDialog.RButtonDarkModeOff.Click();
            }

            pageHome.Header.RightMenu.EventTriggerButtonAccount.Click();
            return Task.FromResult(true);
        }

        public Task<bool> HomePageScrollUp()
        {
            var pageHome = new PageHome();
            pageHome.Feed.FeedScroll.ScrollUpMore();
            return Task.FromResult(true);

        }
    }
}
