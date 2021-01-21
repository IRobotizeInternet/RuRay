
namespace RobotizeFacebook.App.LoggedIn
{
    public interface IWomensFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IColor<ColorWomenApparel>
    {
    }
}
