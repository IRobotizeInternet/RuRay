using System;

namespace RuRay.DAL.MySql.Models
{
    /// <summary>
    /// Defines the <see cref="CarEntity" />.
    /// </summary>
    public class CarEntity
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the ModelName.
        /// </summary>
        public string ModelName { get; set; }

        /// <summary>
        /// Gets or sets the CarType.
        /// </summary>
        public int CarType { get; set; }

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
