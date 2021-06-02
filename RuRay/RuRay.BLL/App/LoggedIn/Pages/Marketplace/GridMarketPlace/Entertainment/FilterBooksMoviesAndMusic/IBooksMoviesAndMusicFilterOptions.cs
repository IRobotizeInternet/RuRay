namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IBooksMoviesAndMusicFilterOptions" />.
    /// </summary>
    public interface IBooksMoviesAndMusicFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
