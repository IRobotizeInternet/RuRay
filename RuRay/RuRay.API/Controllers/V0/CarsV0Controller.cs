namespace RuRay.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using RuRay.API.Models;
    using RuRay.BLL.Contracts;
    using Swashbuckle.AspNetCore.Annotations;

    /// <summary>
    /// Defines the <see cref="CarsV0Controller" />.
    /// </summary>
    [Authorize]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/cars")]
    [ApiVersion("0.9", Deprecated = true)]
    [ApiController]
    public class CarsV0Controller : ControllerBase
    {
        /// <summary>
        /// Defines the _mapper.
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Defines the _carsService.
        /// </summary>
        private readonly ICarsService _carsService;

        /// <summary>
        /// Initializes a new instance of the <see cref="CarsV0Controller"/> class.
        /// </summary>
        /// <param name="mapper">The mapper<see cref="IMapper"/>.</param>
        /// <param name="carsService">The carsService<see cref="ICarsService"/>.</param>
        public CarsV0Controller(IMapper mapper, ICarsService carsService)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _carsService = carsService ?? throw new ArgumentNullException(nameof(carsService));
        }

        /// <summary>
        /// Get cars list.
        /// </summary>
        /// <param name="limit">Items count.</param>
        /// <returns>.</returns>
        [HttpGet("")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(IEnumerable<Car>), Description = "Returns finded cars array")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Missing or invalid pageNumber or pageSize")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> GetCarsV0ListAsync([FromQuery] int limit = 50)
        {
            if (limit == 0)
            {
                return BadRequest();
            }

            var result = await _carsService.GetCarsListAsync(1, limit);
            return Ok(_mapper.Map<IEnumerable<Car>>(result));
        }
    }
}
