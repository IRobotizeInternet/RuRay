using System;
using RuRay.API.Models;
using Swashbuckle.AspNetCore.Filters;

namespace RuRay.API.Swagger
{
    public class CarModelExample : IExamplesProvider<Car>
    {
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
