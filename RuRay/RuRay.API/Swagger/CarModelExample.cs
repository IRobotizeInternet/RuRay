using System;
using RuRay.API.Models;
using Swashbuckle.AspNetCore.Filters;

namespace RuRay.API.Swagger
{
    /// <summary>
    /// Defines the <see cref="CarModelExample" />.
    /// </summary>
    public class CarModelExample : IExamplesProvider<Car>
    {
        /// <summary>
        /// The GetExamples.
        /// </summary>
        /// <returns>The <see cref="Car"/>.</returns>
        public Car GetExamples()
        {
            var dnow = DateTime.UtcNow;
            return new Car
            {
                Id = Guid.NewGuid(),
                ModelName = "Toyota",
                CarType = CarType.Hatchback,
                CreatedOn = dnow,
                ModifiedOn = dnow
            };
        }
    }
}
