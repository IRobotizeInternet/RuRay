namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IFurnitureFilterOptions" />.
    /// </summary>
    public interface IFurnitureFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandFurniture>,
        IDecorStyle<StyleDecorStyle>,
        IFinish<Finish>
    {
    }
}
