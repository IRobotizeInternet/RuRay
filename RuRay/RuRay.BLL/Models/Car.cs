using System;

namespace RuRay.BLL.Models
{
    /// <summary>
    /// Defines the <see cref="Car" />.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the ModelName.
        /// </summary>
        public string ModelName { get; set; }

        /// <summary>
        /// Gets or sets the CarType.
        /// </summary>
        public CarType CarType { get; set; }

        /// <summary>
        /// Gets or sets the CreatedOn.
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the ModifiedOn.
        /// </summary>
        public DateTime ModifiedOn { get; set; }
    }
}
