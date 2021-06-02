namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IOfficeFurnitureFilterOptions" />.
    /// </summary>
    public interface IOfficeFurnitureFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IDecorStyle<HomeDecorStyle>,
        IFinish<Finish>
    {
    }
}
