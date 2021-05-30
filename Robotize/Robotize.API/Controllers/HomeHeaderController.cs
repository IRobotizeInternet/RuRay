using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RuRay.API.Models;
using RuRay.API.Swagger;
using RuRay.BLL;
using RuRay.BLL.Contracts;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace RuRay.API.Controllers
{
    [AllowAnonymous]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/HomeHeader")]
    [ApiVersion("1.0")]
    [ApiController]
    public class HomeHeaderController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IServiceHomeHeader _serviceHomeHeader;

        /// <summary>
        /// Cars db api
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="serviceHomeHeader"></param>
        public HomeHeaderController(IMapper mapper, IServiceHomeHeader serviceHomeHeader)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _serviceHomeHeader = serviceHomeHeader ?? throw new ArgumentNullException(nameof(serviceHomeHeader));
        }

        /// <summary>
        /// Homepage scroll down
        /// </summary>
        [HttpPost("")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Unsupported visual action")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> HomePageScrollDown()
        {
            await _serviceHomeHeader.HomePageScrollDown();
            return Ok();
        }

        /// <summary>
        /// Facebook Change Visual Mode
        /// </summary>
        [HttpPost("{mode}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Unsupported visual mode")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> FacebookChangeVisualMode([FromRoute] Switch mode)
        {
            if (mode == Switch.INVALID) return BadRequest();
            await _serviceHomeHeader.FacebookChangeVisualMode(mode);
            return Ok();
        }
    }
}
