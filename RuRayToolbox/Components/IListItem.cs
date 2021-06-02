namespace RuRayToolbox.Components
{
    /// <summary>
    /// Defines the <see cref="IListItem" />.
    /// </summary>
    public interface IListItem
    {
        /// <summary>
        /// Gets or sets the XIndex.
        /// </summary>
        int XIndex { get; set; }

        /// <summary>
        /// Gets or sets the YIndex.
        /// </summary>
        int YIndex { get; set; }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        void RunConformance();
    }
}
