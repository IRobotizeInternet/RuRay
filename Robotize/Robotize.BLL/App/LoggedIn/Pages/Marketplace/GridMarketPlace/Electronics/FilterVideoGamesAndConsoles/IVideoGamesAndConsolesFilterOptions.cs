
namespace RuRayFacebook.App.LoggedIn
{
    public interface IVideoGamesAndConsolesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IPlatform<Platform>
    {
    }
}
