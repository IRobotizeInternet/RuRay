using System.Threading.Tasks;
using RuRay.BLL.Contracts;
using RuRayFacebook.App.LoggedIn.Pages;

namespace RuRay.BLL
{
    /// <summary>
    /// Defines the <see cref="ServiceHomeHeader" />.
    /// </summary>
    public class ServiceHomeHeader : IServiceHomeHeader
    {
        /// <summary>
        /// The HomePageScrollDown.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
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

        /// <summary>
        /// The FacebookChangeVisualMode.
        /// </summary>
        /// <param name="mode">The mode<see cref="Switch"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
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

        /// <summary>
        /// The HomePageScrollUp.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> HomePageScrollUp()
        {
            var pageHome = new PageHome();
            pageHome.Feed.FeedScroll.ScrollUpMore();
            return Task.FromResult(true);
        }
    }
}
