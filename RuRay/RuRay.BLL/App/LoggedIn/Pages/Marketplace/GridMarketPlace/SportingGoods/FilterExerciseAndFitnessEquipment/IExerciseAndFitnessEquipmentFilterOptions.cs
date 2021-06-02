namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IExerciseAndFitnessEquipmentFilterOptions" />.
    /// </summary>
    public interface IExerciseAndFitnessEquipmentFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
