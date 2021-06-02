namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IVideoGamesAndConsolesFilterOptions" />.
    /// </summary>
    public interface IVideoGamesAndConsolesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IPlatform<Platform>
    {
    }
}
