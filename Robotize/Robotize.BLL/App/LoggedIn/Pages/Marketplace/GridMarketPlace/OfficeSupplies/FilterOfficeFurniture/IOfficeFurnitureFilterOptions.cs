
namespace RobotizeFacebook.App.LoggedIn
{
    public interface IOfficeFurnitureFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IDecorStyle<HomeDecorStyle>,
        IFinish<Finish>
    {
    }
}
