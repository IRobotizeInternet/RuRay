namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IHealthAndBeautyFilterOptions" />.
    /// </summary>
    public interface IHealthAndBeautyFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
