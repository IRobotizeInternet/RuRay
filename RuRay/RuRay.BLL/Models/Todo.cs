namespace RuRay.BLL.Models
{
    /// <summary>
    /// Defines the <see cref="Todo" />.
    /// </summary>
    public class Todo
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Completed.
        /// </summary>
        public bool Completed { get; set; }
    }
}
