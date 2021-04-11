
namespace RobotizeFacebook.App.LoggedIn
{
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
