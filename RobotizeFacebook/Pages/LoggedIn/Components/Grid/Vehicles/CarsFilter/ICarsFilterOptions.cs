namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface ICarsFilterOptions:
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
