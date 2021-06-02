namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IYear" />.
    /// </summary>
    public interface IYear : IFilterOptions
    {
        /// <summary>
        /// The Year.
        /// </summary>
        /// <param name="min">The min<see cref="int?"/>.</param>
        /// <param name="max">The max<see cref="int?"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter Year(int? min, int? max);
    }
}
