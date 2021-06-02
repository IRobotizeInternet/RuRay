namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IHomeHeatingAndCoolingFilterOptions" />.
    /// </summary>
    public interface IHomeHeatingAndCoolingFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
