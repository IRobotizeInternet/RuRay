namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IBabyClothingFilterOptions" />.
    /// </summary>
    public interface IBabyClothingFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBabyAndToddlerSize<BabyAndToddlerSize>
    {
    }
}
