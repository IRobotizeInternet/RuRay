using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Robotize.API.Models;
using Robotize.API.Swagger;
using Robotize.BLL.Contracts;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Robotize.API.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/WindowsScreen")]
    [ApiVersion("1.0")]
    [ApiController]
    public class WindowsScreenController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IServiceWindowsScreen _serviceWindowsScreen;

        /// <summary>
        /// Windows Screen api
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="serviceWindowsScreen"></param>
        public WindowsScreenController(IMapper mapper, IServiceWindowsScreen serviceWindowsScreen)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _serviceWindowsScreen = serviceWindowsScreen ?? throw new ArgumentNullException(nameof(IServiceWindowsScreen));
        }

        /// <summary>
        /// Show or hide gird on the screen
        /// </summary>
        /// <param name="gridVisibility"></param>
        /// <returns></returns>           
        [HttpPost("")]
        [SwaggerResponseExample((int)HttpStatusCode.Created, typeof(CarModelExample))]
        [SwaggerResponse((int)HttpStatusCode.Created, Type = typeof(Car), Description = "Returns created car")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> CreateCarAsync([FromBody] GridVisibility gridVisibility)
        {
            if (gridVisibility == GridVisibility.INVALID) return BadRequest();

            await _serviceWindowsScreen.WindowGrid(gridVisibility);
            return Ok();
        }
    }
}
