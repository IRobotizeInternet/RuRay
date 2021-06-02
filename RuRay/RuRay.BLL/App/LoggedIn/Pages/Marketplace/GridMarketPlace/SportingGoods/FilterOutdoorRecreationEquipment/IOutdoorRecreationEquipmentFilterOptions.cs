namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IOutdoorRecreationEquipmentFilterOptions" />.
    /// </summary>
    public interface IOutdoorRecreationEquipmentFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
