using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Robotize.BLL.Contracts;
using Swashbuckle.AspNetCore.Annotations;

namespace Robotize.API.Controllers
{
    [AllowAnonymous]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/Mouse")]
    [ApiVersion("1.0")]
    [ApiController]
    public class MouseController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IServiceMouse _serviceMouse;

        /// <summary>
        /// Mouse actions
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="serviceMouse"></param>
        public MouseController(IMapper mapper, IServiceMouse serviceMouse)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _serviceMouse = serviceMouse ?? throw new ArgumentNullException(nameof(serviceMouse));
        }

        ///// <summary>
        ///// Keyboard right click action
        ///// </summary>
        //[HttpPost("{index}")]
        //[SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        //[SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Unsupported right click index")]
        //[SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        //public async Task<IActionResult> RightClick([FromRoute] int index)
        //{
        //    if (index < 1) return BadRequest();

        //    await _serviceMouse.RightClickAtPoint(index);
        //    return Ok();
        //}

        /// <summary>
        /// Keyboard left click action
        /// </summary>
        [HttpPost("{index}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Unsupported right click index")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> LeftClick([FromRoute] int index)
        {
            if (index < 1) return BadRequest();

            await _serviceMouse.LeftClickAtPoint(index);
            return Ok();
        }

        /// <summary>
        /// Move cursor to a specified x, y location
        /// </summary>
        [HttpPost("~/GoToXY={index}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Out of bound coordinates")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> GoToXY([FromQuery] int index)
        {
            if (index < 1) return BadRequest();

            await _serviceMouse.GoToXY(index);
            return Ok();
        }
    }
}
