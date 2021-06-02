namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IComputersFilterOptions" />.
    /// </summary>
    public interface IComputersFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
