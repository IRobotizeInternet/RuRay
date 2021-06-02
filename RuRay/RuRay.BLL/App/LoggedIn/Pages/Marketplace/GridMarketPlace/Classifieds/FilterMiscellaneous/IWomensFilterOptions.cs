
namespace RuRayFacebook.App.LoggedIn
{
    public interface IWomensFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IColor<ColorWomenApparel>
    {
    }
}
