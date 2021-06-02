namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IAntiquesAndCollectiblesFilterOptions" />.
    /// </summary>
    public interface IAntiquesAndCollectiblesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
