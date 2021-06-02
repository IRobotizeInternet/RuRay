namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IPatioFurnitureFilterOptions" />.
    /// </summary>
    public interface IPatioFurnitureFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IDecorStyle<StyleDecorStyle>,
        IFinish<Finish>,
        IMaterial<Material>
    {
    }
}
