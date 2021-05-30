namespace RuRayFacebook.App.LoggedIn
{
    public interface ICarsFilterOptions:
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
