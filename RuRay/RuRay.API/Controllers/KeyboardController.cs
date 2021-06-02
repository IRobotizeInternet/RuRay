﻿using System;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RuRay.BLL.Contracts;
using Swashbuckle.AspNetCore.Annotations;

namespace RuRay.API.Controllers
{
    [AllowAnonymous]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/Keyboard")]
    [ApiVersion("1.0")]
    [ApiController]
    public class KeyboardController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IServiceKeyboard _serviceKeyboard;

        /// <summary>
        /// Keyboard actions
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="serviceKeyboard"></param>
        public KeyboardController(IMapper mapper, IServiceKeyboard serviceKeyboard)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _serviceKeyboard = serviceKeyboard ?? throw new ArgumentNullException(nameof(serviceKeyboard));
        }

        /// <summary>
        /// Keyboard left click action
        /// </summary>
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
        /// key stroke
        /// </summary>
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
