using System.Threading.Tasks;

namespace RuRay.BLL.Contracts
{
    public interface IServiceNavigation
    {
        Task<bool> NavigateActivityLog();
        Task<bool> NavigateAdCenter();
        Task<bool> NavigateAdPreferences();
        Task<bool> NavigateArchived();
        Task<bool> NavigateCampus();
        Task<bool> NavigateChats();
        Task<bool> NavigateEvents();
        Task<bool> NavigateFacebookPay();
        Task<bool> NavigateFriends();
        Task<bool> NavigateFundraisers();
        Task<bool> NavigateGames();
        Task<bool> NavigateGroup();
        Task<bool> NavigateGroupCall();
        Task<bool> NavigateHome();
        Task<bool> NavigateJobs();
        Task<bool> NavigateLiveProducer();
        Task<bool> NavigateMarketplace();
        Task<bool> NavigateMemories();
        Task<bool> NavigateMessages();
        Task<bool> NavigateMessengerKids();
        Task<bool> NavigateMovies();
        Task<bool> NavigateNotifications();
        Task<bool> NavigateOffers();
        Task<bool> NavigatePages();
        Task<bool> NavigatePrivacyCheckup();
        Task<bool> NavigatePromote();
        Task<bool> NavigateSaved();
        Task<bool> NavigateSettings();
        Task<bool> NavigateStories();
        Task<bool> NavigateSupportInbox();
        Task<bool> NavigateTrash();
        Task<bool> NavigateUserTimeline();
        Task<bool> NavigateViewPage();
        Task<bool> NavigateWatch();
        Task<bool> NavigateWeather();
    }
}
