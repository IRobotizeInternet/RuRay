namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IFilter{out TFilterOptions}" />.
    /// </summary>
    /// <typeparam name="TFilterOptions">.</typeparam>
    public interface IFilter<out TFilterOptions> where TFilterOptions : IFilterOptions
    {
        /// <summary>
        /// The ClearFilter.
        /// </summary>
        void ClearFilter();

        /// <summary>
        /// Gets the FilterBy.
        /// </summary>
        TFilterOptions FilterBy { get; }
    }
}
