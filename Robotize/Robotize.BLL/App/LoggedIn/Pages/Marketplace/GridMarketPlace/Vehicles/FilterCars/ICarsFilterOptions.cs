namespace RobotizeFacebook.App.LoggedIn
{
    public interface ICarsFilterOptions:
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
