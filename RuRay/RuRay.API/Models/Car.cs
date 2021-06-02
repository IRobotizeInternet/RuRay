using System;
using System.ComponentModel.DataAnnotations;

namespace RuRay.API.Models
{
    /// <summary>
    /// Car type.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Gets or sets the Id
        /// Car id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the ModelName
        /// Car model name.
        /// </summary>
        [Required]
        [StringLength(45, MinimumLength = 1)]
        public string ModelName { get; set; }

        /// <summary>
        /// Gets or sets the CarType
        /// Car type.
        /// </summary>
        [Required]
        public CarType CarType { get; set; }

        /// <summary>
        /// Gets or sets the CreatedOn
        /// CreatedOn.
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the ModifiedOn
        /// ModifiedOn.
        /// </summary>
        public DateTime ModifiedOn { get; set; }
    }
}
