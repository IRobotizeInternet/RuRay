using System.Threading.Tasks;

namespace RuRay.BLL.Contracts
{
    /// <summary>
    /// Defines the <see cref="IServiceNavigation" />.
    /// </summary>
    public interface IServiceNavigation
    {
        /// <summary>
        /// The NavigateActivityLog.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateActivityLog();

        /// <summary>
        /// The NavigateAdCenter.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateAdCenter();

        /// <summary>
        /// The NavigateAdPreferences.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateAdPreferences();

        /// <summary>
        /// The NavigateArchived.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateArchived();

        /// <summary>
        /// The NavigateCampus.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateCampus();

        /// <summary>
        /// The NavigateChats.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateChats();

        /// <summary>
        /// The NavigateEvents.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateEvents();

        /// <summary>
        /// The NavigateFacebookPay.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateFacebookPay();

        /// <summary>
        /// The NavigateFriends.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateFriends();

        /// <summary>
        /// The NavigateFundraisers.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateFundraisers();

        /// <summary>
        /// The NavigateGames.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateGames();

        /// <summary>
        /// The NavigateGroup.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateGroup();

        /// <summary>
        /// The NavigateGroupCall.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateGroupCall();

        /// <summary>
        /// The NavigateHome.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateHome();

        /// <summary>
        /// The NavigateJobs.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateJobs();

        /// <summary>
        /// The NavigateLiveProducer.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateLiveProducer();

        /// <summary>
        /// The NavigateMarketplace.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateMarketplace();

        /// <summary>
        /// The NavigateMemories.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateMemories();

        /// <summary>
        /// The NavigateMessages.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateMessages();

        /// <summary>
        /// The NavigateMessengerKids.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateMessengerKids();

        /// <summary>
        /// The NavigateMovies.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateMovies();

        /// <summary>
        /// The NavigateNotifications.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateNotifications();

        /// <summary>
        /// The NavigateOffers.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateOffers();

        /// <summary>
        /// The NavigatePages.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigatePages();

        /// <summary>
        /// The NavigatePrivacyCheckup.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigatePrivacyCheckup();

        /// <summary>
        /// The NavigatePromote.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigatePromote();

        /// <summary>
        /// The NavigateSaved.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateSaved();

        /// <summary>
        /// The NavigateSettings.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateSettings();

        /// <summary>
        /// The NavigateStories.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateStories();

        /// <summary>
        /// The NavigateSupportInbox.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateSupportInbox();

        /// <summary>
        /// The NavigateTrash.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateTrash();

        /// <summary>
        /// The NavigateUserTimeline.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateUserTimeline();

        /// <summary>
        /// The NavigateViewPage.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateViewPage();

        /// <summary>
        /// The NavigateWatch.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateWatch();

        /// <summary>
        /// The NavigateWeather.
        /// </summary>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> NavigateWeather();
    }
}
