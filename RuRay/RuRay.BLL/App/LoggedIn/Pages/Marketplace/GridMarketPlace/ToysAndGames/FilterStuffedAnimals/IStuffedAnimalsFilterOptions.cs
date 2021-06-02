namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IStuffedAnimalsFilterOptions" />.
    /// </summary>
    public interface IStuffedAnimalsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
