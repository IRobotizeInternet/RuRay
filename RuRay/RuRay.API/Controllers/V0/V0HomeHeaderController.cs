using System;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RuRay.BLL;
using RuRay.BLL.Contracts;
using Swashbuckle.AspNetCore.Annotations;

namespace RuRay.API.Controllers
{
    /// <summary>
    /// Defines the <see cref="V0HomeHeaderController" />.
    /// </summary>
    [AllowAnonymous]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/HomeHeader")]
    [ApiVersion("1.0")]
    [ApiController]
    public class V0HomeHeaderController : ControllerBase
    {
        /// <summary>
        /// Defines the _mapper.
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Defines the _serviceHomeHeader.
        /// </summary>
        private readonly IServiceHomeHeader _serviceHomeHeader;

        /// <summary>
        /// Initializes a new instance of the <see cref="V0HomeHeaderController"/> class.
        /// </summary>
        /// <param name="mapper">.</param>
        /// <param name="serviceHomeHeader">.</param>
        public V0HomeHeaderController(IMapper mapper, IServiceHomeHeader serviceHomeHeader)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _serviceHomeHeader = serviceHomeHeader ?? throw new ArgumentNullException(nameof(serviceHomeHeader));
        }

        ///// <summary>
        ///// Homepage scroll down.
        ///// </summary>
        ///// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        //[HttpPost("")]
        //[SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        //[SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Unsupported visual action")]
        //[SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        //public async Task<IActionResult> HomePageScrollDown()
        //{
        //    await _serviceHomeHeader.HomePageScrollDown();
        //    return Ok();
        //}

        ///// <summary>
        ///// Facebook Change Visual Mode.
        ///// </summary>
        ///// <param name="mode">The mode<see cref="Switch"/>.</param>
        ///// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        //[HttpPost("{mode}")]
        //[SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        //[SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Unsupported visual mode")]
        //[SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        //public async Task<IActionResult> FacebookChangeVisualMode([FromRoute] Switch mode)
        //{
        //    if (mode == Switch.INVALID)
        //    {
        //        return BadRequest();
        //    }

        //    await _serviceHomeHeader.FacebookChangeVisualMode(mode);
        //    return Ok();
        //}
    }
}
