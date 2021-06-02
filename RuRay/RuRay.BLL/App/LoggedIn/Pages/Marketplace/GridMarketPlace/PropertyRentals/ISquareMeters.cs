namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="ISquareMeters" />.
    /// </summary>
    interface ISquareMeters
    {
        /// <summary>
        /// The SquareMeters.
        /// </summary>
        /// <param name="min">The min<see cref="long?"/>.</param>
        /// <param name="max">The max<see cref="long?"/>.</param>
        /// <returns>The <see cref="IFilterOptions"/>.</returns>
        IFilterOptions SquareMeters(long? min, long? max);
    }
}
