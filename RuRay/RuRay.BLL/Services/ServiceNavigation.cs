using System.Threading.Tasks;
using RuRay.BLL.Contracts;
using RuRayFacebook.App.LoggedIn.Pages;

namespace RuRay.BLL.Services
{
    public class ServiceNavigation : IServiceNavigation
    {
        public Task<bool> NavigateActivityLog() { new PageActivityLog().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateAdCenter() { new PageAdCenter().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateAdPreferences() { new PageAdPreferences().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateArchived() { new PageArchived().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateCampus() { new PageCampus().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateChats() { new PageChats().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateEvents() { new PageEvents().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateFacebookPay() { new PageFacebookPay().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateFriends() { new PageFriends().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateFundraisers() { new PageFundraisers().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateGames() { new PageGames().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateGroup() { new PageGroup().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateGroupCall() { new PageGroupCall().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateHome() { new PageHome().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateJobs() { new PageJobs().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateLiveProducer() { new PageLiveProducer().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateMarketplace() { new PageMarketplace().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateMemories() { new PageMemories().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateMessages() { new PageMessages().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateMessengerKids() { new PageMessengerKids().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateMovies() { new PageMovies().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateNotifications() { new PageNotifications().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateOffers() { new PageOffers().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigatePages() { new PagePages().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigatePrivacyCheckup() { new PagePrivacyCheckup().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigatePromote() { new PagePromote().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateSaved() { new PageSaved().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateSettings() { new PageSettings().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateStories() { new PageStories().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateSupportInbox() { new PageSupportInbox().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateTrash() { new PageTrash().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateUserTimeline() { new PageUserTimeline().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateViewPage() { new PageViewPage().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateWatch() { new PageWatch().GoToPage(); return Task.FromResult(true); }
        public Task<bool> NavigateWeather() { new PageWeather().GoToPage(); return Task.FromResult(true); }
    }
}
