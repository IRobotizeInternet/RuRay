namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IUniformsAndWorkClothingFilterOptions" />.
    /// </summary>
    public interface IUniformsAndWorkClothingFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
