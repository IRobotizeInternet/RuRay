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
    /// Defines the <see cref="KeyboardController" />.
    /// </summary>
    [AllowAnonymous]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/Keyboard")]
    [ApiVersion("1.0")]
    [ApiController]
    public class KeyboardController : ControllerBase
    {
        /// <summary>
        /// Defines the _mapper.
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Defines the _serviceKeyboard.
        /// </summary>
        private readonly IServiceKeyboard _serviceKeyboard;

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyboardController"/> class.
        /// </summary>
        /// <param name="mapper">.</param>
        /// <param name="serviceKeyboard">.</param>
        public KeyboardController(IMapper mapper, IServiceKeyboard serviceKeyboard)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _serviceKeyboard = serviceKeyboard ?? throw new ArgumentNullException(nameof(serviceKeyboard));
        }

        /// <summary>
        /// Keyboard left click action.
        /// </summary>
        /// <param name="index">The index<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("{index}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Unsupported location")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> RightClick([FromRoute] int index)
        {
            if (index < 1)
            {
                return BadRequest();
            }

            await _serviceKeyboard.LeftClick(index);
            return Ok();
        }

        /// <summary>
        /// key stroke.
        /// </summary>
        /// <param name="sendKey">The sendKey<see cref="KeyStrokes"/>.</param>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("SendKey/{key}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Unsupported key")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> KeyStoke([FromRoute] KeyStrokes sendKey)
        {
            await _serviceKeyboard.SendKey(sendKey);
            return Ok();
        }
    }
}
