
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IWomensFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IColor<ColorWomenApparel>
    {
    }
}
