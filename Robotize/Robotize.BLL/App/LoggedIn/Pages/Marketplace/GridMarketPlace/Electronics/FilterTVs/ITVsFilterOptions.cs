
namespace RobotizeFacebook.App.LoggedIn
{
    public interface ITVsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandTVs>,
        IDisplayTechnology<DisplayTechnology>,
        IScreenSize<ScreenSize>
    {
    }
}
