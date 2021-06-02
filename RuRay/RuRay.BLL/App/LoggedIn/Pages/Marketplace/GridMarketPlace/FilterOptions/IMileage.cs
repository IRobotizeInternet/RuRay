namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IMileage" />.
    /// </summary>
    public interface IMileage : IFilterOptions
    {
        /// <summary>
        /// The Milage.
        /// </summary>
        /// <param name="min">The min<see cref="double?"/>.</param>
        /// <param name="max">The max<see cref="double?"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter Milage(double? min = null, double? max = null);
    }
}
