namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="ICountertopsFilterOptions" />.
    /// </summary>
    public interface ICountertopsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
