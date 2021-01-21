
namespace RobotizeFacebook.App.LoggedIn
{
    public interface IVideoGamesAndConsolesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IPlatform<Platform>
    {
    }
}
