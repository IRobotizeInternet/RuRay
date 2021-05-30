
namespace RuRayFacebook.App.LoggedIn
{
    public interface IGarageSaleFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
