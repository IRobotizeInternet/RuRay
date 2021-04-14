using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Robotize.API.Models;
using Robotize.API.Swagger;
using Robotize.BLL;
using Robotize.BLL.Contracts;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Robotize.API.Controllers
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
        /// <returns>Returns created car</returns>           
        [HttpPost("")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Unsupported visual action")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> HomePageScrollDown()
        {
            await _serviceHomeHeader.HomePageScrollDown();
            return Ok();
        }

        ///// <summary>
        ///// Homepage scroll Up
        ///// </summary>
        ///// <returns>Returns created car</returns>           
        //[HttpPost("")]
        //[SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        //[SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Unsupported visual action")]
        //[SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        //public async Task<IActionResult> HomePageScrollUp()
        //{
        //    await _serviceHomeHeader.HomePageScrollUp();
        //    return Ok();
        //}
    }
}
