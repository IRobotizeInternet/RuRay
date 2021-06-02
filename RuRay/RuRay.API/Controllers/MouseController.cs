using System;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RuRay.BLL.Contracts;
using Swashbuckle.AspNetCore.Annotations;

namespace RuRay.API.Controllers
{
    /// <summary>
    /// Defines the <see cref="MouseController" />.
    /// </summary>
    [AllowAnonymous]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/Mouse")]
    [ApiVersion("1.0")]
    [ApiController]
    public class MouseController : ControllerBase
    {
        /// <summary>
        /// Defines the _mapper.
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Defines the _serviceMouse.
        /// </summary>
        private readonly IServiceMouse _serviceMouse;

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseController"/> class.
        /// </summary>
        /// <param name="mapper">.</param>
        /// <param name="serviceMouse">.</param>
        public MouseController(IMapper mapper, IServiceMouse serviceMouse)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _serviceMouse = serviceMouse ?? throw new ArgumentNullException(nameof(serviceMouse));
        }

        /// <summary>
        /// Keyboard left click action.
        /// </summary>
        /// <param name="index">The index<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("LeftClick/{index}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Unsupported right click index")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> LeftClick([FromRoute] int index)
        {
            if (index < 1)
            {
                return BadRequest();
            }

            await _serviceMouse.LeftClickAtPoint(index);
            return Ok();
        }

        /// <summary>
        /// Keyboard right click action.
        /// </summary>
        /// <param name="index">The index<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("RightClick/{index}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Unsupported right click index")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> RightClickAtPoint([FromRoute] int index)
        {
            if (index < 1)
            {
                return BadRequest();
            }

            await _serviceMouse.RightClickAtPoint(index);
            return Ok();
        }

        /// <summary>
        /// Move cursor to a specified x, y location.
        /// </summary>
        /// <param name="index">The index<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("GoToXY/{index}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Out of bound coordinates")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> GoToXY([FromRoute] int index)
        {
            if (index < 1)
            {
                return BadRequest();
            }

            await _serviceMouse.GoToXY(index);
            return Ok();
        }
    }
}
