using System;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RuRay.API.Models;
using RuRay.API.Swagger;
using RuRay.BLL.Contracts;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;

namespace RuRay.API.Controllers
{
    /// <summary>
    /// Defines the <see cref="WindowsScreenController" />.
    /// </summary>
    [AllowAnonymous]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/WindowsScreen")]
    [ApiVersion("1.0")]
    [ApiController]
    public class WindowsScreenController : ControllerBase
    {
        /// <summary>
        /// Defines the _mapper.
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Defines the _serviceWindowsScreen.
        /// </summary>
        private readonly IServiceWindowsScreen _serviceWindowsScreen;

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsScreenController"/> class.
        /// </summary>
        /// <param name="mapper">.</param>
        /// <param name="serviceWindowsScreen">.</param>
        public WindowsScreenController(IMapper mapper, IServiceWindowsScreen serviceWindowsScreen)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _serviceWindowsScreen = serviceWindowsScreen ?? throw new ArgumentNullException(nameof(serviceWindowsScreen));
        }

        /// <summary>
        /// Show or hide gird on the screen.
        /// </summary>
        /// <param name="gridVisibility">.</param>
        /// <returns>.</returns>
        [HttpPost("{gridVisibility}")]
        //[SwaggerResponseExample((int)HttpStatusCode.Created, typeof(CarModelExample))]
        //[SwaggerResponse((int)HttpStatusCode.Created, Type = typeof(Car), Description = "Returns created car")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> WindowGrid([FromRoute] GridVisibility gridVisibility)
        {
            if (gridVisibility == GridVisibility.INVALID)
            {
                return BadRequest();
            }

            await _serviceWindowsScreen.WindowGrid(gridVisibility);
            return Ok();
        }
    }
}
