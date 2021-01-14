
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IVideoGamesAndConsolesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IPlatform<Platform>
    {
    }
}
