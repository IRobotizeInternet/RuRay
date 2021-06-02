using System.Threading.Tasks;
using RuRay.BLL.Contracts;
using RuRayFacebook.App.LoggedIn.Pages;

namespace RuRay.BLL.Services
{
    /// <summary>
    /// Defines the <see cref="ServiceNavigation" />.
    /// </summary>
    public class ServiceNavigation : IServiceNavigation
    {
        /// <summary>
        /// The NavigateActivityLog.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateActivityLog()
        {
            new PageActivityLog().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateAdCenter.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateAdCenter()
        {
            new PageAdCenter().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateAdPreferences.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateAdPreferences()
        {
            new PageAdPreferences().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateArchived.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateArchived()
        {
            new PageArchived().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateCampus.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateCampus()
        {
            new PageCampus().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateChats.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateChats()
        {
            new PageChats().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateEvents.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateEvents()
        {
            new PageEvents().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateFacebookPay.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateFacebookPay()
        {
            new PageFacebookPay().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateFriends.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateFriends()
        {
            new PageFriends().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateFundraisers.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateFundraisers()
        {
            new PageFundraisers().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateGames.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateGames()
        {
            new PageGames().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateGroup.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateGroup()
        {
            new PageGroup().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateGroupCall.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateGroupCall()
        {
            new PageGroupCall().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateHome.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateHome()
        {
            new PageHome().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateJobs.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateJobs()
        {
            new PageJobs().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateLiveProducer.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateLiveProducer()
        {
            new PageLiveProducer().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateMarketplace.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateMarketplace()
        {
            new PageMarketplace().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateMemories.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateMemories()
        {
            new PageMemories().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateMessages.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateMessages()
        {
            new PageMessages().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateMessengerKids.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateMessengerKids()
        {
            new PageMessengerKids().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateMovies.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateMovies()
        {
            new PageMovies().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateNotifications.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateNotifications()
        {
            new PageNotifications().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateOffers.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateOffers()
        {
            new PageOffers().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigatePages.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigatePages()
        {
            new PagePages().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigatePrivacyCheckup.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigatePrivacyCheckup()
        {
            new PagePrivacyCheckup().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigatePromote.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigatePromote()
        {
            new PagePromote().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateSaved.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateSaved()
        {
            new PageSaved().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateSettings.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateSettings()
        {
            new PageSettings().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateStories.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateStories()
        {
            new PageStories().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateSupportInbox.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateSupportInbox()
        {
            new PageSupportInbox().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateTrash.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateTrash()
        {
            new PageTrash().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateUserTimeline.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateUserTimeline()
        {
            new PageUserTimeline().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateViewPage.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateViewPage()
        {
            new PageViewPage().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateWatch.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateWatch()
        {
            new PageWatch().GoToPage(); return Task.FromResult(true);
        }

        /// <summary>
        /// The NavigateWeather.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> NavigateWeather()
        {
            new PageWeather().GoToPage(); return Task.FromResult(true);
        }
    }
}
