using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn.Enum
{
    /// <summary>
    /// Defines the FilterCategory.
    /// </summary>
    public enum FilterCategory
    {
        /// <summary>
        /// Defines the ActivityLog.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.ActivityLog), typeof(ResFilterCategories))] ActivityLog = 0,

        /// <summary>
        /// Defines the Posts.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.Posts), typeof(ResFilterCategories))] Posts = 1,

        /// <summary>
        /// Defines the ActivityYoureTaggedIn.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.ActivityYoureTaggedIn), typeof(ResFilterCategories))] ActivityYoureTaggedIn = 2,

        /// <summary>
        /// Defines the PhotosAndVideos.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.PhotosAndVideos), typeof(ResFilterCategories))] PhotosAndVideos = 3,

        /// <summary>
        /// Defines the PhotosYoureTaggedIn.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.PhotosYoureTaggedIn), typeof(ResFilterCategories))] PhotosYoureTaggedIn = 4,

        /// <summary>
        /// Defines the OthersPostsToYourTimeline.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.OthersPostsToYourTimeline), typeof(ResFilterCategories))] OthersPostsToYourTimeline = 5,

        /// <summary>
        /// Defines the HiddenFromTimeline.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.HiddenFromTimeline), typeof(ResFilterCategories))] HiddenFromTimeline = 6,

        /// <summary>
        /// Defines the LikesAndReactions.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.LikesAndReactions), typeof(ResFilterCategories))] LikesAndReactions = 7,

        /// <summary>
        /// Defines the PostsAndComments.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.PostsAndComments), typeof(ResFilterCategories))] PostsAndComments = 8,

        /// <summary>
        /// Defines the PagesPageLikesAndInterests.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.PagesPageLikesAndInterests), typeof(ResFilterCategories))] PagesPageLikesAndInterests = 9,

        /// <summary>
        /// Defines the Comments.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.Comments), typeof(ResFilterCategories))] Comments = 10,

        /// <summary>
        /// Defines the Profile.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.Profile), typeof(ResFilterCategories))] Profile = 11,

        /// <summary>
        /// Defines the AddedFriends.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.AddedFriends), typeof(ResFilterCategories))] AddedFriends = 12,

        /// <summary>
        /// Defines the RemovedFriends.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.RemovedFriends), typeof(ResFilterCategories))] RemovedFriends = 13,

        /// <summary>
        /// Defines the SentFriendRequests.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.SentFriendRequests), typeof(ResFilterCategories))] SentFriendRequests = 14,

        /// <summary>
        /// Defines the ReceivedFriendRequests.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.ReceivedFriendRequests), typeof(ResFilterCategories))] ReceivedFriendRequests = 15,

        /// <summary>
        /// Defines the LifeEvents.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.LifeEvents), typeof(ResFilterCategories))] LifeEvents = 16,

        /// <summary>
        /// Defines the YourStories.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.YourStories), typeof(ResFilterCategories))] YourStories = 17,

        /// <summary>
        /// Defines the VideoPollsYouveTaken.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.VideoPollsYouveTaken), typeof(ResFilterCategories))] VideoPollsYouveTaken = 18,

        /// <summary>
        /// Defines the SongsYouveListenedTo.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.SongsYouveListenedTo), typeof(ResFilterCategories))] SongsYouveListenedTo = 19,

        /// <summary>
        /// Defines the ArticlesYouveRead.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.ArticlesYouveRead), typeof(ResFilterCategories))] ArticlesYouveRead = 20,

        /// <summary>
        /// Defines the MoviesAndTV.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.MoviesAndTV), typeof(ResFilterCategories))] MoviesAndTV = 21,

        /// <summary>
        /// Defines the Games.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.Games), typeof(ResFilterCategories))] Games = 22,

        /// <summary>
        /// Defines the Books.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.Books), typeof(ResFilterCategories))] Books = 23,

        /// <summary>
        /// Defines the ProductsYouWanted.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.ProductsYouWanted), typeof(ResFilterCategories))] ProductsYouWanted = 24,

        /// <summary>
        /// Defines the Notes.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.Notes), typeof(ResFilterCategories))] Notes = 25,

        /// <summary>
        /// Defines the VideosYouveWatched.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.VideosYouveWatched), typeof(ResFilterCategories))] VideosYouveWatched = 26,

        /// <summary>
        /// Defines the VoiceInteractions.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.VoiceInteractions), typeof(ResFilterCategories))] VoiceInteractions = 27,

        /// <summary>
        /// Defines the Following.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.Following), typeof(ResFilterCategories))] Following = 28,

        /// <summary>
        /// Defines the Followers.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.Followers), typeof(ResFilterCategories))] Followers = 29,

        /// <summary>
        /// Defines the Groups.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.Groups), typeof(ResFilterCategories))] Groups = 30,

        /// <summary>
        /// Defines the MembershipActivity.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.MembershipActivity), typeof(ResFilterCategories))] MembershipActivity = 31,

        /// <summary>
        /// Defines the GroupPostsAndComments.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.GroupPostsAndComments), typeof(ResFilterCategories))] GroupPostsAndComments = 32,

        /// <summary>
        /// Defines the GroupReactions.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.GroupReactions), typeof(ResFilterCategories))] GroupReactions = 33,

        /// <summary>
        /// Defines the EventInvitations.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.EventInvitations), typeof(ResFilterCategories))] EventInvitations = 34,

        /// <summary>
        /// Defines the YourEvents.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.YourEvents), typeof(ResFilterCategories))] YourEvents = 35,

        /// <summary>
        /// Defines the EventResponses.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.EventResponses), typeof(ResFilterCategories))] EventResponses = 36,

        /// <summary>
        /// Defines the Polls.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.Polls), typeof(ResFilterCategories))] Polls = 37,

        /// <summary>
        /// Defines the SearchHistory.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.SearchHistory), typeof(ResFilterCategories))] SearchHistory = 38,

        /// <summary>
        /// Defines the VideosYouveSearchedFor.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.VideosYouveSearchedFor), typeof(ResFilterCategories))] VideosYouveSearchedFor = 39,

        /// <summary>
        /// Defines the GroupsYouveSearchedFor.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.GroupsYouveSearchedFor), typeof(ResFilterCategories))] GroupsYouveSearchedFor = 40,

        /// <summary>
        /// Defines the Saved.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.Saved), typeof(ResFilterCategories))] Saved = 41,

        /// <summary>
        /// Defines the YourPlaces.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.YourPlaces), typeof(ResFilterCategories))] YourPlaces = 42,

        /// <summary>
        /// Defines the ActiveSessions.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.ActiveSessions), typeof(ResFilterCategories))] ActiveSessions = 43,

        /// <summary>
        /// Defines the LoginsAndLogouts.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.LoginsAndLogouts), typeof(ResFilterCategories))] LoginsAndLogouts = 44,

        /// <summary>
        /// Defines the RecognizedDevices.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.RecognizedDevices), typeof(ResFilterCategories))] RecognizedDevices = 45,

        /// <summary>
        /// Defines the Apps.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.Apps), typeof(ResFilterCategories))] Apps = 46,

        /// <summary>
        /// Defines the AnonymousPostsYouveWritten.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.AnonymousPostsYouveWritten), typeof(ResFilterCategories))] AnonymousPostsYouveWritten = 47,

        /// <summary>
        /// Defines the MemberProfiles.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.MemberProfiles), typeof(ResFilterCategories))] MemberProfiles = 48,

        /// <summary>
        /// Defines the CreatedTournaments.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.CreatedTournaments), typeof(ResFilterCategories))] CreatedTournaments = 49,

        /// <summary>
        /// Defines the CrisisResponse.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.CrisisResponse), typeof(ResFilterCategories))] CrisisResponse = 50,

        /// <summary>
        /// Defines the RemindersToDonate.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.RemindersToDonate), typeof(ResFilterCategories))] RemindersToDonate = 51,

        /// <summary>
        /// Defines the FundraisersYouHelpManage.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.FundraisersYouHelpManage), typeof(ResFilterCategories))] FundraisersYouHelpManage = 52,

        /// <summary>
        /// Defines the FundraiserMatchesYouveCreated.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.FundraiserMatchesYouveCreated), typeof(ResFilterCategories))] FundraiserMatchesYouveCreated = 53,

        /// <summary>
        /// Defines the GroupAdminActions.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.GroupAdminActions), typeof(ResFilterCategories))] GroupAdminActions = 54,

        /// <summary>
        /// Defines the GroupPostsAboutGroupsYouHaveRecommended.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.GroupPostsAboutGroupsYouHaveRecommended), typeof(ResFilterCategories))] GroupPostsAboutGroupsYouHaveRecommended = 55,

        /// <summary>
        /// Defines the Relationships.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.Relationships), typeof(ResFilterCategories))] Relationships = 56,

        /// <summary>
        /// Defines the MarketplaceListings.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.MarketplaceListings), typeof(ResFilterCategories))] MarketplaceListings = 57,

        /// <summary>
        /// Defines the OtherRecords.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.OtherRecords), typeof(ResFilterCategories))] OtherRecords = 58,

        /// <summary>
        /// Defines the Pokes.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.Pokes), typeof(ResFilterCategories))] Pokes = 59,

        /// <summary>
        /// Defines the HobbiesYouveAddedToYourProfile.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.HobbiesYouveAddedToYourProfile), typeof(ResFilterCategories))] HobbiesYouveAddedToYourProfile = 60,

        /// <summary>
        /// Defines the StoriesActivity.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.StoriesActivity), typeof(ResFilterCategories))] StoriesActivity = 61,

        /// <summary>
        /// Defines the VoiceSearch.
        /// </summary>
        [LocalizedDescription(nameof(ResFilterCategories.VoiceSearch), typeof(ResFilterCategories))] VoiceSearch = 62,
    }
}
